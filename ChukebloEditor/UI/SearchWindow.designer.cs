
namespace ChukebloEditor.UI
{
    partial class SearchWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchWordsLabel = new System.Windows.Forms.Label();
            this.SearchWordsTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancellationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchWordsLabel
            // 
            this.SearchWordsLabel.AutoSize = true;
            this.SearchWordsLabel.Location = new System.Drawing.Point(12, 19);
            this.SearchWordsLabel.Name = "SearchWordsLabel";
            this.SearchWordsLabel.Size = new System.Drawing.Size(129, 22);
            this.SearchWordsLabel.TabIndex = 0;
            this.SearchWordsLabel.Text = "検索する文字列";
            // 
            // SearchWordsTextBox
            // 
            this.SearchWordsTextBox.Location = new System.Drawing.Point(147, 16);
            this.SearchWordsTextBox.Name = "SearchWordsTextBox";
            this.SearchWordsTextBox.Size = new System.Drawing.Size(272, 28);
            this.SearchWordsTextBox.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(114, 55);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 32);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancellationButton
            // 
            this.CancellationButton.Location = new System.Drawing.Point(241, 55);
            this.CancellationButton.Name = "CancellationButton";
            this.CancellationButton.Size = new System.Drawing.Size(75, 32);
            this.CancellationButton.TabIndex = 3;
            this.CancellationButton.Text = "Cancel";
            this.CancellationButton.UseVisualStyleBackColor = true;
            this.CancellationButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 95);
            this.Controls.Add(this.CancellationButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SearchWordsTextBox);
            this.Controls.Add(this.SearchWordsLabel);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchWindow";
            this.Text = "検索ボックス";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchWindow_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchWordsLabel;
        private System.Windows.Forms.TextBox SearchWordsTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancellationButton;
    }
}