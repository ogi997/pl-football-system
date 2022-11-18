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

namespace PLFootballSystem.Forms.FootballClubForm
{
    public partial class AddNewFootballClubForm : Form
    {
        string fcImagePath = string.Empty;
        string fcTshirtImagePath = string.Empty;
        
        string NewNameFcImage = string.Empty;
        string NewNameFcTShirtImage = string.Empty;

        ControllerCity cc = new ControllerCity();
        public AddNewFootballClubForm()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            List<CityModel> cityModels = cc.FindAll();
            //cbCity.DataSource = new BindingSource(cityModels, null);
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
            //string formatForMySql = fcDate.ToString("yyyy-MM-dd HH:mm:ss");

            //za sliku kluba
            string[] array = fcImagePath.Split('.');
            NewNameFcImage = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
            NewNameFcImage += ('.' + array[array.Length - 1]);

            while (NewNameFcImage.Contains('/')) NewNameFcImage.Replace('/', '_');
            while (NewNameFcImage.Contains('\\')) NewNameFcImage.Replace('\\', '_');

            File.Copy(fcImagePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER + Path.DirectorySeparatorChar + NewNameFcImage);

            //za sliku dresa
            string[] array1 = fcTshirtImagePath.Split('.');
            NewNameFcTShirtImage = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
            NewNameFcTShirtImage += ('.' + array1[array1.Length - 1]);

            while (NewNameFcTShirtImage.Contains('/')) NewNameFcTShirtImage.Replace('/', '_');
            while (NewNameFcTShirtImage.Contains('\\')) NewNameFcTShirtImage.Replace('\\', '_');

            File.Copy(fcTshirtImagePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER_TSHIRT + Path.DirectorySeparatorChar + NewNameFcTShirtImage);

            fc.Name = fcName;
            fc.NickName = fcNickname;
            fc.Owner = fcOwner;
            fc.Date = fcDate;
            fc.ImageName = NewNameFcImage;
            fc.TshirtImageName = NewNameFcTShirtImage;
            // Console.WriteLine((cbCity.SelectedItem as dynamic).Name + " " + (cbCity.SelectedItem as dynamic).ID);
            fc.City = new CityModel { ID = (cbCity.SelectedItem as dynamic).ID, Name = (cbCity.SelectedItem as dynamic).Name }; 
            
            //fc.City.Name = (cbCity.SelectedItem as dynamic).Name;
            ControllerFootballClub cfc = new ControllerFootballClub();

            cfc.InsertFC(fc);

            
            //Console.WriteLine(fcDate);
        }
    }
}
