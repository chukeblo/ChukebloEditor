using System.Windows.Forms;

namespace ChukebloEditor.UI.MenuForms
{
    public partial class ProjectsMenuForm : Form
    {
        private ProjectsEditorForm editorForm = null;

        public ProjectsMenuForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewProject_Click(object sender, System.EventArgs e)
        {
            this.pnlProjectsFormWindowRange.Hide();
            this.editorForm = new ProjectsEditorForm();
            this.editorForm.TopLevel = false;
            this.editorForm.Dock = DockStyle.Fill;
            this.editorForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(this.editorForm);
            this.editorForm.BringToFront();
            this.editorForm.Show();
            this.editorForm.FormClosed += EditorForm_FormClosed;
        }

        private void EditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controls.Remove(this.editorForm);
            this.editorForm = null;
            this.pnlProjectsFormWindowRange.BringToFront();
            this.pnlProjectsFormWindowRange.Show();
        }

        private void btnDeleteSelectedProject_Click(object sender, System.EventArgs e)
        {

        }
    }
}
