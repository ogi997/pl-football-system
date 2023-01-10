
namespace PLFootballSystem.Forms.MatchForm
{
    partial class AddNewMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewMatch));
            this.lblHomeFC = new System.Windows.Forms.Label();
            this.cbHomeFC = new System.Windows.Forms.ComboBox();
            this.lblAwayFC = new System.Windows.Forms.Label();
            this.cbAwayFC = new System.Windows.Forms.ComboBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblGoalsHome = new System.Windows.Forms.Label();
            this.numGoalsHome = new System.Windows.Forms.NumericUpDown();
            this.lblGoalsAway = new System.Windows.Forms.Label();
            this.numGoalsAway = new System.Windows.Forms.NumericUpDown();
            this.btnAddFirstTeam = new System.Windows.Forms.Button();
            this.lblFormationHome = new System.Windows.Forms.Label();
            this.cbHomeFormation = new System.Windows.Forms.ComboBox();
            this.lblAwayFormation = new System.Windows.Forms.Label();
            this.cbAwayFormation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalsHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalsAway)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeFC
            // 
            resources.ApplyResources(this.lblHomeFC, "lblHomeFC");
            this.lblHomeFC.Name = "lblHomeFC";
            // 
            // cbHomeFC
            // 
            resources.ApplyResources(this.cbHomeFC, "cbHomeFC");
            this.cbHomeFC.FormattingEnabled = true;
            this.cbHomeFC.Name = "cbHomeFC";
            // 
            // lblAwayFC
            // 
            resources.ApplyResources(this.lblAwayFC, "lblAwayFC");
            this.lblAwayFC.Name = "lblAwayFC";
            // 
            // cbAwayFC
            // 
            resources.ApplyResources(this.cbAwayFC, "cbAwayFC");
            this.cbAwayFC.FormattingEnabled = true;
            this.cbAwayFC.Name = "cbAwayFC";
            // 
            // lblSeason
            // 
            resources.ApplyResources(this.lblSeason, "lblSeason");
            this.lblSeason.Name = "lblSeason";
            // 
            // cbSeason
            // 
            resources.ApplyResources(this.cbSeason, "cbSeason");
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Name = "cbSeason";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // dtDate
            // 
            resources.ApplyResources(this.dtDate, "dtDate");
            this.dtDate.Name = "dtDate";
            // 
            // lblGoalsHome
            // 
            resources.ApplyResources(this.lblGoalsHome, "lblGoalsHome");
            this.lblGoalsHome.Name = "lblGoalsHome";
            // 
            // numGoalsHome
            // 
            resources.ApplyResources(this.numGoalsHome, "numGoalsHome");
            this.numGoalsHome.Name = "numGoalsHome";
            // 
            // lblGoalsAway
            // 
            resources.ApplyResources(this.lblGoalsAway, "lblGoalsAway");
            this.lblGoalsAway.Name = "lblGoalsAway";
            // 
            // numGoalsAway
            // 
            resources.ApplyResources(this.numGoalsAway, "numGoalsAway");
            this.numGoalsAway.Name = "numGoalsAway";
            // 
            // btnAddFirstTeam
            // 
            resources.ApplyResources(this.btnAddFirstTeam, "btnAddFirstTeam");
            this.btnAddFirstTeam.FlatAppearance.BorderSize = 0;
            this.btnAddFirstTeam.Name = "btnAddFirstTeam";
            this.btnAddFirstTeam.UseVisualStyleBackColor = true;
            this.btnAddFirstTeam.Click += new System.EventHandler(this.btnAddFirstTeam_Click);
            // 
            // lblFormationHome
            // 
            resources.ApplyResources(this.lblFormationHome, "lblFormationHome");
            this.lblFormationHome.Name = "lblFormationHome";
            // 
            // cbHomeFormation
            // 
            resources.ApplyResources(this.cbHomeFormation, "cbHomeFormation");
            this.cbHomeFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHomeFormation.FormattingEnabled = true;
            this.cbHomeFormation.Name = "cbHomeFormation";
            // 
            // lblAwayFormation
            // 
            resources.ApplyResources(this.lblAwayFormation, "lblAwayFormation");
            this.lblAwayFormation.Name = "lblAwayFormation";
            // 
            // cbAwayFormation
            // 
            resources.ApplyResources(this.cbAwayFormation, "cbAwayFormation");
            this.cbAwayFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAwayFormation.FormattingEnabled = true;
            this.cbAwayFormation.Name = "cbAwayFormation";
            // 
            // AddNewMatch
            // 
            this.AcceptButton = this.btnAddFirstTeam;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbAwayFormation);
            this.Controls.Add(this.lblAwayFormation);
            this.Controls.Add(this.cbHomeFormation);
            this.Controls.Add(this.lblFormationHome);
            this.Controls.Add(this.btnAddFirstTeam);
            this.Controls.Add(this.numGoalsAway);
            this.Controls.Add(this.lblGoalsAway);
            this.Controls.Add(this.numGoalsHome);
            this.Controls.Add(this.lblGoalsHome);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbSeason);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.cbAwayFC);
            this.Controls.Add(this.lblAwayFC);
            this.Controls.Add(this.cbHomeFC);
            this.Controls.Add(this.lblHomeFC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewMatch";
            ((System.ComponentModel.ISupportInitialize)(this.numGoalsHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalsAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeFC;
        private System.Windows.Forms.ComboBox cbHomeFC;
        private System.Windows.Forms.Label lblAwayFC;
        private System.Windows.Forms.ComboBox cbAwayFC;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.ComboBox cbSeason;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblGoalsHome;
        private System.Windows.Forms.NumericUpDown numGoalsHome;
        private System.Windows.Forms.Label lblGoalsAway;
        private System.Windows.Forms.NumericUpDown numGoalsAway;
        private System.Windows.Forms.Button btnAddFirstTeam;
        private System.Windows.Forms.Label lblFormationHome;
        private System.Windows.Forms.ComboBox cbHomeFormation;
        private System.Windows.Forms.Label lblAwayFormation;
        private System.Windows.Forms.ComboBox cbAwayFormation;
    }
}