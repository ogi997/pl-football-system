
namespace PLFootballSystem.Forms.AccountForm
{
    partial class AllAccountForm
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
            this.lvAllAccounts = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(-1, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvAllAccounts
            // 
            this.lvAllAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Role,
            this.Status});
            this.lvAllAccounts.FullRowSelect = true;
            this.lvAllAccounts.HideSelection = false;
            this.lvAllAccounts.Location = new System.Drawing.Point(12, 89);
            this.lvAllAccounts.Name = "lvAllAccounts";
            this.lvAllAccounts.Size = new System.Drawing.Size(304, 127);
            this.lvAllAccounts.TabIndex = 1;
            this.lvAllAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAllAccounts.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 95;
            // 
            // Role
            // 
            this.Role.Text = "Role";
            this.Role.Width = 101;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 104;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(322, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete account";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(322, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Change role";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(322, 89);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(99, 23);
            this.btnActive.TabIndex = 4;
            this.btnActive.Text = "Activate account";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 63);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(303, 20);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(127, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search user by username";
            // 
            // AllAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 228);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvAllAccounts);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllAccountForm";
            this.Text = "AllAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvAllAccounts;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label lblSearch;
    }
}