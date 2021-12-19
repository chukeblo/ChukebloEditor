using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ChukebloEditor
{
    public partial class ChukebloEditorForm : Form
    {
        private Stack<string> CopySentenceStack = new Stack<string>();
        public ChukebloEditorForm()
        {
            InitializeComponent();
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
                File.WriteAllText(dialog.FileName, TextBox.Text);
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
    }
}
