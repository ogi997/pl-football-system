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

namespace PLFootballSystem.Forms.FootballClubForm
{
    public partial class AllFootballClubForm : Form
    {
        ControllerFootballClub cfc = new ControllerFootballClub();

        public List<FootballClubModel> listFC = new List<FootballClubModel>();
        public AllFootballClubForm()
        {
            InitializeComponent();
            GetData();
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
            // Change background color of buttons
            btnClose.BackColor = primaryColor;
            btnAdd.BackColor = primaryColor;
            btnDelete.BackColor = primaryColor;
            btnUpdate.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            btnAdd.ForeColor = textColor;
            btnDelete.ForeColor = textColor;
            btnUpdate.ForeColor = textColor;

            lblSearch.ForeColor = textColor;
            // Change color of text
            //lblSearch.ForeColor = textColor;
            //.ForeColor = textColor;
            //lblRepeatPassword.ForeColor = textColor;
            //lblPassword.ForeColor = textColor;
        }
        private void GetData()
        {
            List<FootballClubModel> footballClubModels = cfc.FindAll();
            listFC = footballClubModels;
            List<ListViewItem> array = new List<ListViewItem>();
            foreach (FootballClubModel fc in footballClubModels)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag =fc.ID;
                lvi.Text = fc.Name;
                lvi.SubItems.Add(fc.City.Name);
                array.Add(lvi);
            }

            lvAllFootballClub.Items.AddRange(array.ToArray());
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            lvAllFootballClub.Items.Clear();
            List<ListViewItem> a = new List<ListViewItem>();
            for (int i = 0; i < listFC.Count; i++)
            {
                if (string.IsNullOrEmpty(tbSearchBox.Text) || listFC.ElementAt(i).Name.StartsWith(tbSearchBox.Text))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = listFC.ElementAt(i).ID;
                    lvi.Text = listFC.ElementAt(i).Name;
                    lvi.SubItems.Add(listFC.ElementAt(i).City.Name);
                    //lvi.SubItems.Add(listAM.ElementAt(i).Status == 1 ? "Active" : "Suspended");
                    a.Add(lvi);
                }
            }
            lvAllFootballClub.Items.AddRange(a.ToArray());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvAllFootballClub.SelectedItems.Count > 1 || lvAllFootballClub.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select one item");
                return;
            }

            int footballClubId = (int)lvAllFootballClub.SelectedItems[0].Tag;
            Console.WriteLine(footballClubId);
            cfc.DeleteByClubId(footballClubId);

            lvAllFootballClub.Items.Clear();
            GetData();
            lvAllFootballClub.Refresh();

            searchBox_TextChanged(sender, e);
        }

        private void RefreshListView()
        {
            lvAllFootballClub.Items.Clear();
            GetData();
            lvAllFootballClub.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddNewFootballClubForm().ShowDialog();

            RefreshListView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lvAllFootballClub.SelectedItems.Count <= 0 || lvAllFootballClub.SelectedItems.Count > 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please select only one football club." : "Означите само један фудбалски клуб.");
                return;
            }

            FootballClubModel fc = cfc.FindByClubId((int)lvAllFootballClub.SelectedItems[0].Tag);
            fc.ID = (int)lvAllFootballClub.SelectedItems[0].Tag;
            if (fc != null)
            {
                new AddNewFootballClubForm(fc).ShowDialog();

                RefreshListView();
            }
        }
    }
}
