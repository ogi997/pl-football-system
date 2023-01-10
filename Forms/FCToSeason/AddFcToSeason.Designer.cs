
namespace PLFootballSystem.Forms.FCToSeason
{
    partial class AddFcToSeason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFcToSeason));
            this.lblFootballClub = new System.Windows.Forms.Label();
            this.cbFootballClub = new System.Windows.Forms.ComboBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.numberTablePosition = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberTablePosition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFootballClub
            // 
            resources.ApplyResources(this.lblFootballClub, "lblFootballClub");
            this.lblFootballClub.Name = "lblFootballClub";
            // 
            // cbFootballClub
            // 
            resources.ApplyResources(this.cbFootballClub, "cbFootballClub");
            this.cbFootballClub.FormattingEnabled = true;
            this.cbFootballClub.Name = "cbFootballClub";
            // 
            // lblSeason
            // 
            resources.ApplyResources(this.lblSeason, "lblSeason");
            this.lblSeason.Name = "lblSeason";
            // 
            // cbSeason
            // 
            resources.ApplyResources(this.cbSeason, "cbSeason");
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Name = "cbSeason";
            // 
            // numberTablePosition
            // 
            resources.ApplyResources(this.numberTablePosition, "numberTablePosition");
            this.numberTablePosition.Name = "numberTablePosition";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPoints
            // 
            resources.ApplyResources(this.lblPoints, "lblPoints");
            this.lblPoints.Name = "lblPoints";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddFcToSeason
            // 
            this.AcceptButton = this.btnAdd;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numberTablePosition);
            this.Controls.Add(this.cbSeason);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.cbFootballClub);
            this.Controls.Add(this.lblFootballClub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFcToSeason";
            ((System.ComponentModel.ISupportInitialize)(this.numberTablePosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootballClub;
        private System.Windows.Forms.ComboBox cbFootballClub;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.ComboBox cbSeason;
        private System.Windows.Forms.NumericUpDown numberTablePosition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnClose;
    }
}