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
    public partial class AddNewMatch : Form
    {
        ControllerMatch cm = new ControllerMatch();

        ControllerFootballClub cfc = new ControllerFootballClub();
        ControllerSeason cs = new ControllerSeason();
        ControllerFormation cf = new ControllerFormation();

        public AddNewMatch()
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
            btnAddFirstTeam.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnAddFirstTeam.ForeColor = textColor;

            lblAwayFC.ForeColor = textColor;
            lblDate.ForeColor = textColor;
            lblGoalsAway.ForeColor = textColor;
            lblGoalsHome.ForeColor = textColor;
            lblHomeFC.ForeColor = textColor;
            lblSeason.ForeColor = textColor;
            // Change color of text
            //lblSearch.ForeColor = textColor;
            //.ForeColor = textColor;
            //lblRepeatPassword.ForeColor = textColor;
            //lblPassword.ForeColor = textColor;
        }

        private void GetData()
        {
            List<FootballClubModel> footballClubModels = cfc.FindAll();
            cbHomeFC.DisplayMember = "Name";
            cbHomeFC.ValueMember = "ID";
            foreach (var c in footballClubModels)
            {
                cbHomeFC.Items.Add(new { ID = c.ID, Name = c.Name });
            }

            cbHomeFC.SelectedIndex = 0;

            //List<FootballClubModel> footballClubModels = cfc.FindAll();
            cbAwayFC.DisplayMember = "Name";
            cbAwayFC.ValueMember = "ID";
            foreach (var c in footballClubModels)
            {
                cbAwayFC.Items.Add(new { ID = c.ID, Name = c.Name });
            }

            cbAwayFC.SelectedIndex = 0;

            List<SeasonsModel> seasonsModels = cs.FindAll();
            cbSeason.DisplayMember = "Name";
            cbSeason.ValueMember = "ID";
            foreach (var c in seasonsModels)
            {
                cbSeason.Items.Add(new { ID = c.ID, Name = c.year });
            }

            cbSeason.SelectedIndex = 0;

            List<FormationModel> formations = cf.FindAll();
            cbHomeFormation.DisplayMember = "Name";
            cbHomeFormation.ValueMember = "ID";

            cbAwayFormation.DisplayMember = "Name";
            cbAwayFormation.ValueMember = "ID";
            foreach(var c in formations)
            {
                cbHomeFormation.Items.Add(new { ID = c.ID, Name = c.Description });
                cbAwayFormation.Items.Add(new { ID = c.ID, Name = c.Description });
            }


        }

        private void btnAddFirstTeam_Click(object sender, EventArgs e)
        {
           // int homeFC = (cbHomeFC.SelectedIndex as dynamic).ID;
          //  int awayFC = (cbAwayFC.SelectedIndex as dynamic).ID;
          //  int seasonID = (cbSeason.SelectedIndex as dynamic).ID;

            DateTime date = dtDate.Value;

            decimal goalsHome = numGoalsHome.Value;
            decimal goalsAway = numGoalsAway.Value;

            if (cbHomeFormation.SelectedIndex < 0 || cbAwayFormation.SelectedIndex < 0)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please select all formation." : "Изаберите формације.");
                return;
            }

            MatchModel match = new MatchModel
            {
                GoalsScoredHome = (int)goalsHome,
                GoalsReceivedAway = (int)goalsAway,
                Season = new SeasonsModel { ID = (cbSeason.SelectedItem as dynamic).ID },
                Date = date,
                FCHome = new FootballClubModel { ID = (cbHomeFC.SelectedItem as dynamic).ID },
                FCAway = new FootballClubModel { ID = (cbAwayFC.SelectedItem as dynamic).ID }
            };
            FormationModel homeFormation = new FormationModel
            {
                ID = (cbHomeFormation.SelectedItem as dynamic).ID,
                Description = (cbHomeFormation.SelectedItem as dynamic).Name
            };

            FormationModel awayFormation = new FormationModel
            {
                ID = (cbAwayFormation.SelectedItem as dynamic).ID,
                Description = (cbAwayFormation.SelectedItem as dynamic).Name
            };

            new SelectFirstTeam(match, homeFormation, awayFormation).ShowDialog();

        }
    }
}
