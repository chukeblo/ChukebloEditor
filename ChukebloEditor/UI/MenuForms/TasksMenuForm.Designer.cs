
namespace ChukebloEditor.UI.MenuForms
{
    partial class TasksMenuForm
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
            this.pnlTasksFormWindowRange = new System.Windows.Forms.Panel();
            this.lblRecentlyAddedTasks = new System.Windows.Forms.Label();
            this.pnlRecentlyAddedTasks = new System.Windows.Forms.Panel();
            this.pnlAllTasks = new System.Windows.Forms.Panel();
            this.lblAllTasks = new System.Windows.Forms.Label();
            this.btnCreateNewTasks = new System.Windows.Forms.Button();
            this.btnDeleteSelectedTask = new System.Windows.Forms.Button();
            this.pnlTasksFormWindowRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTasksFormWindowRange
            // 
            this.pnlTasksFormWindowRange.Controls.Add(this.btnDeleteSelectedTask);
            this.pnlTasksFormWindowRange.Controls.Add(this.btnCreateNewTasks);
            this.pnlTasksFormWindowRange.Controls.Add(this.pnlAllTasks);
            this.pnlTasksFormWindowRange.Controls.Add(this.lblAllTasks);
            this.pnlTasksFormWindowRange.Controls.Add(this.pnlRecentlyAddedTasks);
            this.pnlTasksFormWindowRange.Controls.Add(this.lblRecentlyAddedTasks);
            this.pnlTasksFormWindowRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasksFormWindowRange.Location = new System.Drawing.Point(0, 0);
            this.pnlTasksFormWindowRange.Name = "pnlTasksFormWindowRange";
            this.pnlTasksFormWindowRange.Size = new System.Drawing.Size(1345, 753);
            this.pnlTasksFormWindowRange.TabIndex = 0;
            // 
            // lblRecentlyAddedTasks
            // 
            this.lblRecentlyAddedTasks.AutoSize = true;
            this.lblRecentlyAddedTasks.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentlyAddedTasks.Location = new System.Drawing.Point(70, 38);
            this.lblRecentlyAddedTasks.Name = "lblRecentlyAddedTasks";
            this.lblRecentlyAddedTasks.Size = new System.Drawing.Size(219, 24);
            this.lblRecentlyAddedTasks.TabIndex = 0;
            this.lblRecentlyAddedTasks.Text = "Recently Added Tasks";
            // 
            // pnlRecentlyAddedTasks
            // 
            this.pnlRecentlyAddedTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecentlyAddedTasks.AutoScroll = true;
            this.pnlRecentlyAddedTasks.Location = new System.Drawing.Point(74, 81);
            this.pnlRecentlyAddedTasks.Name = "pnlRecentlyAddedTasks";
            this.pnlRecentlyAddedTasks.Size = new System.Drawing.Size(1187, 216);
            this.pnlRecentlyAddedTasks.TabIndex = 1;
            // 
            // pnlAllTasks
            // 
            this.pnlAllTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAllTasks.AutoScroll = true;
            this.pnlAllTasks.Location = new System.Drawing.Point(74, 362);
            this.pnlAllTasks.Name = "pnlAllTasks";
            this.pnlAllTasks.Size = new System.Drawing.Size(1187, 216);
            this.pnlAllTasks.TabIndex = 3;
            // 
            // lblAllTasks
            // 
            this.lblAllTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllTasks.AutoSize = true;
            this.lblAllTasks.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllTasks.Location = new System.Drawing.Point(70, 319);
            this.lblAllTasks.Name = "lblAllTasks";
            this.lblAllTasks.Size = new System.Drawing.Size(120, 30);
            this.lblAllTasks.TabIndex = 2;
            this.lblAllTasks.Text = "All Tasks";
            // 
            // btnCreateNewTasks
            // 
            this.btnCreateNewTasks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateNewTasks.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTasks.Location = new System.Drawing.Point(420, 625);
            this.btnCreateNewTasks.Name = "btnCreateNewTasks";
            this.btnCreateNewTasks.Size = new System.Drawing.Size(216, 58);
            this.btnCreateNewTasks.TabIndex = 4;
            this.btnCreateNewTasks.Text = "Create New Task";
            this.btnCreateNewTasks.UseVisualStyleBackColor = true;
            this.btnCreateNewTasks.Click += new System.EventHandler(this.btnCreateNewTask_Click);
            // 
            // btnDeleteSelectedTask
            // 
            this.btnDeleteSelectedTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteSelectedTask.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedTask.Location = new System.Drawing.Point(728, 625);
            this.btnDeleteSelectedTask.Name = "btnDeleteSelectedTask";
            this.btnDeleteSelectedTask.Size = new System.Drawing.Size(216, 58);
            this.btnDeleteSelectedTask.TabIndex = 5;
            this.btnDeleteSelectedTask.Text = "Delete Selected Task";
            this.btnDeleteSelectedTask.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedTask.Click += new System.EventHandler(this.btnDeleteSelectedTask_Click);
            // 
            // TasksMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 753);
            this.Controls.Add(this.pnlTasksFormWindowRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TasksMenuForm";
            this.Text = "TasksMenuForm";
            this.pnlTasksFormWindowRange.ResumeLayout(false);
            this.pnlTasksFormWindowRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTasksFormWindowRange;
        private System.Windows.Forms.Button btnCreateNewTasks;
        private System.Windows.Forms.Panel pnlAllTasks;
        private System.Windows.Forms.Label lblAllTasks;
        private System.Windows.Forms.Panel pnlRecentlyAddedTasks;
        private System.Windows.Forms.Label lblRecentlyAddedTasks;
        private System.Windows.Forms.Button btnDeleteSelectedTask;
    }
}