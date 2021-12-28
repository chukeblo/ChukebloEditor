
namespace ChukebloEditor.UI.MenuForms
{
    partial class ProjectsMenuForm
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
            this.pnlProjectsFormWindowRange = new System.Windows.Forms.Panel();
            this.lblRecentlyAddedProjects = new System.Windows.Forms.Label();
            this.pnlRecentlyAddedProjects = new System.Windows.Forms.Panel();
            this.lblAllProjects = new System.Windows.Forms.Label();
            this.pnlAllProjects = new System.Windows.Forms.Panel();
            this.btnCreateNewProject = new System.Windows.Forms.Button();
            this.btnDeleteSelectedProject = new System.Windows.Forms.Button();
            this.pnlProjectsFormWindowRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProjectsFormWindowRange
            // 
            this.pnlProjectsFormWindowRange.BackColor = System.Drawing.Color.White;
            this.pnlProjectsFormWindowRange.Controls.Add(this.btnDeleteSelectedProject);
            this.pnlProjectsFormWindowRange.Controls.Add(this.btnCreateNewProject);
            this.pnlProjectsFormWindowRange.Controls.Add(this.pnlAllProjects);
            this.pnlProjectsFormWindowRange.Controls.Add(this.lblAllProjects);
            this.pnlProjectsFormWindowRange.Controls.Add(this.pnlRecentlyAddedProjects);
            this.pnlProjectsFormWindowRange.Controls.Add(this.lblRecentlyAddedProjects);
            this.pnlProjectsFormWindowRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProjectsFormWindowRange.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectsFormWindowRange.Name = "pnlProjectsFormWindowRange";
            this.pnlProjectsFormWindowRange.Size = new System.Drawing.Size(1212, 724);
            this.pnlProjectsFormWindowRange.TabIndex = 1;
            // 
            // lblRecentlyAddedProjects
            // 
            this.lblRecentlyAddedProjects.AutoSize = true;
            this.lblRecentlyAddedProjects.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentlyAddedProjects.Location = new System.Drawing.Point(61, 43);
            this.lblRecentlyAddedProjects.Name = "lblRecentlyAddedProjects";
            this.lblRecentlyAddedProjects.Size = new System.Drawing.Size(301, 30);
            this.lblRecentlyAddedProjects.TabIndex = 0;
            this.lblRecentlyAddedProjects.Text = "Recently Added Projects";
            // 
            // pnlRecentlyAddedProjects
            // 
            this.pnlRecentlyAddedProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecentlyAddedProjects.AutoScroll = true;
            this.pnlRecentlyAddedProjects.Location = new System.Drawing.Point(65, 85);
            this.pnlRecentlyAddedProjects.Name = "pnlRecentlyAddedProjects";
            this.pnlRecentlyAddedProjects.Size = new System.Drawing.Size(1066, 214);
            this.pnlRecentlyAddedProjects.TabIndex = 1;
            // 
            // lblAllProjects
            // 
            this.lblAllProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllProjects.AutoSize = true;
            this.lblAllProjects.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllProjects.Location = new System.Drawing.Point(61, 324);
            this.lblAllProjects.Name = "lblAllProjects";
            this.lblAllProjects.Size = new System.Drawing.Size(118, 24);
            this.lblAllProjects.TabIndex = 2;
            this.lblAllProjects.Text = "All Projects";
            // 
            // pnlAllProjects
            // 
            this.pnlAllProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAllProjects.AutoScroll = true;
            this.pnlAllProjects.Location = new System.Drawing.Point(65, 372);
            this.pnlAllProjects.Name = "pnlAllProjects";
            this.pnlAllProjects.Size = new System.Drawing.Size(1066, 224);
            this.pnlAllProjects.TabIndex = 3;
            // 
            // btnCreateNewProject
            // 
            this.btnCreateNewProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateNewProject.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewProject.Location = new System.Drawing.Point(327, 631);
            this.btnCreateNewProject.Name = "btnCreateNewProject";
            this.btnCreateNewProject.Size = new System.Drawing.Size(238, 58);
            this.btnCreateNewProject.TabIndex = 4;
            this.btnCreateNewProject.Text = "Create New Project";
            this.btnCreateNewProject.UseVisualStyleBackColor = true;
            this.btnCreateNewProject.Click += new System.EventHandler(this.btnCreateNewProject_Click);
            // 
            // btnDeleteSelectedProject
            // 
            this.btnDeleteSelectedProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteSelectedProject.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectedProject.Location = new System.Drawing.Point(655, 631);
            this.btnDeleteSelectedProject.Name = "btnDeleteSelectedProject";
            this.btnDeleteSelectedProject.Size = new System.Drawing.Size(238, 58);
            this.btnDeleteSelectedProject.TabIndex = 5;
            this.btnDeleteSelectedProject.Text = "Delete Selected Project";
            this.btnDeleteSelectedProject.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedProject.Click += new System.EventHandler(this.btnDeleteSelectedProject_Click);
            // 
            // ProjectsMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 724);
            this.Controls.Add(this.pnlProjectsFormWindowRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectsMenuForm";
            this.Text = "ProjectsMenuForm";
            this.pnlProjectsFormWindowRange.ResumeLayout(false);
            this.pnlProjectsFormWindowRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProjectsFormWindowRange;
        private System.Windows.Forms.Label lblRecentlyAddedProjects;
        private System.Windows.Forms.Label lblAllProjects;
        private System.Windows.Forms.Panel pnlRecentlyAddedProjects;
        private System.Windows.Forms.Panel pnlAllProjects;
        private System.Windows.Forms.Button btnDeleteSelectedProject;
        private System.Windows.Forms.Button btnCreateNewProject;
    }
}