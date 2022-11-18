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
    public partial class ViewFootballClubForm : Form
    {
        public ViewFootballClubForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewFC_Click(object sender, EventArgs e)
        {
            new AddNewFootballClubForm().ShowDialog();
        }

        private void btnAllFC_Click(object sender, EventArgs e)
        {
            new AllFootballClubForm().ShowDialog();
        }
    }
}
