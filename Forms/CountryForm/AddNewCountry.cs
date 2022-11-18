using PLFootballSystem.Controller;
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

namespace PLFootballSystem.Forms.CountryForm
{
    public partial class AddNewCountry : Form
    {
        string filePath = string.Empty;
        string NewName = string.Empty;

        ControllerCountry cc = new ControllerCountry();
        public AddNewCountry()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
           // openFileDialog.InitialDirectory = "c:\\";
            //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

           

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            string nameOfCountry = tbCountryName.Text;
            string[] array = filePath.Split('.');
            NewName = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
            NewName += ('.' + array[array.Length - 1]);
            File.Copy(filePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperCountry.FOLDER + Path.DirectorySeparatorChar + NewName);

            cc.InsertCountry(nameOfCountry, NewName);
        }
    }
}
