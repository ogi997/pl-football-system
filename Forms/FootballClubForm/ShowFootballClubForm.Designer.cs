
namespace PLFootballSystem.Forms.FootballClubForm
{
    partial class ShowFootballClubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowFootballClubForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbGrb = new System.Windows.Forms.PictureBox();
            this.pbDres = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFounded = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnShowPlayers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pbGrb
            // 
            resources.ApplyResources(this.pbGrb, "pbGrb");
            this.pbGrb.Name = "pbGrb";
            this.pbGrb.TabStop = false;
            // 
            // pbDres
            // 
            resources.ApplyResources(this.pbDres, "pbDres");
            this.pbDres.Name = "pbDres";
            this.pbDres.TabStop = false;
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblFounded
            // 
            resources.ApplyResources(this.lblFounded, "lblFounded");
            this.lblFounded.Name = "lblFounded";
            // 
            // lblOwner
            // 
            resources.ApplyResources(this.lblOwner, "lblOwner");
            this.lblOwner.Name = "lblOwner";
            // 
            // lblNickname
            // 
            resources.ApplyResources(this.lblNickname, "lblNickname");
            this.lblNickname.Name = "lblNickname";
            // 
            // lblCity
            // 
            resources.ApplyResources(this.lblCity, "lblCity");
            this.lblCity.Name = "lblCity";
            // 
            // btnShowPlayers
            // 
            this.btnShowPlayers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnShowPlayers, "btnShowPlayers");
            this.btnShowPlayers.Name = "btnShowPlayers";
            this.btnShowPlayers.UseVisualStyleBackColor = true;
            this.btnShowPlayers.Click += new System.EventHandler(this.btnShowPlayers_Click);
            // 
            // ShowFootballClubForm
            // 
            this.AcceptButton = this.btnShowPlayers;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowPlayers);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblFounded);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbDres);
            this.Controls.Add(this.pbGrb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowFootballClubForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbGrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbGrb;
        private System.Windows.Forms.PictureBox pbDres;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFounded;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnShowPlayers;
    }
}