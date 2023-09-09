using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class LoginGuiController
    {
        private FrmLogin frmLogin;

        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null) instance = new LoginGuiController();
                return instance;
            }
        }

        public void LoginUser(FrmLogin frmLogin)
        {
            Communication.Instance.Connect();
            this.frmLogin = frmLogin;
            
            string username = frmLogin.TxtUsername.Text;
            string password = frmLogin.TxtPassword.Text;

            User user = Communication.Instance.LoginUser(username, password);
            if (user != null && user.Username != null)
            {
                MessageBox.Show("Success!");
                MainGuiController.Instance.logedUser = user;
                MainGuiController.Instance.ShowFrmMain(frmLogin);
            }
            else
            {
                MessageBox.Show("Wrong credentials!");
            }


        }


    }
}
