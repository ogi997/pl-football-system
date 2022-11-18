
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
            this.lblFootballClub = new System.Windows.Forms.Label();
            this.cbFootballClub = new System.Windows.Forms.ComboBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.numberTablePosition = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberTablePosition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFootballClub
            // 
            this.lblFootballClub.AutoSize = true;
            this.lblFootballClub.Location = new System.Drawing.Point(13, 13);
            this.lblFootballClub.Name = "lblFootballClub";
            this.lblFootballClub.Size = new System.Drawing.Size(67, 13);
            this.lblFootballClub.TabIndex = 0;
            this.lblFootballClub.Text = "Football club";
            // 
            // cbFootballClub
            // 
            this.cbFootballClub.FormattingEnabled = true;
            this.cbFootballClub.Location = new System.Drawing.Point(16, 30);
            this.cbFootballClub.Name = "cbFootballClub";
            this.cbFootballClub.Size = new System.Drawing.Size(121, 21);
            this.cbFootballClub.TabIndex = 1;
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(13, 54);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(43, 13);
            this.lblSeason.TabIndex = 2;
            this.lblSeason.Text = "Season";
            // 
            // cbSeason
            // 
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Location = new System.Drawing.Point(16, 70);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(121, 21);
            this.cbSeason.TabIndex = 3;
            // 
            // numberTablePosition
            // 
            this.numberTablePosition.Location = new System.Drawing.Point(16, 98);
            this.numberTablePosition.Name = "numberTablePosition";
            this.numberTablePosition.Size = new System.Drawing.Size(120, 20);
            this.numberTablePosition.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(193, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddFcToSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 150);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numberTablePosition);
            this.Controls.Add(this.cbSeason);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.cbFootballClub);
            this.Controls.Add(this.lblFootballClub);
            this.Name = "AddFcToSeason";
            this.Text = "AddFcToSeason";
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
    }
}