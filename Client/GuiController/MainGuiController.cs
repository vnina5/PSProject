using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class MainGuiController
    {
        private FrmMain frmMain;
        private FrmLogin frmLogin;
        private LoginGuiController loginGuiController;
        private MemberGuiController memberGuiController;
        private ProjectGuiController projectGuiController;

        public User logedUser { get; set; }

        private static MainGuiController instance;
        public static MainGuiController Instance
        {
            get
            {
                if (instance == null) instance = new MainGuiController();
                return instance;
            }
        }

        private MainGuiController()
        {
            loginGuiController = new LoginGuiController();
            memberGuiController = new MemberGuiController();
            projectGuiController = new ProjectGuiController();
        }


        internal void ShowFrmMain(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;

            frmMain = new FrmMain();
            frmLogin.Visible = false;
            frmMain.Text = logedUser.ToString();
            frmMain.AutoSize = true;
            frmMain.ShowDialog();

            frmLogin.Visible = true;
        }

        internal void ShowMemberPanel()
        {
            ChangePanel(memberGuiController.CreateUCMember(), frmMain.PnlMain);
            frmMain.MembersToolStripMenuItem.BackColor = Color.LightSteelBlue;
            frmMain.ProjectsToolStripMenuItem.BackColor = Color.Transparent;
        }

        internal void ShowProjectPanel()
        {
            ChangePanel(projectGuiController.CreateUCProjectView(), frmMain.PnlMain);
            frmMain.ProjectsToolStripMenuItem.BackColor = Color.LightSteelBlue;
            frmMain.MembersToolStripMenuItem.BackColor = Color.Transparent;
        }

        internal void Logout()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Log out", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK) 
            {
                logedUser = null;
                frmMain.Close();
                frmLogin.Visible = true;
            }

        }

        private void ChangePanel(UserControl uc, Panel pnl)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.AutoSize = true;
            pnl.AutoSize = true;

            uc.Width = pnl.Width;
        }


    }
}
