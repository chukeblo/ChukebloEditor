namespace ChukebloEditor.UI
{
    partial class MPMainWindow
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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnWikiMenu = new System.Windows.Forms.Button();
            this.btnProjectsMenu = new System.Windows.Forms.Button();
            this.btnTasksMenu = new System.Windows.Forms.Button();
            this.btnTodoMenu = new System.Windows.Forms.Button();
            this.btnScheduleMenu = new System.Windows.Forms.Button();
            this.btnHomeMenu = new System.Windows.Forms.Button();
            this.pnlSettingMenu = new System.Windows.Forms.Panel();
            this.btnAccountMenu = new System.Windows.Forms.Button();
            this.btnBugReportMenu = new System.Windows.Forms.Button();
            this.btnHelpMenu = new System.Windows.Forms.Button();
            this.pnlHomeIcon = new System.Windows.Forms.Panel();
            this.pnlMenuForm = new System.Windows.Forms.Panel();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnTopBarToDo = new System.Windows.Forms.Button();
            this.btnTopBarTasks = new System.Windows.Forms.Button();
            this.btnTopBarProjects = new System.Windows.Forms.Button();
            this.btnTopBarWiki = new System.Windows.Forms.Button();
            this.pnlSideBar.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlSettingMenu.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.pnlMainMenu);
            this.pnlSideBar.Controls.Add(this.pnlSettingMenu);
            this.pnlSideBar.Controls.Add(this.pnlHomeIcon);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(215, 752);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.AutoScroll = true;
            this.pnlMainMenu.BackColor = System.Drawing.Color.Aqua;
            this.pnlMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMainMenu.Controls.Add(this.btnWikiMenu);
            this.pnlMainMenu.Controls.Add(this.btnProjectsMenu);
            this.pnlMainMenu.Controls.Add(this.btnTasksMenu);
            this.pnlMainMenu.Controls.Add(this.btnTodoMenu);
            this.pnlMainMenu.Controls.Add(this.btnScheduleMenu);
            this.pnlMainMenu.Controls.Add(this.btnHomeMenu);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 110);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(215, 485);
            this.pnlMainMenu.TabIndex = 13;
            // 
            // btnWikiMenu
            // 
            this.btnWikiMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnWikiMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWikiMenu.FlatAppearance.BorderSize = 0;
            this.btnWikiMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWikiMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWikiMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnWikiMenu.Location = new System.Drawing.Point(0, 291);
            this.btnWikiMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWikiMenu.Name = "btnWikiMenu";
            this.btnWikiMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnWikiMenu.Size = new System.Drawing.Size(215, 58);
            this.btnWikiMenu.TabIndex = 19;
            this.btnWikiMenu.Text = "Wiki";
            this.btnWikiMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWikiMenu.UseVisualStyleBackColor = false;
            this.btnWikiMenu.Click += new System.EventHandler(this.btnWikiMenu_Click);
            // 
            // btnProjectsMenu
            // 
            this.btnProjectsMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnProjectsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjectsMenu.FlatAppearance.BorderSize = 0;
            this.btnProjectsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectsMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectsMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnProjectsMenu.Location = new System.Drawing.Point(0, 233);
            this.btnProjectsMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProjectsMenu.Name = "btnProjectsMenu";
            this.btnProjectsMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProjectsMenu.Size = new System.Drawing.Size(215, 58);
            this.btnProjectsMenu.TabIndex = 17;
            this.btnProjectsMenu.Text = "Projects";
            this.btnProjectsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjectsMenu.UseVisualStyleBackColor = false;
            this.btnProjectsMenu.Click += new System.EventHandler(this.btnProjectsMenu_Click);
            // 
            // btnTasksMenu
            // 
            this.btnTasksMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnTasksMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasksMenu.FlatAppearance.BorderSize = 0;
            this.btnTasksMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasksMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasksMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTasksMenu.Location = new System.Drawing.Point(0, 175);
            this.btnTasksMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTasksMenu.Name = "btnTasksMenu";
            this.btnTasksMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTasksMenu.Size = new System.Drawing.Size(215, 58);
            this.btnTasksMenu.TabIndex = 15;
            this.btnTasksMenu.Text = "Tasks";
            this.btnTasksMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasksMenu.UseVisualStyleBackColor = false;
            this.btnTasksMenu.Click += new System.EventHandler(this.btnTasksMenu_Click);
            // 
            // btnTodoMenu
            // 
            this.btnTodoMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnTodoMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTodoMenu.FlatAppearance.BorderSize = 0;
            this.btnTodoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodoMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodoMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTodoMenu.Location = new System.Drawing.Point(0, 117);
            this.btnTodoMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTodoMenu.Name = "btnTodoMenu";
            this.btnTodoMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTodoMenu.Size = new System.Drawing.Size(215, 58);
            this.btnTodoMenu.TabIndex = 14;
            this.btnTodoMenu.Text = "To-Do";
            this.btnTodoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodoMenu.UseVisualStyleBackColor = false;
            this.btnTodoMenu.Click += new System.EventHandler(this.btnTodoMenu_Click);
            // 
            // btnScheduleMenu
            // 
            this.btnScheduleMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnScheduleMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScheduleMenu.FlatAppearance.BorderSize = 0;
            this.btnScheduleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnScheduleMenu.Location = new System.Drawing.Point(0, 59);
            this.btnScheduleMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnScheduleMenu.Name = "btnScheduleMenu";
            this.btnScheduleMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnScheduleMenu.Size = new System.Drawing.Size(215, 58);
            this.btnScheduleMenu.TabIndex = 21;
            this.btnScheduleMenu.Text = "Schedule";
            this.btnScheduleMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScheduleMenu.UseVisualStyleBackColor = false;
            this.btnScheduleMenu.Click += new System.EventHandler(this.btnScheduleMenu_Click);
            // 
            // btnHomeMenu
            // 
            this.btnHomeMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnHomeMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHomeMenu.FlatAppearance.BorderSize = 0;
            this.btnHomeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHomeMenu.Location = new System.Drawing.Point(0, 0);
            this.btnHomeMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHomeMenu.Name = "btnHomeMenu";
            this.btnHomeMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHomeMenu.Size = new System.Drawing.Size(215, 59);
            this.btnHomeMenu.TabIndex = 20;
            this.btnHomeMenu.Text = "Home";
            this.btnHomeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeMenu.UseVisualStyleBackColor = false;
            this.btnHomeMenu.Click += new System.EventHandler(this.btnHomeMenu_Click);
            // 
            // pnlSettingMenu
            // 
            this.pnlSettingMenu.BackColor = System.Drawing.Color.Aqua;
            this.pnlSettingMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSettingMenu.Controls.Add(this.btnAccountMenu);
            this.pnlSettingMenu.Controls.Add(this.btnBugReportMenu);
            this.pnlSettingMenu.Controls.Add(this.btnHelpMenu);
            this.pnlSettingMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSettingMenu.Location = new System.Drawing.Point(0, 595);
            this.pnlSettingMenu.Name = "pnlSettingMenu";
            this.pnlSettingMenu.Size = new System.Drawing.Size(215, 157);
            this.pnlSettingMenu.TabIndex = 11;
            // 
            // btnAccountMenu
            // 
            this.btnAccountMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnAccountMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAccountMenu.FlatAppearance.BorderSize = 0;
            this.btnAccountMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAccountMenu.Location = new System.Drawing.Point(0, 4);
            this.btnAccountMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccountMenu.Name = "btnAccountMenu";
            this.btnAccountMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccountMenu.Size = new System.Drawing.Size(215, 51);
            this.btnAccountMenu.TabIndex = 13;
            this.btnAccountMenu.Text = "Account";
            this.btnAccountMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountMenu.UseVisualStyleBackColor = false;
            // 
            // btnBugReportMenu
            // 
            this.btnBugReportMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnBugReportMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBugReportMenu.FlatAppearance.BorderSize = 0;
            this.btnBugReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBugReportMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBugReportMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBugReportMenu.Location = new System.Drawing.Point(0, 55);
            this.btnBugReportMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBugReportMenu.Name = "btnBugReportMenu";
            this.btnBugReportMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBugReportMenu.Size = new System.Drawing.Size(215, 51);
            this.btnBugReportMenu.TabIndex = 12;
            this.btnBugReportMenu.Text = "Bug Report";
            this.btnBugReportMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBugReportMenu.UseVisualStyleBackColor = false;
            // 
            // btnHelpMenu
            // 
            this.btnHelpMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnHelpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelpMenu.FlatAppearance.BorderSize = 0;
            this.btnHelpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHelpMenu.Location = new System.Drawing.Point(0, 106);
            this.btnHelpMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHelpMenu.Name = "btnHelpMenu";
            this.btnHelpMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelpMenu.Size = new System.Drawing.Size(215, 51);
            this.btnHelpMenu.TabIndex = 10;
            this.btnHelpMenu.Text = "Help";
            this.btnHelpMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpMenu.UseVisualStyleBackColor = false;
            // 
            // pnlHomeIcon
            // 
            this.pnlHomeIcon.BackColor = System.Drawing.Color.Aqua;
            this.pnlHomeIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomeIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeIcon.Name = "pnlHomeIcon";
            this.pnlHomeIcon.Size = new System.Drawing.Size(215, 110);
            this.pnlHomeIcon.TabIndex = 10;
            // 
            // pnlMenuForm
            // 
            this.pnlMenuForm.BackColor = System.Drawing.Color.White;
            this.pnlMenuForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuForm.Location = new System.Drawing.Point(215, 46);
            this.pnlMenuForm.Name = "pnlMenuForm";
            this.pnlMenuForm.Size = new System.Drawing.Size(1252, 706);
            this.pnlMenuForm.TabIndex = 3;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Cyan;
            this.pnlTopBar.Controls.Add(this.btnTopBarWiki);
            this.pnlTopBar.Controls.Add(this.btnTopBarProjects);
            this.pnlTopBar.Controls.Add(this.btnTopBarTasks);
            this.pnlTopBar.Controls.Add(this.btnTopBarToDo);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(215, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1252, 46);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnTopBarToDo
            // 
            this.btnTopBarToDo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTopBarToDo.FlatAppearance.BorderSize = 0;
            this.btnTopBarToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopBarToDo.Location = new System.Drawing.Point(0, 0);
            this.btnTopBarToDo.Name = "btnTopBarToDo";
            this.btnTopBarToDo.Size = new System.Drawing.Size(294, 46);
            this.btnTopBarToDo.TabIndex = 0;
            this.btnTopBarToDo.Text = "To-Do";
            this.btnTopBarToDo.UseVisualStyleBackColor = true;
            this.btnTopBarToDo.Click += new System.EventHandler(this.btnTopBarToDo_Click);
            // 
            // btnTopBarTasks
            // 
            this.btnTopBarTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTopBarTasks.FlatAppearance.BorderSize = 0;
            this.btnTopBarTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopBarTasks.Location = new System.Drawing.Point(294, 0);
            this.btnTopBarTasks.Name = "btnTopBarTasks";
            this.btnTopBarTasks.Size = new System.Drawing.Size(294, 46);
            this.btnTopBarTasks.TabIndex = 1;
            this.btnTopBarTasks.Text = "Tasks";
            this.btnTopBarTasks.UseVisualStyleBackColor = true;
            this.btnTopBarTasks.Click += new System.EventHandler(this.btnTopBarTasks_Click);
            // 
            // btnTopBarProjects
            // 
            this.btnTopBarProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTopBarProjects.FlatAppearance.BorderSize = 0;
            this.btnTopBarProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopBarProjects.Location = new System.Drawing.Point(588, 0);
            this.btnTopBarProjects.Name = "btnTopBarProjects";
            this.btnTopBarProjects.Size = new System.Drawing.Size(294, 46);
            this.btnTopBarProjects.TabIndex = 2;
            this.btnTopBarProjects.Text = "Projects";
            this.btnTopBarProjects.UseVisualStyleBackColor = true;
            this.btnTopBarProjects.Click += new System.EventHandler(this.btnTopBarProjects_Click);
            // 
            // btnTopBarWiki
            // 
            this.btnTopBarWiki.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTopBarWiki.FlatAppearance.BorderSize = 0;
            this.btnTopBarWiki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopBarWiki.Location = new System.Drawing.Point(882, 0);
            this.btnTopBarWiki.Name = "btnTopBarWiki";
            this.btnTopBarWiki.Size = new System.Drawing.Size(294, 46);
            this.btnTopBarWiki.TabIndex = 3;
            this.btnTopBarWiki.Text = "Wiki";
            this.btnTopBarWiki.UseVisualStyleBackColor = true;
            this.btnTopBarWiki.Click += new System.EventHandler(this.btnTopBarWiki_Click);
            // 
            // MPMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 752);
            this.Controls.Add(this.pnlMenuForm);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSideBar);
            this.Font = new System.Drawing.Font("MS Outlook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MPMainWindow";
            this.Text = "MP - by chukeblo";
            this.pnlSideBar.ResumeLayout(false);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlSettingMenu.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlMenuForm;
        private System.Windows.Forms.Panel pnlHomeIcon;
        private System.Windows.Forms.Panel pnlSettingMenu;
        private System.Windows.Forms.Button btnHelpMenu;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnHomeMenu;
        private System.Windows.Forms.Button btnWikiMenu;
        private System.Windows.Forms.Button btnProjectsMenu;
        private System.Windows.Forms.Button btnTasksMenu;
        private System.Windows.Forms.Button btnTodoMenu;
        private System.Windows.Forms.Button btnScheduleMenu;
        private System.Windows.Forms.Button btnBugReportMenu;
        private System.Windows.Forms.Button btnAccountMenu;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnTopBarWiki;
        private System.Windows.Forms.Button btnTopBarProjects;
        private System.Windows.Forms.Button btnTopBarTasks;
        private System.Windows.Forms.Button btnTopBarToDo;
    }
}

