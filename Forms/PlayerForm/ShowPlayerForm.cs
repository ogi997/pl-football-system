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
    public partial class ShowPlayerForm : Form
    {
        ControllerPlayer cp = new ControllerPlayer();
        public ShowPlayerForm()
        {
            InitializeComponent();
            SetTheme();
        }

        public ShowPlayerForm(int playerId)
        {
            InitializeComponent();
            GetData(playerId);
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
           

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            lblCountryName.ForeColor = textColor;
            lblDate.ForeColor = textColor;
            lblNumber.ForeColor = textColor;
            lblPlayerDate.ForeColor = textColor;
            lblPlayerName.ForeColor = textColor;
            lblPlayerNumber.ForeColor = textColor;
            lblPlayerPosition.ForeColor = textColor;
            lblPosition.ForeColor = textColor;
            // Change color of text
            //lblSearch.ForeColor = textColor;
            //.ForeColor = textColor;
            //lblRepeatPassword.ForeColor = textColor;
            //lblPassword.ForeColor = textColor;
        }

        private void GetData(int playerId)
        {
            PlayerModel pm = cp.FindByPlayerId(playerId);

            lblCountryName.Text = pm.Country.Name;
            lblPlayerDate.Text = pm.Date.ToString();
            lblPlayerNumber.Text = pm.Number.ToString();
            lblPlayerName.Text = pm.Name;
            lblPlayerPosition.Text = pm.Position.Description;


            pbPlayerFace.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + pm.ImageName);
            pbCountryFlag.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperCountry.FOLDER + Path.DirectorySeparatorChar + pm.Country.ImageName);

        }
    }
}
