﻿using PLFootballSystem.Forms.FootballClubForm;
using PLFootballSystem.Forms.SeasonForm;
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

namespace PLFootballSystem.Forms
{
    public partial class UserForm : Form
    {
        public AccountModel account = new AccountModel();
        public UserForm()
        {
            InitializeComponent();
            SetTheme();
            lblUser.Text = account.Username;
        }

        public UserForm(AccountModel acc)
        {
            InitializeComponent();
            account = acc;
            SetTheme();
            lblUser.Text = account.Username;
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
            btnFootballClub.BackColor = primaryColor;
            btnLogout.BackColor = primaryColor;
            btnMatch.BackColor = primaryColor;
            btnSettings.BackColor = primaryColor;
            btnTable.BackColor = primaryColor;

            this.BackColor = tertiaryColor;
        }
        private void ChangeTextColor(Color textColor)
        {
            btnFootballClub.ForeColor = textColor;
            btnLogout.ForeColor = textColor;
            btnMatch.ForeColor = textColor;
            btnSettings.ForeColor = textColor;
            btnTable.ForeColor = textColor;

            lblWelcome.ForeColor = textColor;
            lblUser.ForeColor = textColor;

            
        }


        private void btnTable_Click(object sender, EventArgs e)
        {
            new ChooseSeasonTableForm().ShowDialog();
        }

        private void btnFootballClub_Click(object sender, EventArgs e)
        {
            new ChooseFootballClubForm().ShowDialog();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            new ChooseSeasonMatchForm().ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm(account).ShowDialog();

            this.Controls.Clear();
            this.InitializeComponent();
            lblUser.Text = account.Username;
            SetTheme();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();

            
        }
    }
}
