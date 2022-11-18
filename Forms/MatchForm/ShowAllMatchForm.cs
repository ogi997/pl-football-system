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
        }

        public ShowAllMatchForm(int seasonId)
        {
            InitializeComponent();
            GetData(seasonId);
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
                MessageBox.Show("Select only one match");
                return;
            }

            int matchId = (int)lvAllMatch.SelectedItems[0].Tag;
            Console.WriteLine(matchId);

            MatchModel match = cm.FindMatchById(matchId);
            List<PlayerModel> playerHome = cft.FindMatchByIdAndClub(matchId, match.FCHome.ID);
            List<PlayerModel> playerAway = cft.FindMatchByIdAndClub(matchId, match.FCAway.ID);

            new ShowFirstTeamForm(playerHome, playerAway).ShowDialog();
        }
    }
}
