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
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            Employee = new Button();
            CustomerDetails = new Button();
            CustomerRegistration = new Button();
            ServicesAdding = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Employee);
            panel1.Controls.Add(CustomerDetails);
            panel1.Controls.Add(CustomerRegistration);
            panel1.Controls.Add(ServicesAdding);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 104);
            panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(744, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(539, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(332, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(128, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Employee
            // 
            Employee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Employee.BackColor = Color.SteelBlue;
            Employee.FlatStyle = FlatStyle.Popup;
            Employee.Font = new Font("Lucida Calligraphy", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Employee.ForeColor = Color.Silver;
            Employee.Location = new Point(744, 13);
            Employee.Name = "Employee";
            Employee.Size = new Size(146, 76);
            Employee.TabIndex = 3;
            Employee.Text = "Employee";
            Employee.UseVisualStyleBackColor = false;
            Employee.Click += Employee_Click;
            // 
            // CustomerDetails
            // 
            CustomerDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerDetails.BackColor = Color.SteelBlue;
            CustomerDetails.FlatStyle = FlatStyle.Popup;
            CustomerDetails.Font = new Font("Lucida Calligraphy", 8F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerDetails.ForeColor = Color.Silver;
            CustomerDetails.Location = new Point(539, 13);
            CustomerDetails.Name = "CustomerDetails";
            CustomerDetails.Size = new Size(142, 76);
            CustomerDetails.TabIndex = 2;
            CustomerDetails.Text = "Customer Details";
            CustomerDetails.UseVisualStyleBackColor = false;
            // 
            // CustomerRegistration
            // 
            CustomerRegistration.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomerRegistration.BackColor = Color.SteelBlue;
            CustomerRegistration.FlatStyle = FlatStyle.Popup;
            CustomerRegistration.Font = new Font("Lucida Calligraphy", 8F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerRegistration.ForeColor = Color.Silver;
            CustomerRegistration.Location = new Point(332, 13);
            CustomerRegistration.Name = "CustomerRegistration";
            CustomerRegistration.Size = new Size(145, 76);
            CustomerRegistration.TabIndex = 1;
            CustomerRegistration.Text = "Customer Registration";
            CustomerRegistration.UseVisualStyleBackColor = false;
            CustomerRegistration.Click += CustomerRegistration_Click;
            // 
            // ServicesAdding
            // 
            ServicesAdding.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ServicesAdding.BackColor = Color.SteelBlue;
            ServicesAdding.FlatAppearance.BorderColor = SystemColors.Control;
            ServicesAdding.FlatAppearance.MouseDownBackColor = Color.DarkMagenta;
            ServicesAdding.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            ServicesAdding.FlatStyle = FlatStyle.Popup;
            ServicesAdding.Font = new Font("Lucida Calligraphy", 8F, FontStyle.Bold, GraphicsUnit.Point);
            ServicesAdding.ForeColor = Color.Silver;
            ServicesAdding.Location = new Point(128, 11);
            ServicesAdding.Name = "ServicesAdding";
            ServicesAdding.Size = new Size(142, 78);
            ServicesAdding.TabIndex = 0;
            ServicesAdding.Text = "Add Services";
            ServicesAdding.UseVisualStyleBackColor = false;
            ServicesAdding.Click += ServicesAdding_Click;
            ServicesAdding.DragOver += ServicesAdding_DragOver;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 462);
            panel2.TabIndex = 2;
            // 
            // ReserList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReserList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReserList";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button CustomerDetails;
        private Button CustomerRegistration;
        private Button ServicesAdding;
        private Button Employee;
    }
}