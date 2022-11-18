using PLFootballSystem.Controller;
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

namespace PLFootballSystem.Forms.PlayerForm
{
    public partial class ShowPlayerForm : Form
    {
        ControllerPlayer cp = new ControllerPlayer();
        public ShowPlayerForm()
        {
            InitializeComponent();
        }

        public ShowPlayerForm(int playerId)
        {
            InitializeComponent();
            GetData(playerId);
        }

        private void GetData(int playerId)
        {
            PlayerModel pm = cp.FindByPlayerId(playerId);

            lblCountryName.Text = pm.Country.Name;
            lblPlayerDate.Text = pm.Date.ToString();
            lblPlayerNumber.Text = pm.Number.ToString();
            lblPlayerName.Text = pm.Name;
            lblPlayerPosition.Text = pm.Position.Description;


            pbPlayerFace.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + pm.ImageName);
            pbCountryFlag.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperCountry.FOLDER + Path.DirectorySeparatorChar + pm.Country.ImageName);

        }
    }
}
