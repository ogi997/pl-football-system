
namespace PLFootballSystem.Forms.PlayerForm
{
    partial class ShowPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPlayerForm));
            this.pbPlayerFace = new System.Windows.Forms.PictureBox();
            this.pbCountryFlag = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPlayerDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountryFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerFace
            // 
            resources.ApplyResources(this.pbPlayerFace, "pbPlayerFace");
            this.pbPlayerFace.Name = "pbPlayerFace";
            this.pbPlayerFace.TabStop = false;
            // 
            // pbCountryFlag
            // 
            resources.ApplyResources(this.pbCountryFlag, "pbCountryFlag");
            this.pbCountryFlag.Name = "pbCountryFlag";
            this.pbCountryFlag.TabStop = false;
            // 
            // lblPlayerName
            // 
            resources.ApplyResources(this.lblPlayerName, "lblPlayerName");
            this.lblPlayerName.Name = "lblPlayerName";
            // 
            // lblCountryName
            // 
            resources.ApplyResources(this.lblCountryName, "lblCountryName");
            this.lblCountryName.Name = "lblCountryName";
            // 
            // lblNumber
            // 
            resources.ApplyResources(this.lblNumber, "lblNumber");
            this.lblNumber.Name = "lblNumber";
            // 
            // lblPlayerNumber
            // 
            resources.ApplyResources(this.lblPlayerNumber, "lblPlayerNumber");
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.Name = "lblPosition";
            // 
            // lblPlayerPosition
            // 
            resources.ApplyResources(this.lblPlayerPosition, "lblPlayerPosition");
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // lblPlayerDate
            // 
            resources.ApplyResources(this.lblPlayerDate, "lblPlayerDate");
            this.lblPlayerDate.Name = "lblPlayerDate";
            // 
            // ShowPlayerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPlayerDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbCountryFlag);
            this.Controls.Add(this.pbPlayerFace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowPlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountryFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerFace;
        private System.Windows.Forms.PictureBox pbCountryFlag;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPlayerDate;
    }
}