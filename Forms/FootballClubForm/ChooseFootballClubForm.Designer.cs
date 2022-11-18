
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
            this.lblChooseFC = new System.Windows.Forms.Label();
            this.cbFootballClub = new System.Windows.Forms.ComboBox();
            this.btnShowFC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseFC
            // 
            this.lblChooseFC.AutoSize = true;
            this.lblChooseFC.Location = new System.Drawing.Point(82, 37);
            this.lblChooseFC.Name = "lblChooseFC";
            this.lblChooseFC.Size = new System.Drawing.Size(103, 13);
            this.lblChooseFC.TabIndex = 0;
            this.lblChooseFC.Text = "Choose football club";
            // 
            // cbFootballClub
            // 
            this.cbFootballClub.FormattingEnabled = true;
            this.cbFootballClub.Location = new System.Drawing.Point(85, 54);
            this.cbFootballClub.Name = "cbFootballClub";
            this.cbFootballClub.Size = new System.Drawing.Size(121, 21);
            this.cbFootballClub.TabIndex = 1;
            // 
            // btnShowFC
            // 
            this.btnShowFC.Location = new System.Drawing.Point(85, 82);
            this.btnShowFC.Name = "btnShowFC";
            this.btnShowFC.Size = new System.Drawing.Size(75, 23);
            this.btnShowFC.TabIndex = 2;
            this.btnShowFC.Text = "Show football club";
            this.btnShowFC.UseVisualStyleBackColor = true;
            this.btnShowFC.Click += new System.EventHandler(this.btnShowFC_Click);
            // 
            // ChooseFootballClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 152);
            this.Controls.Add(this.btnShowFC);
            this.Controls.Add(this.cbFootballClub);
            this.Controls.Add(this.lblChooseFC);
            this.Name = "ChooseFootballClubForm";
            this.Text = "ChooseFootballClubForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseFC;
        private System.Windows.Forms.ComboBox cbFootballClub;
        private System.Windows.Forms.Button btnShowFC;
    }
}