using System;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    public partial class MPMainWindow : Form
    {
        private void InitializeTESubmenuState()
        {
            HideTESubmenuPanels();
            HideTESubmenuButtons();
        }

        private void HideTESubmenuPanels()
        {
            pnlTEFileSubmenu.Visible = false;
            pnlTEEditSubmenu.Visible = false;
            pnlTEDisplaySubmenu.Visible = false;
        }

        private void ShowTESubmenuButtons()
        {
            btnTEDisplaySubmenu.Visible = true;
            btnTEEditSubmenu.Visible = true;
            btnTEFileSubmenu.Visible = true;
        }

        private void HideTESubmenuButtons()
        {
            btnTEFileSubmenu.Visible = false;
            btnTEEditSubmenu.Visible = false;
            btnTEDisplaySubmenu.Visible = false;
        }

        #region Event Listeners
        #region Menu Button Click Events
        private void ShowTESubmenuPanel(Panel targetPanel)
        {
            if (targetPanel.Visible)
            {
                targetPanel.Visible = false;
                return;
            }
            HideTESubmenuPanels();
            HideTESubmenuButtons();

            ShowTESubmenuButtons();
            targetPanel.Visible = true;
            targetPanel.SendToBack();
            // TODO: とりあえずべた書きした描画調整処理なので要検討
            var list = CreateButtonListUntil(targetPanel);
            while (list.Count != 0)
            {
                list.Pop().SendToBack();
            }
        }

        private void btnTEFileSubmenu_Click(object sender, EventArgs e)
        {
            ShowTESubmenuPanel(pnlTEFileSubmenu);
        }

        private void btnTEEditSubmenu_Click(object sender, EventArgs e)
        {
            ShowTESubmenuPanel(pnlTEEditSubmenu);
        }

        private void btnTEDisplaySubmenu_Click(object sender, EventArgs e)
        {
            ShowTESubmenuPanel(pnlTEDisplaySubmenu);
        }

        #endregion Menu Button Click Events
        #region Submenu Button Click Events
        #region File Submenu
        private void btnTEFileCreateNewFileSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEFileOpenFileSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEFileOpenFolderSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEFileSaveSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEFileSaveAsSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }
        #endregion File Submenu
        #region Edit Submenu
        private void btnTEEditSelectAllSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEEditCutSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEEditLineCutSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEEditCopySubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEEditLineCopySubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEEditPasteSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEEditFindSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }
        #endregion Edit Submenu
        #region Display Submenu
        private void btnTEDisplayDisableTextHighlightSubmenu_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }

        private void btnTEEditEnableConsole_Click(object sender, EventArgs e)
        {
            // some operation code
            // ..

            HideTESubmenuPanels();
        }
        #endregion Display Submenu
        #endregion Submenu Button Click Events
        #endregion Event Listeners
    }
}
