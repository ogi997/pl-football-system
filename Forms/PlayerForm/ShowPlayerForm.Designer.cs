
namespace PLFootballSystem.Forms.PlayerForm
{
    partial class ShowPlayerForm
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
            this.pbPlayerFace = new System.Windows.Forms.PictureBox();
            this.pbCountryFlag = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPlayerDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountryFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerFace
            // 
            this.pbPlayerFace.Location = new System.Drawing.Point(13, 13);
            this.pbPlayerFace.Name = "pbPlayerFace";
            this.pbPlayerFace.Size = new System.Drawing.Size(119, 107);
            this.pbPlayerFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayerFace.TabIndex = 0;
            this.pbPlayerFace.TabStop = false;
            this.pbPlayerFace.WaitOnLoad = true;
            // 
            // pbCountryFlag
            // 
            this.pbCountryFlag.Location = new System.Drawing.Point(346, 13);
            this.pbCountryFlag.Name = "pbCountryFlag";
            this.pbCountryFlag.Size = new System.Drawing.Size(100, 50);
            this.pbCountryFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCountryFlag.TabIndex = 1;
            this.pbCountryFlag.TabStop = false;
            this.pbCountryFlag.WaitOnLoad = true;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(57, 127);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "label1";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Location = new System.Drawing.Point(385, 70);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(35, 13);
            this.lblCountryName.TabIndex = 3;
            this.lblCountryName.Text = "label1";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(13, 158);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(77, 13);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Player number:";
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(97, 157);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerNumber.TabIndex = 5;
            this.lblPlayerNumber.Text = "label1";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(13, 175);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Position:";
            // 
            // lblPlayerPosition
            // 
            this.lblPlayerPosition.AutoSize = true;
            this.lblPlayerPosition.Location = new System.Drawing.Point(100, 175);
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            this.lblPlayerPosition.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerPosition.TabIndex = 7;
            this.lblPlayerPosition.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 192);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date:";
            // 
            // lblPlayerDate
            // 
            this.lblPlayerDate.AutoSize = true;
            this.lblPlayerDate.Location = new System.Drawing.Point(100, 192);
            this.lblPlayerDate.Name = "lblPlayerDate";
            this.lblPlayerDate.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerDate.TabIndex = 9;
            this.lblPlayerDate.Text = "label1";
            // 
            // ShowPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 237);
            this.Controls.Add(this.lblPlayerDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbCountryFlag);
            this.Controls.Add(this.pbPlayerFace);
            this.Name = "ShowPlayerForm";
            this.Text = "ShowPlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountryFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerFace;
        private System.Windows.Forms.PictureBox pbCountryFlag;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPlayerDate;
    }
}