using PLFootballSystem.Controller;
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

namespace PLFootballSystem.Forms.FirstTeamForm
{
    public partial class ShowFirstTeamForm : Form
    {
        Dictionary<int, Label> labels = new Dictionary<int, Label>();
        Dictionary<int, Label> labels2 = new Dictionary<int, Label>();
        int countForTag = 1;
        int countForTag2 = 1;
        int gap = 0;


        FormationModel home = new FormationModel();
        FormationModel away = new FormationModel();

        List<PlayerModel> homePlayers = new List<PlayerModel>();
        List<PlayerModel> awayPlayers = new List<PlayerModel>();

        ControllerPlayer cp = new ControllerPlayer();

        public ShowFirstTeamForm()
        {
            InitializeComponent();
            SetTheme();
        }

        public ShowFirstTeamForm(List<PlayerModel> playerHome, List<PlayerModel> playerAway, FormationModel formationHome, FormationModel formationAway)
        {
            InitializeComponent();

            home = formationHome;
            away = formationAway;

            homePlayers = playerHome;
            awayPlayers = playerAway;

            SetTheme();
            SetData();
            SetData2();
        }

        private void SetGap(int number)
        {
            switch (number)
            {
                case 1: gap = 210; break;
                case 2: gap = 85; break;
                case 3: gap = 25; break;
                case 4: gap = 15; break;
                case 5: gap = 3; break;
                case 6: gap = 1; break;
            }
        }

        private void SetData()
        {
            string[] array = home.Description.Split('-');
            int numberOfDefence = int.Parse(array[0]);
            int numberOfMidfield = int.Parse(array[1]);
            int numberOfAttack = int.Parse(array[2]);

            int locationDefense = pDefense.Width / numberOfDefence;
            int locationMidfield = pMidfield.Width / numberOfMidfield;
            int locationAttack = pAttack.Width / numberOfAttack;

            pbGoalkeeper.Width = 75;
            pbGoalkeeper.Height = 65;
            pbGoalkeeper.BackColor = Color.Transparent;
            labels.Add(0, lblGoalkeeper);

            foreach(var pl in homePlayers)
            {
                if (pl.pos == 0)
                {
                    PlayerModel p = cp.FindByPlayerId(pl.ID);
                    pbGoalkeeper.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
                    lblGoalkeeper.Text = p.Name;
                }
            }

            PictureBox pictureBox = null;
            Label label = null;

            //defense
            SetGap(numberOfDefence);
            for (int i = 0; i < numberOfDefence; i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Tag = countForTag;
                pictureBox.Width = 75;
                pictureBox.Height = 75;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point((locationDefense * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                
                pDefense.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationDefense * i) + gap, 95);


                foreach(var pl in homePlayers)
                {
                    if (pl.pos == countForTag)
                    {
                        PlayerModel p = cp.FindByPlayerId(pl.ID);
                        pictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
                        label.Text = p.Name;
                    }
                }

                pDefense.Controls.Add(label);
                labels.Add(countForTag, label);
                countForTag++;
            }

            //midfield
            SetGap(numberOfMidfield);
            for (int i = 0; i < numberOfMidfield; i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Tag = countForTag;
                pictureBox.Width = 75;
                pictureBox.Height = 75;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point((locationMidfield * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pMidfield.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationMidfield * i) + gap, 95);


                foreach (var pl in homePlayers)
                {
                    if (pl.pos == countForTag)
                    {
                        PlayerModel p = cp.FindByPlayerId(pl.ID);
                        pictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
                        label.Text = p.Name;
                    }
                }

                pMidfield.Controls.Add(label);
                labels.Add(countForTag, label);
                countForTag++;
            }

            //attack
            SetGap(numberOfAttack);
            for (int i = 0; i < numberOfAttack; i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Tag = countForTag;
                pictureBox.Width = 75;
                pictureBox.Height = 75;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point((locationAttack * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pAttack.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationAttack * i) + gap, 95);


                foreach (var pl in homePlayers)
                {
                    if (pl.pos == countForTag)
                    {
                        PlayerModel p = cp.FindByPlayerId(pl.ID);
                        pictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
                        label.Text = p.Name;
                    }
                }

                pAttack.Controls.Add(label);
                labels.Add(countForTag, label);
                countForTag++;
            }
        }

