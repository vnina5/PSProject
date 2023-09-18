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

            List<User> users = Communication.Instance.LoginUser(username, password);
            if (users.Count == 1 && users.First<User>().Username != null)
            {
                MessageBox.Show("Success!");
                MainGuiController.Instance.logedUser = users.First<User>();
                MainGuiController.Instance.ShowFrmMain(frmLogin);
            }
            else
            {
                MessageBox.Show("Wrong credentials!");
            }


        }


    }
}
