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

namespace PLFootballSystem.Forms.FootballClubForm
{
    public partial class ChooseFootballClubForm : Form
    {
        ControllerFootballClub cfc = new ControllerFootballClub();
        public ChooseFootballClubForm()
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
            btnShowFC.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnShowFC.ForeColor = textColor;
            lblChooseFC.ForeColor = textColor;
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
        }

        private void btnShowFC_Click(object sender, EventArgs e)
        {
            this.Hide();
            int footballClubId = (cbFootballClub.SelectedItem as dynamic).ID;
            FootballClubModel footballClubModel = cfc.FindByClubId(footballClubId);

            new ShowFootballClubForm(footballClubModel).ShowDialog();
        }
    }
}
