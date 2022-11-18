
namespace PLFootballSystem.Forms.PlayerPosition
{
    partial class AddNewPlayerPosition
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
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.tbPlayerPositionName = new System.Windows.Forms.TextBox();
            this.btnAddPlayerPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerPosition
            // 
            this.lblPlayerPosition.AutoSize = true;
            this.lblPlayerPosition.Location = new System.Drawing.Point(29, 13);
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            this.lblPlayerPosition.Size = new System.Drawing.Size(104, 13);
            this.lblPlayerPosition.TabIndex = 0;
            this.lblPlayerPosition.Text = "Player position name";
            // 
            // tbPlayerPositionName
            // 
            this.tbPlayerPositionName.Location = new System.Drawing.Point(32, 30);
            this.tbPlayerPositionName.Name = "tbPlayerPositionName";
            this.tbPlayerPositionName.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerPositionName.TabIndex = 1;
            // 
            // btnAddPlayerPosition
            // 
            this.btnAddPlayerPosition.Location = new System.Drawing.Point(153, 26);
            this.btnAddPlayerPosition.Name = "btnAddPlayerPosition";
            this.btnAddPlayerPosition.Size = new System.Drawing.Size(120, 23);
            this.btnAddPlayerPosition.TabIndex = 2;
            this.btnAddPlayerPosition.Text = "Add Player Position";
            this.btnAddPlayerPosition.UseVisualStyleBackColor = true;
            this.btnAddPlayerPosition.Click += new System.EventHandler(this.btnAddPlayerPosition_Click);
            // 
            // AddNewPlayerPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 170);
            this.Controls.Add(this.btnAddPlayerPosition);
            this.Controls.Add(this.tbPlayerPositionName);
            this.Controls.Add(this.lblPlayerPosition);
            this.Name = "AddNewPlayerPosition";
            this.Text = "AddNewPlayerPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.TextBox tbPlayerPositionName;
        private System.Windows.Forms.Button btnAddPlayerPosition;
    }
}