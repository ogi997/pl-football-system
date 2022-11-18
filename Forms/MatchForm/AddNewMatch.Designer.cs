
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
            ((System.ComponentModel.ISupportInitialize)(this.numGoalsHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalsAway)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeFC
            // 
            this.lblHomeFC.AutoSize = true;
            this.lblHomeFC.Location = new System.Drawing.Point(13, 13);
            this.lblHomeFC.Name = "lblHomeFC";
            this.lblHomeFC.Size = new System.Drawing.Size(98, 13);
            this.lblHomeFC.TabIndex = 0;
            this.lblHomeFC.Text = "Home Football club";
            // 
            // cbHomeFC
            // 
            this.cbHomeFC.FormattingEnabled = true;
            this.cbHomeFC.Location = new System.Drawing.Point(16, 30);
            this.cbHomeFC.Name = "cbHomeFC";
            this.cbHomeFC.Size = new System.Drawing.Size(121, 21);
            this.cbHomeFC.TabIndex = 1;
            // 
            // lblAwayFC
            // 
            this.lblAwayFC.AutoSize = true;
            this.lblAwayFC.Location = new System.Drawing.Point(13, 54);
            this.lblAwayFC.Name = "lblAwayFC";
            this.lblAwayFC.Size = new System.Drawing.Size(96, 13);
            this.lblAwayFC.TabIndex = 2;
            this.lblAwayFC.Text = "Away Football club";
            // 
            // cbAwayFC
            // 
            this.cbAwayFC.FormattingEnabled = true;
            this.cbAwayFC.Location = new System.Drawing.Point(16, 70);
            this.cbAwayFC.Name = "cbAwayFC";
            this.cbAwayFC.Size = new System.Drawing.Size(121, 21);
            this.cbAwayFC.TabIndex = 3;
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(13, 94);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(43, 13);
            this.lblSeason.TabIndex = 4;
            this.lblSeason.Text = "Season";
            // 
            // cbSeason
            // 
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Location = new System.Drawing.Point(16, 110);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(121, 21);
            this.cbSeason.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(13, 134);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(16, 151);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 20);
            this.dtDate.TabIndex = 7;
            // 
            // lblGoalsHome
            // 
            this.lblGoalsHome.AutoSize = true;
            this.lblGoalsHome.Location = new System.Drawing.Point(13, 174);
            this.lblGoalsHome.Name = "lblGoalsHome";
            this.lblGoalsHome.Size = new System.Drawing.Size(96, 13);
            this.lblGoalsHome.TabIndex = 8;
            this.lblGoalsHome.Text = "Goals for Home FC";
            // 
            // numGoalsHome
            // 
            this.numGoalsHome.Location = new System.Drawing.Point(17, 190);
            this.numGoalsHome.Name = "numGoalsHome";
            this.numGoalsHome.Size = new System.Drawing.Size(120, 20);
            this.numGoalsHome.TabIndex = 9;
            // 
            // lblGoalsAway
            // 
            this.lblGoalsAway.AutoSize = true;
            this.lblGoalsAway.Location = new System.Drawing.Point(15, 213);
            this.lblGoalsAway.Name = "lblGoalsAway";
            this.lblGoalsAway.Size = new System.Drawing.Size(94, 13);
            this.lblGoalsAway.TabIndex = 10;
            this.lblGoalsAway.Text = "Goals for Away FC";
            // 
            // numGoalsAway
            // 
            this.numGoalsAway.Location = new System.Drawing.Point(18, 229);
            this.numGoalsAway.Name = "numGoalsAway";
            this.numGoalsAway.Size = new System.Drawing.Size(120, 20);
            this.numGoalsAway.TabIndex = 11;
            // 
            // btnAddFirstTeam
            // 
            this.btnAddFirstTeam.Location = new System.Drawing.Point(186, 229);
            this.btnAddFirstTeam.Name = "btnAddFirstTeam";
            this.btnAddFirstTeam.Size = new System.Drawing.Size(100, 23);
            this.btnAddFirstTeam.TabIndex = 12;
            this.btnAddFirstTeam.Text = "Add first team";
            this.btnAddFirstTeam.UseVisualStyleBackColor = true;
            this.btnAddFirstTeam.Click += new System.EventHandler(this.btnAddFirstTeam_Click);
            // 
            // AddNewMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 285);
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
            this.Name = "AddNewMatch";
            this.Text = "AddNewMatch";
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
    }
}