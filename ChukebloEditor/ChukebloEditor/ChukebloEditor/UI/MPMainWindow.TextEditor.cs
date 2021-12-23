using System;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    public partial class MPMainWindow : Form
    {
        private void InitializeTESubmenuState()
        {
            pnlTEFileSubmenu.Visible = false;
            pnlTEEditSubmenu.Visible = false;
            pnlTEDisplaySubmenu.Visible = false;
        }

        private void HideTESubmenu()
        {
            if (pnlTEFileSubmenu.Visible)
            {
                pnlTEFileSubmenu.Visible = false;
            }
            if (pnlTEEditSubmenu.Visible)
            {
                pnlTEEditSubmenu.Visible = false;
            }
            if (pnlTEDisplaySubmenu.Visible)
            {
                pnlTEDisplaySubmenu.Visible = false;
            }
        }

        #region Event Listeners
        #region Menu Button Click Events
        private void ShowTESubmenu(Panel submenu)
        {
            if (submenu.Visible)
            {
                submenu.Visible = false;
                return;
            }
            HideSubmenu();
            submenu.Visible = true;
        }

        private void btnTEFileSubmenu_Click(object sender, EventArgs e)
        {
            ShowTESubmenu(pnlTEFileSubmenu);
        }

        private void btnTEEditSubmenu_Click(object sender, EventArgs e)
        {
            ShowTESubmenu(pnlTEEditSubmenu);
        }

        private void btnTEDisplaySubmenu_Click(object sender, EventArgs e)
        {
            ShowTESubmenu(pnlTEDisplaySubmenu);
        }

        #endregion Menu Button Click Events
        #region Submenu Button Click Events
        #region File Submenu
        private void btnTEFileCreateNewFileSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEFileOpenFileSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEFileOpenFolderSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEFileSaveSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEFileSaveAsSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }
        #endregion File Submenu
        #region Edit Submenu
        private void btnTEEditSelectAllSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEEditCutSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEEditLineCutSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEEditCopySubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEEditLineCopySubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEEditPasteSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEEditFindSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }
        #endregion Edit Submenu
        #region Display Submenu
        private void btnTEDisplayDisableTextHighlightSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }

        private void btnTEEditEnableConsole_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenu();
        }
        #endregion Display Submenu
        #endregion Submenu Button Click Events
        #endregion Event Listeners
    }
}
