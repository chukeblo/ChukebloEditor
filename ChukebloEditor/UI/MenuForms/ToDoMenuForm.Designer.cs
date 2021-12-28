
namespace ChukebloEditor.UI.MenuForms
{
    partial class ToDoMenuForm
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
            this.pnlToDoFormWindowRange = new System.Windows.Forms.Panel();
            this.pnlFinishedToDoItems = new System.Windows.Forms.Panel();
            this.lblFinishedToDoItems = new System.Windows.Forms.Label();
            this.pnlUnfinishedToDoItems = new System.Windows.Forms.Panel();
            this.lblUnfinishedToDoItems = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlToDoFormWindowRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToDoFormWindowRange
            // 
            this.pnlToDoFormWindowRange.BackColor = System.Drawing.Color.White;
            this.pnlToDoFormWindowRange.Controls.Add(this.btnDelete);
            this.pnlToDoFormWindowRange.Controls.Add(this.btnCreate);
            this.pnlToDoFormWindowRange.Controls.Add(this.pnlFinishedToDoItems);
            this.pnlToDoFormWindowRange.Controls.Add(this.lblFinishedToDoItems);
            this.pnlToDoFormWindowRange.Controls.Add(this.pnlUnfinishedToDoItems);
            this.pnlToDoFormWindowRange.Controls.Add(this.lblUnfinishedToDoItems);
            this.pnlToDoFormWindowRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToDoFormWindowRange.Location = new System.Drawing.Point(0, 0);
            this.pnlToDoFormWindowRange.Name = "pnlToDoFormWindowRange";
            this.pnlToDoFormWindowRange.Size = new System.Drawing.Size(1036, 614);
            this.pnlToDoFormWindowRange.TabIndex = 0;
            // 
            // pnlFinishedToDoItems
            // 
            this.pnlFinishedToDoItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFinishedToDoItems.AutoScroll = true;
            this.pnlFinishedToDoItems.BackColor = System.Drawing.Color.White;
            this.pnlFinishedToDoItems.Location = new System.Drawing.Point(75, 255);
            this.pnlFinishedToDoItems.Name = "pnlFinishedToDoItems";
            this.pnlFinishedToDoItems.Size = new System.Drawing.Size(886, 262);
            this.pnlFinishedToDoItems.TabIndex = 3;
            // 
            // lblFinishedToDoItems
            // 
            this.lblFinishedToDoItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinishedToDoItems.AutoSize = true;
            this.lblFinishedToDoItems.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishedToDoItems.Location = new System.Drawing.Point(71, 213);
            this.lblFinishedToDoItems.Name = "lblFinishedToDoItems";
            this.lblFinishedToDoItems.Size = new System.Drawing.Size(218, 24);
            this.lblFinishedToDoItems.TabIndex = 2;
            this.lblFinishedToDoItems.Text = "Finished To-Do Items";
            // 
            // pnlUnfinishedToDoItems
            // 
            this.pnlUnfinishedToDoItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnfinishedToDoItems.AutoScroll = true;
            this.pnlUnfinishedToDoItems.BackColor = System.Drawing.Color.White;
            this.pnlUnfinishedToDoItems.Location = new System.Drawing.Point(75, 86);
            this.pnlUnfinishedToDoItems.Name = "pnlUnfinishedToDoItems";
            this.pnlUnfinishedToDoItems.Size = new System.Drawing.Size(886, 104);
            this.pnlUnfinishedToDoItems.TabIndex = 1;
            // 
            // lblUnfinishedToDoItems
            // 
            this.lblUnfinishedToDoItems.AutoSize = true;
            this.lblUnfinishedToDoItems.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfinishedToDoItems.Location = new System.Drawing.Point(71, 38);
            this.lblUnfinishedToDoItems.Name = "lblUnfinishedToDoItems";
            this.lblUnfinishedToDoItems.Size = new System.Drawing.Size(240, 24);
            this.lblUnfinishedToDoItems.TabIndex = 0;
            this.lblUnfinishedToDoItems.Text = "Unfinished To-Do Items";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.Location = new System.Drawing.Point(242, 533);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(235, 59);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create New To-Do Item";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(596, 533);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(235, 59);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected To-Do Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ToDoMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 614);
            this.Controls.Add(this.pnlToDoFormWindowRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoMenuForm";
            this.Text = "ToDoMenuForm";
            this.pnlToDoFormWindowRange.ResumeLayout(false);
            this.pnlToDoFormWindowRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToDoFormWindowRange;
        private System.Windows.Forms.Panel pnlFinishedToDoItems;
        private System.Windows.Forms.Label lblFinishedToDoItems;
        private System.Windows.Forms.Panel pnlUnfinishedToDoItems;
        private System.Windows.Forms.Label lblUnfinishedToDoItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
    }
}