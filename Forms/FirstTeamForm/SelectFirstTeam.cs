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
    public partial class SelectFirstTeam : Form
    {
        int countForTag = 1;
        int countForTag2 = 1;
        int gap = 0;

        public static Dictionary<int, int> homePlayers = new Dictionary<int, int>();
        public static Dictionary<int, int> awayPlayers = new Dictionary<int, int>();
        MatchModel matchModel = new MatchModel();
        ControllerPlayer cp = new ControllerPlayer();
        ControllerMatch cm = new ControllerMatch();
        ControllerFirstTeam cft = new ControllerFirstTeam();

        Dictionary<int, Label> labels = new Dictionary<int, Label>();
        Dictionary<int, Label> labels2 = new Dictionary<int, Label>();

        FormationModel homeFormation = new FormationModel();
        FormationModel awayFormation = new FormationModel();
        public SelectFirstTeam()
        {
            InitializeComponent();
            SetData();
            SetData2();
        }
        public SelectFirstTeam(MatchModel match, FormationModel home, FormationModel away)
        {
            InitializeComponent();
            matchModel = match;
            homeFormation = home;
            awayFormation = away;
            SetData();
            SetData2();
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
            btnAddFirstTeam.BackColor = primaryColor;

            this.BackColor = secondaryColor;
        }

        private void ChangeTextColor(Color textColor)
        {
            btnAddFirstTeam.ForeColor = textColor;
           
        }


        private void SetGap(int number)
        {
            switch(number)
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
            string[] array = homeFormation.Description.Split('-');
            int numberOfDefence = int.Parse(array[0]);
            int numberOfMidfield = int.Parse(array[1]);
            int numberOfAttack = int.Parse(array[2]);

            int locationDefense = pDefense.Width / numberOfDefence;
            int locationMidfield = pMidfield.Width / numberOfMidfield;
            int locationAttack = pAttack.Width / numberOfAttack;

            pbGoalkeeper.Width = 75;
            pbGoalkeeper.Height = 65;
            pbGoalkeeper.Click += new EventHandler(clickEvent);

            lblGoalkeeper.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Unknown" : "Непознато";
            labels.Add(0, lblGoalkeeper);

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
                pictureBox.Image = Properties.Resources.clickMe;
                pictureBox.Location = new Point((locationDefense * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new EventHandler(clickEvent);
                pDefense.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationDefense * i) + gap, 95);
                
                label.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Unknown" : "Непознато";
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
                pictureBox.Image = Properties.Resources.clickMe;
                pictureBox.Location = new Point((locationMidfield * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new EventHandler(clickEvent);
                pMidfield.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationMidfield * i) + gap, 95);

                label.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Unknown" : "Непознато";
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
                pictureBox.Image = Properties.Resources.clickMe;
                pictureBox.Location = new Point((locationAttack * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new EventHandler(clickEvent);
                pAttack.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationAttack * i) + gap, 95);

                label.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Unknown" : "Непознато";
                pAttack.Controls.Add(label);
                labels.Add(countForTag, label);
                countForTag++;
            }
        }

        private void SetData2()
        {
            string[] array = awayFormation.Description.Split('-');
            int numberOfDefence = int.Parse(array[0]);
            int numberOfMidfield = int.Parse(array[1]);
            int numberOfAttack = int.Parse(array[2]);

            int locationDefense = pDefense2.Width / numberOfDefence;
            int locationMidfield = pMidfield2.Width / numberOfMidfield;
            int locationAttack = pAttack2.Width / numberOfAttack;

            pbGoalkeeper2.Width = 75;
            pbGoalkeeper2.Height = 65;
            pbGoalkeeper2.Click += new EventHandler(clickEvent2);
            lblGoalkeeper2.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Unknown" : "Непознато";
            labels2.Add(0, lblGoalkeeper2);
            //pbGoalkeeper.Tag = 0;

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
                pictureBox.Image = Properties.Resources.clickMe;
                pictureBox.Location = new Point((locationDefense * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new EventHandler(clickEvent2);
                pDefense2.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationDefense * i) + gap, 95);

                label.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Unknown" : "Непознато";
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
                pictureBox.Image = Properties.Resources.clickMe;
                pictureBox.Location = new Point((locationMidfield * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new EventHandler(clickEvent2);
                pMidfield2.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationMidfield * i) + gap, 95);

                label.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Unknown" : "Непознато";
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
                pictureBox.Image = Properties.Resources.clickMe;
                pictureBox.Location = new Point((locationAttack * i) + gap, 15);
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += new EventHandler(clickEvent2);
                pAttack2.Controls.Add(pictureBox);

                label = new Label();
                label.Name = "lblPlayer" + countForTag2;
                label.BackColor = Color.Transparent;
                label.Width = 50;
                label.Location = new Point((locationAttack * i) + gap, 95);

                label.Text = "en".Equals(ChangeLanguage.GetLanguage()) ? "Unknown" : "Непознато";
                pAttack2.Controls.Add(label);
                labels2.Add(countForTag2, label);
                countForTag2++;
            }
        }

        private void clickEvent(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
           // Console.WriteLine(picture.Tag);
            new SelectPlayerForFirstTeam(matchModel.FCHome.ID, Convert.ToInt32(picture.Tag), true).ShowDialog();

            if (!homePlayers.ContainsKey(Convert.ToInt32(picture.Tag)))
                return;

            int playerId = homePlayers[Convert.ToInt32(picture.Tag)];
            PlayerModel p = cp.FindByPlayerId(playerId);
            //Console.WriteLine(p.Name);
            //Console.WriteLine(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
            picture.BackColor = Color.Transparent;
            picture.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
            labels[Convert.ToInt32(picture.Tag)].Text = p.Name;
            
        }

        private void clickEvent2(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            //Console.WriteLine(picture.Tag);
            new SelectPlayerForFirstTeam(matchModel.FCAway.ID, Convert.ToInt32(picture.Tag), false).ShowDialog();

            if (!awayPlayers.ContainsKey(Convert.ToInt32(picture.Tag)))
                return;

            int playerId = awayPlayers[Convert.ToInt32(picture.Tag)];
            PlayerModel p = cp.FindByPlayerId(playerId);
           // Console.WriteLine(p.Name);
           // Console.WriteLine(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
            picture.BackColor = Color.Transparent;
            picture.Image = Image.FromFile(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + WrapperPlayer.FOLDER + Path.DirectorySeparatorChar + p.ImageName);
            labels2[Convert.ToInt32(picture.Tag)].Text = p.Name;

        }

        private void btnAddFirstTeam_Click(object sender, EventArgs e)
        {
            Console.WriteLine(homePlayers.Count + " " + awayPlayers.Count);
             if (homePlayers.Count < 11 || awayPlayers.Count < 11)
             {
                 MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "You must have 11 players in first team." : "Морате изабрати по 11 играча за клубове.");
                 return;
             }
            //Add match
            int? matchId = cm.InsertMatch(matchModel);

            //Add home first team
            foreach (var playerId in homePlayers)
            {
                FirstTeamModel firstTeamHomeModel = new FirstTeamModel
                {
                    FC = new FootballClubModel { ID = matchModel.FCHome.ID },
                    Match = new MatchModel { ID = (int)matchId },
                    Player = new PlayerModel { ID = playerId.Value }
                };
                //Add to database
                cft.InsertFirstTeam(firstTeamHomeModel, homeFormation.ID, playerId.Key);
            }

            //add away first team
            foreach (var playerId in awayPlayers)
            {
                FirstTeamModel firstTeamAwayModel = new FirstTeamModel
                {
                    FC = new FootballClubModel { ID = matchModel.FCAway.ID },
                    Match = new MatchModel { ID = (int)matchId },
                    Player = new PlayerModel { ID = playerId.Value }
                };

                //Add to databse
                cft.InsertFirstTeam(firstTeamAwayModel, awayFormation.ID, playerId.Key);
            }

            MessageBox.Show("en".Equals(ChangeLanguage.GetLanguage()) ? "Successfully added." : "Успјешно додано.");
            homePlayers.Clear();
            awayPlayers.Clear();
            this.Close();
        }
    }
}
