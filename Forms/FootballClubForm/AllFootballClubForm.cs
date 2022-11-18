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
    public partial class AllFootballClubForm : Form
    {
        ControllerFootballClub cfc = new ControllerFootballClub();

        public List<FootballClubModel> listFC = new List<FootballClubModel>();
        public AllFootballClubForm()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            List<FootballClubModel> footballClubModels = cfc.FindAll();
            listFC = footballClubModels;
            List<ListViewItem> array = new List<ListViewItem>();
            foreach (FootballClubModel fc in footballClubModels)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag =fc.ID;
                lvi.Text = fc.Name;
                lvi.SubItems.Add(fc.City.Name);
                array.Add(lvi);
            }

            lvAllFootballClub.Items.AddRange(array.ToArray());
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            lvAllFootballClub.Items.Clear();
            List<ListViewItem> a = new List<ListViewItem>();
            for (int i = 0; i < listFC.Count; i++)
            {
                if (string.IsNullOrEmpty(tbSearchBox.Text) || listFC.ElementAt(i).Name.StartsWith(tbSearchBox.Text))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = listFC.ElementAt(i).ID;
                    lvi.Text = listFC.ElementAt(i).Name;
                    lvi.SubItems.Add(listFC.ElementAt(i).City.Name);
                    //lvi.SubItems.Add(listAM.ElementAt(i).Status == 1 ? "Active" : "Suspended");
                    a.Add(lvi);
                }
            }
            lvAllFootballClub.Items.AddRange(a.ToArray());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvAllFootballClub.SelectedItems.Count > 1 || lvAllFootballClub.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select one item");
                return;
            }

            int footballClubId = (int)lvAllFootballClub.SelectedItems[0].Tag;
            Console.WriteLine(footballClubId);
            cfc.DeleteByClubId(footballClubId);

            lvAllFootballClub.Items.Clear();
            GetData();
            lvAllFootballClub.Refresh();

            searchBox_TextChanged(sender, e);
        }
    }
}
