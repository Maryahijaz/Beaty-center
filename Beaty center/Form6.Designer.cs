namespace Beaty_center
{
    partial class ReserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserList));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            Home = new Button();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            Employee = new Button();
            CustomerRegistration = new Button();
            panelPlaceholder = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Home);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(Employee);
            panel1.Controls.Add(CustomerRegistration);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 104);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(826, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            Home.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Home.BackColor = Color.SteelBlue;
            Home.FlatStyle = FlatStyle.Popup;
            Home.Font = new Font("Lucida Calligraphy", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Home.ForeColor = Color.Silver;
            Home.Location = new Point(826, 13);
            Home.Name = "Home";
            Home.Size = new Size(146, 76);
            Home.TabIndex = 8;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(536, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(254, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Employee
            // 
            Employee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Employee.BackColor = Color.SteelBlue;
            Employee.FlatStyle = FlatStyle.Popup;
            Employee.Font = new Font("Lucida Calligraphy", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Employee.ForeColor = Color.Silver;
            Employee.Location = new Point(536, 13);
            Employee.Name = "Employee";
            Employee.Size = new Size(146, 76);
            Employee.TabIndex = 3;
            Employee.Text = "Employee";
            Employee.UseVisualStyleBackColor = false;
            Employee.Click += Employee_Click;
            // 
            // CustomerRegistration
            // 
            CustomerRegistration.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerRegistration.BackColor = Color.SteelBlue;
            CustomerRegistration.FlatStyle = FlatStyle.Popup;
            CustomerRegistration.Font = new Font("Lucida Calligraphy", 8F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerRegistration.ForeColor = Color.Silver;
            CustomerRegistration.Location = new Point(254, 13);
            CustomerRegistration.Name = "CustomerRegistration";
            CustomerRegistration.Size = new Size(145, 76);
            CustomerRegistration.TabIndex = 1;
            CustomerRegistration.Text = "Customer Registration";
            CustomerRegistration.UseVisualStyleBackColor = false;
            CustomerRegistration.Click += CustomerRegistration_Click;
            // 
            // panelPlaceholder
            // 
            panelPlaceholder.Location = new Point(0, 158);
            panelPlaceholder.Name = "panelPlaceholder";
            panelPlaceholder.Size = new Size(1102, 715);
            panelPlaceholder.TabIndex = 2;
            // 
            // ReserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 872);
            Controls.Add(panelPlaceholder);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReserList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReserList";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panelPlaceholder;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button CustomerRegistration;
        private Button Employee;
        private Button Home;
        private PictureBox pictureBox2;
    }
}