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
    public partial class AllAccountForm : Form
    {
        public ControllerAccount ca = new ControllerAccount();
        public List<AccountModel> listAM = new List<AccountModel>();
        public AllAccountForm()
        {
            InitializeComponent();
            GetAllData();
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
            btnAddAccount.BackColor = primaryColor;
            btnDelete.BackColor = primaryColor;
            btnUpdate.BackColor = primaryColor;
            btnActive.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            btnAddAccount.ForeColor = textColor;
            btnDelete.ForeColor = textColor;
            btnUpdate.ForeColor = textColor;
            btnActive.ForeColor = textColor;
            lblSearch.ForeColor = textColor;
        }

        private void GetAllData()
        {
            List<AccountModel> accounts = ca.FindAll();
            listAM = accounts;
            List<ListViewItem> array = new List<ListViewItem>();
            foreach(AccountModel am in accounts)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = am.ID;
                lvi.Text = am.Username;
                lvi.SubItems.Add(am.Role.Name);
                lvi.SubItems.Add(am.Status == 1 ? "en".Equals(ChangeLanguage.GetLanguage()) ? "Active" : "Активан" : "en".Equals(ChangeLanguage.GetLanguage()) ? "Suspended" : "Суспендован");
                array.Add(lvi);
            }

            lvAllAccounts.Items.AddRange(array.ToArray());

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            lvAllAccounts.Items.Clear();
            List<ListViewItem> a = new List<ListViewItem>(); 
            for (int i = 0; i < listAM.Count; i++)
            {
                if (string.IsNullOrEmpty(searchBox.Text) || listAM.ElementAt(i).Username.StartsWith(searchBox.Text)) {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = listAM.ElementAt(i).ID;
                    lvi.Text = listAM.ElementAt(i).Username;
                    lvi.SubItems.Add(listAM.ElementAt(i).Role.Name);
                    lvi.SubItems.Add(listAM.ElementAt(i).Status == 1 ? "en".Equals(ChangeLanguage.GetLanguage()) ? "Active" : "Активан" : "en".Equals(ChangeLanguage.GetLanguage()) ? "Suspended" : "Суспендован");
                    a.Add(lvi);
                }
            }
            lvAllAccounts.Items.AddRange(a.ToArray());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            var mainForm = Application.OpenForms.OfType<AdminForm>().Single();
            mainForm.SetLblPath("en".Equals(ChangeLanguage.GetLanguage()) ? "Home" : "Почетна");
        }
        private void DeleteOrActivate(bool delete)
        {
            if (lvAllAccounts.SelectedItems.Count <= 0 || lvAllAccounts.SelectedItems.Count > 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please select one user." : "Означите само једног корисника.");
                return;
            }
            var ID = lvAllAccounts.SelectedItems[0].Tag;
            var result = ca.FindStatusById((int)ID);
            if (result == (delete ? 0 : 1))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? $"User already {(delete ? "block." : "active.")}" : $"Корисник је већ {(delete ? "блокиран." : "активан.")}");
                return;
            }

            ca.UpdateStatusById(delete ? 0 : 1, (int)lvAllAccounts.SelectedItems[0].Tag);
            RefreshListView();
            MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully updated." : "Успјешно ажурирано.");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteOrActivate(true);
            searchBox_TextChanged(sender, e);
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            DeleteOrActivate(false);
            searchBox_TextChanged(sender, e);
        }

        private void RefreshListView()
        {
            lvAllAccounts.Items.Clear();
            GetAllData();
            lvAllAccounts.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvAllAccounts.SelectedItems.Count <= 0 || lvAllAccounts.SelectedItems.Count > 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please select one user." : "Селектујте једног корисника.");
                return;
            }
            AccountModel ac = ca.FindAccountById((int)lvAllAccounts.SelectedItems[0].Tag);

            if (ac != null )
            {
                if (ac.Role.ID == 1)
                {
                    ca.UpdateRoleById(2, ac.ID);
                } else
                {
                    ca.UpdateRoleById(1, ac.ID);
                }

                RefreshListView();
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            new AddUpdateAccountForm().ShowDialog();

            RefreshListView();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (lvAllAccounts.SelectedItems.Count <= 0 || lvAllAccounts.SelectedItems.Count > 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please select one user." : "Селектујте једног корисника.");
                return;
            }
            AccountModel ac = ca.FindAccountById((int)lvAllAccounts.SelectedItems[0].Tag);
           
            if (ac != null)
            {
                new AddUpdateAccountForm(ac).ShowDialog();

                RefreshListView();
            }

        }
    }
}
