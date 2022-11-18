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

namespace PLFootballSystem.Forms.FootballClubForm
{
    public partial class ChooseFootballClubForm : Form
    {
        ControllerFootballClub cfc = new ControllerFootballClub();
        public ChooseFootballClubForm()
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
        }

        private void btnShowFC_Click(object sender, EventArgs e)
        {
            this.Hide();
            int footballClubId = (cbFootballClub.SelectedItem as dynamic).ID;
            FootballClubModel footballClubModel = cfc.FindByClubId(footballClubId);

            new ShowFootballClubForm(footballClubModel).ShowDialog();
        }
    }
}
