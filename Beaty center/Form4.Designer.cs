﻿namespace Beaty_center
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            HOME = new Button();
            label1 = new Label();
            Services = new Button();
            ContactUs = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            txtPhoneNumber = new TextBox();
            btnReservationInfo = new Button();
            sur = new TextBox();
            textBox1 = new TextBox();
            Reser = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // HOME
            // 
            HOME.BackColor = Color.Silver;
            HOME.FlatStyle = FlatStyle.Popup;
            HOME.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HOME.ForeColor = Color.DarkMagenta;
            HOME.Location = new Point(582, 15);
            HOME.Name = "HOME";
            HOME.Size = new Size(94, 29);
            HOME.TabIndex = 2;
            HOME.Text = "Home";
            HOME.UseVisualStyleBackColor = false;
            HOME.Click += HOME_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(532, 66);
            label1.TabIndex = 4;
            label1.Text = "CHERRY BEAUTY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Services
            // 
            Services.BackColor = Color.Silver;
            Services.FlatStyle = FlatStyle.Popup;
            Services.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Services.ForeColor = Color.DarkMagenta;
            Services.Location = new Point(699, 15);
            Services.Name = "Services";
            Services.Size = new Size(94, 29);
            Services.TabIndex = 11;
            Services.Text = "Services";
            Services.UseVisualStyleBackColor = false;
            Services.Click += Services_Click;
            // 
            // ContactUs
            // 
            ContactUs.BackColor = Color.Silver;
            ContactUs.FlatStyle = FlatStyle.Popup;
            ContactUs.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ContactUs.ForeColor = Color.DarkMagenta;
            ContactUs.Location = new Point(817, 15);
            ContactUs.Name = "ContactUs";
            ContactUs.Size = new Size(94, 29);
            ContactUs.TabIndex = 12;
            ContactUs.Text = "Contact ";
            ContactUs.UseVisualStyleBackColor = false;
            ContactUs.Click += ContactUs_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(btnReservationInfo);
            panel1.Controls.Add(sur);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Reser);
            panel1.Location = new Point(161, 145);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 409);
            panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.DarkMagenta;
            textBox2.Location = new Point(328, 169);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Email";
            textBox2.Size = new Size(217, 33);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.ForeColor = Color.DarkMagenta;
            txtPhoneNumber.Location = new Point(32, 169);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(217, 33);
            txtPhoneNumber.TabIndex = 4;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btnReservationInfo
            // 
            btnReservationInfo.BackColor = SystemColors.Window;
            btnReservationInfo.BackgroundImageLayout = ImageLayout.None;
            btnReservationInfo.FlatStyle = FlatStyle.Popup;
            btnReservationInfo.ForeColor = Color.DarkMagenta;
            btnReservationInfo.Location = new Point(181, 248);
            btnReservationInfo.Margin = new Padding(3, 4, 3, 4);
            btnReservationInfo.Name = "btnReservationInfo";
            btnReservationInfo.Size = new Size(217, 47);
            btnReservationInfo.TabIndex = 3;
            btnReservationInfo.Text = "Reservation";
            btnReservationInfo.UseVisualStyleBackColor = false;
            btnReservationInfo.Click += button1_Click;
            // 
            // sur
            // 
            sur.BorderStyle = BorderStyle.FixedSingle;
            sur.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sur.ForeColor = Color.DarkMagenta;
            sur.Location = new Point(328, 105);
            sur.Margin = new Padding(3, 4, 3, 4);
            sur.Multiline = true;
            sur.Name = "sur";
            sur.PlaceholderText = "User Surname";
            sur.Size = new Size(217, 33);
            sur.TabIndex = 2;
            sur.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DarkMagenta;
            textBox1.Location = new Point(32, 105);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "User Name";
            textBox1.Size = new Size(217, 33);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Reser
            // 
            Reser.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Reser.ForeColor = Color.DarkMagenta;
            Reser.Location = new Point(32, 0);
            Reser.Name = "Reser";
            Reser.Size = new Size(513, 48);
            Reser.TabIndex = 0;
            Reser.Text = "Reservation";
            Reser.TextAlign = ContentAlignment.MiddleCenter;
            Reser.Click += Reser_Click;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(ContactUs);
            Controls.Add(Services);
            Controls.Add(label1);
            Controls.Add(HOME);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HOME;
        private Label label1;
        private Button Services;
        private Button ContactUs;
        private Panel panel1;
        private Label Reser;
        private TextBox textBox1;
        private TextBox sur;
        private Button btnReservationInfo;
        private TextBox txtPhoneNumber;
        private TextBox textBox2;
        private PictureBox pictureBox2;
    }
}