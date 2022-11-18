
namespace PLFootballSystem.Forms.FootballClubForm
{
    partial class ViewFootballClubForm
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
            this.btnAllFC = new System.Windows.Forms.Button();
            this.btnAddNewFC = new System.Windows.Forms.Button();
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
            // btnAllFC
            // 
            this.btnAllFC.Location = new System.Drawing.Point(13, 69);
            this.btnAllFC.Name = "btnAllFC";
            this.btnAllFC.Size = new System.Drawing.Size(104, 23);
            this.btnAllFC.TabIndex = 1;
            this.btnAllFC.Text = "All football clubs";
            this.btnAllFC.UseVisualStyleBackColor = true;
            this.btnAllFC.Click += new System.EventHandler(this.btnAllFC_Click);
            // 
            // btnAddNewFC
            // 
            this.btnAddNewFC.Location = new System.Drawing.Point(182, 69);
            this.btnAddNewFC.Name = "btnAddNewFC";
            this.btnAddNewFC.Size = new System.Drawing.Size(140, 23);
            this.btnAddNewFC.TabIndex = 2;
            this.btnAddNewFC.Text = "Add new Football club";
            this.btnAddNewFC.UseVisualStyleBackColor = true;
            this.btnAddNewFC.Click += new System.EventHandler(this.btnAddNewFC_Click);
            // 
            // ViewFootballClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 255);
            this.Controls.Add(this.btnAddNewFC);
            this.Controls.Add(this.btnAllFC);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFootballClubForm";
            this.Text = "ViewFootballClubForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAllFC;
        private System.Windows.Forms.Button btnAddNewFC;
    }
}