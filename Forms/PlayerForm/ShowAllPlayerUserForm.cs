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
    public partial class ShowAllPlayerUserForm : Form
    {
        ControllerPlayer cp = new ControllerPlayer();
        public List<PlayerModel> listPM = new List<PlayerModel>();
        public ShowAllPlayerUserForm()
        {
            InitializeComponent();
            SetTheme();
        }

        public ShowAllPlayerUserForm(int footballClubId)
        {
            InitializeComponent();
            SetTheme();
            GetData(footballClubId);
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
            btnOpenPlayer.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            btnOpenPlayer.ForeColor = textColor;

            lblAllClubPlayer.ForeColor = textColor;
        }

        private void GetData(int footballClubId)
        {
            List<PlayerModel> playerModels = cp.FindByClubId(footballClubId);
            listPM = playerModels;
            List<ListViewItem> array = new List<ListViewItem>();
            foreach (PlayerModel pm in playerModels)
            {
                Console.WriteLine(pm);
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = pm.ID;
                lvi.Text = pm.Name;
                lvi.SubItems.Add(pm.Position.Description);
                lvi.SubItems.Add(pm.Status == 1 ? "en".Equals(ChangeLanguage.GetLanguage()) ? "Active" : "Активан" : "en".Equals(ChangeLanguage.GetLanguage()) ? "Suspended" : "Блокиран");
                array.Add(lvi);
            }

            lvAllClubPlayer.Items.AddRange(array.ToArray());

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenPlayer_Click(object sender, EventArgs e)
        {
            if (lvAllClubPlayer.SelectedItems.Count > 1 || lvAllClubPlayer.SelectedItems.Count < 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Select only one player to show." : "Означите једног играча.");
                return;
            }

            int playerId = (int)lvAllClubPlayer.SelectedItems[0].Tag;

            new ShowPlayerForm(playerId).ShowDialog();
        }
    }
}
