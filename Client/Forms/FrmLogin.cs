using Client.GuiController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "pera";
            txtPassword.Text = "pera";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginGuiController.Instance.LoginUser(this);
        }
    }
}