        private void SetData2()
        {
            string[] array = away.Description.Split('-');
            int numberOfDefence = int.Parse(array[0]);
            int numberOfMidfield = int.Parse(array[1]);
            int numberOfAttack = int.Parse(array[2]);

            int locationDefense = pDefense2.Width / numberOfDefence;
            int locationMidfield = pMidfield2.Width / numberOfMidfield;
            int locationAttack = pAttack2.Width / numberOfAttack;

            pbGoalkeeper2.Width = 75;
            pbGoalkeeper2.Height = 65;
            pbGoalkeeper2.BackColor = Color.Transparent;

            foreach (var pl in awayPlayers)
            {
                if (pl.pos == 0)
                {
                    PlayerModel p = cp.FindByPlayerId(pl.ID);
                    pbGoalkeeper2.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
                    lblGoalkeeper2.Text = p.Name;
                }
            }
            labels2.Add(0, lblGoalkeeper2);


            PictureBox pictureBox = null;
            Label label = null;

            //defense
            SetGap(numberOfDefence);
            for (int i = 0; i < numberOfDefence; i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Tag = countForTag2;
                pictureBox.Width = 75;
                pictureBox.Height = 75;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point((locationDefense * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pDefense2.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationDefense * i) + gap, 95);

                foreach (var pl in awayPlayers)
                {
                    if (pl.pos == countForTag2)
                    {
                        PlayerModel p = cp.FindByPlayerId(pl.ID);
                        pictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
                        label.Text = p.Name;
                    }
                }

                pDefense2.Controls.Add(label);
                labels2.Add(countForTag2, label);
                countForTag2++;
            }

            //midfield
            SetGap(numberOfMidfield);
            for (int i = 0; i < numberOfMidfield; i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Tag = countForTag2;
                pictureBox.Width = 75;
                pictureBox.Height = 75;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point((locationMidfield * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pMidfield2.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag2;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationMidfield * i) + gap, 95);

                foreach (var pl in awayPlayers)
                {
                    if (pl.pos == countForTag2)
                    {
                        PlayerModel p = cp.FindByPlayerId(pl.ID);
                        pictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
                        label.Text = p.Name;
                    }
                }

                pMidfield2.Controls.Add(label);
                labels2.Add(countForTag2, label);
                countForTag2++;
            }

            //attack
            SetGap(numberOfAttack);
            for (int i = 0; i < numberOfAttack; i++)
            {
                pictureBox = new PictureBox();
                pictureBox.Tag = countForTag2;
                pictureBox.Width = 75;
                pictureBox.Height = 75;
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point((locationAttack * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pAttack2.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag2;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationAttack * i) + gap, 95);


                foreach (var pl in awayPlayers)
                {
                    Console.WriteLine(pl.Name);
                    if (pl.pos == countForTag2)
                    {
                        PlayerModel p = cp.FindByPlayerId(pl.ID);
                        pictureBox.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
                        label.Text = p.Name;
                    }
                }

                pAttack2.Controls.Add(label);
                labels2.Add(countForTag2, label);
                countForTag2++;
            }
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
            btnClose.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnClose.ForeColor = textColor;
            foreach(Label label in labels.Values)
            {
                label.ForeColor = textColor;
            }

            foreach (Label label in labels2.Values)
            {
                label.ForeColor = textColor;
            }
        }

        public void ShowPlayerProfile(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int playerId = (int)p.Tag;

            new ShowPlayerForm(playerId).ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb2Player1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowPlayerProfile(sender, e);
        }
    }
}
