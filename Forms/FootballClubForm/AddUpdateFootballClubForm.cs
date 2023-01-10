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

namespace PLFootballSystem.Forms.FootballClubForm
{
    public partial class AddNewFootballClubForm : Form
    {
        string fcImagePath = string.Empty;
        string fcTshirtImagePath = string.Empty;
        
        string NewNameFcImage = string.Empty;
        string NewNameFcTShirtImage = string.Empty;

        string UpdatefcImagePath = string.Empty;
        string UpdatefcTshirtImagePath = string.Empty;

        string UpdateNewNameFcImage = string.Empty;
        string UpdateNewNameFcTShirtImage = string.Empty;

        bool update;

        public FootballClubModel fcModel = new FootballClubModel();

        ControllerCity cc = new ControllerCity();
        ControllerFootballClub cfc = new ControllerFootballClub();
        public AddNewFootballClubForm()
        {
            InitializeComponent();
            GetData();

            update = false;
            SetTheme();
        }

        public AddNewFootballClubForm(FootballClubModel footballClubModel)
        {
            InitializeComponent();
            GetData();

            fcModel = footballClubModel;

            tbFootballClubName.Text = footballClubModel.Name;
            tbFootballClubNickname.Text = footballClubModel.NickName;
            tbFootballClubOwner.Text = footballClubModel.Owner;

            cbCity.SelectedIndex = footballClubModel.City.ID;
            dtFounded.Value = footballClubModel.Date;

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
            btnAddImage.BackColor = primaryColor;
            btnAddTshirtImage.BackColor = primaryColor;
            btnSave.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            btnAddImage.ForeColor = textColor;
            btnAddTshirtImage.ForeColor = textColor;
            btnSave.ForeColor = textColor;

            lblCity.ForeColor = textColor;
            lblFootballClubImage.ForeColor = textColor;
            lblFootballClubName.ForeColor = textColor;
            lblFootballClubNickname.ForeColor = textColor;
            lblFootballClubOwner.ForeColor = textColor;
            lblFootballClubTshirt.ForeColor = textColor;
            lblFounded.ForeColor = textColor;

        }

        private void GetData()
        {
            List<CityModel> cityModels = cc.FindAll();
            cbCity.DisplayMember = "Name";
            cbCity.ValueMember = "ID";
            foreach(var c in cityModels)
            {
                cbCity.Items.Add(new { ID = c.ID, Name = c.Name });
            }

            cbCity.SelectedIndex = 0;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            fdFCImage.FilterIndex = 2;
            fdFCImage.RestoreDirectory = true;
            if (fdFCImage.ShowDialog() == DialogResult.OK)
            {
                fcImagePath = fdFCImage.FileName;
            }
        }

        private void btnAddTshirtImage_Click(object sender, EventArgs e)
        {
            fdTshirtImage.FilterIndex = 2;
            fdTshirtImage.RestoreDirectory = true;
            if (fdTshirtImage.ShowDialog() == DialogResult.OK)
            {
                fcTshirtImagePath = fdTshirtImage.FileName;
            }
        }

        private void btnAddFootballClub_Click(object sender, EventArgs e)
        {
            FootballClubModel fc = new FootballClubModel();

            string fcName = tbFootballClubName.Text;
            string fcNickname = tbFootballClubNickname.Text;
            string fcOwner = tbFootballClubOwner.Text;
            DateTime fcDate = dtFounded.Value;

            if (string.IsNullOrEmpty(fcName) || string.IsNullOrEmpty(fcNickname) || string.IsNullOrEmpty(fcOwner))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please input all data." : "Сва поља су обавезна.");
                return;
            }

