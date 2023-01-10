
namespace PLFootballSystem.Forms.FirstTeamForm
{
    partial class SelectFirstTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFirstTeam));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblGoalkeeper = new System.Windows.Forms.Label();
            this.pAttack = new System.Windows.Forms.Panel();
            this.pMidfield = new System.Windows.Forms.Panel();
            this.pbGoalkeeper = new System.Windows.Forms.PictureBox();
            this.pDefense = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblGoalkeeper2 = new System.Windows.Forms.Label();
            this.pAttack2 = new System.Windows.Forms.Panel();
            this.pMidfield2 = new System.Windows.Forms.Panel();
            this.pbGoalkeeper2 = new System.Windows.Forms.PictureBox();
            this.pDefense2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddFirstTeam = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoalkeeper)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoalkeeper2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackgroundImage = global::PLFootballSystem.Properties.Resources.teren;
            this.tabPage1.Controls.Add(this.lblGoalkeeper);
            this.tabPage1.Controls.Add(this.pAttack);
            this.tabPage1.Controls.Add(this.pMidfield);
            this.tabPage1.Controls.Add(this.pbGoalkeeper);
            this.tabPage1.Controls.Add(this.pDefense);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblGoalkeeper
            // 
            resources.ApplyResources(this.lblGoalkeeper, "lblGoalkeeper");
            this.lblGoalkeeper.Name = "lblGoalkeeper";
            // 
            // pAttack
            // 
            resources.ApplyResources(this.pAttack, "pAttack");
            this.pAttack.Name = "pAttack";
            // 
            // pMidfield
            // 
            resources.ApplyResources(this.pMidfield, "pMidfield");
            this.pMidfield.Name = "pMidfield";
            // 
            // pbGoalkeeper
            // 
            resources.ApplyResources(this.pbGoalkeeper, "pbGoalkeeper");
            this.pbGoalkeeper.BackColor = System.Drawing.Color.Transparent;
            this.pbGoalkeeper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGoalkeeper.Image = global::PLFootballSystem.Properties.Resources.clickMe1;
            this.pbGoalkeeper.Name = "pbGoalkeeper";
            this.pbGoalkeeper.TabStop = false;
            this.pbGoalkeeper.Tag = "0";
            // 
            // pDefense
            // 
            resources.ApplyResources(this.pDefense, "pDefense");
            this.pDefense.Name = "pDefense";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackgroundImage = global::PLFootballSystem.Properties.Resources.teren;
            this.tabPage2.Controls.Add(this.lblGoalkeeper2);
            this.tabPage2.Controls.Add(this.pAttack2);
            this.tabPage2.Controls.Add(this.pMidfield2);
            this.tabPage2.Controls.Add(this.pbGoalkeeper2);
            this.tabPage2.Controls.Add(this.pDefense2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblGoalkeeper2
            // 
            resources.ApplyResources(this.lblGoalkeeper2, "lblGoalkeeper2");
            this.lblGoalkeeper2.Name = "lblGoalkeeper2";
            // 
            // pAttack2
            // 
            resources.ApplyResources(this.pAttack2, "pAttack2");
            this.pAttack2.Name = "pAttack2";
            // 
            // pMidfield2
            // 
            resources.ApplyResources(this.pMidfield2, "pMidfield2");
            this.pMidfield2.Name = "pMidfield2";
            // 
            // pbGoalkeeper2
            // 
            resources.ApplyResources(this.pbGoalkeeper2, "pbGoalkeeper2");
            this.pbGoalkeeper2.BackColor = System.Drawing.Color.Transparent;
            this.pbGoalkeeper2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGoalkeeper2.Image = global::PLFootballSystem.Properties.Resources.clickMe1;
            this.pbGoalkeeper2.Name = "pbGoalkeeper2";
            this.pbGoalkeeper2.TabStop = false;
            this.pbGoalkeeper2.Tag = "0";
            // 
            // pDefense2
            // 
            resources.ApplyResources(this.pDefense2, "pDefense2");
            this.pDefense2.Name = "pDefense2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnAddFirstTeam);
            this.panel1.Name = "panel1";
            // 
            // btnAddFirstTeam
            // 
            resources.ApplyResources(this.btnAddFirstTeam, "btnAddFirstTeam");
            this.btnAddFirstTeam.FlatAppearance.BorderSize = 0;
            this.btnAddFirstTeam.Name = "btnAddFirstTeam";
            this.btnAddFirstTeam.UseVisualStyleBackColor = true;
            this.btnAddFirstTeam.Click += new System.EventHandler(this.btnAddFirstTeam_Click);
            // 
            // SelectFirstTeam
            // 
            this.AcceptButton = this.btnAddFirstTeam;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "SelectFirstTeam";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoalkeeper)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoalkeeper2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pDefense;
        private System.Windows.Forms.PictureBox pbGoalkeeper;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pAttack;
        private System.Windows.Forms.Panel pMidfield;
        private System.Windows.Forms.Label lblGoalkeeper;
        private System.Windows.Forms.Label lblGoalkeeper2;
        private System.Windows.Forms.Panel pAttack2;
        private System.Windows.Forms.Panel pMidfield2;
        private System.Windows.Forms.PictureBox pbGoalkeeper2;
        private System.Windows.Forms.Panel pDefense2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddFirstTeam;
    }
}