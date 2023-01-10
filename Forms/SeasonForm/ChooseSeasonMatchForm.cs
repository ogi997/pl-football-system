using PLFootballSystem.Controller;
using PLFootballSystem.Forms.MatchForm;
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

namespace PLFootballSystem.Forms.SeasonForm
{
    public partial class ChooseSeasonMatchForm : Form
    {
        ControllerSeason cs = new ControllerSeason();
        public ChooseSeasonMatchForm()
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
            btnShowMatch.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnShowMatch.ForeColor = textColor;

            lblChooseSeason.ForeColor = textColor;
            // Change color of text
            //lblSearch.ForeColor = textColor;
            //.ForeColor = textColor;
            //lblRepeatPassword.ForeColor = textColor;
            //lblPassword.ForeColor = textColor;
        }

        private void GetData()
        {
            List<SeasonsModel> seasonsModels = cs.FindAll();

            cbChooseSeason.DisplayMember = "Name";
            cbChooseSeason.ValueMember = "ID";
            foreach (var c in seasonsModels)
            {
                cbChooseSeason.Items.Add(new { ID = c.ID, Name = c.year });
            }

            cbChooseSeason.SelectedIndex = 0;
        }

        private void btnShowMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            int seasonId = (cbChooseSeason.SelectedItem as dynamic).ID;

            new ShowAllMatchForm(seasonId).ShowDialog();

        }
    }
}
