
namespace PLFootballSystem.Forms
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuOther = new System.Windows.Forms.Panel();
            this.btnSeason = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.panelSubMenuPL = new System.Windows.Forms.Panel();
            this.btnClubToSeason = new System.Windows.Forms.Button();
            this.btnNewMatch = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnNewFC = new System.Windows.Forms.Button();
            this.btnPL = new System.Windows.Forms.Button();
            this.panelSubMenuAccount = new System.Windows.Forms.Panel();
            this.btnAddNewAccount = new System.Windows.Forms.Button();
            this.btnAllAccount = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.panelSubMenuUser = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuOther.SuspendLayout();
            this.panelSubMenuPL.SuspendLayout();
            this.panelSubMenuAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.panelSubMenuUser.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSideMenu.Controls.Add(this.panelSubMenuOther);
            this.panelSideMenu.Controls.Add(this.btnOther);
            this.panelSideMenu.Controls.Add(this.panelSubMenuPL);
            this.panelSideMenu.Controls.Add(this.btnPL);
            this.panelSideMenu.Controls.Add(this.panelSubMenuAccount);
            this.panelSideMenu.Controls.Add(this.btnAccount);
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 635);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSubMenuOther
            // 
            this.panelSubMenuOther.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSubMenuOther.Controls.Add(this.btnSeason);
            this.panelSubMenuOther.Controls.Add(this.btnCity);
            this.panelSubMenuOther.Controls.Add(this.btnPosition);
            this.panelSubMenuOther.Controls.Add(this.btnCountry);
            this.panelSubMenuOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuOther.Location = new System.Drawing.Point(0, 452);
            this.panelSubMenuOther.Name = "panelSubMenuOther";
            this.panelSubMenuOther.Size = new System.Drawing.Size(250, 130);
            this.panelSubMenuOther.TabIndex = 6;
            // 
            // btnSeason
            // 
            this.btnSeason.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeason.Location = new System.Drawing.Point(0, 90);
            this.btnSeason.Name = "btnSeason";
            this.btnSeason.Size = new System.Drawing.Size(250, 30);
            this.btnSeason.TabIndex = 3;
            this.btnSeason.Text = "Add new season";
            this.btnSeason.UseVisualStyleBackColor = true;
            this.btnSeason.Click += new System.EventHandler(this.btnSeason_Click);
            // 
            // btnCity
            // 
            this.btnCity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCity.Location = new System.Drawing.Point(0, 60);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(250, 30);
            this.btnCity.TabIndex = 2;
            this.btnCity.Text = "Add new city";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPosition.Location = new System.Drawing.Point(0, 30);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(250, 30);
            this.btnPosition.TabIndex = 1;
            this.btnPosition.Text = "Add new player position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCountry.Location = new System.Drawing.Point(0, 0);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(250, 30);
            this.btnCountry.TabIndex = 0;
            this.btnCountry.Text = "Add new Country";
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // btnOther
            // 
            this.btnOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOther.Location = new System.Drawing.Point(0, 407);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(250, 45);
            this.btnOther.TabIndex = 5;
            this.btnOther.Text = "Add other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // panelSubMenuPL
            // 
            this.panelSubMenuPL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSubMenuPL.Controls.Add(this.btnClubToSeason);
            this.panelSubMenuPL.Controls.Add(this.btnNewMatch);
            this.panelSubMenuPL.Controls.Add(this.btnPlayer);
            this.panelSubMenuPL.Controls.Add(this.btnNewFC);
            this.panelSubMenuPL.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPL.Location = new System.Drawing.Point(0, 279);
            this.panelSubMenuPL.Name = "panelSubMenuPL";
            this.panelSubMenuPL.Size = new System.Drawing.Size(250, 128);
            this.panelSubMenuPL.TabIndex = 4;
            // 
            // btnClubToSeason
            // 
            this.btnClubToSeason.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClubToSeason.Location = new System.Drawing.Point(0, 90);
            this.btnClubToSeason.Name = "btnClubToSeason";
            this.btnClubToSeason.Size = new System.Drawing.Size(250, 30);
            this.btnClubToSeason.TabIndex = 3;
            this.btnClubToSeason.Text = "Add club to season";
            this.btnClubToSeason.UseVisualStyleBackColor = true;
            this.btnClubToSeason.Click += new System.EventHandler(this.btnClubToSeason_Click);
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewMatch.Location = new System.Drawing.Point(0, 60);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(250, 30);
            this.btnNewMatch.TabIndex = 2;
            this.btnNewMatch.Text = "Add new match";
            this.btnNewMatch.UseVisualStyleBackColor = true;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // btnPlayer
            // 
            this.btnPlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayer.Location = new System.Drawing.Point(0, 30);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(250, 30);
            this.btnPlayer.TabIndex = 1;
            this.btnPlayer.Text = "Player";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnNewFC
            // 
            this.btnNewFC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewFC.Location = new System.Drawing.Point(0, 0);
            this.btnNewFC.Name = "btnNewFC";
            this.btnNewFC.Size = new System.Drawing.Size(250, 30);
            this.btnNewFC.TabIndex = 0;
            this.btnNewFC.Text = "Football Club";
            this.btnNewFC.UseVisualStyleBackColor = true;
            this.btnNewFC.Click += new System.EventHandler(this.btnNewFC_Click);
            // 
            // btnPL
            // 
            this.btnPL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPL.Location = new System.Drawing.Point(0, 234);
            this.btnPL.Name = "btnPL";
            this.btnPL.Size = new System.Drawing.Size(250, 45);
            this.btnPL.TabIndex = 3;
            this.btnPL.Text = "Premier League";
            this.btnPL.UseVisualStyleBackColor = true;
            this.btnPL.Click += new System.EventHandler(this.btnPL_Click);
            // 
            // panelSubMenuAccount
            // 
            this.panelSubMenuAccount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSubMenuAccount.Controls.Add(this.btnAddNewAccount);
            this.panelSubMenuAccount.Controls.Add(this.btnAllAccount);
            this.panelSubMenuAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuAccount.Location = new System.Drawing.Point(0, 167);
            this.panelSubMenuAccount.Name = "panelSubMenuAccount";
            this.panelSubMenuAccount.Size = new System.Drawing.Size(250, 67);
            this.panelSubMenuAccount.TabIndex = 2;
            // 
            // btnAddNewAccount
            // 
            this.btnAddNewAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewAccount.Location = new System.Drawing.Point(0, 30);
            this.btnAddNewAccount.Name = "btnAddNewAccount";
            this.btnAddNewAccount.Size = new System.Drawing.Size(250, 30);
            this.btnAddNewAccount.TabIndex = 2;
            this.btnAddNewAccount.Text = "Add new account";
            this.btnAddNewAccount.UseVisualStyleBackColor = true;
            this.btnAddNewAccount.Click += new System.EventHandler(this.btnAddNewAccount_Click);
            // 
            // btnAllAccount
            // 
            this.btnAllAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllAccount.Location = new System.Drawing.Point(0, 0);
            this.btnAllAccount.Name = "btnAllAccount";
            this.btnAllAccount.Size = new System.Drawing.Size(250, 30);
            this.btnAllAccount.TabIndex = 0;
            this.btnAllAccount.Text = "All account";
            this.btnAllAccount.UseVisualStyleBackColor = true;
            this.btnAllAccount.Click += new System.EventHandler(this.btnAllAccount_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.Location = new System.Drawing.Point(0, 122);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(250, 45);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Accounts";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::PLFootballSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTopBar.Controls.Add(this.panelSubMenuUser);
            this.panelTopBar.Controls.Add(this.lblUser);
            this.panelTopBar.Controls.Add(this.lblPath);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(250, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(684, 77);
            this.panelTopBar.TabIndex = 1;
            // 
            // panelSubMenuUser
            // 
            this.panelSubMenuUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubMenuUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelSubMenuUser.Controls.Add(this.btnLogout);
            this.panelSubMenuUser.Controls.Add(this.btnSettings);
            this.panelSubMenuUser.Location = new System.Drawing.Point(565, 26);
            this.panelSubMenuUser.Name = "panelSubMenuUser";
            this.panelSubMenuUser.Size = new System.Drawing.Size(100, 48);
            this.panelSubMenuUser.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 21);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 21);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Location = new System.Drawing.Point(637, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "label1";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblPath
            // 
            this.lblPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 32);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(35, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "label1";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 77);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(684, 558);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::PLFootballSystem.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(154, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(401, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 635);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuOther.ResumeLayout(false);
            this.panelSubMenuPL.ResumeLayout(false);
            this.panelSubMenuAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelSubMenuUser.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMenuAccount;
        private System.Windows.Forms.Button btnAddNewAccount;
        private System.Windows.Forms.Button btnAllAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panelSubMenuUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelSubMenuOther;
        private System.Windows.Forms.Button btnSeason;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Panel panelSubMenuPL;
        private System.Windows.Forms.Button btnClubToSeason;
        private System.Windows.Forms.Button btnNewMatch;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnNewFC;
        private System.Windows.Forms.Button btnPL;
    }
}