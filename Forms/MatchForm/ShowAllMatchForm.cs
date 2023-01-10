using PLFootballSystem.Controller;
using PLFootballSystem.Forms.FirstTeamForm;
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

namespace PLFootballSystem.Forms.MatchForm
{
    public partial class ShowAllMatchForm : Form
    {
        ControllerMatch cm = new ControllerMatch();
        ControllerFirstTeam cft = new ControllerFirstTeam();
        public List<MatchModel> listMM = new List<MatchModel>();

        int homeFcId;
        int awayFCId;

        public ShowAllMatchForm()
        {
            InitializeComponent();
            SetTheme();
        }

        public ShowAllMatchForm(int seasonId)
        {
            InitializeComponent();
            GetData(seasonId);
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
            btnOpenFirstTeam.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            btnOpenFirstTeam.ForeColor = textColor;

            
            // Change color of text
            //lblSearch.ForeColor = textColor;
            //.ForeColor = textColor;
            //lblRepeatPassword.ForeColor = textColor;
            //lblPassword.ForeColor = textColor;
        }

        private void GetData(int seasonId)
        {
            List<MatchModel> matchModels = cm.FindMatchBySeasonId(seasonId);
            listMM = matchModels;
            List<ListViewItem> array = new List<ListViewItem>();
            foreach (MatchModel mm in matchModels)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = mm.ID;
                lvi.Text = mm.FCHome.Name;
                lvi.SubItems.Add(mm.GoalsScoredHome.ToString());
                lvi.SubItems.Add(mm.GoalsReceivedAway.ToString());
                lvi.SubItems.Add(mm.FCAway.Name);
                array.Add(lvi);
            }

            lvAllMatch.Items.AddRange(array.ToArray());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFirstTeam_Click(object sender, EventArgs e)
        {
            if (lvAllMatch.SelectedItems.Count > 1 || lvAllMatch.SelectedItems.Count < 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Select only one match." : "Изаберите једну утакмицу.");
                return;
            }

            int matchId = (int)lvAllMatch.SelectedItems[0].Tag;
            Console.WriteLine(matchId);

            MatchModel match = cm.FindMatchById(matchId);
            List<PlayerModel> playerHome = cft.FindMatchByIdAndClub(matchId, match.FCHome.ID);
            FormationModel formationHome = cft.FindFormation(matchId, match.FCHome.ID);

            List<PlayerModel> playerAway = cft.FindMatchByIdAndClub(matchId, match.FCAway.ID);
            FormationModel formationAway = cft.FindFormation(matchId, match.FCAway.ID);

            new ShowFirstTeamForm(playerHome, playerAway, formationHome, formationAway).ShowDialog();
        }
    }
}
