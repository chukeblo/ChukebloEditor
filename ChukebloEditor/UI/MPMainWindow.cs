using ChukebloEditor.Command;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    delegate void ShowTargetSubmenuDelegate();
    public partial class MPMainWindow : Form
    {
        private Dictionary<ToolMenuType, Form> forms = new Dictionary<ToolMenuType, Form>();
        private CommandInvoker commandInvoker = CommandInvoker.Instance;
        private ToolMenuType currentToolMenuType = ToolMenuType.Idle;
        private Form currentlyActiveForm = null;

        public MPMainWindow()
        {
            InitializeComponent();
            InitializeSubmenuState();
        }

        private void InitializeSubmenuState()
        {
            InitializeTESubmenuState();
            pnlToDoListMenu.Visible = false;
            pnlTaskManagementMenu.Visible = false;
            pnlConfigurationMenu.Visible = false;
        }

        private void HideSubmenu()
        {
            HideTESubmenuButtons();
            if (pnlToDoListMenu.Visible)
            {
                pnlToDoListMenu.Visible = false;
            }
            if (pnlTaskManagementMenu.Visible)
            {
                pnlTaskManagementMenu.Visible = false;
            }
            if (pnlConfigurationMenu.Visible)
            {
                pnlConfigurationMenu.Visible = false;
            }
        }

        private void ShowSubmenu(ToolMenuType type)
        {
            HideSubmenu();

            switch (type)
            {
                case ToolMenuType.TextEditor:
                    ShowTESubmenuButtons();
                    break;
                case ToolMenuType.ToDoList:
                    pnlToDoListMenu.Visible = true;
                    break;
                case ToolMenuType.TaskManagement:
                    pnlTaskManagementMenu.Visible = true;
                    break;
                case ToolMenuType.Configuration:
                    pnlConfigurationMenu.Visible = true;
                    break;
                case ToolMenuType.Help:
                    break;
                default:
                    throw new InvalidOperationException("not supported tool menu type");
            }
        }

        public void SwitchActiveBodyMainForm(ToolMenuType nextType, Form nextForm)
        {
            if (currentlyActiveForm != null)
            {
                // すでにアクティブなウィンドウがある場合
                if (!ConfigureDeactivateBodyMainForm())
                {
                    // ユーザーがウィンドウを閉じない選択をした場合は何もしない
                    return;
                }
                bool onlyDeactivate = currentToolMenuType == nextType;
                DeactivateBodyMainForm();
                InitializeSubmenuState();
                if (onlyDeactivate)
                {
                    // 現在アクティブなウィンドウと同じメニューボタンが押された場合はウィンドウを閉じるだけで抜ける
                    return;
                }
            }
            ActivateBodyMainForm(nextForm);
            ShowSubmenu(nextType);
            currentToolMenuType = nextType;
        }

        private void ActivateBodyMainForm(Form newBodyMainForm)
        {
            currentlyActiveForm = newBodyMainForm;
            currentlyActiveForm.TopLevel = false;
            currentlyActiveForm.FormBorderStyle = FormBorderStyle.None;
            currentlyActiveForm.Dock = DockStyle.Fill;
            BodyMainPanel.Controls.Add(currentlyActiveForm);
            BodyMainPanel.Tag = currentlyActiveForm;
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
            currentToolMenuType = ToolMenuType.Idle;
        }

        private Stack<Button> CreateButtonListUntil(Panel panel)
        {
            var list = new Stack<Button>();

            list.Push(btnTextEditorMenu);
            list.Push(btnTEFileSubmenu);
            if (panel == pnlTEFileSubmenu)
            {
                return list;
            }
            list.Push(btnTEEditSubmenu);
            if (panel == pnlTEEditSubmenu)
            {
                return list;
            }
            list.Push(btnTEDisplaySubmenu);
            return list;
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

        #region Event Listeners
        #region Menu Button Click Events
        private void btnTextEditorMenu_Click(object sender, EventArgs e)
        {
            Form nextForm = (currentToolMenuType == ToolMenuType.TextEditor) ? null : new WikiEditorForm();
            SwitchActiveBodyMainForm(ToolMenuType.TextEditor, nextForm);
        }

        private void btnTodoMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(ToolMenuType.ToDoList, new Form());
        }

        private void btnTaskManagementMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(ToolMenuType.TaskManagement, new Form());
        }

        private void btnConfigurationMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(ToolMenuType.Configuration, new Form());
        }

        private void btnHelpMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(ToolMenuType.Help, new Form());
        }
        #endregion Menu Button Click Events
        #region Submenu Button Click Events
        #region To-Do List Submenu
        private void btnToDoListAddItemSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }

        private void btnToDoListRemoveItemSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }

        private void btnToDoListCloseSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }
        #endregion To-Do List Submenu
        #region Task Management Submenu
        private void btnTaskManagementOpenSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }

        private void btnTaskManagementSaveSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }

        private void btnTaskManagementCloseSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }
        #endregion Task Management Submenu
        #region Configuration Submenu
        private void btnConfigurationTextEditorSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }

        private void btnConfigurationToDoListSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }

        private void btnConfigurationTaskManagementSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideSubmenu();
        }
        #endregion Configuraion Submenu

        #endregion Submenu Button Click Events

        #endregion Event Listeners
    }
}
