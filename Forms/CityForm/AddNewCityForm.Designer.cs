
namespace PLFootballSystem.Forms.CityForm
{
    partial class AddNewCityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCityForm));
            this.lblCityName = new System.Windows.Forms.Label();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            resources.ApplyResources(this.lblCityName, "lblCityName");
            this.lblCityName.Name = "lblCityName";
            // 
            // tbCityName
            // 
            resources.ApplyResources(this.tbCityName, "tbCityName");
            this.tbCityName.Name = "tbCityName";
            // 
            // btnAddCity
            // 
            this.btnAddCity.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddCity, "btnAddCity");
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddNewCityForm
            // 
            this.AcceptButton = this.btnAddCity;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.tbCityName);
            this.Controls.Add(this.lblCityName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewCityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnClose;
    }
}