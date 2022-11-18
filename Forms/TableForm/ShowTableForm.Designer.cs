
namespace PLFootballSystem.Forms.TableForm
{
    partial class ShowTableForm
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
            this.lvTable = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvTable
            // 
            this.lvTable.HideSelection = false;
            this.lvTable.Location = new System.Drawing.Point(12, 13);
            this.lvTable.Name = "lvTable";
            this.lvTable.Size = new System.Drawing.Size(252, 425);
            this.lvTable.TabIndex = 0;
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.View = System.Windows.Forms.View.List;
            // 
            // ShowTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 450);
            this.Controls.Add(this.lvTable);
            this.Name = "ShowTableForm";
            this.Text = "ShowTableForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTable;
    }
}