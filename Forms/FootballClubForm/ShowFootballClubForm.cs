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

namespace PLFootballSystem.Forms.FootballClubForm
{
    public partial class ShowFootballClubForm : Form
    {
        FootballClubModel fc = new FootballClubModel();
        public ShowFootballClubForm()
        {
            InitializeComponent();
        }

        public ShowFootballClubForm(FootballClubModel footballClubModel)
        {
            InitializeComponent();

            fc = footballClubModel;

            lblCity.Text = footballClubModel.City.Name;
            lblFounded.Text = footballClubModel.Date.ToString();
            lblName.Text = footballClubModel.Name;
            lblNickname.Text = footballClubModel.NickName;
            lblOwner.Text = footballClubModel.Owner;

            pbGrb.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER + Path.DirectorySeparatorChar + footballClubModel.ImageName);
            pbDres.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER_TSHIRT + Path.DirectorySeparatorChar + footballClubModel.TshirtImageName);
        }

        private void btnShowPlayers_Click(object sender, EventArgs e)
        {
            new ShowAllPlayerUserForm(fc.ID).ShowDialog();
        }
    }
}
