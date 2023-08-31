using Client.GuiController;
using Client.UserControls;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoSize = true;

 
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //pnlMain.Controls.Add(new UCMembersView());
            membersToolStripMenuItem.Click += (s, a) => MainGuiController.Instance.ShowMemberPanel();
            projectsToolStripMenuItem.Click += (s, a) => MainGuiController.Instance.ShowProjectPanel();
            topicsToolStripMenuItem.Click += (s, a) => MainGuiController.Instance.ShowTopicPanel();

        }

        public void ChangePanel(Control UControl)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(UControl);
            //UControl.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;



        }


    }
}
