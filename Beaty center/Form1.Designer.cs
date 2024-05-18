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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(841, 206);
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
            CherryBeauty.Location = new Point(337, 0);
            CherryBeauty.Name = "CherryBeauty";
            CherryBeauty.Size = new Size(219, 41);
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
            HOME.Location = new Point(10, 9);
            HOME.Margin = new Padding(3, 2, 3, 2);
            HOME.Name = "HOME";
            HOME.Size = new Size(82, 22);
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
            Services.Location = new Point(98, 9);
            Services.Margin = new Padding(3, 2, 3, 2);
            Services.Name = "Services";
            Services.Size = new Size(82, 22);
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
            ContactUs.Location = new Point(186, 9);
            ContactUs.Margin = new Padding(3, 2, 3, 2);
            ContactUs.Name = "ContactUs";
            ContactUs.Size = new Size(82, 22);
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
            Login.Location = new Point(662, 9);
            Login.Margin = new Padding(3, 2, 3, 2);
            Login.Name = "Login";
            Login.Size = new Size(82, 22);
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
            Reservation.Location = new Point(749, 9);
            Reservation.Margin = new Padding(3, 2, 3, 2);
            Reservation.Name = "Reservation";
            Reservation.Size = new Size(77, 22);
            Reservation.TabIndex = 6;
            Reservation.Text = "Reservation";
            Reservation.UseVisualStyleBackColor = false;
            Reservation.Click += Reservation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 583);
            Controls.Add(Reservation);
            Controls.Add(Login);
            Controls.Add(ContactUs);
            Controls.Add(Services);
            Controls.Add(HOME);
            Controls.Add(CherryBeauty);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}