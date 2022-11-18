using PLFootballSystem.Forms.FootballClubForm;
using PLFootballSystem.Forms.SeasonForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLFootballSystem.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            new ChooseSeasonTableForm().ShowDialog();
        }

        private void btnFootballClub_Click(object sender, EventArgs e)
        {
            new ChooseFootballClubForm().ShowDialog();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            new ChooseSeasonMatchForm().ShowDialog();
        }
    }
}
