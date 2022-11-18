using PLFootballSystem.Controller;
using PLFootballSystem.Forms.MatchForm;
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

namespace PLFootballSystem.Forms.SeasonForm
{
    public partial class ChooseSeasonMatchForm : Form
    {
        ControllerSeason cs = new ControllerSeason();
        public ChooseSeasonMatchForm()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            List<SeasonsModel> seasonsModels = cs.FindAll();

            cbChooseSeason.DisplayMember = "Name";
            cbChooseSeason.ValueMember = "ID";
            foreach (var c in seasonsModels)
            {
                cbChooseSeason.Items.Add(new { ID = c.ID, Name = c.year });
            }

            cbChooseSeason.SelectedIndex = 0;
        }

        private void btnShowMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            int seasonId = (cbChooseSeason.SelectedItem as dynamic).ID;

            new ShowAllMatchForm(seasonId).ShowDialog();

           // List<FootballClubModel> footballClubModels = cfcs.FindBySeasonId(seasonId);

             

           // new ShowTableForm(footballClubModels).ShowDialog();
        }
    }
}
