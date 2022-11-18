
namespace PLFootballSystem.Forms.PlayerForm
{
    partial class AddNewPlayer
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.numPlayerNumber = new System.Windows.Forms.NumericUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePlayerDate = new System.Windows.Forms.DateTimePicker();
            this.lblPlayerImage = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cbPlayerCountry = new System.Windows.Forms.ComboBox();
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.cbPlayerPosition = new System.Windows.Forms.ComboBox();
            this.lblPlayerClub = new System.Windows.Forms.Label();
            this.cbPlayerFC = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.fdPlayerImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(23, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(65, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player name";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(26, 30);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerName.TabIndex = 1;
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(26, 57);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(74, 13);
            this.lblPlayerNumber.TabIndex = 2;
            this.lblPlayerNumber.Text = "Player number";
            // 
            // numPlayerNumber
            // 
            this.numPlayerNumber.Location = new System.Drawing.Point(29, 74);
            this.numPlayerNumber.Name = "numPlayerNumber";
            this.numPlayerNumber.Size = new System.Drawing.Size(120, 20);
            this.numPlayerNumber.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // datePlayerDate
            // 
            this.datePlayerDate.Location = new System.Drawing.Point(29, 118);
            this.datePlayerDate.Name = "datePlayerDate";
            this.datePlayerDate.Size = new System.Drawing.Size(200, 20);
            this.datePlayerDate.TabIndex = 5;
            // 
            // lblPlayerImage
            // 
            this.lblPlayerImage.AutoSize = true;
            this.lblPlayerImage.Location = new System.Drawing.Point(29, 145);
            this.lblPlayerImage.Name = "lblPlayerImage";
            this.lblPlayerImage.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerImage.TabIndex = 6;
            this.lblPlayerImage.Text = "Image player";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(29, 161);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(97, 23);
            this.btnSelectImage.TabIndex = 7;
            this.btnSelectImage.Text = "Select image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(29, 191);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(74, 13);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Player country";
            // 
            // cbPlayerCountry
            // 
            this.cbPlayerCountry.FormattingEnabled = true;
            this.cbPlayerCountry.Location = new System.Drawing.Point(32, 208);
            this.cbPlayerCountry.Name = "cbPlayerCountry";
            this.cbPlayerCountry.Size = new System.Drawing.Size(121, 21);
            this.cbPlayerCountry.TabIndex = 9;
            // 
            // lblPlayerPosition
            // 
            this.lblPlayerPosition.AutoSize = true;
            this.lblPlayerPosition.Location = new System.Drawing.Point(29, 232);
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            this.lblPlayerPosition.Size = new System.Drawing.Size(75, 13);
            this.lblPlayerPosition.TabIndex = 10;
            this.lblPlayerPosition.Text = "Player position";
            // 
            // cbPlayerPosition
            // 
            this.cbPlayerPosition.FormattingEnabled = true;
            this.cbPlayerPosition.Location = new System.Drawing.Point(32, 248);
            this.cbPlayerPosition.Name = "cbPlayerPosition";
            this.cbPlayerPosition.Size = new System.Drawing.Size(121, 21);
            this.cbPlayerPosition.TabIndex = 11;
            // 
            // lblPlayerClub
            // 
            this.lblPlayerClub.AutoSize = true;
            this.lblPlayerClub.Location = new System.Drawing.Point(29, 282);
            this.lblPlayerClub.Name = "lblPlayerClub";
            this.lblPlayerClub.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerClub.TabIndex = 12;
            this.lblPlayerClub.Text = "Football club";
            // 
            // cbPlayerFC
            // 
            this.cbPlayerFC.FormattingEnabled = true;
            this.cbPlayerFC.Location = new System.Drawing.Point(32, 298);
            this.cbPlayerFC.Name = "cbPlayerFC";
            this.cbPlayerFC.Size = new System.Drawing.Size(121, 21);
            this.cbPlayerFC.TabIndex = 13;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(232, 295);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 14;
            this.btnAddPlayer.Text = "Add player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // fdPlayerImage
            // 
            this.fdPlayerImage.FileName = "openFileDialog1";
            // 
            // AddNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 368);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.cbPlayerFC);
            this.Controls.Add(this.lblPlayerClub);
            this.Controls.Add(this.cbPlayerPosition);
            this.Controls.Add(this.lblPlayerPosition);
            this.Controls.Add(this.cbPlayerCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.lblPlayerImage);
            this.Controls.Add(this.datePlayerDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.numPlayerNumber);
            this.Controls.Add(this.lblPlayerNumber);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "AddNewPlayer";
            this.Text = "AddNewPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.NumericUpDown numPlayerNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePlayerDate;
        private System.Windows.Forms.Label lblPlayerImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cbPlayerCountry;
        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.ComboBox cbPlayerPosition;
        private System.Windows.Forms.Label lblPlayerClub;
        private System.Windows.Forms.ComboBox cbPlayerFC;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.OpenFileDialog fdPlayerImage;
    }
}