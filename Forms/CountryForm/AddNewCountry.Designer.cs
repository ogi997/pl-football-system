
namespace PLFootballSystem.Forms.CountryForm
{
    partial class AddNewCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCountry));
            this.lblCountryName = new System.Windows.Forms.Label();
            this.tbCountryName = new System.Windows.Forms.TextBox();
            this.lblCountryFlagImage = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountryName
            // 
            resources.ApplyResources(this.lblCountryName, "lblCountryName");
            this.lblCountryName.Name = "lblCountryName";
            // 
            // tbCountryName
            // 
            resources.ApplyResources(this.tbCountryName, "tbCountryName");
            this.tbCountryName.Name = "tbCountryName";
            // 
            // lblCountryFlagImage
            // 
            resources.ApplyResources(this.lblCountryFlagImage, "lblCountryFlagImage");
            this.lblCountryFlagImage.Name = "lblCountryFlagImage";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSelectImage, "btnSelectImage");
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCountry, "btnCountry");
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddNewCountry
            // 
            this.AcceptButton = this.btnCountry;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblCountryFlagImage);
            this.Controls.Add(this.tbCountryName);
            this.Controls.Add(this.lblCountryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox tbCountryName;
        private System.Windows.Forms.Label lblCountryFlagImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnCountry;
        private System.Windows.Forms.Button btnClose;
    }
}