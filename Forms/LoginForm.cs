using PLFootballSystem.Controller;
using PLFootballSystem.Forms;
using PLFootballSystem.Model;
using PLFootballSystem.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLFootballSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //postavi default-ni jezik
            ChangeLanguage.UpdateConfig("language", "en");
        }

        private bool isClicked = false;
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if(isClicked)
            {
                btnShowPassword.BackgroundImage = Properties.Resources.eye;
                txtPassword.PasswordChar = '*';
                isClicked = !isClicked;
            } else
            {
                btnShowPassword.BackgroundImage = Properties.Resources.hidden;
                txtPassword.PasswordChar = '\0';
                isClicked = !isClicked;
            }

        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            ControllerAccount ca = new ControllerAccount();

            AccountModel am = ca.FindUserByUsernameAndPassword(username, password);

            if (am != null)
            {
                if (am.Status == 1)
                {
                    if ("Admin".Equals(am.Role.Name))
                    {
                        this.Hide();
                        string theme = ca.SelectTheme(am.ID);
                        ChangeTheme.UpdateConfig("theme", theme);
                        new AdminForm(am).Show();
                    }
                    if ("Korisnik".Equals(am.Role.Name))
                    {
                        this.Hide();
                        string theme = ca.SelectTheme(am.ID);
                        ChangeTheme.UpdateConfig("theme", theme);
                        new UserForm(am).Show();
                    }
                } else
                {
                    MessageBox.Show("Your account are suspended.", "Suspended account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Your username or password are incorrect.", "Bad username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
