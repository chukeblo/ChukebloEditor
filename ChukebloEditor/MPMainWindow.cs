using ChukebloEditor.Command;
using ChukebloEditor.UI.MenuForms;
using System;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    delegate void ShowTargetSubmenuDelegate();
    public partial class MPMainWindow : Form
    {
        private CommandInvoker commandInvoker = CommandInvoker.Instance;
        private FormType currentFormType = FormType.Home;
        private Form currentlyActiveForm = null;

        public MPMainWindow()
        {
            InitializeComponent();
            ActivateBodyMainForm(new HomeMenuForm());
        }

        public void SwitchActiveBodyMainForm(FormType nextType)
        {
            if (currentFormType != FormType.Home)
            {
                // すでにアクティブなウィンドウがある場合
                if (!ConfigureDeactivateBodyMainForm())
                {
                    // ユーザーがウィンドウを閉じない選択をした場合は何もしない
                    return;
                }
                if (currentFormType == nextType)
                {
                    nextType = FormType.Home;
                }
                DeactivateBodyMainForm();
            }

            Form nextForm;
            switch (nextType)
            {
                case FormType.Home:
                    nextForm = new HomeMenuForm();
                    break;
                case FormType.ToDo:
                    nextForm = new ToDoMenuForm();
                    break;
                case FormType.Tasks:
                    nextForm = new TasksMenuForm();
                    break;
                case FormType.Projects:
                    nextForm = new ProjectsMenuForm();
                    break;
                case FormType.Wiki:
                    nextForm = new WikiMenuForm();
                    break;
                default:
                    throw new InvalidOperationException("not supported form type");
            }
            ActivateBodyMainForm(nextForm);
            currentFormType = nextType;
        }

        private void ActivateBodyMainForm(Form newBodyMainForm)
        {
            currentlyActiveForm?.Close();
            currentlyActiveForm = newBodyMainForm;
            currentlyActiveForm.TopLevel = false;
            currentlyActiveForm.FormBorderStyle = FormBorderStyle.None;
            currentlyActiveForm.Dock = DockStyle.Fill;
            pnlMenuForm.Controls.Add(currentlyActiveForm);
            pnlMenuForm.Tag = currentlyActiveForm;
            currentlyActiveForm.BringToFront();
            currentlyActiveForm.Show();
        }

        private bool ConfigureDeactivateBodyMainForm()
        {
            var messageResult = MessageBox.Show(MessageBoxConstants.LeaveMessage,
                MessageBoxConstants.ExitCaption, MessageBoxButtons.YesNo);
            if (messageResult == System.Windows.Forms.DialogResult.No)
            {
                return false;
            }
            return true;
        }

        private void DeactivateBodyMainForm()
        {
            currentlyActiveForm.Close();
            currentlyActiveForm = null;
            currentFormType = FormType.Home;
        }

        private DialogResult<string> AskUserWithDialog(DialogParamBase param)
        {
            switch (param)
            {
                case OpenFileDialogParam openFileDialogParam:
                    return GetOpenFileName(openFileDialogParam);
                default:
                    throw new InvalidOperationException("not supported dialog param");
            }
        }

        private DialogResult<string> GetOpenFileName(OpenFileDialogParam param)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = param.Title;
            openFileDialog.InitialDirectory = param.InitialDirectory;
            openFileDialog.Filter = param.Filter;
            var dialogResult = openFileDialog.ShowDialog();
            switch (dialogResult)
            {
                case System.Windows.Forms.DialogResult.OK:
                    return new DialogSucceeded<string>(openFileDialog.FileName);
                case System.Windows.Forms.DialogResult.Cancel:
                    return new DialogFailed<string>("dialog result=cancel");
                default:
                    throw new InvalidOperationException("not'supported dialog result");
            }

        }

        private void btnHomeMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.Home);
        }

        private void btnScheduleMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnTodoMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.ToDo);
        }

        private void btnTasksMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.Tasks);
        }

        private void btnProjectsMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.Projects);
        }

        private void btnWikiMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.Wiki);
        }

        private void btnTopBarToDo_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.ToDo);
        }

        private void btnTopBarTasks_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.Tasks);
        }

        private void btnTopBarProjects_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.Projects);
        }

        private void btnTopBarWiki_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(FormType.Wiki);
        }
    }
}
