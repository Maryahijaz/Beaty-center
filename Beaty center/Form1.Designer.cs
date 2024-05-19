namespace Beaty_center
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            CherryBeauty = new Label();
            HOME = new Button();
            Services = new Button();
            ContactUs = new Button();
            Login = new Button();
            Reservation = new Button();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(961, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CherryBeauty
            // 
            CherryBeauty.BackColor = Color.Silver;
            CherryBeauty.BorderStyle = BorderStyle.FixedSingle;
            CherryBeauty.FlatStyle = FlatStyle.Popup;
            CherryBeauty.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CherryBeauty.ForeColor = Color.DarkMagenta;
            CherryBeauty.Location = new Point(385, 0);
            CherryBeauty.Name = "CherryBeauty";
            CherryBeauty.Size = new Size(250, 54);
            CherryBeauty.TabIndex = 1;
            CherryBeauty.Text = "CHERRY BEAUTY";
            CherryBeauty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HOME
            // 
            HOME.BackColor = Color.Silver;
            HOME.FlatStyle = FlatStyle.Popup;
            HOME.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HOME.ForeColor = Color.DarkMagenta;
            HOME.Location = new Point(11, 12);
            HOME.Name = "HOME";
            HOME.Size = new Size(94, 29);
            HOME.TabIndex = 2;
            HOME.Text = "Home";
            HOME.UseVisualStyleBackColor = false;
            HOME.Click += HOME_Click;
            // 
            // Services
            // 
            Services.BackColor = Color.Silver;
            Services.FlatStyle = FlatStyle.Popup;
            Services.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Services.ForeColor = Color.DarkMagenta;
            Services.Location = new Point(112, 12);
            Services.Name = "Services";
            Services.Size = new Size(94, 29);
            Services.TabIndex = 3;
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
            ContactUs.Location = new Point(213, 12);
            ContactUs.Name = "ContactUs";
            ContactUs.Size = new Size(94, 29);
            ContactUs.TabIndex = 4;
            ContactUs.Text = "Contact ";
            ContactUs.UseVisualStyleBackColor = false;
            ContactUs.Click += ContactUs_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.Silver;
            Login.FlatStyle = FlatStyle.Popup;
            Login.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Login.ForeColor = Color.DarkMagenta;
            Login.Location = new Point(757, 12);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Reservation
            // 
            Reservation.BackColor = Color.Silver;
            Reservation.FlatStyle = FlatStyle.Popup;
            Reservation.Font = new Font("Magneto", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Reservation.ForeColor = Color.DarkMagenta;
            Reservation.Location = new Point(856, 12);
            Reservation.Name = "Reservation";
            Reservation.Size = new Size(88, 29);
            Reservation.TabIndex = 6;
            Reservation.Text = "Reservation";
            Reservation.UseVisualStyleBackColor = false;
            Reservation.Click += Reservation_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(0, 366);
            label3.Name = "label3";
            label3.Size = new Size(961, 411);
            label3.TabIndex = 7;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(85, 295);
            label2.Name = "label2";
            label2.Size = new Size(789, 47);
            label2.TabIndex = 8;
            label2.Text = "About US";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 777);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Reservation);
            Controls.Add(Login);
            Controls.Add(ContactUs);
            Controls.Add(Services);
            Controls.Add(HOME);
            Controls.Add(CherryBeauty);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label CherryBeauty;
        private Button HOME;
        private Button Services;
        private Button ContactUs;
        private Button Login;
        private Button Reservation;
        private Label label3;
        private Label label2;
    }
}