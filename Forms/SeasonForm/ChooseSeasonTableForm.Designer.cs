
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
            this.cbChooseSeason = new System.Windows.Forms.ComboBox();
            this.lblChooseSeason = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbChooseSeason
            // 
            this.cbChooseSeason.FormattingEnabled = true;
            this.cbChooseSeason.Location = new System.Drawing.Point(76, 52);
            this.cbChooseSeason.Name = "cbChooseSeason";
            this.cbChooseSeason.Size = new System.Drawing.Size(121, 21);
            this.cbChooseSeason.TabIndex = 0;
            // 
            // lblChooseSeason
            // 
            this.lblChooseSeason.AutoSize = true;
            this.lblChooseSeason.Location = new System.Drawing.Point(76, 33);
            this.lblChooseSeason.Name = "lblChooseSeason";
            this.lblChooseSeason.Size = new System.Drawing.Size(80, 13);
            this.lblChooseSeason.TabIndex = 1;
            this.lblChooseSeason.Text = "Choose season";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(121, 80);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show table";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ChooseSeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 130);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblChooseSeason);
            this.Controls.Add(this.cbChooseSeason);
            this.Name = "ChooseSeasonForm";
            this.Text = "ChooseSeasonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChooseSeason;
        private System.Windows.Forms.Label lblChooseSeason;
        private System.Windows.Forms.Button btnShow;
    }
}