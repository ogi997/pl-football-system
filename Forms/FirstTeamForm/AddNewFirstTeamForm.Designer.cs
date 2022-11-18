
namespace PLFootballSystem.Forms.FirstTeamForm
{
    partial class AddNewFirstTeamForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.lvFirstTeamHome = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAllPlayersHome = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAllPlayersAway = new System.Windows.Forms.Label();
            this.lblFirstTeamAway = new System.Windows.Forms.Label();
            this.btnRemoveFirstTeam = new System.Windows.Forms.Button();
            this.btnAddFirstTeam = new System.Windows.Forms.Button();
            this.lvFirstTeamAway = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAllPlayersAway = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnRemovePlayer);
            this.tabPage1.Controls.Add(this.btnAddPlayer);
            this.tabPage1.Controls.Add(this.lvFirstTeamHome);
            this.tabPage1.Controls.Add(this.lvAllPlayersHome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home football club";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First team player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "All players home fc";
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(339, 134);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(27, 23);
            this.btnRemovePlayer.TabIndex = 4;
            this.btnRemovePlayer.Text = "<<";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(339, 105);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(27, 23);
            this.btnAddPlayer.TabIndex = 3;
            this.btnAddPlayer.Text = ">>";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // lvFirstTeamHome
            // 
            this.lvFirstTeamHome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.position});
            this.lvFirstTeamHome.FullRowSelect = true;
            this.lvFirstTeamHome.HideSelection = false;
            this.lvFirstTeamHome.Location = new System.Drawing.Point(376, 34);
            this.lvFirstTeamHome.Name = "lvFirstTeamHome";
            this.lvFirstTeamHome.Size = new System.Drawing.Size(302, 224);
            this.lvFirstTeamHome.TabIndex = 2;
            this.lvFirstTeamHome.UseCompatibleStateImageBehavior = false;
            this.lvFirstTeamHome.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Player name";
            this.name.Width = 144;
            // 
            // position
            // 
            this.position.Text = "Position";
            this.position.Width = 153;
            // 
            // lvAllPlayersHome
            // 
            this.lvAllPlayersHome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAllPlayersHome.FullRowSelect = true;
            this.lvAllPlayersHome.HideSelection = false;
            this.lvAllPlayersHome.Location = new System.Drawing.Point(9, 34);
            this.lvAllPlayersHome.Name = "lvAllPlayersHome";
            this.lvAllPlayersHome.Size = new System.Drawing.Size(319, 224);
            this.lvAllPlayersHome.TabIndex = 0;
            this.lvAllPlayersHome.UseCompatibleStateImageBehavior = false;
            this.lvAllPlayersHome.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblFirstTeamAway);
            this.tabPage2.Controls.Add(this.btnRemoveFirstTeam);
            this.tabPage2.Controls.Add(this.btnAddFirstTeam);
            this.tabPage2.Controls.Add(this.lvFirstTeamAway);
            this.tabPage2.Controls.Add(this.lvAllPlayersAway);
            this.tabPage2.Controls.Add(this.lblAllPlayersAway);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Away football club";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddMatch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(526, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(607, 12);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(75, 23);
            this.btnAddMatch.TabIndex = 0;
            this.btnAddMatch.Text = "Add match";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Player name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Position";
            this.columnHeader2.Width = 165;
            // 
            // lblAllPlayersAway
            // 
            this.lblAllPlayersAway.AutoSize = true;
            this.lblAllPlayersAway.Location = new System.Drawing.Point(9, 7);
            this.lblAllPlayersAway.Name = "lblAllPlayersAway";
            this.lblAllPlayersAway.Size = new System.Drawing.Size(94, 13);
            this.lblAllPlayersAway.TabIndex = 0;
            this.lblAllPlayersAway.Text = "All players away fc";
            // 
            // lblFirstTeamAway
            // 
            this.lblFirstTeamAway.AutoSize = true;
            this.lblFirstTeamAway.Location = new System.Drawing.Point(376, 2);
            this.lblFirstTeamAway.Name = "lblFirstTeamAway";
            this.lblFirstTeamAway.Size = new System.Drawing.Size(83, 13);
            this.lblFirstTeamAway.TabIndex = 12;
            this.lblFirstTeamAway.Text = "First team player";
            // 
            // btnRemoveFirstTeam
            // 
            this.btnRemoveFirstTeam.Location = new System.Drawing.Point(342, 132);
            this.btnRemoveFirstTeam.Name = "btnRemoveFirstTeam";
            this.btnRemoveFirstTeam.Size = new System.Drawing.Size(27, 23);
            this.btnRemoveFirstTeam.TabIndex = 10;
            this.btnRemoveFirstTeam.Text = "<<";
            this.btnRemoveFirstTeam.UseVisualStyleBackColor = true;
            this.btnRemoveFirstTeam.Click += new System.EventHandler(this.btnRemoveFirstTeam_Click);
            // 
            // btnAddFirstTeam
            // 
            this.btnAddFirstTeam.Location = new System.Drawing.Point(342, 103);
            this.btnAddFirstTeam.Name = "btnAddFirstTeam";
            this.btnAddFirstTeam.Size = new System.Drawing.Size(27, 23);
            this.btnAddFirstTeam.TabIndex = 9;
            this.btnAddFirstTeam.Text = ">>";
            this.btnAddFirstTeam.UseVisualStyleBackColor = true;
            this.btnAddFirstTeam.Click += new System.EventHandler(this.btnAddFirstTeam_Click);
            // 
            // lvFirstTeamAway
            // 
            this.lvFirstTeamAway.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvFirstTeamAway.FullRowSelect = true;
            this.lvFirstTeamAway.HideSelection = false;
            this.lvFirstTeamAway.Location = new System.Drawing.Point(379, 32);
            this.lvFirstTeamAway.Name = "lvFirstTeamAway";
            this.lvFirstTeamAway.Size = new System.Drawing.Size(302, 224);
            this.lvFirstTeamAway.TabIndex = 8;
            this.lvFirstTeamAway.UseCompatibleStateImageBehavior = false;
            this.lvFirstTeamAway.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Player name";
            this.columnHeader3.Width = 144;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Position";
            this.columnHeader4.Width = 153;
            // 
            // lvAllPlayersAway
            // 
            this.lvAllPlayersAway.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvAllPlayersAway.FullRowSelect = true;
            this.lvAllPlayersAway.HideSelection = false;
            this.lvAllPlayersAway.Location = new System.Drawing.Point(12, 32);
            this.lvAllPlayersAway.Name = "lvAllPlayersAway";
            this.lvAllPlayersAway.Size = new System.Drawing.Size(319, 224);
            this.lvAllPlayersAway.TabIndex = 7;
            this.lvAllPlayersAway.UseCompatibleStateImageBehavior = false;
            this.lvAllPlayersAway.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Player name";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Position";
            this.columnHeader6.Width = 165;
            // 
            // AddNewFirstTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 347);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddNewFirstTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewFirstTeamForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.ListView lvFirstTeamHome;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader position;
        private System.Windows.Forms.ListView lvAllPlayersHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblFirstTeamAway;
        private System.Windows.Forms.Button btnRemoveFirstTeam;
        private System.Windows.Forms.Button btnAddFirstTeam;
        private System.Windows.Forms.ListView lvFirstTeamAway;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvAllPlayersAway;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblAllPlayersAway;
    }
}