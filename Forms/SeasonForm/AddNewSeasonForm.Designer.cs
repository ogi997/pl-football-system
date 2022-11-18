
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
            this.lblSeason = new System.Windows.Forms.Label();
            this.tbSeason = new System.Windows.Forms.TextBox();
            this.btnAddNewSeason = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(13, 13);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(43, 13);
            this.lblSeason.TabIndex = 0;
            this.lblSeason.Text = "Season";
            // 
            // tbSeason
            // 
            this.tbSeason.Location = new System.Drawing.Point(16, 30);
            this.tbSeason.Name = "tbSeason";
            this.tbSeason.Size = new System.Drawing.Size(100, 20);
            this.tbSeason.TabIndex = 1;
            // 
            // btnAddNewSeason
            // 
            this.btnAddNewSeason.Location = new System.Drawing.Point(136, 26);
            this.btnAddNewSeason.Name = "btnAddNewSeason";
            this.btnAddNewSeason.Size = new System.Drawing.Size(102, 23);
            this.btnAddNewSeason.TabIndex = 2;
            this.btnAddNewSeason.Text = "Add new season";
            this.btnAddNewSeason.UseVisualStyleBackColor = true;
            this.btnAddNewSeason.Click += new System.EventHandler(this.btnAddNewSeason_Click);
            // 
            // AddNewSeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 143);
            this.Controls.Add(this.btnAddNewSeason);
            this.Controls.Add(this.tbSeason);
            this.Controls.Add(this.lblSeason);
            this.Name = "AddNewSeasonForm";
            this.Text = "AddNewSeasonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.TextBox tbSeason;
        private System.Windows.Forms.Button btnAddNewSeason;
    }
}