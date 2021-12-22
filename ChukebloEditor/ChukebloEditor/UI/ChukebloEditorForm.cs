using ChukebloEditor.Command;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    delegate void HighlightSelectedWordsDelegate(int index, int length);
    // UIイベント関連の処理はこのファイルにまとめる
    public partial class ChukebloEditorForm : Form
    {
        // UIコントロール用デリゲート
        private readonly HighlightSelectedWordsDelegate _highlightSelectedWordsDelegate;

        private CommandInvoker _commandInvoker;
        private SearchWindow _searchWindow;
        // Copy/Cut/Paste用データ
        private Stack<string> CopySentenceStack = new Stack<string>();
        // Find/Relace用データ
        private List<int> _matchedStringIndexList = new List<int>();
        private int _searchWordsLength = 0;

        public ChukebloEditorForm()
        {
            InitializeComponent();
            _highlightSelectedWordsDelegate = HighlightSelectedWords;
            _commandInvoker = new CommandInvoker();
            _searchWindow = new SearchWindow();
            _commandInvoker.Run();
        }

        // ファイルメニュータブにあるボタン押下イベントのリスナーメソッド

        /// <summary>
        /// 「新規ファイル作成」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileMenuCreateNewButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != string.Empty)
            {
                // 現在編集済みのファイルが未保存の場合はポップアップ表示する
                var result = MessageBox.Show(MessageBoxConstants.CreateNewFileMessage,
                    MessageBoxConstants.CreateNewFileCaption, MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            var dialog = new SaveFileDialog();
            dialog.Filter = DialogConstants.TextFileFilter;
            dialog.Title = DialogConstants.CreateNewFileTitle;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = string.Empty;
                CurrentlyOpenedFileName.Text = dialog.FileName;
                var param = new FileIOParam(dialog.FileName, string.Empty);
                var command = CommandFactory.GenerateCommand(CommandType.Save, param);
                _commandInvoker.AddCommand(command);
            }
        }

        /// <summary>
        /// 「ファイルを開く」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileMenuOpenButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = DialogConstants.TextFileFilter;
            dialog.Title = DialogConstants.OpenFileTitle;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = File.ReadAllText(dialog.FileName);
                CurrentlyOpenedFileName.Text = dialog.FileName;
            }
        }

        /// <summary>
        /// 「上書き保存」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileMenuOverwriteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentlyOpenedFileName.Text))
            {
                // 現在開いているファイル名がない場合は新規保存イベントのフローに移行
                FileMenuSaveButton_Click(sender, e);
                return;
            }
            var param = new FileIOParam(CurrentlyOpenedFileName.Text, TextBox.Text);
            var command = CommandFactory.GenerateCommand(CommandType.Save, param);
            _commandInvoker.AddCommand(command);
        }

        /// <summary>
        /// 「新規保存」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileMenuSaveButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = DialogConstants.TextFileFilter;
            dialog.Title = DialogConstants.SaveAsNewFileTitle;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            CurrentlyOpenedFileName.Text = dialog.FileName;
            var param = new FileIOParam(dialog.FileName, TextBox.Text);
            var command = CommandFactory.GenerateCommand(CommandType.Save, param);
            _commandInvoker.AddCommand(command);
        }

        /// <summary>
        /// 「終了」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileMenuExitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(MessageBoxConstants.ExitMessage,
                MessageBoxConstants.ExitCaption, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        // 編集メニュータブにあるボタン押下イベントのリスナーメソッド

        /// <summary>
        /// 「すべて選択」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMenuSelectAllButton_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }

        /// <summary>
        /// 「切り取り」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMenuCutButton_Click(object sender, EventArgs e)
        {
            CopySentenceStack.Push(TextBox.SelectedText);
            var tmp = TextBox.Text;
            var selectionStart = TextBox.SelectionStart;
            var newText = tmp.Remove(TextBox.SelectionStart, TextBox.SelectionLength);
            TextBox.Text = newText;
            TextBox.SelectionStart = selectionStart;
        }

        /// <summary>
        /// 「カーソル行切り取り」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMenuCutLineButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox.Text))
            {
                // すでに空の場合何もしない
                return;
            }

            // TODO: 文字列を削除する処理はコマンドで行うように修正する
            var cursoredLine = TextBox.GetLineFromCharIndex(TextBox.SelectionStart);
            // 1行目を行削除しようとするとエラーが吐かれるのでセーフティを設ける
            var nextCursor = TextBox.GetFirstCharIndexFromLine(cursoredLine > 0 ? cursoredLine - 1 : 0);

            var linedTextList = TextBox.Lines.ToList();
            linedTextList.RemoveAt(cursoredLine);
            TextBox.Text = string.Join(Environment.NewLine, linedTextList);
            TextBox.SelectionStart = nextCursor;
        }

        /// <summary>
        /// 「コピー」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMenuCopyButton_Click(object sender, EventArgs e)
        {
            CopySentenceStack.Push(TextBox.SelectedText);
        }

        /// <summary>
        /// 「ペースト」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMenuPasteButton_Click(object sender, EventArgs e)
        {
            if (CopySentenceStack.Count == 0)
            {
                return;
            }
            var pasteStartIndex = TextBox.SelectionStart;
            var lastCopiedSentence = CopySentenceStack.Pop();
            var newText = TextBox.Text.Insert(pasteStartIndex, lastCopiedSentence);
            TextBox.Text = newText;
            TextBox.SelectionStart = pasteStartIndex + lastCopiedSentence.Length;
        }

        /// <summary>
        /// 「検索」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EditMenuFindButton_Click(object sender, EventArgs e)
        {
            // TODO: 連続して検索機能が呼ばれたときの対応
            _searchWindow.Show();
            try
            {
                var searchWords = await _searchWindow.WaitSearchWords();
                var param = new SearchParam(TextBox.Text, searchWords);
                param.OnFindCompleted += FindCommandReceiver_OnFindCompleted;
                var command = CommandFactory.GenerateCommand(CommandType.Find, param);
                _commandInvoker.AddCommand(command);
            }
            catch (OperationCanceledException)
            {
                // 検索がキャンセルされた場合にここに来るのは想定内
            }
            finally
            {
                _searchWindow.Clear();
                _searchWindow.Hide();
            }
        }


        /// <summary>
        /// 検索完了イベントのリスナーメソッド
        /// UIスレッドでUIコントロールを行う必要があるため、HighlightSelectedWordsメソッドに
        /// 具体的な処理は移譲している
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FindCommandReceiver_OnFindCompleted(object sender, FindCompletedEventArgs e)
        {
            _matchedStringIndexList = e.IndexList;
            _searchWordsLength = e.SearchWordsLength;
            foreach (var index in _matchedStringIndexList)
            {
                Invoke(_highlightSelectedWordsDelegate, new object[] { index, _searchWordsLength });
            }
        }

        /// <summary>
        /// 検索で該当した文字列をハイライトを行う
        /// </summary>
        /// <param name="index">該当部分の先頭インデックス</param>
        /// <param name="length">検索文字列の長さ</param>
        private void HighlightSelectedWords(int index, int length)
        {
            // TODO: 連続してハイライト解除機能が呼ばれたときの対応
            TextBox.SelectionStart = index;
            TextBox.SelectionLength = length;
            TextBox.SelectionColor = Color.Red;
        }

        // 表示メニュータブにあるボタン押下イベントのリスナーメソッド

        /// <summary>
        /// 「ハイライト解除」ボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayMenuUnhighlightButton_Click(object sender, EventArgs e)
        {
            foreach (var index in _matchedStringIndexList)
            {
                TextBox.SelectionStart = index;
                TextBox.SelectionLength = _searchWordsLength;
                TextBox.SelectionColor = Color.Empty;
            }
        }
    }
}
