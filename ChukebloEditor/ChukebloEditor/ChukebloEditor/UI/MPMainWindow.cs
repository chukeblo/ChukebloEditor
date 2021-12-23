using System;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    delegate void InitializeSubmenuStateDelegate();
    public partial class MPMainWindow : Form
    {
        private ToolMenuType currentToolMenuType = ToolMenuType.Idle;
        private Form currentlyActiveForm = null;

        public MPMainWindow()
        {
            InitializeComponent();
            InitializeSubmenuState();
        }

        private void InitializeSubmenuState()
        {
            pnlTextEditorMenu.Visible = false;
            pnlToDoListMenu.Visible = false;
            pnlTaskManagementMenu.Visible = false;
            pnlConfigurationMenu.Visible = false;
        }

        private void HideSubmenu()
        {
            if (pnlTextEditorMenu.Visible)
            {
                pnlTextEditorMenu.Visible = false;
            }
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
            Panel targetPanel;
            InitializeSubmenuStateDelegate initializeSubmenuStateDelegate = null;
            switch (type)
            {
                case ToolMenuType.TextEditor:
                    targetPanel = pnlTextEditorMenu;
                    initializeSubmenuStateDelegate = InitializeTESubmenuState;
                    break;
                case ToolMenuType.ToDoList:
                    targetPanel = pnlToDoListMenu;
                    break;
                case ToolMenuType.TaskManagement:
                    targetPanel = pnlTaskManagementMenu;
                    break;
                case ToolMenuType.Configuration:
                    targetPanel = pnlConfigurationMenu;
                    break;
                default:
                    throw new InvalidOperationException("not supported tool menu type");
            }

            if (targetPanel.Visible)
            {
                targetPanel.Visible = false;
                return;
            }
            HideSubmenu();
            targetPanel.Visible = true;
            initializeSubmenuStateDelegate?.Invoke();
        }

        public void SwitchActiveBodyMainForm(ToolMenuType nextType, Form nextForm)
        {
            if (currentToolMenuType == nextType)
            {
                if (!ConfigureDeactivateBodyMainForm())
                {
                    return;
                }
                DeactivateBodyMainForm();
                return;
            }
            if (currentlyActiveForm != null)
            {
                DeactivateBodyMainForm();
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
            if (messageResult == DialogResult.No)
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

        #region Event Listeners
        #region Menu Button Click Events
        private void btnTextEditorMenu_Click(object sender, EventArgs e)
        {
            Form nextForm = (currentToolMenuType == ToolMenuType.TextEditor) ? null : new TextEditorForm();
            SwitchActiveBodyMainForm(ToolMenuType.TextEditor, nextForm);
        }

        private void btnTodoMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(ToolMenuType.ToDoList, new Form());
        }

        private void btnTaskManagementMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(ToolMenuType.ToDoList, new Form());
        }

        private void btnConfigurationMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(ToolMenuType.ToDoList, new Form());
        }

        private void btnHelpMenu_Click(object sender, EventArgs e)
        {
            SwitchActiveBodyMainForm(ToolMenuType.ToDoList, new Form());
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
