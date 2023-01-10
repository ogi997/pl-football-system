
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAccountForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.lvAllAccounts = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvAllAccounts
            // 
            resources.ApplyResources(this.lvAllAccounts, "lvAllAccounts");
            this.lvAllAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username,
            this.Role,
            this.Status});
            this.lvAllAccounts.FullRowSelect = true;
            this.lvAllAccounts.HideSelection = false;
            this.lvAllAccounts.Name = "lvAllAccounts";
            this.lvAllAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAllAccounts.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            resources.ApplyResources(this.Username, "Username");
            // 
            // Role
            // 
            resources.ApplyResources(this.Role, "Role");
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActive
            // 
            resources.ApplyResources(this.btnActive, "btnActive");
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.Name = "btnActive";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // lblSearch
            // 
            resources.ApplyResources(this.lblSearch, "lblSearch");
            this.lblSearch.Name = "lblSearch";
            // 
            // btnAddAccount
            // 
            resources.ApplyResources(this.btnAddAccount, "btnAddAccount");
            this.btnAddAccount.FlatAppearance.BorderSize = 0;
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // AllAccountForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvAllAccounts);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllAccountForm";
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
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnUpdate;
    }
}