using PLFootballSystem.Controller;
using PLFootballSystem.Model;
using PLFootballSystem.Util;
using PLFootballSystem.Util.Theme;
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
    public partial class AddUpdateAccountForm : Form
    {
        ControllerAccount ca = new ControllerAccount();
        ControllerRole cr = new ControllerRole();

        public AccountModel account = new AccountModel();

        bool update;
        public AddUpdateAccountForm()
        {
            InitializeComponent();

            foreach(var p in cr.FindAll())
            {
                cbRole.Items.Add(p.Name);
            }

            update = false;
            SetTheme();
        }

        public AddUpdateAccountForm(AccountModel ac)
        {
            InitializeComponent();

            foreach (var p in cr.FindAll())
            {
                cbRole.Items.Add(p.Name);
            }

            account = ac;

            tbUsername.Text = ac.Username;
            cbRole.SelectedIndex = cbRole.FindStringExact(ac.Role.Name);

            update = true;
            SetTheme();
        }

        private void SetTheme()
        {
            if ("light".Equals(ChangeTheme.GetTheme()))
            {
                ChangeThemee(Theme.GetLight()[ThemeColor.Primary], Theme.GetLight()[ThemeColor.Secondary], Theme.GetLight()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetLight()[ThemeColor.Text]);
            }
            else if ("dark".Equals(ChangeTheme.GetTheme()))
            {
                ChangeThemee(Theme.GetDark()[ThemeColor.Primary], Theme.GetDark()[ThemeColor.Secondary], Theme.GetDark()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetDark()[ThemeColor.Text]);
            }
            else if ("nature".Equals(ChangeTheme.GetTheme()))
            {
                ChangeThemee(Theme.GetNature()[ThemeColor.Primary], Theme.GetNature()[ThemeColor.Secondary], Theme.GetNature()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetNature()[ThemeColor.Text]);
            }
        }

        private void ChangeThemee(Color primaryColor, Color secondaryColor, Color tertiaryColor)
        {
            btnClose.BackColor = primaryColor;
            btnSave.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            btnSave.ForeColor = textColor;
            lblUsername.ForeColor = textColor;
            lblRole.ForeColor = textColor;
            lblRepeatPassword.ForeColor = textColor;
            lblPassword.ForeColor = textColor;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string repeatedPassword = tbRepeatPassword.Text;
            string role = cbRole.Text;

            
            if (!update)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatedPassword) || string.IsNullOrEmpty(role))
                {
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
                }
                else
                {
                    idRole = 1;
                }

                AccountModel accoutModel = new AccountModel()
                {
                    Username = username,
                    Password = password,
                    Role = new RoleModel { ID = idRole, Name = role },
                    Status = 1
                };


                ca.Insert(accoutModel);

                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully added." : "Успјешно додано.");

                return;
            }

            //update
            string usernameUpdate = tbUsername.Text;
            string passwordUpdate = tbPassword.Text;
            string repeatedPasswordUpdate = tbRepeatPassword.Text;
            string roleUpdate = cbRole.Text;

            if (string.IsNullOrEmpty(usernameUpdate) || string.IsNullOrEmpty(passwordUpdate) || string.IsNullOrEmpty(repeatedPasswordUpdate) || string.IsNullOrEmpty(roleUpdate))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "All input are requare." : "Морате попунити сва поља.");
                return;
            }

            if (!passwordUpdate.Equals(repeatedPasswordUpdate))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Passwords are not same." : "Лозинке нису исте.");
                return;
            }

            int idRoleUpdate;
            if ("Korisnik".Equals(role))
            {
                idRoleUpdate = 2;
            }
            else
            {
                idRoleUpdate = 1;
            }

            AccountModel accoutModelUpdate = new AccountModel()
            {
                ID = account.ID,
                Username = usernameUpdate,
                Password = passwordUpdate,
                Role = new RoleModel { ID = idRoleUpdate, Name = role },
                Status = 1
            };

            ca.UpdateById(accoutModelUpdate);
            MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully updated." : "Успјешно ажурирано.");

        }
    }
}
