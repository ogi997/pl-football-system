using PLFootballSystem.Controller;
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
    public partial class AddNewSeasonForm : Form
    {
        ControllerSeason cs = new ControllerSeason();
        public AddNewSeasonForm()
        {
            InitializeComponent();
        }

        private void btnAddNewSeason_Click(object sender, EventArgs e)
        {
            string year = tbSeason.Text;
            cs.InsertSeason(year);
        }
    }
}
