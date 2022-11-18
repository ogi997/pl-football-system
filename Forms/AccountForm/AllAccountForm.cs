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
    public partial class AllAccountForm : Form
    {
        public ControllerAccount ca = new ControllerAccount();
        public List<AccountModel> listAM = new List<AccountModel>();
        public AllAccountForm()
        {
            InitializeComponent();
            GetAllData();
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
                lvi.SubItems.Add(am.Status == 1 ? "Active" : "Suspended");
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
                    lvi.SubItems.Add(listAM.ElementAt(i).Status == 1 ? "Active" : "Suspended");
                    a.Add(lvi);
                }
            }
            lvAllAccounts.Items.AddRange(a.ToArray());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            var mainForm = Application.OpenForms.OfType<AdminForm>().Single();
            mainForm.SetLblPath("Home");
        }
        private void DeleteOrActivate(bool delete)
        {
            if (lvAllAccounts.SelectedItems.Count <= 0 || lvAllAccounts.SelectedItems.Count > 1)
            {
                MessageBox.Show("Please select one user.");
                return;
            }
            var ID = lvAllAccounts.SelectedItems[0].Tag;
            var result = ca.FindStatusById((int)ID);
            if (result == (delete ? 0 : 1))
            {
                MessageBox.Show($"User already {(delete ? "deleted." : "active.")}");
                return;
            }

            ca.UpdateStatusById(delete ? 0 : 1, (int)lvAllAccounts.SelectedItems[0].Tag);
            RefreshListView();
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
                MessageBox.Show("Please select one user.");
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
    }
}
