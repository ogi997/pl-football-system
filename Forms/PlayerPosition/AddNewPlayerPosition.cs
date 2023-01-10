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

namespace PLFootballSystem.Forms.PlayerPosition
{
    public partial class AddNewPlayerPosition : Form
    {
        ControllerPlayerPosition cpp = new ControllerPlayerPosition();
        public AddNewPlayerPosition()
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
            btnAddPlayerPosition.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnAddPlayerPosition.ForeColor = textColor;
            lblPlayerPosition.ForeColor = textColor;

        }

        private void btnAddPlayerPosition_Click(object sender, EventArgs e)
        {
            string positionName = tbPlayerPositionName.Text;

            if (string.IsNullOrEmpty(positionName))
            {
                MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Please input data." : "Унесите назив позиције.");
                return;
            }

            cpp.InsertPlayerPosition(positionName);
            MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully added." : "Успјешно додано.");
        }
    }
}
