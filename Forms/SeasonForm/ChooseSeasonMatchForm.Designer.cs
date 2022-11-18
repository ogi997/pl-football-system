
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
            this.lblChooseSeason = new System.Windows.Forms.Label();
            this.cbChooseSeason = new System.Windows.Forms.ComboBox();
            this.btnShowMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseSeason
            // 
            this.lblChooseSeason.AutoSize = true;
            this.lblChooseSeason.Location = new System.Drawing.Point(62, 32);
            this.lblChooseSeason.Name = "lblChooseSeason";
            this.lblChooseSeason.Size = new System.Drawing.Size(80, 13);
            this.lblChooseSeason.TabIndex = 0;
            this.lblChooseSeason.Text = "Choose season";
            // 
            // cbChooseSeason
            // 
            this.cbChooseSeason.FormattingEnabled = true;
            this.cbChooseSeason.Location = new System.Drawing.Point(65, 49);
            this.cbChooseSeason.Name = "cbChooseSeason";
            this.cbChooseSeason.Size = new System.Drawing.Size(121, 21);
            this.cbChooseSeason.TabIndex = 1;
            // 
            // btnShowMatch
            // 
            this.btnShowMatch.Location = new System.Drawing.Point(65, 77);
            this.btnShowMatch.Name = "btnShowMatch";
            this.btnShowMatch.Size = new System.Drawing.Size(75, 23);
            this.btnShowMatch.TabIndex = 2;
            this.btnShowMatch.Text = "Show match";
            this.btnShowMatch.UseVisualStyleBackColor = true;
            this.btnShowMatch.Click += new System.EventHandler(this.btnShowMatch_Click);
            // 
            // ChooseSeasonMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 167);
            this.Controls.Add(this.btnShowMatch);
            this.Controls.Add(this.cbChooseSeason);
            this.Controls.Add(this.lblChooseSeason);
            this.Name = "ChooseSeasonMatchForm";
            this.Text = "ChooseSeasonMatchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseSeason;
        private System.Windows.Forms.ComboBox cbChooseSeason;
        private System.Windows.Forms.Button btnShowMatch;
    }
}