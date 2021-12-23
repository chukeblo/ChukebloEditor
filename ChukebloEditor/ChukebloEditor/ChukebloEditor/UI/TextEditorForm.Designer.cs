
namespace ChukebloEditor.UI
{
    partial class TextEditorForm
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
            this.pnlTextEditorSideBar = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlConsoleArea = new System.Windows.Forms.Panel();
            this.pnlTextBoxArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlTextEditorSideBar
            // 
            this.pnlTextEditorSideBar.AutoScroll = true;
            this.pnlTextEditorSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTextEditorSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTextEditorSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTextEditorSideBar.Name = "pnlTextEditorSideBar";
            this.pnlTextEditorSideBar.Size = new System.Drawing.Size(249, 822);
            this.pnlTextEditorSideBar.TabIndex = 0;
            // 
            // pnlConsoleArea
            // 
            this.pnlConsoleArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConsoleArea.Location = new System.Drawing.Point(249, 642);
            this.pnlConsoleArea.Name = "pnlConsoleArea";
            this.pnlConsoleArea.Size = new System.Drawing.Size(1277, 180);
            this.pnlConsoleArea.TabIndex = 1;
            // 
            // pnlTextBoxArea
            // 
            this.pnlTextBoxArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextBoxArea.Location = new System.Drawing.Point(249, 0);
            this.pnlTextBoxArea.Name = "pnlTextBoxArea";
            this.pnlTextBoxArea.Size = new System.Drawing.Size(1277, 642);
            this.pnlTextBoxArea.TabIndex = 2;
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 822);
            this.Controls.Add(this.pnlTextBoxArea);
            this.Controls.Add(this.pnlConsoleArea);
            this.Controls.Add(this.pnlTextEditorSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TextEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTextEditorSideBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlConsoleArea;
        private System.Windows.Forms.Panel pnlTextBoxArea;
    }
}

