using ApplicationLogic;
using Base_form.ServerCommunication;
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

            if (btnLogin.Enabled) {

                User user = new User
                {
                    Username = tbUsername.Text,
                    Password = tbPassword.Text,
                };

                // TODO add validation and red stuff to indicate wrong, also exeption handling if null is provided
                if (user.Username == "") {
                    tbUsername.BackColor = Color.Salmon;
                    return;
                }

                if (user.Password == "") {
                    tbPassword.BackColor = Color.Salmon;
                    return;
                }

                try {
                    Communication.Instance.Connect();
                    // User currentUser = userController.LoginUser(user);
                    User currentUser = Communication.Instance.Login(user);
                    
                    if (currentUser != null)
                    {
                        Controller.Instance.CurrentUser = currentUser;
                        this.DialogResult = DialogResult.OK; // This closes form and return assigned value to whatewer is listening for showDialog 
                    }
                    else
                    {
                        lblUserNotFound.Visible = true;
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error happened while tryingh to log in: " +  error.Message);
                }

            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (tbUsername.BackColor != Color.White)
            {
                tbUsername.BackColor = Color.White;
                lblUserNotFound.Visible = false;
            }
            if (lblUserNotFound.Visible)
            {
                lblUserNotFound.Visible = false;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.BackColor != Color.White)
            {
                tbPassword.BackColor = Color.White;
            }
            if(lblUserNotFound.Visible)
            {
                lblUserNotFound.Visible = false;
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // idk, do something
        }
    }
}