            if(!update)
            {
                //za sliku kluba
                string[] array = fcImagePath.Split('.');
                NewNameFcImage = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
                NewNameFcImage += ('.' + array[array.Length - 1]);

                if (string.IsNullOrEmpty(NewNameFcImage))
                {
                    MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Input Football club picture." : "Изаберите грб фудбалског клуба.");
                    return;
                }

                while (NewNameFcImage.Contains('/')) NewNameFcImage = NewNameFcImage.Replace('/', '_');
                while (NewNameFcImage.Contains('\\')) NewNameFcImage = NewNameFcImage.Replace('\\', '_');

                File.Copy(fcImagePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER + Path.DirectorySeparatorChar + NewNameFcImage);

                //za sliku dresa
                string[] array1 = fcTshirtImagePath.Split('.');
                NewNameFcTShirtImage = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
                NewNameFcTShirtImage += ('.' + array1[array1.Length - 1]);

                if (string.IsNullOrEmpty(NewNameFcTShirtImage))
                {
                    MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Input Football club tshirt image." : "Изаберите дрес фудбалског клуба.");
                    return;
                }

                while (NewNameFcTShirtImage.Contains('/')) NewNameFcTShirtImage = NewNameFcTShirtImage.Replace('/', '_');
                while (NewNameFcTShirtImage.Contains('\\')) NewNameFcTShirtImage = NewNameFcTShirtImage.Replace('\\', '_');

                File.Copy(fcTshirtImagePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER_TSHIRT + Path.DirectorySeparatorChar + NewNameFcTShirtImage);

                fc.Name = fcName;
                fc.NickName = fcNickname;
                fc.Owner = fcOwner;
                fc.Date = fcDate;
                fc.ImageName = NewNameFcImage;
                fc.TshirtImageName = NewNameFcTShirtImage;
                fc.City = new CityModel { ID = (cbCity.SelectedItem as dynamic).ID, Name = (cbCity.SelectedItem as dynamic).Name };

                cfc.InsertFC(fc);

                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully added." : "Успјешно додано.");

                return;
            }

            //update
            string fcNameUpdate = tbFootballClubName.Text;
            string fcNicknameUpdate = tbFootballClubNickname.Text;
            string fcOwnerUpdate = tbFootballClubOwner.Text;
            DateTime fcDateUpdate = dtFounded.Value;



            if (!string.IsNullOrEmpty(UpdatefcImagePath))
            {
                string[] array = UpdatefcImagePath.Split('.');
                UpdateNewNameFcImage = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
                UpdateNewNameFcImage += ('.' + array[array.Length - 1]);

                while (UpdateNewNameFcImage.Contains('/')) UpdateNewNameFcImage = UpdateNewNameFcImage.Replace('/', '_');
                while (UpdateNewNameFcImage.Contains('\\')) UpdateNewNameFcImage = UpdateNewNameFcImage.Replace('\\', '_');

                File.Copy(UpdatefcImagePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER + Path.DirectorySeparatorChar + UpdateNewNameFcImage);
            }

            if (!string.IsNullOrEmpty(UpdatefcTshirtImagePath))
            {
                string[] array1 = UpdatefcTshirtImagePath.Split('.');
                UpdateNewNameFcTShirtImage = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
                UpdateNewNameFcTShirtImage += ('.' + array1[array1.Length - 1]);

                while (UpdateNewNameFcTShirtImage.Contains('/')) UpdateNewNameFcTShirtImage = UpdateNewNameFcTShirtImage.Replace('/', '_');
                while (UpdateNewNameFcTShirtImage.Contains('\\')) UpdateNewNameFcTShirtImage = UpdateNewNameFcTShirtImage.Replace('\\', '_');

                File.Copy(UpdatefcTshirtImagePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER_TSHIRT + Path.DirectorySeparatorChar + UpdateNewNameFcTShirtImage);
            }

            FootballClubModel updateFC = new FootballClubModel()
            {
                ID = fcModel.ID,
                Name = fcNameUpdate,
                NickName = fcNicknameUpdate,
                Owner = fcOwnerUpdate,
                Date = fcDateUpdate,
                ImageName = string.IsNullOrEmpty(UpdateNewNameFcImage) ? fcModel.ImageName : UpdateNewNameFcImage,
                TshirtImageName = string.IsNullOrEmpty(UpdatefcTshirtImagePath) ? fcModel.TshirtImageName : UpdateNewNameFcTShirtImage,
                City = new CityModel { ID = (cbCity.SelectedItem as dynamic).ID, Name = (cbCity.SelectedItem as dynamic).Name }
            };

            cfc.UpdateByClubId(updateFC);

            MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully updated." : "Успјешно ажурирано.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
