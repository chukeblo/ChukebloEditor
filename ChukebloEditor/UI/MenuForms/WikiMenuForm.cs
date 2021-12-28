﻿using System.Windows.Forms;

namespace ChukebloEditor.UI.MenuForms
{
    public partial class WikiMenuForm : Form
    {
        private Form editorForm = null;
        public WikiMenuForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            this.pnlWikiFormWindowRange.Hide();
            this.editorForm = new WikiEditorForm();
            this.editorForm.TopLevel = false;
            this.editorForm.FormBorderStyle = FormBorderStyle.None;
            this.editorForm.Dock = DockStyle.Fill;
            this.Controls.Add(editorForm);
            this.Tag = editorForm;
            this.editorForm.BringToFront();
            this.editorForm.Show();
            this.editorForm.FormClosed += EditorForm_FormClosed;
        }

        private void EditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controls.Remove(this.editorForm);
            this.pnlWikiFormWindowRange.Show();
            this.pnlWikiFormWindowRange.BringToFront();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            this.pnlWikiFormWindowRange.Show();
        }
    }
}
