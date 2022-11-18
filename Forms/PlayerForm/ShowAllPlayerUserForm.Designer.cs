
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
            this.lblAllClubPlayer.AutoSize = true;
            this.lblAllClubPlayer.Location = new System.Drawing.Point(13, 13);
            this.lblAllClubPlayer.Name = "lblAllClubPlayer";
            this.lblAllClubPlayer.Size = new System.Drawing.Size(72, 13);
            this.lblAllClubPlayer.TabIndex = 0;
            this.lblAllClubPlayer.Text = "All club player";
            // 
            // lvAllClubPlayer
            // 
            this.lvAllClubPlayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvAllClubPlayer.FullRowSelect = true;
            this.lvAllClubPlayer.HideSelection = false;
            this.lvAllClubPlayer.Location = new System.Drawing.Point(13, 30);
            this.lvAllClubPlayer.Name = "lvAllClubPlayer";
            this.lvAllClubPlayer.Size = new System.Drawing.Size(280, 241);
            this.lvAllClubPlayer.TabIndex = 1;
            this.lvAllClubPlayer.UseCompatibleStateImageBehavior = false;
            this.lvAllClubPlayer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Position";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 103;
            // 
            // btnOpenPlayer
            // 
            this.btnOpenPlayer.Location = new System.Drawing.Point(300, 30);
            this.btnOpenPlayer.Name = "btnOpenPlayer";
            this.btnOpenPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPlayer.TabIndex = 2;
            this.btnOpenPlayer.Text = "Open player";
            this.btnOpenPlayer.UseVisualStyleBackColor = true;
            this.btnOpenPlayer.Click += new System.EventHandler(this.btnOpenPlayer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(385, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowAllPlayerUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 283);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpenPlayer);
            this.Controls.Add(this.lvAllClubPlayer);
            this.Controls.Add(this.lblAllClubPlayer);
            this.Name = "ShowAllPlayerUserForm";
            this.Text = "ShowAllPlayerUserForm";
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