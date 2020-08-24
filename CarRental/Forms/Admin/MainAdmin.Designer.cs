namespace CarRental
{
    partial class MainAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdmin));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelDropdown = new System.Windows.Forms.Panel();
            this.BtnClientReport = new System.Windows.Forms.Button();
            this.BtnTransaction = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnCarReport = new System.Windows.Forms.Button();
            this.BtnCarReg = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelLeft.SuspendLayout();
            this.PanelDropdown.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.PanelLeft.Controls.Add(this.panel3);
            this.PanelLeft.Controls.Add(this.PanelDropdown);
            this.PanelLeft.Controls.Add(this.BtnCarReg);
            this.PanelLeft.Controls.Add(this.menuStrip1);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(125, 387);
            this.PanelLeft.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(120, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 363);
            this.panel3.TabIndex = 2;
            // 
            // PanelDropdown
            // 
            this.PanelDropdown.Controls.Add(this.BtnClientReport);
            this.PanelDropdown.Controls.Add(this.BtnTransaction);
            this.PanelDropdown.Controls.Add(this.BtnReport);
            this.PanelDropdown.Controls.Add(this.BtnCarReport);
            this.PanelDropdown.Location = new System.Drawing.Point(0, 112);
            this.PanelDropdown.MaximumSize = new System.Drawing.Size(122, 160);
            this.PanelDropdown.MinimumSize = new System.Drawing.Size(122, 57);
            this.PanelDropdown.Name = "PanelDropdown";
            this.PanelDropdown.Size = new System.Drawing.Size(122, 57);
            this.PanelDropdown.TabIndex = 5;
            // 
            // BtnClientReport
            // 
            this.BtnClientReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BtnClientReport.FlatAppearance.BorderSize = 0;
            this.BtnClientReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientReport.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClientReport.Location = new System.Drawing.Point(3, 58);
            this.BtnClientReport.Name = "BtnClientReport";
            this.BtnClientReport.Size = new System.Drawing.Size(119, 35);
            this.BtnClientReport.TabIndex = 4;
            this.BtnClientReport.Text = "Client Report";
            this.BtnClientReport.UseVisualStyleBackColor = false;
            this.BtnClientReport.Click += new System.EventHandler(this.BtnClientReport_Click_1);
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BtnTransaction.FlatAppearance.BorderSize = 0;
            this.BtnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransaction.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnTransaction.Location = new System.Drawing.Point(3, 128);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.Size = new System.Drawing.Size(119, 36);
            this.BtnTransaction.TabIndex = 4;
            this.BtnTransaction.Text = "Rent Report";
            this.BtnTransaction.UseVisualStyleBackColor = false;
            this.BtnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnReport.Image = global::CarRental.Properties.Resources.icons8_report_card_32;
            this.BtnReport.Location = new System.Drawing.Point(0, 0);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(122, 57);
            this.BtnReport.TabIndex = 4;
            this.BtnReport.Text = "Reports";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnCarReport
            // 
            this.BtnCarReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.BtnCarReport.FlatAppearance.BorderSize = 0;
            this.BtnCarReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarReport.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCarReport.Location = new System.Drawing.Point(3, 93);
            this.BtnCarReport.Name = "BtnCarReport";
            this.BtnCarReport.Size = new System.Drawing.Size(119, 35);
            this.BtnCarReport.TabIndex = 5;
            this.BtnCarReport.Text = "Car Report";
            this.BtnCarReport.UseVisualStyleBackColor = false;
            this.BtnCarReport.Click += new System.EventHandler(this.BtnCarReport_Click);
            // 
            // BtnCarReg
            // 
            this.BtnCarReg.FlatAppearance.BorderSize = 0;
            this.BtnCarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarReg.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCarReg.Image = global::CarRental.Properties.Resources.icons8_car1_32;
            this.BtnCarReg.Location = new System.Drawing.Point(3, 52);
            this.BtnCarReg.Name = "BtnCarReg";
            this.BtnCarReg.Size = new System.Drawing.Size(116, 54);
            this.BtnCarReg.TabIndex = 1;
            this.BtnCarReg.Text = "Cars";
            this.BtnCarReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCarReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCarReg.UseVisualStyleBackColor = true;
            this.BtnCarReg.Click += new System.EventHandler(this.BtnCarReg_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(125, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.PanelContainer.Location = new System.Drawing.Point(125, 24);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(675, 360);
            this.PanelContainer.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.MainAdmin_Load);
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            this.PanelDropdown.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Button BtnCarReg;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PanelDropdown;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnTransaction;
        private System.Windows.Forms.Button BtnCarReport;
        private System.Windows.Forms.Button BtnClientReport;
        private System.Windows.Forms.Panel panel3;
    }
}