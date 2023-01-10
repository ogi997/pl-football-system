using PLFootballSystem.Forms.PlayerForm;
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
    public partial class ShowFootballClubForm : Form
    {
        FootballClubModel fc = new FootballClubModel();
        public ShowFootballClubForm()
        {
            InitializeComponent();
            SetTheme();
        }

        public ShowFootballClubForm(FootballClubModel footballClubModel)
        {
            InitializeComponent();

            fc = footballClubModel;

            lblCity.Text = footballClubModel.City.Name;
            lblFounded.Text = footballClubModel.Date.ToString();
            lblName.Text = footballClubModel.Name;
            lblNickname.Text = footballClubModel.NickName;
            lblOwner.Text = footballClubModel.Owner;
            
            SetTheme();
            
            pbGrb.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER + Path.DirectorySeparatorChar + footballClubModel.ImageName);
            pbDres.Image = new Bitmap(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperFootballClub.FOLDER_TSHIRT + Path.DirectorySeparatorChar + footballClubModel.TshirtImageName);
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
            btnShowPlayers.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnShowPlayers.ForeColor = textColor;

            lblCity.ForeColor = textColor;
            lblName.ForeColor = textColor;
            lblNickname.ForeColor = textColor;
            lblOwner.ForeColor = textColor;
            lblFounded.ForeColor = textColor;
            // Change color of text
            //lblSearch.ForeColor = textColor;
            //.ForeColor = textColor;
            //lblRepeatPassword.ForeColor = textColor;
            //lblPassword.ForeColor = textColor;
        }

        private void btnShowPlayers_Click(object sender, EventArgs e)
        {
            new ShowAllPlayerUserForm(fc.ID).ShowDialog();
        }
    }
}
