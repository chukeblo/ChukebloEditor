
namespace ChukebloEditor.UI.ManagementItemForms
{
    partial class ToDoItemForm
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
            this.pnlToDoItemWiindowRange = new System.Windows.Forms.Panel();
            this.pctTrashbox = new System.Windows.Forms.PictureBox();
            this.chkbxFinished = new System.Windows.Forms.CheckBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pnlToDoItemWiindowRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrashbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToDoItemWiindowRange
            // 
            this.pnlToDoItemWiindowRange.Controls.Add(this.pctTrashbox);
            this.pnlToDoItemWiindowRange.Controls.Add(this.chkbxFinished);
            this.pnlToDoItemWiindowRange.Controls.Add(this.txtMemo);
            this.pnlToDoItemWiindowRange.Controls.Add(this.txtTag);
            this.pnlToDoItemWiindowRange.Controls.Add(this.txtTitle);
            this.pnlToDoItemWiindowRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToDoItemWiindowRange.Location = new System.Drawing.Point(0, 0);
            this.pnlToDoItemWiindowRange.Name = "pnlToDoItemWiindowRange";
            this.pnlToDoItemWiindowRange.Size = new System.Drawing.Size(200, 250);
            this.pnlToDoItemWiindowRange.TabIndex = 0;
            this.pnlToDoItemWiindowRange.Click += new System.EventHandler(this.pnlToDoItemWindowRange_Click);
            // 
            // pctTrashbox
            // 
            this.pctTrashbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctTrashbox.BackColor = System.Drawing.Color.Transparent;
            this.pctTrashbox.Image = global::ChukebloEditor.Properties.Resources.trashbox;
            this.pctTrashbox.InitialImage = global::ChukebloEditor.Properties.Resources.trashbox;
            this.pctTrashbox.Location = new System.Drawing.Point(160, 21);
            this.pctTrashbox.Name = "pctTrashbox";
            this.pctTrashbox.Size = new System.Drawing.Size(29, 35);
            this.pctTrashbox.TabIndex = 9;
            this.pctTrashbox.TabStop = false;
            this.pctTrashbox.Click += new System.EventHandler(this.pctTrashbox_Click);
            // 
            // chkbxFinished
            // 
            this.chkbxFinished.AutoSize = true;
            this.chkbxFinished.BackColor = System.Drawing.Color.Transparent;
            this.chkbxFinished.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxFinished.Location = new System.Drawing.Point(13, 23);
            this.chkbxFinished.Name = "chkbxFinished";
            this.chkbxFinished.Size = new System.Drawing.Size(104, 26);
            this.chkbxFinished.TabIndex = 8;
            this.chkbxFinished.Text = "Finished";
            this.chkbxFinished.UseVisualStyleBackColor = false;
            this.chkbxFinished.CheckedChanged += new System.EventHandler(this.chkbxFinished_CheckedChanged);
            // 
            // txtMemo
            // 
            this.txtMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemo.BackColor = System.Drawing.Color.White;
            this.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemo.Location = new System.Drawing.Point(12, 208);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ReadOnly = true;
            this.txtMemo.Size = new System.Drawing.Size(169, 21);
            this.txtMemo.TabIndex = 7;
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.BackColor = System.Drawing.Color.White;
            this.txtTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTag.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTag.Location = new System.Drawing.Point(12, 140);
            this.txtTag.Name = "txtTag";
            this.txtTag.ReadOnly = true;
            this.txtTag.Size = new System.Drawing.Size(169, 21);
            this.txtTag.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(12, 71);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(169, 21);
            this.txtTitle.TabIndex = 5;
            // 
            // ToDoItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(200, 250);
            this.Controls.Add(this.pnlToDoItemWiindowRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoItemForm";
            this.Text = "ToDoItemForm";
            this.pnlToDoItemWiindowRange.ResumeLayout(false);
            this.pnlToDoItemWiindowRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrashbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToDoItemWiindowRange;
        private System.Windows.Forms.PictureBox pctTrashbox;
        private System.Windows.Forms.CheckBox chkbxFinished;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtTitle;
    }
}