using PLFootballSystem.Controller;
using PLFootballSystem.Util;
using PLFootballSystem.Util.Theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLFootballSystem.Forms.CityForm
{
   
    public partial class AddNewCityForm : Form
    {
        ControllerCity cc = new ControllerCity();
        public AddNewCityForm()
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
            btnAddCity.BackColor = primaryColor;
            btnClose.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnAddCity.ForeColor = textColor;
            btnClose.ForeColor = textColor;
            lblCityName.ForeColor = textColor;
        
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            string cityName = tbCityName.Text;

            if (string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please input name of city." : "Унесите име града.");
                return;
            }

            cc.InsertCity(cityName);
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
