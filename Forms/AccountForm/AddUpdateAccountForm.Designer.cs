
namespace PLFootballSystem.Forms.AccountForm
{
    partial class AddUpdateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUpdateAccountForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.Name = "tbUsername";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // lblRepeatPassword
            // 
            resources.ApplyResources(this.lblRepeatPassword, "lblRepeatPassword");
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            // 
            // tbRepeatPassword
            // 
            resources.ApplyResources(this.tbRepeatPassword, "tbRepeatPassword");
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            // 
            // lblRole
            // 
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.Name = "lblRole";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbRole, "cbRole");
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Name = "cbRole";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddUpdateAccountForm
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.tbRepeatPassword);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUpdateAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnSave;
    }
}