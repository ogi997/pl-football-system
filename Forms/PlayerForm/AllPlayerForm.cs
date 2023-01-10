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

namespace PLFootballSystem.Forms.PlayerForm
{
    public partial class AllPlayerForm : Form
    {
        ControllerPlayer cp = new ControllerPlayer();
        public List<PlayerModel> listPL = new List<PlayerModel>();
        public AllPlayerForm()
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
            btnActive.BackColor = primaryColor;
            btnAddPlayer.BackColor = primaryColor;
            btnClose.BackColor = primaryColor;
            btnDelete.BackColor = primaryColor;
            btnUpdate.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            btnActive.ForeColor = textColor;
            btnAddPlayer.ForeColor = textColor;
            btnDelete.ForeColor = textColor;
            btnUpdate.ForeColor = textColor;

            lblSearch.ForeColor = textColor;
        }

        private void GetData()
        {
            List<PlayerModel> playerModels = cp.FindAll();
            listPL = playerModels;
            List<ListViewItem> array = new List<ListViewItem>();
            foreach (PlayerModel pl in playerModels)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = pl.ID;
                lvi.Text = pl.Name;
                lvi.SubItems.Add(pl.Position.Description);
                lvi.SubItems.Add(pl.Status == 1 ? "en".Equals(ChangeLanguage.GetLanguage()) ? "Active" : "Активан" : "en".Equals(ChangeLanguage.GetLanguage()) ? "Suspended" : "Блокиран");
                array.Add(lvi);
            }

            lvAllPlayers.Items.AddRange(array.ToArray());
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            lvAllPlayers.Items.Clear();
            List<ListViewItem> a = new List<ListViewItem>();
            for (int i = 0; i < listPL.Count; i++)
            {
                if (string.IsNullOrEmpty(tbSearchBox.Text) || listPL.ElementAt(i).Name.StartsWith(tbSearchBox.Text))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = listPL.ElementAt(i).ID;
                    lvi.Text = listPL.ElementAt(i).Name;
                    lvi.SubItems.Add(listPL.ElementAt(i).Position.Description);
                    lvi.SubItems.Add(listPL.ElementAt(i).Status == 1 ? "en".Equals(ChangeLanguage.GetLanguage()) ? "Active" : "Активан" : "en".Equals(ChangeLanguage.GetLanguage()) ? "Suspended" : "Блокиран");
                    a.Add(lvi);
                }
            }
            lvAllPlayers.Items.AddRange(a.ToArray());
        }

        private void DeleteOrActivate(bool delete)
        {
            if (lvAllPlayers.SelectedItems.Count <= 0 || lvAllPlayers.SelectedItems.Count > 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please select one player." : "Изаберите једног играча.");
                return;
            }
            var ID = lvAllPlayers.SelectedItems[0].Tag;
            var result = cp.FindStatusById((int)ID);
            if (result == (delete ? 0 : 1))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? $"User already {(delete ? "blocked." : "active.")}" : $"Корисник је већ {(delete ? "блокиран." : "активан.")}");
                return;
            }

            cp.UpdateStatusByID(delete ? 0 : 1, (int)lvAllPlayers.SelectedItems[0].Tag);
            MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully updated." : "Успјешно ажурирано.");
            RefreshListView();
        }
        private void RefreshListView()
        {
            lvAllPlayers.Items.Clear();
            GetData();
            lvAllPlayers.Refresh();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteOrActivate(true);
            searchBox_TextChanged(sender, e);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            DeleteOrActivate(false);
            searchBox_TextChanged(sender, e);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteOrActivate(true);
            searchBox_TextChanged(sender, e);
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            new AddUpdatePlayer().ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (lvAllPlayers.SelectedItems.Count <= 0 || lvAllPlayers.SelectedItems.Count > 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please select only one player." : "Изаберите једног играча.");
                return;
            }

            PlayerModel player = cp.FindByPlayerId((int)lvAllPlayers.SelectedItems[0].Tag);

            if (player != null)
            {
                new AddUpdatePlayer(player).ShowDialog();

                RefreshListView();
            }


        }
    }
}
