using PLFootballSystem.Forms.AccountForm;
using PLFootballSystem.Forms.CountryForm;
using PLFootballSystem.Forms.CityForm;
using PLFootballSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLFootballSystem.Forms.PlayerPosition;
using PLFootballSystem.Forms.SeasonForm;
using PLFootballSystem.Forms.PlayerForm;
using PLFootballSystem.Forms.FootballClubForm;
using PLFootballSystem.Forms.FCToSeason;
using PLFootballSystem.Forms.MatchForm;
using PLFootballSystem.Util;
using PLFootballSystem.Util.Theme;
using PLFootballSystem.Controller;

namespace PLFootballSystem.Forms
{
    public partial class AdminForm : Form
    {
        ControllerAccount ca = new ControllerAccount();
        public AccountModel acc = new AccountModel();
        public AdminForm()
        {
            InitializeComponent();
            CustomizeDesign();
            SetTheme();
        }

        public AdminForm(AccountModel am)
        {
            InitializeComponent();
            CustomizeDesign();
            lblUser.Text = am.Username;
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Home" : "Почетна";
            acc = am;

            SetTheme();

        }

        private void SetTheme()
        {
            if ("light".Equals(ca.SelectTheme(acc.ID)))
            {
                ChangeThemee(Theme.GetLight()[ThemeColor.Primary], Theme.GetLight()[ThemeColor.Secondary], Theme.GetLight()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetLight()[ThemeColor.Text]);
            }
            else if ("dark".Equals(ca.SelectTheme(acc.ID)))
            {
                ChangeThemee(Theme.GetDark()[ThemeColor.Primary], Theme.GetDark()[ThemeColor.Secondary], Theme.GetDark()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetDark()[ThemeColor.Text]);
            } else if ("nature".Equals(ca.SelectTheme(acc.ID)))
            {
                ChangeThemee(Theme.GetNature()[ThemeColor.Primary], Theme.GetNature()[ThemeColor.Secondary], Theme.GetNature()[ThemeColor.Tertiary]);
                ChangeTextColor(Theme.GetNature()[ThemeColor.Text]);
            }
        }


        private void ChangeThemee(Color primaryColor, Color secondaryColor, Color tertiaryColor)
        {
            btnAccount.BackColor = primaryColor;
            
            btnPL.BackColor = primaryColor;
            btnNewFC.BackColor = secondaryColor;
            btnPlayer.BackColor = secondaryColor;
            btnNewMatch.BackColor = secondaryColor;
            btnClubToSeason.BackColor = secondaryColor;

            btnOther.BackColor = primaryColor;
            btnCountry.BackColor = secondaryColor;
            btnPosition.BackColor = secondaryColor;
            btnCity.BackColor = secondaryColor;
            btnSeason.BackColor = secondaryColor;

            btnSettings.BackColor = secondaryColor;
            btnLogout.BackColor = secondaryColor;

            panelSideMenu.BackColor = tertiaryColor;
            panelTopBar.BackColor = tertiaryColor;
            panelMain.BackColor = secondaryColor;

            panelSubMenuUser.BackColor = secondaryColor;

        }

        private void ChangeTextColor(Color textColor)
        {
            btnAccount.ForeColor = textColor;

            btnPL.ForeColor = textColor;
            btnNewFC.ForeColor = textColor;
            btnPlayer.ForeColor = textColor;
            btnNewMatch.ForeColor = textColor;
            btnClubToSeason.ForeColor = textColor;

            btnOther.ForeColor = textColor;
            btnCountry.ForeColor = textColor;
            btnPosition.ForeColor = textColor;
            btnCity.ForeColor = textColor;
            btnSeason.ForeColor = textColor;

            btnSettings.ForeColor = textColor;
            btnLogout.ForeColor = textColor;

            lblPath.ForeColor = textColor;
            lblUser.ForeColor = textColor;

        }


        public void SetLblPath(string path)
        {
            lblPath.Text = path;
        }
        private void CustomizeDesign()
        {
            panelSubMenuUser.Visible = false;
            panelSubMenuPL.Visible = false;
            panelSubMenuOther.Visible = false;
        }

        private void HideSubMenu()
        {

            if (panelSubMenuUser.Visible == true)
                panelSubMenuUser.Visible = false;

            if (panelSubMenuPL.Visible == true)
                panelSubMenuPL.Visible = false;

            if (panelSubMenuOther.Visible == true)
                panelSubMenuOther.Visible = false;

        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            } else
            {
                SubMenu.Visible = false;
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AllAccountForm());
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Account / All accounts" : "Налози / Сви налози";
        }

        private void btnPL_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuPL);

        }

        private Form activeForm = null;
        private void OpenNewFormInPanelMain(Form newForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = newForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(activeForm);
            panelMain.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuUser);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            
            DialogResult result = MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Do you want to logout?" : "Да ли желите да се одјавите?", "en".Equals(ChangeLanguage.GetLanguage()) ? "Logout" : "Одјава", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                this.Close();
                new LoginForm().Show();
                
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            new SettingsForm(acc).ShowDialog();

            this.Controls.Clear();
            this.InitializeComponent();
            CustomizeDesign();
            lblUser.Text = acc.Username;
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Home" : "Почетна";
            SetTheme();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuOther);
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewCountry());
            HideSubMenu();
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Premier League / Add new country" : "Премијер лига / Додај нову државу";
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewCityForm());
            HideSubMenu();
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Premier League / Add new city" : "Премијер лига / Додај нови град"; ;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewPlayerPosition());
            HideSubMenu();
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Premier League / Add new player position" : "Премијер лига / Додај нову позицију играча";
        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewSeasonForm());
            HideSubMenu();
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Premier League / Add new season" : "Премијер лига / Додај нову сезону";
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AllPlayerForm());
            HideSubMenu();
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Premier League / Player" : "Премијер лига / Играчи" ;
        }

        private void btnNewFC_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AllFootballClubForm());
            HideSubMenu();
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Premier League / Football club" : "Премијер лига / Фудбалски клубови";
        }

        private void btnClubToSeason_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddFcToSeason());
            HideSubMenu();
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Premier League / Add football club to season" : "Премијер лига / Додај клуб на табелу" ;
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewMatch());
            HideSubMenu();
            lblPath.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Premier League / Add new match" : "Премијер лига / Додај нову утакмицу";
        }
    }
}
