using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            //if (frmLogin.TxtUsername.Text == null || frmLogin.TxtUsername.Text == "")
            //{
            //    frmLogin.TxtUsername.BackColor = Color.Salmon;
            //}
            //if (frmLogin.TxtPassword.Text == null || frmLogin.TxtPassword.Text == "")
            //{
            //    frmLogin.TxtPassword.BackColor = Color.Salmon;
            //}

            string username = frmLogin.TxtUsername.Text.Trim();
            string password = frmLogin.TxtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                if (string.IsNullOrEmpty(username)) 
                {
                    frmLogin.TxtUsername.BackColor = Color.Salmon;
                }
                if (string.IsNullOrEmpty(password))
                {
                    frmLogin.TxtPassword.BackColor = Color.Salmon;
                }
                MessageBox.Show("Some field is empthy!");
                return;
            }

            //if (!username.Contains('@'))
            //{
            //    MessageBox.Show("Format of username is not correct.");
            //    return;
            //}

            List<User> users = Communication.Instance.LoginUser(username, password);
            if (users.Count == 1 && users.First<User>().Username != null)
            {
                MessageBox.Show("Successfully login!");
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
