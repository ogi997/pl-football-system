
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.panelSubMenuUser.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            resources.ApplyResources(this.panelSideMenu, "panelSideMenu");
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSideMenu.Controls.Add(this.panelSubMenuOther);
            this.panelSideMenu.Controls.Add(this.btnOther);
            this.panelSideMenu.Controls.Add(this.panelSubMenuPL);
            this.panelSideMenu.Controls.Add(this.btnPL);
            this.panelSideMenu.Controls.Add(this.btnAccount);
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Name = "panelSideMenu";
            // 
            // panelSubMenuOther
            // 
            this.panelSubMenuOther.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSubMenuOther.Controls.Add(this.btnSeason);
            this.panelSubMenuOther.Controls.Add(this.btnCity);
            this.panelSubMenuOther.Controls.Add(this.btnPosition);
            this.panelSubMenuOther.Controls.Add(this.btnCountry);
            resources.ApplyResources(this.panelSubMenuOther, "panelSubMenuOther");
            this.panelSubMenuOther.Name = "panelSubMenuOther";
            // 
            // btnSeason
            // 
            resources.ApplyResources(this.btnSeason, "btnSeason");
            this.btnSeason.FlatAppearance.BorderSize = 0;
            this.btnSeason.Name = "btnSeason";
            this.btnSeason.UseVisualStyleBackColor = true;
            this.btnSeason.Click += new System.EventHandler(this.btnSeason_Click);
            // 
            // btnCity
            // 
            resources.ApplyResources(this.btnCity, "btnCity");
            this.btnCity.FlatAppearance.BorderSize = 0;
            this.btnCity.Name = "btnCity";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // btnPosition
            // 
            resources.ApplyResources(this.btnPosition, "btnPosition");
            this.btnPosition.FlatAppearance.BorderSize = 0;
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnCountry
            // 
            resources.ApplyResources(this.btnCountry, "btnCountry");
            this.btnCountry.FlatAppearance.BorderSize = 0;
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // btnOther
            // 
            resources.ApplyResources(this.btnOther, "btnOther");
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.Name = "btnOther";
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
            resources.ApplyResources(this.panelSubMenuPL, "panelSubMenuPL");
            this.panelSubMenuPL.Name = "panelSubMenuPL";
            // 
            // btnClubToSeason
            // 
            resources.ApplyResources(this.btnClubToSeason, "btnClubToSeason");
            this.btnClubToSeason.FlatAppearance.BorderSize = 0;
            this.btnClubToSeason.Name = "btnClubToSeason";
            this.btnClubToSeason.UseVisualStyleBackColor = true;
            this.btnClubToSeason.Click += new System.EventHandler(this.btnClubToSeason_Click);
            // 
            // btnNewMatch
            // 
            resources.ApplyResources(this.btnNewMatch, "btnNewMatch");
            this.btnNewMatch.FlatAppearance.BorderSize = 0;
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.UseVisualStyleBackColor = true;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // btnPlayer
            // 
            resources.ApplyResources(this.btnPlayer, "btnPlayer");
            this.btnPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnNewFC
            // 
            resources.ApplyResources(this.btnNewFC, "btnNewFC");
            this.btnNewFC.FlatAppearance.BorderSize = 0;
            this.btnNewFC.Name = "btnNewFC";
            this.btnNewFC.UseVisualStyleBackColor = true;
            this.btnNewFC.Click += new System.EventHandler(this.btnNewFC_Click);
            // 
            // btnPL
            // 
            resources.ApplyResources(this.btnPL, "btnPL");
            this.btnPL.FlatAppearance.BorderSize = 0;
            this.btnPL.Name = "btnPL";
            this.btnPL.UseVisualStyleBackColor = true;
            this.btnPL.Click += new System.EventHandler(this.btnPL_Click);
            // 
            // btnAccount
            // 
            resources.ApplyResources(this.btnAccount, "btnAccount");
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::PLFootballSystem.Properties.Resources.logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTopBar.Controls.Add(this.panelSubMenuUser);
            this.panelTopBar.Controls.Add(this.lblUser);
            this.panelTopBar.Controls.Add(this.lblPath);
            resources.ApplyResources(this.panelTopBar, "panelTopBar");
            this.panelTopBar.Name = "panelTopBar";
            // 
            // panelSubMenuUser
            // 
            resources.ApplyResources(this.panelSubMenuUser, "panelSubMenuUser");
            this.panelSubMenuUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelSubMenuUser.Controls.Add(this.btnLogout);
            this.panelSubMenuUser.Controls.Add(this.btnSettings);
            this.panelSubMenuUser.Name = "panelSubMenuUser";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.Name = "lblUser";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblPath
            // 
            resources.ApplyResources(this.lblPath, "lblPath");
            this.lblPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPath.Name = "lblPath";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMain.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::PLFootballSystem.Properties.Resources.logo2;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // AdminForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuOther.ResumeLayout(false);
            this.panelSubMenuPL.ResumeLayout(false);
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