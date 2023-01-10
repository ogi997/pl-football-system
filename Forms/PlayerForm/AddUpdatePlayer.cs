using PLFootballSystem.Controller;
using PLFootballSystem.Model;
using PLFootballSystem.Util;
using PLFootballSystem.Util.Theme;
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
    public partial class AddUpdatePlayer : Form
    {
        ControllerCountry cc = new ControllerCountry();
        ControllerPlayerPosition cpc = new ControllerPlayerPosition();
        ControllerFootballClub cfc = new ControllerFootballClub();
        ControllerPlayer cp = new ControllerPlayer();

        string filePath = string.Empty;
        string NewName = string.Empty;

        bool update;

        PlayerModel pp = new PlayerModel();
        public AddUpdatePlayer()
        {
            InitializeComponent();
            GetData();
            SetTheme();

            update = false;
        }

        public AddUpdatePlayer(PlayerModel player)
        {
            InitializeComponent();
            GetData();

            pp = player;

            tbPlayerName.Text = player.Name;
            numPlayerNumber.Value = player.Number;
            datePlayerDate.Value = player.Date;

            cbPlayerCountry.SelectedIndex = cbPlayerCountry.FindStringExact(player.Country.Name);
            cbPlayerFC.SelectedIndex = cbPlayerFC.FindStringExact(player.FootballClub.Name);
            cbPlayerPosition.SelectedIndex = cbPlayerPosition.FindStringExact(player.Position.Description);

            update = true;
            SetTheme();
        }

        private void SetTheme()
        {
            if ("light".Equals(ChangeTheme.GetTheme()))
            {
                ChangeThemee(Theme.GetLight()[ThemeColor.Primary], Theme.GetLight()[ThemeColor.Secondary], Theme.GetLight()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetLight()[ThemeColor.Text]);
            }
            else if ("dark".Equals(ChangeTheme.GetTheme()))
            {
                ChangeThemee(Theme.GetDark()[ThemeColor.Primary], Theme.GetDark()[ThemeColor.Secondary], Theme.GetDark()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetDark()[ThemeColor.Text]);
            }
            else if ("nature".Equals(ChangeTheme.GetTheme()))
            {
                ChangeThemee(Theme.GetNature()[ThemeColor.Primary], Theme.GetNature()[ThemeColor.Secondary], Theme.GetNature()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetNature()[ThemeColor.Text]);
            }
        }

        private void ChangeThemee(Color primaryColor, Color secondaryColor, Color tertiaryColor)
        {
            btnClose.BackColor = primaryColor;
            btnSelectImage.BackColor = primaryColor;
            btnSave.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            btnSelectImage.ForeColor = textColor;
            btnSave.ForeColor = textColor;

            lblCountry.ForeColor = textColor;
            lblDate.ForeColor = textColor;
            lblPlayerClub.ForeColor = textColor;
            lblPlayerImage.ForeColor = textColor;
            lblPlayerName.ForeColor = textColor;
            lblPlayerNumber.ForeColor = textColor;
            lblPlayerPosition.ForeColor = textColor;

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

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "You must input all data." : "Попуните сва поља.");
                return;
            }

            if (!update)
            {
                string[] array1 = filePath.Split('.');
                NewName = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
                NewName += ('.' + array1[array1.Length - 1]);

                if (string.IsNullOrEmpty(NewName))
                {
                    MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please add player image." : "Изаберите слику играча");
                    return;
                }

                while (NewName.Contains('/')) NewName = NewName.Replace('/', '_');
                while (NewName.Contains('\\')) NewName = NewName.Replace('\\', '_');
                File.Copy(filePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + NewName);

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

                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully added." : "Успјешно додано.");

                return;
            }

            //update
            string UpdateplayerName = tbPlayerName.Text;
            decimal Updatenum = numPlayerNumber.Value;
            DateTime Updatedate = datePlayerDate.Value;

            PlayerModel player = new PlayerModel()
            {
                ID = pp.ID,
                Name = UpdateplayerName,
                Number = (int)Updatenum,
                Date = Updatedate,
                ImageName = NewName,
                Country = new CountryModel { ID = (cbPlayerCountry.SelectedItem as dynamic).ID },
                Position = new PositionModel { ID = (cbPlayerPosition.SelectedItem as dynamic).ID },
                FootballClub = new FootballClubModel { ID = (cbPlayerFC.SelectedItem as dynamic).ID },
                Status = 1
            };

            cp.UpdatePlayerById(player);

            MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully updated." : "Успјешно ажурирано.");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
