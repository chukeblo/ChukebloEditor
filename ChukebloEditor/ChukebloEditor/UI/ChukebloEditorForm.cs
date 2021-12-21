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

        private void FileMenuOpenButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = File.ReadAllText(dialog.FileName);
                CurrentlyOpenedFileName.Text = dialog.FileName;
            }
        }

        private void FileMenuOverwriteButton_Click(object sender, EventArgs e)
        {
            var param = new FileIOParam(CurrentlyOpenedFileName.Text, TextBox.Text);
            var command = CommandFactory.GenerateCommand(CommandType.Save, param);
            _commandInvoker.AddCommand(command);
        }

        private void FileMenuSaveButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "保存";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var param = new FileIOParam(dialog.FileName, TextBox.Text);
                var command = CommandFactory.GenerateCommand(CommandType.Save, param);
                _commandInvoker.AddCommand(command);
            }
        }

        private void FileMenuExitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("ChukebloEditorを終了しますか？", "終了", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FileMenuCreateNewButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != string.Empty)
            {
                var result = MessageBox.Show("保存されていないテキストは削除されますがよろしいですか？", "新規作成", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            TextBox.Text = string.Empty;
            CurrentlyOpenedFileName.Text = string.Empty;
        }

        private void EditMenuCopyButton_Click(object sender, EventArgs e)
        {
            CopySentenceStack.Push(TextBox.SelectedText);
        }

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

        private void EditMenuSelectAllButton_Click(object sender, EventArgs e)
        {
            TextBox.SelectAll();
        }

        private void EditMenuCutButton_Click(object sender, EventArgs e)
        {
            CopySentenceStack.Push(TextBox.SelectedText);
            var tmp = TextBox.Text;
            var selectionStart = TextBox.SelectionStart;
            var newText = tmp.Remove(TextBox.SelectionStart, TextBox.SelectionLength);
            TextBox.Text = newText;
            TextBox.SelectionStart = selectionStart;
        }

        private void EditMenuCutLineButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox.Text))
            {
                // すでに空の場合何もしない
                return;
            }

            var cursoredLine = TextBox.GetLineFromCharIndex(TextBox.SelectionStart);
            // 1行目を行削除しようとするとエラーが吐かれるのでセーフティを設ける
            var nextCursor = TextBox.GetFirstCharIndexFromLine(cursoredLine > 0 ? cursoredLine - 1 : 0);

            var linedTextList = TextBox.Lines.ToList();
            linedTextList.RemoveAt(cursoredLine);
            TextBox.Text = string.Join(Environment.NewLine, linedTextList);
            TextBox.SelectionStart = nextCursor;
        }

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

        public void FindCommandReceiver_OnFindCompleted(object sender, FindCompletedEventArgs e)
        {
            _matchedStringIndexList = e.IndexList;
            _searchWordsLength = e.SearchWordsLength;
            foreach (var index in _matchedStringIndexList)
            {
                Invoke(_highlightSelectedWordsDelegate, new object[] { index, _searchWordsLength });
            }
        }

        private void HighlightSelectedWords(int index, int length)
        {
            // TODO: 連続してハイライト解除機能が呼ばれたときの対応
            TextBox.SelectionStart = index;
            TextBox.SelectionLength = length;
            TextBox.SelectionColor = Color.Red;
        }

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
