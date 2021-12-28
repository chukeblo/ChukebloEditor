using System.Windows.Forms;

namespace ChukebloEditor.UI.MenuForms
{
    public partial class TasksMenuForm : Form
    {
        private Form editorForm = null;

        public TasksMenuForm()
        {
            InitializeComponent();
        }

        private void btnCreateNewTask_Click(object sender, System.EventArgs e)
        {
            this.pnlTasksFormWindowRange.Hide();
            this.editorForm = new ToDoEditorForm();
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
            this.pnlTasksFormWindowRange.BringToFront();
            this.pnlTasksFormWindowRange.Show();
        }

        private void btnDeleteSelectedTask_Click(object sender, System.EventArgs e)
        {

        }
    }
}
