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

namespace PLFootballSystem.Forms.FCToSeason
{
    public partial class AddFcToSeason : Form
    {
        ControllerFootballClub cfc = new ControllerFootballClub();
        ControllerSeason cs = new ControllerSeason();
        ControllerFCHasSeason fchs = new ControllerFCHasSeason();
        public AddFcToSeason()
        {
            InitializeComponent();
            GetData();
        }
        
        private void GetData()
        {
            List<FootballClubModel> footballClubModels = cfc.FindAll();
            cbFootballClub.DisplayMember = "Name";
            cbFootballClub.ValueMember = "ID";
            foreach (var c in footballClubModels)
            {
                cbFootballClub.Items.Add(new { ID = c.ID, Name = c.Name });
            }
            cbFootballClub.SelectedIndex = 0;

            List<SeasonsModel> seasonsModels = cs.FindAll();
            cbSeason.DisplayMember = "Year";
            cbSeason.ValueMember = "ID";
            foreach (var c in seasonsModels)
            {
                cbSeason.Items.Add(new { ID = c.ID, Year = c.year });
            }
            cbSeason.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FCSeasonsModel fCSeasonsModel = new FCSeasonsModel();
            fCSeasonsModel.FC = new FootballClubModel { ID = (cbFootballClub.SelectedItem as dynamic).ID };
            fCSeasonsModel.Seasons = new SeasonsModel { ID = (cbSeason.SelectedItem as dynamic).ID };
            fCSeasonsModel.TablePosition = (int)numberTablePosition.Value;
            fchs.Insert(fCSeasonsModel);

        }
    }
}
