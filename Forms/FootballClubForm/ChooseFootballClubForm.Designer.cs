
namespace PLFootballSystem.Forms.FootballClubForm
{
    partial class ChooseFootballClubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFootballClubForm));
            this.lblChooseFC = new System.Windows.Forms.Label();
            this.cbFootballClub = new System.Windows.Forms.ComboBox();
            this.btnShowFC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseFC
            // 
            resources.ApplyResources(this.lblChooseFC, "lblChooseFC");
            this.lblChooseFC.Name = "lblChooseFC";
            // 
            // cbFootballClub
            // 
            this.cbFootballClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFootballClub.FormattingEnabled = true;
            resources.ApplyResources(this.cbFootballClub, "cbFootballClub");
            this.cbFootballClub.Name = "cbFootballClub";
            // 
            // btnShowFC
            // 
            this.btnShowFC.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnShowFC, "btnShowFC");
            this.btnShowFC.Name = "btnShowFC";
            this.btnShowFC.UseVisualStyleBackColor = true;
            this.btnShowFC.Click += new System.EventHandler(this.btnShowFC_Click);
            // 
            // ChooseFootballClubForm
            // 
            this.AcceptButton = this.btnShowFC;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowFC);
            this.Controls.Add(this.cbFootballClub);
            this.Controls.Add(this.lblChooseFC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseFootballClubForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseFC;
        private System.Windows.Forms.ComboBox cbFootballClub;
        private System.Windows.Forms.Button btnShowFC;
    }
}