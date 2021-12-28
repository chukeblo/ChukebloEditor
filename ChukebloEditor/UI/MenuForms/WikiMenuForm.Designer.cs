
namespace ChukebloEditor.UI.MenuForms
{
    partial class WikiMenuForm
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
            this.lblAllWiki = new System.Windows.Forms.Label();
            this.pnlAllWiki = new System.Windows.Forms.Panel();
            this.pnlRecentlyAddedWiki = new System.Windows.Forms.Panel();
            this.lblRecentlyAddedWiki = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlWikiFormWindowRange = new System.Windows.Forms.Panel();
            this.pnlWikiFormWindowRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAllWiki
            // 
            this.lblAllWiki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllWiki.AutoSize = true;
            this.lblAllWiki.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllWiki.Location = new System.Drawing.Point(86, 377);
            this.lblAllWiki.Name = "lblAllWiki";
            this.lblAllWiki.Size = new System.Drawing.Size(99, 29);
            this.lblAllWiki.TabIndex = 0;
            this.lblAllWiki.Text = "All Wiki";
            // 
            // pnlAllWiki
            // 
            this.pnlAllWiki.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAllWiki.AutoScroll = true;
            this.pnlAllWiki.BackColor = System.Drawing.Color.White;
            this.pnlAllWiki.Location = new System.Drawing.Point(90, 421);
            this.pnlAllWiki.Name = "pnlAllWiki";
            this.pnlAllWiki.Size = new System.Drawing.Size(1139, 286);
            this.pnlAllWiki.TabIndex = 1;
            // 
            // pnlRecentlyAddedWiki
            // 
            this.pnlRecentlyAddedWiki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecentlyAddedWiki.AutoScroll = true;
            this.pnlRecentlyAddedWiki.BackColor = System.Drawing.Color.White;
            this.pnlRecentlyAddedWiki.Location = new System.Drawing.Point(90, 85);
            this.pnlRecentlyAddedWiki.Name = "pnlRecentlyAddedWiki";
            this.pnlRecentlyAddedWiki.Size = new System.Drawing.Size(1139, 271);
            this.pnlRecentlyAddedWiki.TabIndex = 2;
            // 
            // lblRecentlyAddedWiki
            // 
            this.lblRecentlyAddedWiki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecentlyAddedWiki.AutoSize = true;
            this.lblRecentlyAddedWiki.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentlyAddedWiki.Location = new System.Drawing.Point(86, 40);
            this.lblRecentlyAddedWiki.Name = "lblRecentlyAddedWiki";
            this.lblRecentlyAddedWiki.Size = new System.Drawing.Size(256, 29);
            this.lblRecentlyAddedWiki.TabIndex = 3;
            this.lblRecentlyAddedWiki.Text = "Recently Added Wiki";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.Location = new System.Drawing.Point(372, 756);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(227, 48);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create New Wiki";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(711, 756);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 48);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected Wiki";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlWikiFormWindowRange
            // 
            this.pnlWikiFormWindowRange.Controls.Add(this.btnDelete);
            this.pnlWikiFormWindowRange.Controls.Add(this.btnCreate);
            this.pnlWikiFormWindowRange.Controls.Add(this.lblRecentlyAddedWiki);
            this.pnlWikiFormWindowRange.Controls.Add(this.pnlRecentlyAddedWiki);
            this.pnlWikiFormWindowRange.Controls.Add(this.pnlAllWiki);
            this.pnlWikiFormWindowRange.Controls.Add(this.lblAllWiki);
            this.pnlWikiFormWindowRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWikiFormWindowRange.Location = new System.Drawing.Point(0, 0);
            this.pnlWikiFormWindowRange.Name = "pnlWikiFormWindowRange";
            this.pnlWikiFormWindowRange.Size = new System.Drawing.Size(1336, 874);
            this.pnlWikiFormWindowRange.TabIndex = 6;
            // 
            // WikiMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1336, 874);
            this.Controls.Add(this.pnlWikiFormWindowRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WikiMenuForm";
            this.Text = "WikiMenuForm";
            this.pnlWikiFormWindowRange.ResumeLayout(false);
            this.pnlWikiFormWindowRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAllWiki;
        private System.Windows.Forms.Panel pnlAllWiki;
        private System.Windows.Forms.Panel pnlRecentlyAddedWiki;
        private System.Windows.Forms.Label lblRecentlyAddedWiki;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlWikiFormWindowRange;
    }
}