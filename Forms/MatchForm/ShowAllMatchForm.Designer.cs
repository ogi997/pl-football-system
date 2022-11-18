
namespace PLFootballSystem.Forms.MatchForm
{
    partial class ShowAllMatchForm
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
            this.lvAllMatch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenFirstTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(423, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvAllMatch
            // 
            this.lvAllMatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAllMatch.FullRowSelect = true;
            this.lvAllMatch.HideSelection = false;
            this.lvAllMatch.Location = new System.Drawing.Point(13, 13);
            this.lvAllMatch.Name = "lvAllMatch";
            this.lvAllMatch.Size = new System.Drawing.Size(404, 240);
            this.lvAllMatch.TabIndex = 1;
            this.lvAllMatch.UseCompatibleStateImageBehavior = false;
            this.lvAllMatch.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Home";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Home goals";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Away goals";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Away";
            this.columnHeader4.Width = 117;
            // 
            // btnOpenFirstTeam
            // 
            this.btnOpenFirstTeam.Location = new System.Drawing.Point(424, 13);
            this.btnOpenFirstTeam.Name = "btnOpenFirstTeam";
            this.btnOpenFirstTeam.Size = new System.Drawing.Size(75, 45);
            this.btnOpenFirstTeam.TabIndex = 2;
            this.btnOpenFirstTeam.Text = "Open First team";
            this.btnOpenFirstTeam.UseVisualStyleBackColor = true;
            this.btnOpenFirstTeam.Click += new System.EventHandler(this.btnOpenFirstTeam_Click);
            // 
            // ShowAllMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 265);
            this.Controls.Add(this.btnOpenFirstTeam);
            this.Controls.Add(this.lvAllMatch);
            this.Controls.Add(this.btnClose);
            this.Name = "ShowAllMatchForm";
            this.Text = "ShowAllMatchForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvAllMatch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnOpenFirstTeam;
    }
}