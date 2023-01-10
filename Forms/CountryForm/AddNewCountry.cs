using PLFootballSystem.Controller;
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
            // Change background color of buttons
            btnCountry.BackColor = primaryColor;
            btnClose.BackColor = primaryColor;
            btnSelectImage.BackColor = primaryColor;
            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnCountry.ForeColor = textColor;
            btnClose.ForeColor = textColor;
            btnSelectImage.ForeColor = textColor;
            lblCountryFlagImage.ForeColor = textColor;
            lblCountryName.ForeColor = textColor;
            // Change color of text
            //lblSearch.ForeColor = textColor;
            //.ForeColor = textColor;
            //lblRepeatPassword.ForeColor = textColor;
            //lblPassword.ForeColor = textColor;
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

            if (string.IsNullOrEmpty(nameOfCountry))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please input name of country." : "Унесите име државе.");
                return;
            }

            string[] array = filePath.Split('.');
            NewName = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
            NewName += ('.' + array[array.Length - 1]);

            while (NewName.Contains('/')) NewName = NewName.Replace('/', '_');
            while (NewName.Contains('\\')) NewName = NewName.Replace('\\', '_');

            File.Copy(filePath, Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperCountry.FOLDER + Path.DirectorySeparatorChar + NewName);

            cc.InsertCountry(nameOfCountry, NewName);
            MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully added." : "Успјешно додано.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

            var mainForm = Application.OpenForms.OfType<AdminForm>().Single();
            mainForm.SetLblPath("en".Equals(ChangeLanguage.GetLanguage()) ? "Home" : "Почетна");
        }
    }
}
