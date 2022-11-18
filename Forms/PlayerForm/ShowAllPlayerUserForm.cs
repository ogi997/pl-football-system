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

namespace PLFootballSystem.Forms.PlayerForm
{
    public partial class ShowAllPlayerUserForm : Form
    {
        ControllerPlayer cp = new ControllerPlayer();
        public List<PlayerModel> listPM = new List<PlayerModel>();
        public ShowAllPlayerUserForm()
        {
            InitializeComponent();
        }

        public ShowAllPlayerUserForm(int footballClubId)
        {
            InitializeComponent();
            Console.WriteLine(footballClubId);
            GetData(footballClubId);
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
                lvi.SubItems.Add(pm.Status == 1 ? "Active" : "Suspended");
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
                MessageBox.Show("Select only one player to show");
                return;
            }

            int playerId = (int)lvAllClubPlayer.SelectedItems[0].Tag;

            new ShowPlayerForm(playerId).ShowDialog();
        }
    }
}
