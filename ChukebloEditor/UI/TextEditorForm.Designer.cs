
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
            this.pnlFileExplolerArea = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlConsoleArea = new System.Windows.Forms.Panel();
            this.pnlTextBoxArea = new System.Windows.Forms.Panel();
            this.pnlFileTabArea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlFileExplolerArea
            // 
            this.pnlFileExplolerArea.AutoScroll = true;
            this.pnlFileExplolerArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlFileExplolerArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFileExplolerArea.Location = new System.Drawing.Point(0, 0);
            this.pnlFileExplolerArea.Name = "pnlFileExplolerArea";
            this.pnlFileExplolerArea.Size = new System.Drawing.Size(206, 822);
            this.pnlFileExplolerArea.TabIndex = 0;
            // 
            // pnlConsoleArea
            // 
            this.pnlConsoleArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlConsoleArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConsoleArea.Location = new System.Drawing.Point(206, 642);
            this.pnlConsoleArea.Name = "pnlConsoleArea";
            this.pnlConsoleArea.Size = new System.Drawing.Size(1320, 180);
            this.pnlConsoleArea.TabIndex = 1;
            // 
            // pnlTextBoxArea
            // 
            this.pnlTextBoxArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextBoxArea.Location = new System.Drawing.Point(0, 0);
            this.pnlTextBoxArea.Name = "pnlTextBoxArea";
            this.pnlTextBoxArea.Size = new System.Drawing.Size(1526, 822);
            this.pnlTextBoxArea.TabIndex = 2;
            // 
            // pnlFileTabArea
            // 
            this.pnlFileTabArea.BackColor = System.Drawing.Color.Lime;
            this.pnlFileTabArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFileTabArea.Location = new System.Drawing.Point(206, 0);
            this.pnlFileTabArea.Name = "pnlFileTabArea";
            this.pnlFileTabArea.Size = new System.Drawing.Size(1320, 35);
            this.pnlFileTabArea.TabIndex = 3;
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 822);
            this.Controls.Add(this.pnlTextBoxArea);
            this.Controls.Add(this.pnlFileTabArea);
            this.Controls.Add(this.pnlConsoleArea);
            this.Controls.Add(this.pnlFileExplolerArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TextEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFileExplolerArea;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlConsoleArea;
        private System.Windows.Forms.Panel pnlTextBoxArea;
        private System.Windows.Forms.Panel pnlFileTabArea;
    }
}

