namespace CarRental
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.BntRental = new System.Windows.Forms.Button();
            this.BtnCars = new System.Windows.Forms.Button();
            this.BtnClient = new System.Windows.Forms.Button();
            this.PanelLeft.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.PanelLeft.Controls.Add(this.panel1);
            this.PanelLeft.Controls.Add(this.BntRental);
            this.PanelLeft.Controls.Add(this.BtnCars);
            this.PanelLeft.Controls.Add(this.BtnClient);
            this.PanelLeft.Controls.Add(this.menuStrip1);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(119, 387);
            this.PanelLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(114, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 363);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(119, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Logut";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.PanelContainer.Location = new System.Drawing.Point(117, 24);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(684, 363);
            this.PanelContainer.TabIndex = 2;
            // 
            // BntRental
            // 
            this.BntRental.FlatAppearance.BorderSize = 0;
            this.BntRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntRental.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntRental.ForeColor = System.Drawing.SystemColors.Control;
            this.BntRental.Image = global::CarRental.Properties.Resources.icons8_car_rental_32;
            this.BntRental.Location = new System.Drawing.Point(0, 166);
            this.BntRental.Name = "BntRental";
            this.BntRental.Size = new System.Drawing.Size(118, 54);
            this.BntRental.TabIndex = 1;
            this.BntRental.Text = "Rental";
            this.BntRental.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BntRental.UseVisualStyleBackColor = true;
            this.BntRental.Click += new System.EventHandler(this.BntRental_Click);
            // 
            // BtnCars
            // 
            this.BtnCars.FlatAppearance.BorderSize = 0;
            this.BtnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCars.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCars.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCars.Image = global::CarRental.Properties.Resources.icons8_car1_32;
            this.BtnCars.Location = new System.Drawing.Point(2, 52);
            this.BtnCars.Name = "BtnCars";
            this.BtnCars.Size = new System.Drawing.Size(118, 54);
            this.BtnCars.TabIndex = 0;
            this.BtnCars.Text = "Cars";
            this.BtnCars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCars.UseVisualStyleBackColor = true;
            this.BtnCars.Click += new System.EventHandler(this.BtnCars_Click);
            // 
            // BtnClient
            // 
            this.BtnClient.FlatAppearance.BorderSize = 0;
            this.BtnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClient.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClient.Image = global::CarRental.Properties.Resources.icons8_customer_32;
            this.BtnClient.Location = new System.Drawing.Point(0, 109);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(118, 54);
            this.BtnClient.TabIndex = 1;
            this.BtnClient.Text = "Client";
            this.BtnClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClient.UseVisualStyleBackColor = true;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // FormMain
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
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelLeft.ResumeLayout(false);
            this.PanelLeft.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Button BtnCars;
        private System.Windows.Forms.Button BntRental;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

