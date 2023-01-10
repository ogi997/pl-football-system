
namespace PLFootballSystem.Forms.FootballClubForm
{
    partial class AddNewFootballClubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFootballClubForm));
            this.lblFootballClubName = new System.Windows.Forms.Label();
            this.tbFootballClubName = new System.Windows.Forms.TextBox();
            this.lblFootballClubNickname = new System.Windows.Forms.Label();
            this.tbFootballClubNickname = new System.Windows.Forms.TextBox();
            this.lblFootballClubOwner = new System.Windows.Forms.Label();
            this.tbFootballClubOwner = new System.Windows.Forms.TextBox();
            this.lblFounded = new System.Windows.Forms.Label();
            this.dtFounded = new System.Windows.Forms.DateTimePicker();
            this.lblFootballClubImage = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.lblFootballClubTshirt = new System.Windows.Forms.Label();
            this.btnAddTshirtImage = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.fdFCImage = new System.Windows.Forms.OpenFileDialog();
            this.fdTshirtImage = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFootballClubName
            // 
            resources.ApplyResources(this.lblFootballClubName, "lblFootballClubName");
            this.lblFootballClubName.Name = "lblFootballClubName";
            // 
            // tbFootballClubName
            // 
            resources.ApplyResources(this.tbFootballClubName, "tbFootballClubName");
            this.tbFootballClubName.Name = "tbFootballClubName";
            // 
            // lblFootballClubNickname
            // 
            resources.ApplyResources(this.lblFootballClubNickname, "lblFootballClubNickname");
            this.lblFootballClubNickname.Name = "lblFootballClubNickname";
            // 
            // tbFootballClubNickname
            // 
            resources.ApplyResources(this.tbFootballClubNickname, "tbFootballClubNickname");
            this.tbFootballClubNickname.Name = "tbFootballClubNickname";
            // 
            // lblFootballClubOwner
            // 
            resources.ApplyResources(this.lblFootballClubOwner, "lblFootballClubOwner");
            this.lblFootballClubOwner.Name = "lblFootballClubOwner";
            // 
            // tbFootballClubOwner
            // 
            resources.ApplyResources(this.tbFootballClubOwner, "tbFootballClubOwner");
            this.tbFootballClubOwner.Name = "tbFootballClubOwner";
            // 
            // lblFounded
            // 
            resources.ApplyResources(this.lblFounded, "lblFounded");
            this.lblFounded.Name = "lblFounded";
            // 
            // dtFounded
            // 
            resources.ApplyResources(this.dtFounded, "dtFounded");
            this.dtFounded.Name = "dtFounded";
            // 
            // lblFootballClubImage
            // 
            resources.ApplyResources(this.lblFootballClubImage, "lblFootballClubImage");
            this.lblFootballClubImage.Name = "lblFootballClubImage";
            // 
            // btnAddImage
            // 
            resources.ApplyResources(this.btnAddImage, "btnAddImage");
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lblFootballClubTshirt
            // 
            resources.ApplyResources(this.lblFootballClubTshirt, "lblFootballClubTshirt");
            this.lblFootballClubTshirt.Name = "lblFootballClubTshirt";
            // 
            // btnAddTshirtImage
            // 
            resources.ApplyResources(this.btnAddTshirtImage, "btnAddTshirtImage");
            this.btnAddTshirtImage.FlatAppearance.BorderSize = 0;
            this.btnAddTshirtImage.Name = "btnAddTshirtImage";
            this.btnAddTshirtImage.UseVisualStyleBackColor = true;
            this.btnAddTshirtImage.Click += new System.EventHandler(this.btnAddTshirtImage_Click);
            // 
            // lblCity
            // 
            resources.ApplyResources(this.lblCity, "lblCity");
            this.lblCity.Name = "lblCity";
            // 
            // cbCity
            // 
            resources.ApplyResources(this.cbCity, "cbCity");
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Name = "cbCity";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAddFootballClub_Click);
            // 
            // fdFCImage
            // 
            resources.ApplyResources(this.fdFCImage, "fdFCImage");
            // 
            // fdTshirtImage
            // 
            resources.ApplyResources(this.fdTshirtImage, "fdTshirtImage");
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddNewFootballClubForm
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnAddTshirtImage);
            this.Controls.Add(this.lblFootballClubTshirt);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.lblFootballClubImage);
            this.Controls.Add(this.dtFounded);
            this.Controls.Add(this.lblFounded);
            this.Controls.Add(this.tbFootballClubOwner);
            this.Controls.Add(this.lblFootballClubOwner);
            this.Controls.Add(this.tbFootballClubNickname);
            this.Controls.Add(this.lblFootballClubNickname);
            this.Controls.Add(this.tbFootballClubName);
            this.Controls.Add(this.lblFootballClubName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewFootballClubForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootballClubName;
        private System.Windows.Forms.TextBox tbFootballClubName;
        private System.Windows.Forms.Label lblFootballClubNickname;
        private System.Windows.Forms.TextBox tbFootballClubNickname;
        private System.Windows.Forms.Label lblFootballClubOwner;
        private System.Windows.Forms.TextBox tbFootballClubOwner;
        private System.Windows.Forms.Label lblFounded;
        private System.Windows.Forms.DateTimePicker dtFounded;
        private System.Windows.Forms.Label lblFootballClubImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.Label lblFootballClubTshirt;
        private System.Windows.Forms.Button btnAddTshirtImage;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog fdFCImage;
        private System.Windows.Forms.OpenFileDialog fdTshirtImage;
        private System.Windows.Forms.Button btnClose;
    }
}