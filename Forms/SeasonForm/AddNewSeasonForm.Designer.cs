
namespace PLFootballSystem.Forms.SeasonForm
{
    partial class AddNewSeasonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSeasonForm));
            this.lblSeason = new System.Windows.Forms.Label();
            this.tbSeason = new System.Windows.Forms.TextBox();
            this.btnAddNewSeason = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeason
            // 
            resources.ApplyResources(this.lblSeason, "lblSeason");
            this.lblSeason.Name = "lblSeason";
            // 
            // tbSeason
            // 
            resources.ApplyResources(this.tbSeason, "tbSeason");
            this.tbSeason.Name = "tbSeason";
            // 
            // btnAddNewSeason
            // 
            this.btnAddNewSeason.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddNewSeason, "btnAddNewSeason");
            this.btnAddNewSeason.Name = "btnAddNewSeason";
            this.btnAddNewSeason.UseVisualStyleBackColor = true;
            this.btnAddNewSeason.Click += new System.EventHandler(this.btnAddNewSeason_Click);
            // 
            // AddNewSeasonForm
            // 
            this.AcceptButton = this.btnAddNewSeason;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddNewSeason);
            this.Controls.Add(this.tbSeason);
            this.Controls.Add(this.lblSeason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewSeasonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.TextBox tbSeason;
        private System.Windows.Forms.Button btnAddNewSeason;
    }
}