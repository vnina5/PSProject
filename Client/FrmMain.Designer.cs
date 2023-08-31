using System.ComponentModel;
using System.Windows.Forms;

namespace Client
{
    partial class FrmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.topicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(0, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 396);
            this.pnlMain.TabIndex = 0;
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.topicsToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 28);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // topicsToolStripMenuItem
            // 
            this.topicsToolStripMenuItem.Name = "topicsToolStripMenuItem";
            this.topicsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.topicsToolStripMenuItem.Text = "Topics";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlMain;
        private MenuStrip msMain;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem topicsToolStripMenuItem;

        public Panel PnlMain { get => pnlMain; set => pnlMain = value; }
        public MenuStrip MsMain { get => msMain; set => msMain = value; }
        public ToolStripMenuItem MembersToolStripMenuItem { get => membersToolStripMenuItem; set => membersToolStripMenuItem = value; }
        public ToolStripMenuItem ProjectsToolStripMenuItem { get => projectsToolStripMenuItem; set => projectsToolStripMenuItem = value; }
        public BackgroundWorker BackgroundWorker1 { get => backgroundWorker1; set => backgroundWorker1 = value; }
        public ToolStripMenuItem TopicsToolStripMenuItem { get => topicsToolStripMenuItem; set => topicsToolStripMenuItem = value; }
    }
}

