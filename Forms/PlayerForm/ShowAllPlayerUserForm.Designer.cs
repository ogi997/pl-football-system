
namespace PLFootballSystem.Forms.PlayerForm
{
    partial class ShowAllPlayerUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAllPlayerUserForm));
            this.lblAllClubPlayer = new System.Windows.Forms.Label();
            this.lvAllClubPlayer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenPlayer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAllClubPlayer
            // 
            resources.ApplyResources(this.lblAllClubPlayer, "lblAllClubPlayer");
            this.lblAllClubPlayer.Name = "lblAllClubPlayer";
            // 
            // lvAllClubPlayer
            // 
            this.lvAllClubPlayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAllClubPlayer.FullRowSelect = true;
            this.lvAllClubPlayer.HideSelection = false;
            resources.ApplyResources(this.lvAllClubPlayer, "lvAllClubPlayer");
            this.lvAllClubPlayer.Name = "lvAllClubPlayer";
            this.lvAllClubPlayer.UseCompatibleStateImageBehavior = false;
            this.lvAllClubPlayer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // btnOpenPlayer
            // 
            this.btnOpenPlayer.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnOpenPlayer, "btnOpenPlayer");
            this.btnOpenPlayer.Name = "btnOpenPlayer";
            this.btnOpenPlayer.UseVisualStyleBackColor = true;
            this.btnOpenPlayer.Click += new System.EventHandler(this.btnOpenPlayer_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowAllPlayerUserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenPlayer);
            this.Controls.Add(this.lvAllClubPlayer);
            this.Controls.Add(this.lblAllClubPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowAllPlayerUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAllClubPlayer;
        private System.Windows.Forms.ListView lvAllClubPlayer;
        private System.Windows.Forms.Button btnOpenPlayer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}