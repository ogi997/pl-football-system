using PLFootballSystem.Controller;
using PLFootballSystem.Model;
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

namespace PLFootballSystem.Forms.FCToSeason
{
    public partial class AddFcToSeason : Form
    {
        ControllerFootballClub cfc = new ControllerFootballClub();
        ControllerSeason cs = new ControllerSeason();
        ControllerFCHasSeason fchs = new ControllerFCHasSeason();
        public AddFcToSeason()
        {
            InitializeComponent();
            GetData();
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
            btnAdd.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnAdd.ForeColor = textColor;
            lblFootballClub.ForeColor = textColor;
            lblPoints.ForeColor = textColor;
            lblSeason.ForeColor = textColor;
            //lblCityName.ForeColor = textColor;
            // Change color of text
            //lblSearch.ForeColor = textColor;
            //.ForeColor = textColor;
            //lblRepeatPassword.ForeColor = textColor;
            //lblPassword.ForeColor = textColor;
        }

        private void GetData()
        {
            List<FootballClubModel> footballClubModels = cfc.FindAll();
            cbFootballClub.DisplayMember = "Name";
            cbFootballClub.ValueMember = "ID";
            foreach (var c in footballClubModels)
            {
                cbFootballClub.Items.Add(new { ID = c.ID, Name = c.Name });
            }
            cbFootballClub.SelectedIndex = 0;

            List<SeasonsModel> seasonsModels = cs.FindAll();
            cbSeason.DisplayMember = "Year";
            cbSeason.ValueMember = "ID";
            foreach (var c in seasonsModels)
            {
                cbSeason.Items.Add(new { ID = c.ID, Year = c.year });
            }
            cbSeason.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            FCSeasonsModel fCSeasonsModel = new FCSeasonsModel();
            fCSeasonsModel.FC = new FootballClubModel { ID = (cbFootballClub.SelectedItem as dynamic).ID };
            fCSeasonsModel.Seasons = new SeasonsModel { ID = (cbSeason.SelectedItem as dynamic).ID };
            fCSeasonsModel.TablePosition = (int)numberTablePosition.Value;
            fchs.Insert(fCSeasonsModel);
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
