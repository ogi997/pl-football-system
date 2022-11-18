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

namespace PLFootballSystem.Forms.TableForm
{
    public partial class ShowTableForm : Form
    {
 
        public ShowTableForm()
        {
            InitializeComponent();
        }

        public ShowTableForm(List<FootballClubModel> footballClubModels)
        {
            InitializeComponent();
            ShowTable(footballClubModels);
        }

        private void ShowTable(List<FootballClubModel> table)
        {
            foreach(var t in table)
            {
                lvTable.Items.Add(t.Name);
            }
        }
    }
}
