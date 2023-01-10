
namespace PLFootballSystem.Forms.SeasonForm
{
    partial class ChooseSeasonMatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseSeasonMatchForm));
            this.lblChooseSeason = new System.Windows.Forms.Label();
            this.cbChooseSeason = new System.Windows.Forms.ComboBox();
            this.btnShowMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseSeason
            // 
            resources.ApplyResources(this.lblChooseSeason, "lblChooseSeason");
            this.lblChooseSeason.Name = "lblChooseSeason";
            // 
            // cbChooseSeason
            // 
            this.cbChooseSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseSeason.FormattingEnabled = true;
            resources.ApplyResources(this.cbChooseSeason, "cbChooseSeason");
            this.cbChooseSeason.Name = "cbChooseSeason";
            // 
            // btnShowMatch
            // 
            this.btnShowMatch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnShowMatch, "btnShowMatch");
            this.btnShowMatch.Name = "btnShowMatch";
            this.btnShowMatch.UseVisualStyleBackColor = true;
            this.btnShowMatch.Click += new System.EventHandler(this.btnShowMatch_Click);
            // 
            // ChooseSeasonMatchForm
            // 
            this.AcceptButton = this.btnShowMatch;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowMatch);
            this.Controls.Add(this.cbChooseSeason);
            this.Controls.Add(this.lblChooseSeason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseSeasonMatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseSeason;
        private System.Windows.Forms.ComboBox cbChooseSeason;
        private System.Windows.Forms.Button btnShowMatch;
    }
}