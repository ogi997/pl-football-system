
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewPlayerPosition));
            this.lblPlayerPosition = new System.Windows.Forms.Label();
            this.tbPlayerPositionName = new System.Windows.Forms.TextBox();
            this.btnAddPlayerPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerPosition
            // 
            resources.ApplyResources(this.lblPlayerPosition, "lblPlayerPosition");
            this.lblPlayerPosition.Name = "lblPlayerPosition";
            // 
            // tbPlayerPositionName
            // 
            resources.ApplyResources(this.tbPlayerPositionName, "tbPlayerPositionName");
            this.tbPlayerPositionName.Name = "tbPlayerPositionName";
            // 
            // btnAddPlayerPosition
            // 
            this.btnAddPlayerPosition.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAddPlayerPosition, "btnAddPlayerPosition");
            this.btnAddPlayerPosition.Name = "btnAddPlayerPosition";
            this.btnAddPlayerPosition.UseVisualStyleBackColor = true;
            this.btnAddPlayerPosition.Click += new System.EventHandler(this.btnAddPlayerPosition_Click);
            // 
            // AddNewPlayerPosition
            // 
            this.AcceptButton = this.btnAddPlayerPosition;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddPlayerPosition);
            this.Controls.Add(this.tbPlayerPositionName);
            this.Controls.Add(this.lblPlayerPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewPlayerPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerPosition;
        private System.Windows.Forms.TextBox tbPlayerPositionName;
        private System.Windows.Forms.Button btnAddPlayerPosition;
    }
}