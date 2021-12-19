
namespace ChukebloEditor
{
    partial class ChukebloEditorForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuBarButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuCreateNewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuOverwriteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuBarButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuCopyButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuPasteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuSelectAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.CurrentlyOpenedFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.EditMenuCutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuBarButton,
            this.EditMenuBarButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuBarButton
            // 
            this.FileMenuBarButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuCreateNewButton,
            this.FileMenuOpenButton,
            this.FileMenuOverwriteButton,
            this.FileMenuSaveButton,
            this.FileMenuExitButton});
            this.FileMenuBarButton.Name = "FileMenuBarButton";
            this.FileMenuBarButton.ShowShortcutKeys = false;
            this.FileMenuBarButton.Size = new System.Drawing.Size(65, 24);
            this.FileMenuBarButton.Text = "ファイル";
            // 
            // FileMenuCreateNewButton
            // 
            this.FileMenuCreateNewButton.Name = "FileMenuCreateNewButton";
            this.FileMenuCreateNewButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileMenuCreateNewButton.Size = new System.Drawing.Size(291, 26);
            this.FileMenuCreateNewButton.Text = "新規作成";
            this.FileMenuCreateNewButton.Click += new System.EventHandler(this.FileMenuCreateNewButton_Click);
            // 
            // FileMenuOpenButton
            // 
            this.FileMenuOpenButton.Name = "FileMenuOpenButton";
            this.FileMenuOpenButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileMenuOpenButton.Size = new System.Drawing.Size(291, 26);
            this.FileMenuOpenButton.Text = "ファイルを開く";
            this.FileMenuOpenButton.Click += new System.EventHandler(this.FileMenuOpenButton_Click);
            // 
            // FileMenuOverwriteButton
            // 
            this.FileMenuOverwriteButton.Name = "FileMenuOverwriteButton";
            this.FileMenuOverwriteButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileMenuOverwriteButton.Size = new System.Drawing.Size(291, 26);
            this.FileMenuOverwriteButton.Text = "上書き保存";
            // 
            // FileMenuSaveButton
            // 
            this.FileMenuSaveButton.Name = "FileMenuSaveButton";
            this.FileMenuSaveButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.FileMenuSaveButton.Size = new System.Drawing.Size(291, 26);
            this.FileMenuSaveButton.Text = "名前を付けて保存";
            this.FileMenuSaveButton.Click += new System.EventHandler(this.FileMenuSaveButton_Click);
            // 
            // FileMenuExitButton
            // 
            this.FileMenuExitButton.Name = "FileMenuExitButton";
            this.FileMenuExitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.FileMenuExitButton.Size = new System.Drawing.Size(291, 26);
            this.FileMenuExitButton.Text = "終了";
            this.FileMenuExitButton.Click += new System.EventHandler(this.FileMenuExitButton_Click);
            // 
            // EditMenuBarButton
            // 
            this.EditMenuBarButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMenuSelectAllButton,
            this.EditMenuCutButton,
            this.EditMenuCopyButton,
            this.EditMenuPasteButton});
            this.EditMenuBarButton.Name = "EditMenuBarButton";
            this.EditMenuBarButton.Size = new System.Drawing.Size(53, 24);
            this.EditMenuBarButton.Text = "編集";
            // 
            // EditMenuCopyButton
            // 
            this.EditMenuCopyButton.Name = "EditMenuCopyButton";
            this.EditMenuCopyButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EditMenuCopyButton.Size = new System.Drawing.Size(224, 26);
            this.EditMenuCopyButton.Text = "コピー";
            this.EditMenuCopyButton.Click += new System.EventHandler(this.EditMenuCopyButton_Click);
            // 
            // EditMenuPasteButton
            // 
            this.EditMenuPasteButton.Name = "EditMenuPasteButton";
            this.EditMenuPasteButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.EditMenuPasteButton.Size = new System.Drawing.Size(224, 26);
            this.EditMenuPasteButton.Text = "ペースト";
            this.EditMenuPasteButton.Click += new System.EventHandler(this.EditMenuPasteButton_Click);
            // 
            // EditMenuSelectAllButton
            // 
            this.EditMenuSelectAllButton.Name = "EditMenuSelectAllButton";
            this.EditMenuSelectAllButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.EditMenuSelectAllButton.Size = new System.Drawing.Size(224, 26);
            this.EditMenuSelectAllButton.Text = "すべて選択";
            this.EditMenuSelectAllButton.Click += new System.EventHandler(this.EditMenuSelectAllButton_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentlyOpenedFileName});
            this.StatusBar.Location = new System.Drawing.Point(0, 631);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1199, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // CurrentlyOpenedFileName
            // 
            this.CurrentlyOpenedFileName.Name = "CurrentlyOpenedFileName";
            this.CurrentlyOpenedFileName.Size = new System.Drawing.Size(0, 18);
            // 
            // TextBox
            // 
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Location = new System.Drawing.Point(0, 28);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox.Size = new System.Drawing.Size(1199, 603);
            this.TextBox.TabIndex = 4;
            // 
            // EditMenuCutButton
            // 
            this.EditMenuCutButton.Name = "EditMenuCutButton";
            this.EditMenuCutButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EditMenuCutButton.Size = new System.Drawing.Size(224, 26);
            this.EditMenuCutButton.Text = "切り取り";
            this.EditMenuCutButton.Click += new System.EventHandler(this.EditMenuCutButton_Click);
            // 
            // ChukebloEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 653);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChukebloEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChukebloEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuBarButton;
        private System.Windows.Forms.ToolStripMenuItem FileMenuOpenButton;
        private System.Windows.Forms.ToolStripMenuItem FileMenuSaveButton;
        private System.Windows.Forms.ToolStripMenuItem FileMenuExitButton;
        private System.Windows.Forms.ToolStripMenuItem FileMenuOverwriteButton;
        private System.Windows.Forms.ToolStripMenuItem FileMenuCreateNewButton;
        private System.Windows.Forms.ToolStripMenuItem EditMenuBarButton;
        private System.Windows.Forms.ToolStripMenuItem EditMenuCopyButton;
        private System.Windows.Forms.ToolStripMenuItem EditMenuPasteButton;
        private System.Windows.Forms.ToolStripMenuItem EditMenuSelectAllButton;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel CurrentlyOpenedFileName;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem EditMenuCutButton;
    }
}

