
namespace PLFootballSystem.Forms.PlayerForm
{
    partial class ViewPlayerForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAllPlayer = new System.Windows.Forms.Button();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAllPlayer
            // 
            this.btnAllPlayer.Location = new System.Drawing.Point(65, 100);
            this.btnAllPlayer.Name = "btnAllPlayer";
            this.btnAllPlayer.Size = new System.Drawing.Size(106, 23);
            this.btnAllPlayer.TabIndex = 1;
            this.btnAllPlayer.Text = "List all players";
            this.btnAllPlayer.UseVisualStyleBackColor = true;
            this.btnAllPlayer.Click += new System.EventHandler(this.btnAllPlayer_Click);
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(210, 100);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(97, 23);
            this.btnAddNewPlayer.TabIndex = 2;
            this.btnAddNewPlayer.Text = "Add new player";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // ViewPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 233);
            this.Controls.Add(this.btnAddNewPlayer);
            this.Controls.Add(this.btnAllPlayer);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPlayerForm";
            this.Text = "ViewPlayerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAllPlayer;
        private System.Windows.Forms.Button btnAddNewPlayer;
    }
}