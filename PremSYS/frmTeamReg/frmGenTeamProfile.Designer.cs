﻿namespace frmTeamReg
{
    partial class frmGenTeamProfile
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
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.mnuRegTeam = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTeams = new System.Windows.Forms.GroupBox();
            this.txtHG = new System.Windows.Forms.TextBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grdTeamInfo = new System.Windows.Forms.DataGridView();
            this.mnuRegTeam.SuspendLayout();
            this.grpTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeamInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTeams
            // 
            this.cboTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Location = new System.Drawing.Point(49, 80);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(156, 21);
            this.cboTeams.TabIndex = 0;
            this.cboTeams.SelectedIndexChanged += new System.EventHandler(this.cboTeams_SelectedIndexChanged);
            // 
            // mnuRegTeam
            // 
            this.mnuRegTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.exitToolStripMenuItem});
            this.mnuRegTeam.Location = new System.Drawing.Point(0, 0);
            this.mnuRegTeam.Name = "mnuRegTeam";
            this.mnuRegTeam.Size = new System.Drawing.Size(1033, 24);
            this.mnuRegTeam.TabIndex = 59;
            this.mnuRegTeam.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpTeams
            // 
            this.grpTeams.Controls.Add(this.txtHG);
            this.grpTeams.Controls.Add(this.txtManager);
            this.grpTeams.Controls.Add(this.label3);
            this.grpTeams.Controls.Add(this.label2);
            this.grpTeams.Controls.Add(this.label1);
            this.grpTeams.Controls.Add(this.txtName);
            this.grpTeams.Location = new System.Drawing.Point(673, 27);
            this.grpTeams.Name = "grpTeams";
            this.grpTeams.Size = new System.Drawing.Size(360, 159);
            this.grpTeams.TabIndex = 60;
            this.grpTeams.TabStop = false;
            this.grpTeams.Text = "Team Profile";
            // 
            // txtHG
            // 
            this.txtHG.Location = new System.Drawing.Point(102, 103);
            this.txtHG.Name = "txtHG";
            this.txtHG.ReadOnly = true;
            this.txtHG.Size = new System.Drawing.Size(100, 20);
            this.txtHG.TabIndex = 5;
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(102, 62);
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(100, 20);
            this.txtManager.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home Ground";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 19);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // grdTeamInfo
            // 
            this.grdTeamInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeamInfo.Location = new System.Drawing.Point(49, 177);
            this.grdTeamInfo.Name = "grdTeamInfo";
            this.grdTeamInfo.Size = new System.Drawing.Size(431, 157);
            this.grdTeamInfo.TabIndex = 61;
            this.grdTeamInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTeamInfo_CellContentClick);
            // 
            // frmGenTeamProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 504);
            this.Controls.Add(this.grdTeamInfo);
            this.Controls.Add(this.grpTeams);
            this.Controls.Add(this.mnuRegTeam);
            this.Controls.Add(this.cboTeams);
            this.Name = "frmGenTeamProfile";
            this.Text = "frmGenTeamProfile";
            this.Load += new System.EventHandler(this.frmGenTeamProfile_Load);
            this.mnuRegTeam.ResumeLayout(false);
            this.mnuRegTeam.PerformLayout();
            this.grpTeams.ResumeLayout(false);
            this.grpTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeamInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.MenuStrip mnuRegTeam;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpTeams;
        private System.Windows.Forms.TextBox txtHG;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView grdTeamInfo;
    }
}