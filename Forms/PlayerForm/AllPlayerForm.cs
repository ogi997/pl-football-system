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

namespace PLFootballSystem.Forms.PlayerForm
{
    public partial class AllPlayerForm : Form
    {
        ControllerPlayer cp = new ControllerPlayer();
        public List<PlayerModel> listPL = new List<PlayerModel>();
        public AllPlayerForm()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            List<PlayerModel> playerModels = cp.FindAll();
            listPL = playerModels;
            List<ListViewItem> array = new List<ListViewItem>();
            foreach (PlayerModel pl in playerModels)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = pl.ID;
                lvi.Text = pl.Name;
                lvi.SubItems.Add(pl.Position.Description);
                lvi.SubItems.Add(pl.Status == 1 ? "Active" : "Suspended");
                array.Add(lvi);
            }

            lvAllPlayers.Items.AddRange(array.ToArray());
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            lvAllPlayers.Items.Clear();
            List<ListViewItem> a = new List<ListViewItem>();
            for (int i = 0; i < listPL.Count; i++)
            {
                if (string.IsNullOrEmpty(tbSearchBox.Text) || listPL.ElementAt(i).Name.StartsWith(tbSearchBox.Text))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = listPL.ElementAt(i).ID;
                    lvi.Text = listPL.ElementAt(i).Name;
                    lvi.SubItems.Add(listPL.ElementAt(i).Position.Description);
                    lvi.SubItems.Add(listPL.ElementAt(i).Status == 1 ? "Active" : "Suspended");
                    a.Add(lvi);
                }
            }
            lvAllPlayers.Items.AddRange(a.ToArray());
        }

        private void DeleteOrActivate(bool delete)
        {
            if (lvAllPlayers.SelectedItems.Count <= 0 || lvAllPlayers.SelectedItems.Count > 1)
            {
                MessageBox.Show("Please select one player.");
                return;
            }
            var ID = lvAllPlayers.SelectedItems[0].Tag;
            var result = cp.FindStatusById((int)ID);
            if (result == (delete ? 0 : 1))
            {
                MessageBox.Show($"User already {(delete ? "deleted." : "active.")}");
                return;
            }

            cp.UpdateStatusByID(delete ? 0 : 1, (int)lvAllPlayers.SelectedItems[0].Tag);
            RefreshListView();
        }
        private void RefreshListView()
        {
            lvAllPlayers.Items.Clear();
            GetData();
            lvAllPlayers.Refresh();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteOrActivate(true);
            searchBox_TextChanged(sender, e);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            DeleteOrActivate(false);
            searchBox_TextChanged(sender, e);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteOrActivate(true);
            searchBox_TextChanged(sender, e);
        }
    }
}
