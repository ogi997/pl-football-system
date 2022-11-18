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

namespace PLFootballSystem.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        public AdminForm(AccountModel am)
        {
            InitializeComponent();
            CustomizeDesign();
            lblUser.Text = am.Username;
        }
        public void SetLblPath(string path)
        {
            lblPath.Text = path;
        }
        private void CustomizeDesign()
        {
            panelSubMenuAccount.Visible = false;
            panelSubMenuUser.Visible = false;
            panelSubMenuPL.Visible = false;
            panelSubMenuOther.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelSubMenuAccount.Visible == true)
                panelSubMenuAccount.Visible = false;

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
                //prvo zatvori sve ostale submenus pa otvori odgovarajuci
                HideSubMenu();
                SubMenu.Visible = true;
            } else
            {
                SubMenu.Visible = false;
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuAccount);
        }

        private void btnAllAccount_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AllAccountForm());
            HideSubMenu();
            lblPath.Text = "Account / All accounts";
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewAccountForm());
            HideSubMenu();
            lblPath.Text = "Account / Add new account";
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
            DialogResult result = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                this.Close();
                new LoginForm().Show();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            new SettingsForm().ShowDialog();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuOther);
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewCountry());
            HideSubMenu();
            lblPath.Text = "Premier League / Add new country";
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            //OpenNewFormInPanelMain(new CityForm());
            OpenNewFormInPanelMain(new AddNewCityForm());
            HideSubMenu();
            lblPath.Text = "Premier League / Add new city";
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewPlayerPosition());
            HideSubMenu();
            lblPath.Text = "Premier League / Add new player position";
        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewSeasonForm());
            HideSubMenu();
            lblPath.Text = "Premier League / Add new season";
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new ViewPlayerForm());
            HideSubMenu();
            lblPath.Text = "Premier League / Player";
        }

        private void btnNewFC_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new ViewFootballClubForm());
            HideSubMenu();
            lblPath.Text = "Premier League / Football club";
        }

        private void btnClubToSeason_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddFcToSeason());
            HideSubMenu();
            lblPath.Text = "Premier League / Add football club to season";
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanelMain(new AddNewMatch());
            HideSubMenu();
            lblPath.Text = "Premier League / Add new match";
        }
    }
}
