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
    public partial class ViewPlayerForm : Form
    {
        public ViewPlayerForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            new AddNewPlayer().ShowDialog();
        }

        private void btnAllPlayer_Click(object sender, EventArgs e)
        {
            new AllPlayerForm().ShowDialog();
        }
    }
}
