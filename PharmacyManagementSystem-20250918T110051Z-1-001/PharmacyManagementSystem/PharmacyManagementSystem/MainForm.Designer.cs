namespace PharmacyManagementSystem
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new PharmacyManagementSystem.AdminDashboard();
            this.dashBtn = new System.Windows.Forms.Button();
            this.invBtn = new System.Windows.Forms.Button();
            this.ordBtn = new System.Windows.Forms.Button();
            this.alertBtn = new System.Windows.Forms.Button();
            this.Archivebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.adminDashboard1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(190, 55);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(876, 595);
            this.mainPanel.TabIndex = 2;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adminDashboard1.Location = new System.Drawing.Point(-11, -12);
            this.adminDashboard1.Margin = new System.Windows.Forms.Padding(2);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(876, 596);
            this.adminDashboard1.TabIndex = 0;
            this.adminDashboard1.Load += new System.EventHandler(this.adminDashboard1_Load);
            // 
            // dashBtn
            // 
            this.dashBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.dashBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBtn.ForeColor = System.Drawing.Color.White;
            this.dashBtn.Location = new System.Drawing.Point(0, 0);
            this.dashBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dashBtn.Name = "dashBtn";
            this.dashBtn.Size = new System.Drawing.Size(190, 67);
            this.dashBtn.TabIndex = 2;
            this.dashBtn.Text = "DASHBOARD";
            this.dashBtn.UseVisualStyleBackColor = false;
            this.dashBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // invBtn
            // 
            this.invBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.invBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.invBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invBtn.ForeColor = System.Drawing.Color.White;
            this.invBtn.Location = new System.Drawing.Point(0, 67);
            this.invBtn.Margin = new System.Windows.Forms.Padding(2);
            this.invBtn.Name = "invBtn";
            this.invBtn.Size = new System.Drawing.Size(190, 67);
            this.invBtn.TabIndex = 3;
            this.invBtn.Text = "INVENTORY";
            this.invBtn.UseVisualStyleBackColor = false;
            this.invBtn.Click += new System.EventHandler(this.invBtn_Click);
            // 
            // ordBtn
            // 
            this.ordBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.ordBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordBtn.ForeColor = System.Drawing.Color.White;
            this.ordBtn.Location = new System.Drawing.Point(0, 134);
            this.ordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ordBtn.Name = "ordBtn";
            this.ordBtn.Size = new System.Drawing.Size(190, 67);
            this.ordBtn.TabIndex = 4;
            this.ordBtn.Text = "Categories Management";
            this.ordBtn.UseVisualStyleBackColor = false;
            this.ordBtn.Click += new System.EventHandler(this.ordBtn_Click);
            // 
            // alertBtn
            // 
            this.alertBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.alertBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertBtn.ForeColor = System.Drawing.Color.White;
            this.alertBtn.Location = new System.Drawing.Point(0, 201);
            this.alertBtn.Margin = new System.Windows.Forms.Padding(2);
            this.alertBtn.Name = "alertBtn";
            this.alertBtn.Size = new System.Drawing.Size(190, 67);
            this.alertBtn.TabIndex = 5;
            this.alertBtn.Text = "Order Management";
            this.alertBtn.UseVisualStyleBackColor = false;
            this.alertBtn.Click += new System.EventHandler(this.alertBtn_Click);
            // 
            // Archivebtn
            // 
            this.Archivebtn.BackColor = System.Drawing.Color.DarkGreen;
            this.Archivebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Archivebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archivebtn.ForeColor = System.Drawing.Color.White;
            this.Archivebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Archivebtn.Location = new System.Drawing.Point(0, 268);
            this.Archivebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Archivebtn.Name = "Archivebtn";
            this.Archivebtn.Size = new System.Drawing.Size(190, 67);
            this.Archivebtn.TabIndex = 6;
            this.Archivebtn.Text = "Archive";
            this.Archivebtn.UseVisualStyleBackColor = false;
            this.Archivebtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 335);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 67);
            this.button1.TabIndex = 7;
            this.button1.Text = "User management";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Archivebtn);
            this.panel2.Controls.Add(this.alertBtn);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.ordBtn);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.invBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dashBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 595);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(88, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nine 27 Pharmacy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 55);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(9, 152);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(9, 85);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 650);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private AdminDashboard adminDashboard1;
        private System.Windows.Forms.Button dashBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ordBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button alertBtn;
        private System.Windows.Forms.Button Archivebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

