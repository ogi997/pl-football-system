using PLFootballSystem.Controller;
using PLFootballSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLFootballSystem.Forms.AccountForm
{
    public partial class AddNewAccountForm : Form
    {
        ControllerAccount ca = new ControllerAccount();
        ControllerRole cr = new ControllerRole();
        public AddNewAccountForm()
        {
            InitializeComponent();

            foreach(var p in cr.FindAll())
            {
                cbRole.Items.Add(p.Name);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainForm = Application.OpenForms.OfType<AdminForm>().Single();
            mainForm.SetLblPath("Home");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string repeatedPassword = tbRepeatPassword.Text;
            string role = cbRole.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatedPassword) || string.IsNullOrEmpty(role)) {
                MessageBox.Show("All input are requare.");
                return;
            }

            if (!password.Equals(repeatedPassword))
            {
                MessageBox.Show("Passwords are not same");
                return;
            }
            AccountModel account = ca.FindByUsername(username);

            if (account != null)
            {
                MessageBox.Show($"Username {username} already exist.");
                return;
            }
            int idRole;
            if ("Korisnik".Equals(role))
            {
                idRole = 2;
            } else
            {
                idRole = 1;
            }

            AccountModel accoutModel = new AccountModel()
            {
                Username = username,
                Password = password,
                Role = new RoleModel { ID = idRole, Name = role},
                Status = 1
            };


            ca.Insert(accoutModel);

            //Console.WriteLine(username + " " + password + " " + repeatedPassword + " " + role);
        }
    }
}
