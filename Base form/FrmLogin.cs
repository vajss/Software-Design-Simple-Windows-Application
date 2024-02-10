using ApplicationLogic;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            tbPassword.Text = "TestPass";
            tbUsername.Text = "Vajss"; // delete this test user
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Controller userController = Controller.Instance;

            if (btnLogin.Enabled) {
                User user = new User
                {
                    Username = tbUsername.Text,
                    Password = tbPassword.Text,
                };

                // TODO add validation and red stuff to indicate wrong, also exeption handling if null is provided
                User currentUser = userController.LoginUser(user);
                if (currentUser != null)
                {
                    this.DialogResult = DialogResult.OK; // This closes form and return assigned value to whatewer is listening for showDialog 
                }
            }
        }
    }
}
