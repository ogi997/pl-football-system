using PLFootballSystem.Controller;
using PLFootballSystem.Forms.FirstTeamForm;
using PLFootballSystem.Model;
using PLFootballSystem.Util;
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
    public partial class SelectPlayerForFirstTeam : Form
    {
        int clubId;
        bool isHome;

        ControllerPlayer cp = new ControllerPlayer();
        int pictureBoxTag;
        public SelectPlayerForFirstTeam()
        {
            InitializeComponent();
        }
        public SelectPlayerForFirstTeam(int id, int tag, bool home)
        {
            InitializeComponent();
            clubId = id;
            isHome = home;
            pictureBoxTag = tag;
            GetData();
        }
        private void GetData()
        {
            List<PlayerModel> playerModelsHome = cp.FindByClubId(clubId);

            List<ListViewItem> array = new List<ListViewItem>();
            foreach (PlayerModel pl in playerModelsHome)
            {
                if (pl.Status == 0) continue;
                if (SelectFirstTeam.homePlayers.ContainsValue(pl.ID)) continue;
                if (SelectFirstTeam.awayPlayers.ContainsValue(pl.ID)) continue;

                ListViewItem lvi = new ListViewItem();
                lvi.Tag = pl.ID;
                lvi.Text = pl.Name;
                lvi.SubItems.Add(pl.Position.Description);
                array.Add(lvi);
            }

            lvAllPlayers.Items.AddRange(array.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lvAllPlayers.SelectedItems.Count <= 0 || lvAllPlayers.SelectedItems.Count > 1)
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Select only one player." : "Изаберите једног играча.");
                return;
            }

            int playerId = (int)lvAllPlayers.SelectedItems[0].Tag;

            if(isHome)
            {
                if (SelectFirstTeam.homePlayers.ContainsKey(pictureBoxTag))
                    SelectFirstTeam.homePlayers.Remove(pictureBoxTag);

                SelectFirstTeam.homePlayers.Add(pictureBoxTag, playerId);
            } else
            {
                if (SelectFirstTeam.awayPlayers.ContainsKey(pictureBoxTag))
                    SelectFirstTeam.awayPlayers.Remove(pictureBoxTag);

                SelectFirstTeam.awayPlayers.Add(pictureBoxTag, playerId);
            }

            this.Close();
        }
    }
}
