using PLFootballSystem.Controller;
using PLFootballSystem.Forms.FirstTeamForm;
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

namespace PLFootballSystem.Forms.MatchForm
{
    public partial class AddNewMatch : Form
    {
        ControllerMatch cm = new ControllerMatch();

        ControllerFootballClub cfc = new ControllerFootballClub();
        ControllerSeason cs = new ControllerSeason();

        public AddNewMatch()
        {
            InitializeComponent();
            GetData();
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


        }

        private void btnAddFirstTeam_Click(object sender, EventArgs e)
        {
           // int homeFC = (cbHomeFC.SelectedIndex as dynamic).ID;
          //  int awayFC = (cbAwayFC.SelectedIndex as dynamic).ID;
          //  int seasonID = (cbSeason.SelectedIndex as dynamic).ID;

            DateTime date = dtDate.Value;

            decimal goalsHome = numGoalsHome.Value;
            decimal goalsAway = numGoalsAway.Value;

            MatchModel match = new MatchModel
            {
                GoalsScoredHome = (int)goalsHome,
                GoalsReceivedAway = (int)goalsAway,
                Season = new SeasonsModel { ID = (cbSeason.SelectedItem as dynamic).ID },
                Date = date,
                FCHome = new FootballClubModel { ID = (cbHomeFC.SelectedItem as dynamic).ID },
                FCAway = new FootballClubModel { ID = (cbAwayFC.SelectedItem as dynamic).ID }
            };

            new AddNewFirstTeamForm(match).ShowDialog();

           // int? id = cm.InsertMatch(match);
           // Console.WriteLine("ID:" + id);
        }
    }
}
