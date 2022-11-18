using PLFootballSystem.Controller;
using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLFootballSystem.Forms.PlayerForm
{
    public partial class AddNewPlayer : Form
    {
        ControllerCountry cc = new ControllerCountry();
        ControllerPlayerPosition cpc = new ControllerPlayerPosition();
        ControllerFootballClub cfc = new ControllerFootballClub();
        ControllerPlayer cp = new ControllerPlayer();

        string filePath = string.Empty;
        string NewName = string.Empty;
        public AddNewPlayer()
        {
            InitializeComponent();
            GetData();
        }
        private void GetData()
        {
            List<CountryModel> countryModels = cc.FindAll();
            cbPlayerCountry.DisplayMember = "Name";
            cbPlayerCountry.ValueMember = "ID";
            foreach (var c in countryModels)
            {
                cbPlayerCountry.Items.Add(new { ID = c.ID, Name = c.Name });
            }
            cbPlayerCountry.SelectedIndex = 0;

            List<PositionModel> positionModels = cpc.FindAll();
            cbPlayerPosition.DisplayMember = "Description";
            cbPlayerPosition.ValueMember = "ID";
            foreach (var c in positionModels)
            {
                cbPlayerPosition.Items.Add(new { ID = c.ID, Description = c.Description });
            }
            cbPlayerPosition.SelectedIndex = 0;

            List<FootballClubModel> footballClubModels = cfc.FindAll();
            cbPlayerFC.DisplayMember = "Name";
            cbPlayerFC.ValueMember = "ID";
            foreach (var c in footballClubModels)
            {
                cbPlayerFC.Items.Add(new { ID = c.ID, Name = c.Name });
            }
            cbPlayerFC.SelectedIndex = 0;


        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            fdPlayerImage.FilterIndex = 2;
            fdPlayerImage.RestoreDirectory = true;


            if (fdPlayerImage.ShowDialog() == DialogResult.OK)
            {
                filePath = fdPlayerImage.FileName;
            }
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string playerName = tbPlayerName.Text;
            decimal num = numPlayerNumber.Value;
            DateTime date = datePlayerDate.Value;

            string[] array1 = filePath.Split('.');
            NewName = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
            NewName += ('.' + array1[array1.Length - 1]);
            
            while(NewName.Contains('/')) NewName.Replace('/', '_');
            while(NewName.Contains('\\')) NewName.Replace('\\', '_');
            File.Copy(filePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + NewName);

            //int idCountry = (cbPlayerCountry as dynamic).ID;
            //int idPosition = (cbPlayerPosition as dynamic).ID;
            //int idFC = (cbPlayerFC as dynamic).ID;
            PlayerModel playerModel = new PlayerModel()
            {
                Name = playerName,
                Number = (int)num,
                Date = date,
                ImageName = NewName,
                Country = new CountryModel { ID = (cbPlayerCountry.SelectedItem as dynamic).ID },
                Position = new PositionModel { ID = (cbPlayerPosition.SelectedItem as dynamic).ID },
                FootballClub = new FootballClubModel { ID = (cbPlayerFC.SelectedItem as dynamic).ID },
                Status = 1
            };

            cp.InsertPlayer(playerModel);
        }
    }
}
