
namespace PLFootballSystem.Forms.PlayerForm
{
    partial class AddUpdatePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdatePlayer));
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.numPlayerNumber = new System.Windows.Forms.NumericUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePlayerDate = new System.Windows.Forms.DateTimePicker();
            this.lblPlayerImage = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbPlayerCountry = new System.Windows.Forms.ComboBox();
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.cbPlayerPosition = new System.Windows.Forms.ComboBox();
            this.lblPlayerClub = new System.Windows.Forms.Label();
            this.cbPlayerFC = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.fdPlayerImage = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            resources.ApplyResources(this.lblPlayerName, "lblPlayerName");
            this.lblPlayerName.Name = "lblPlayerName";
            // 
            // tbPlayerName
            // 
            resources.ApplyResources(this.tbPlayerName, "tbPlayerName");
            this.tbPlayerName.Name = "tbPlayerName";
            // 
            // lblPlayerNumber
            // 
            resources.ApplyResources(this.lblPlayerNumber, "lblPlayerNumber");
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            // 
            // numPlayerNumber
            // 
            resources.ApplyResources(this.numPlayerNumber, "numPlayerNumber");
            this.numPlayerNumber.Name = "numPlayerNumber";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // datePlayerDate
            // 
            resources.ApplyResources(this.datePlayerDate, "datePlayerDate");
            this.datePlayerDate.Name = "datePlayerDate";
            // 
            // lblPlayerImage
            // 
            resources.ApplyResources(this.lblPlayerImage, "lblPlayerImage");
            this.lblPlayerImage.Name = "lblPlayerImage";
            // 
            // btnSelectImage
            // 
            resources.ApplyResources(this.btnSelectImage, "btnSelectImage");
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblCountry
            // 
            resources.ApplyResources(this.lblCountry, "lblCountry");
            this.lblCountry.Name = "lblCountry";
            // 
            // cbPlayerCountry
            // 
            this.cbPlayerCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerCountry.FormattingEnabled = true;
            resources.ApplyResources(this.cbPlayerCountry, "cbPlayerCountry");
            this.cbPlayerCountry.Name = "cbPlayerCountry";
            // 
            // lblPlayerPosition
            // 
            resources.ApplyResources(this.lblPlayerPosition, "lblPlayerPosition");
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            // 
            // cbPlayerPosition
            // 
            this.cbPlayerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerPosition.FormattingEnabled = true;
            resources.ApplyResources(this.cbPlayerPosition, "cbPlayerPosition");
            this.cbPlayerPosition.Name = "cbPlayerPosition";
            // 
            // lblPlayerClub
            // 
            resources.ApplyResources(this.lblPlayerClub, "lblPlayerClub");
            this.lblPlayerClub.Name = "lblPlayerClub";
            // 
            // cbPlayerFC
            // 
            this.cbPlayerFC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerFC.FormattingEnabled = true;
            resources.ApplyResources(this.cbPlayerFC, "cbPlayerFC");
            this.cbPlayerFC.Name = "cbPlayerFC";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // fdPlayerImage
            // 
            this.fdPlayerImage.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddUpdatePlayer
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPlayerFC);
            this.Controls.Add(this.lblPlayerClub);
            this.Controls.Add(this.cbPlayerPosition);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.cbPlayerCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblPlayerImage);
            this.Controls.Add(this.datePlayerDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.numPlayerNumber);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdatePlayer";
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.NumericUpDown numPlayerNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePlayerDate;
        private System.Windows.Forms.Label lblPlayerImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbPlayerCountry;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.ComboBox cbPlayerPosition;
        private System.Windows.Forms.Label lblPlayerClub;
        private System.Windows.Forms.ComboBox cbPlayerFC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog fdPlayerImage;
        private System.Windows.Forms.Button btnClose;
    }
}