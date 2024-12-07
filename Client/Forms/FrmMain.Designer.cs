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
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.Location = new System.Drawing.Point(0, 43);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(976, 391);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // msMain
            // 
            this.msMain.AutoSize = false;
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(976, 40);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            this.msMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMain_ItemClicked);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.AutoSize = false;
            this.membersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.membersToolStripMenuItem.Text = "Members";
            this.membersToolStripMenuItem.BackColorChanged += new System.EventHandler(this.membersToolStripMenuItem_BackColorChanged);
            this.membersToolStripMenuItem.DisplayStyleChanged += new System.EventHandler(this.membersToolStripMenuItem_DisplayStyleChanged);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.AutoSize = false;
            this.projectsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.AutoSize = false;
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 436);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private MenuStrip msMain;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem projectsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private BackgroundWorker backgroundWorker1;

        public Panel PnlMain { get => pnlMain; set => pnlMain = value; }
        public MenuStrip MsMain { get => msMain; set => msMain = value; }
        public ToolStripMenuItem MembersToolStripMenuItem { get => membersToolStripMenuItem; set => membersToolStripMenuItem = value; }
        public ToolStripMenuItem ProjectsToolStripMenuItem { get => projectsToolStripMenuItem; set => projectsToolStripMenuItem = value; }
        public ToolStripMenuItem LogOutToolStripMenuItem { get => logOutToolStripMenuItem; set => logOutToolStripMenuItem = value; }
        public BackgroundWorker BackgroundWorker1 { get => backgroundWorker1; set => backgroundWorker1 = value; }
    }
}

