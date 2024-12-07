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
            membersToolStripMenuItem.Click += (s, a) => MainGuiController.Instance.ShowMemberPanel();
            projectsToolStripMenuItem.Click += (s, a) => MainGuiController.Instance.ShowProjectPanel();
            logOutToolStripMenuItem.Click += (s, a) => MainGuiController.Instance.Logout();

            pnlMain.Width = this.Width;
        }

        private void msMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void membersToolStripMenuItem_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void membersToolStripMenuItem_DisplayStyleChanged(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        //public void ChangePanel(Control UControl)
        //{
        //    pnlMain.Controls.Clear();
        //    pnlMain.Controls.Add(UControl);
        //    UControl.Dock = DockStyle.Fill;
        //    pnlMain.AutoSize = true;

        //}


    }
}
