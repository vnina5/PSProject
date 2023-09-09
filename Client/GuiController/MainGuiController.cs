using Common;
using System;
using System.Collections.Generic;
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

        internal void ShowFrmLogin(FrmLogin frmLogin)
        {
            //Communication.Instance.Connect();

            //frmLogin = new FrmLogin();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(frmLogin);
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
            frmMain.ChangePanel(memberGuiController.CreateUCMember());
        }

        internal void ShowProjectPanel()
        {
            frmMain.ChangePanel(projectGuiController.CreateUCProjectView());
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
    }
}
