
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
            this.lblCountryName = new System.Windows.Forms.Label();
            this.tbCountryName = new System.Windows.Forms.TextBox();
            this.lblCountryFlagImage = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Location = new System.Drawing.Point(39, 32);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(72, 13);
            this.lblCountryName.TabIndex = 0;
            this.lblCountryName.Text = "Country name";
            // 
            // tbCountryName
            // 
            this.tbCountryName.Location = new System.Drawing.Point(42, 49);
            this.tbCountryName.Name = "tbCountryName";
            this.tbCountryName.Size = new System.Drawing.Size(100, 20);
            this.tbCountryName.TabIndex = 1;
            // 
            // lblCountryFlagImage
            // 
            this.lblCountryFlagImage.AutoSize = true;
            this.lblCountryFlagImage.Location = new System.Drawing.Point(42, 76);
            this.lblCountryFlagImage.Name = "lblCountryFlagImage";
            this.lblCountryFlagImage.Size = new System.Drawing.Size(97, 13);
            this.lblCountryFlagImage.TabIndex = 2;
            this.lblCountryFlagImage.Text = "Country Flag image";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(45, 93);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(97, 23);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "Select image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnCountry
            // 
            this.btnCountry.Location = new System.Drawing.Point(196, 92);
            this.btnCountry.Name = "btnCountry";
            this.btnCountry.Size = new System.Drawing.Size(75, 23);
            this.btnCountry.TabIndex = 4;
            this.btnCountry.Text = "Add country";
            this.btnCountry.UseVisualStyleBackColor = true;
            this.btnCountry.Click += new System.EventHandler(this.btnCountry_Click);
            // 
            // AddNewCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 221);
            this.Controls.Add(this.btnCountry);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblCountryFlagImage);
            this.Controls.Add(this.tbCountryName);
            this.Controls.Add(this.lblCountryName);
            this.Name = "AddNewCountry";
            this.Text = "AddNewCountry";
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
    }
}