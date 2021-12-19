using ChukebloEditor.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ChukebloEditor
{
    // UIイベント関連の処理はこのファイルにまとめる
    public partial class ChukebloEditorForm : Form
    {
        private CommandInvoker _commandInvoker;
        private Stack<string> CopySentenceStack = new Stack<string>();
        
        public ChukebloEditorForm()
        {
            InitializeComponent();
            _commandInvoker = new CommandInvoker();
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

        private void FileMenuOverwriteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
