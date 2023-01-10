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

namespace PLFootballSystem.Forms
{
    public partial class SettingsForm : Form
    {
        ControllerTheme ct = new ControllerTheme();
        ControllerAccount ca = new ControllerAccount();
        AccountModel account = new AccountModel();
        public SettingsForm()
        {
            InitializeComponent();
            GetData();
            SetTheme();
        }

        public SettingsForm(AccountModel acc)
        {
            InitializeComponent();
            account = acc;
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
            btnSave.BackColor = primaryColor;

            this.BackColor = tertiaryColor;
        }
        private void ChangeTextColor(Color textColor)
        {
            btnSave.ForeColor = textColor;

            lblLanguage.ForeColor = textColor;
            label1.ForeColor = textColor;


        }

        private void GetData()
        {
            List<ThemeModel> themeModels = ct.FindAll();
            foreach(var t in themeModels)
            {
                cbTheme.Items.Add(t.Description);
            }

            Console.WriteLine("acc:" + account.Theme.Description);
            cbTheme.SelectedIndex = cbTheme.FindStringExact(ca.SelectTheme(account.ID));

            cbLanguage.SelectedIndex = "en".Equals(ChangeLanguage.GetLanguage()) ? cbLanguage.FindStringExact("English") : cbLanguage.FindStringExact("Српски");
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var lan = cbLanguage.SelectedItem;
            var theme = cbTheme.SelectedItem;
            Console.WriteLine("Theme: " + theme);
            if ("English".Equals(lan))
            {
                ChangeLanguage.UpdateConfig("language", "en");
            } else
            {
                ChangeLanguage.UpdateConfig("language", "sr-Cyrl");
            }

            if ("light".Equals(theme))
            {
                ChangeTheme.UpdateConfig("theme", "light");
                ca.UpdateTheme(account.ID, 1);
            } else if ("dark".Equals(theme))
            {
                ChangeTheme.UpdateConfig("theme", "dark");
                ca.UpdateTheme(account.ID, 2);
            } else if ("nature".Equals(theme))
            {
                ChangeTheme.UpdateConfig("theme", "nature");
                ca.UpdateTheme(account.ID, 3);
            }

            ChangeLanguage.UpdateCulture();

            this.Close();
        }
    }
}
