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

namespace PLFootballSystem.Forms.FirstTeamForm
{
    public partial class AddNewFirstTeamForm : Form
    {
        HashSet<int> firstTeamHomeIdsPlayer = new HashSet<int>();
        HashSet<int> firstTeamAwayIdsPlayer = new HashSet<int>();

        MatchModel matchModel = null;
        ControllerPlayer cp = new ControllerPlayer();
        ControllerMatch cm = new ControllerMatch();
        ControllerFirstTeam cft = new ControllerFirstTeam();
        public AddNewFirstTeamForm()
        {
            InitializeComponent();
            GetData();
        }

        public AddNewFirstTeamForm(MatchModel match)
        {
            InitializeComponent();
            matchModel = match;
            GetData();
        }
        private void GetData()
        {
            List<PlayerModel> playerModelsHome = cp.FindByClubId(matchModel.FCHome.ID);
            List<PlayerModel> playerModelsAway = cp.FindByClubId(matchModel.FCAway.ID);

            AddToListView(lvAllPlayersHome, playerModelsHome);
            AddToListView(lvAllPlayersAway, playerModelsAway);
        }

        private void AddToListView(ListView listView, List<PlayerModel> players)
        {
            List<ListViewItem> array = new List<ListViewItem>();
            foreach (PlayerModel pl in players)
            {
                if (pl.Status == 0) continue;
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = pl.ID;
                //Console.WriteLine(pl.Name);
                lvi.Text = pl.Name;
                lvi.SubItems.Add(pl.Position.Description);
                array.Add(lvi);
            }

            listView.Items.AddRange(array.ToArray());
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddFirstTeam(lvAllPlayersHome, lvFirstTeamHome, firstTeamHomeIdsPlayer, false);

        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            AddFirstTeam(lvFirstTeamHome, lvAllPlayersHome, firstTeamHomeIdsPlayer, true);
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFirstTeam_Click(object sender, EventArgs e)
        {
            AddFirstTeam(lvAllPlayersAway, lvFirstTeamAway, firstTeamAwayIdsPlayer, false);
        }

        private void btnRemoveFirstTeam_Click(object sender, EventArgs e)
        {
            AddFirstTeam(lvFirstTeamAway, lvAllPlayersAway, firstTeamAwayIdsPlayer, true);
        }

        private void AddFirstTeam(ListView allPlayers, ListView firstTeamPlayers, HashSet<int> saveIds, bool removePlayer)
        {
            if (allPlayers.SelectedItems.Count > 1 || allPlayers.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select one player");
                return;
            }

            int playerId = (int)allPlayers.SelectedItems[0].Tag;
            PlayerModel playerModel = cp.FindByPlayerId(playerId);

            if (removePlayer)
                saveIds.Remove(playerId);
            else
                saveIds.Add(playerId);

            List<ListViewItem> arrayPlayerFirstTeam = new List<ListViewItem>();

            ListViewItem lvi = new ListViewItem();
            lvi.Tag = playerModel.ID;
            lvi.Text = playerModel.Name;
            lvi.SubItems.Add(playerModel.Position.Description);
            arrayPlayerFirstTeam.Add(lvi);
            firstTeamPlayers.Items.AddRange(arrayPlayerFirstTeam.ToArray());

            allPlayers.SelectedItems[0].Remove();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            //Add match
            int? matchId = cm.InsertMatch(matchModel);

            //Add home first team
            Console.WriteLine("Home ids: ");
            foreach(var playerId in firstTeamHomeIdsPlayer)
            {
                FirstTeamModel firstTeamHomeModel = new FirstTeamModel
                {
                    FC = new FootballClubModel { ID = matchModel.FCHome.ID },
                    Match = new MatchModel { ID = (int)matchId },
                    Player = new PlayerModel { ID = playerId }
                };
                Console.WriteLine(playerId);
                //Add to database
                cft.InsertFirstTeam(firstTeamHomeModel);
            }

            Console.WriteLine("============");
            Console.WriteLine("Away ids: ");
            foreach (var playerId in firstTeamAwayIdsPlayer)
            {
                FirstTeamModel firstTeamAwayModel = new FirstTeamModel
                {
                    FC = new FootballClubModel { ID = matchModel.FCAway.ID },
                    Match = new MatchModel { ID = (int)matchId },
                    Player = new PlayerModel { ID = playerId }
                };
                Console.WriteLine(playerId);

                //Add to databse
                cft.InsertFirstTeam(firstTeamAwayModel);
            }
        }
    }
}
