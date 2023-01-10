
namespace PLFootballSystem.Forms.SeasonForm
{
    partial class ChooseSeasonTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseSeasonTableForm));
            this.cbChooseSeason = new System.Windows.Forms.ComboBox();
            this.lblChooseSeason = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbChooseSeason
            // 
            this.cbChooseSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseSeason.FormattingEnabled = true;
            resources.ApplyResources(this.cbChooseSeason, "cbChooseSeason");
            this.cbChooseSeason.Name = "cbChooseSeason";
            // 
            // lblChooseSeason
            // 
            resources.ApplyResources(this.lblChooseSeason, "lblChooseSeason");
            this.lblChooseSeason.Name = "lblChooseSeason";
            // 
            // btnShow
            // 
            this.btnShow.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.Name = "btnShow";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ChooseSeasonTableForm
            // 
            this.AcceptButton = this.btnShow;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblChooseSeason);
            this.Controls.Add(this.cbChooseSeason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseSeasonTableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChooseSeason;
        private System.Windows.Forms.Label lblChooseSeason;
        private System.Windows.Forms.Button btnShow;
    }
}