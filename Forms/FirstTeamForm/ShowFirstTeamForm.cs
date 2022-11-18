using PLFootballSystem.Forms.PlayerForm;
using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLFootballSystem.Forms.FirstTeamForm
{
    public partial class ShowFirstTeamForm : Form
    {
        public ShowFirstTeamForm()
        {
            InitializeComponent();
        }

        public ShowFirstTeamForm(List<PlayerModel> playerHome, List<PlayerModel> playerAway)
        {
            InitializeComponent();

            pb2Player1.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + playerHome[0].ImageName);
            lbl2Player1.Text = playerHome[0].Name;
            pb2Player1.Tag = playerHome[0].ID;
            pb2Player1.BackColor = Color.Transparent;

            pbPlayer1.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + playerAway[0].ImageName);
            lblPlayer1.Text = playerAway[0].Name;
        }

        public void ShowPlayerProfile(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int playerId = (int)p.Tag;

            new ShowPlayerForm(playerId).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb2Player1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowPlayerProfile(sender, e);
        }
    }
}
