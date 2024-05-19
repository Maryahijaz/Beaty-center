namespace Beaty_center
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
            Email = new TextBox();
            txtPhoneNumber = new TextBox();
            btnReservationInfo = new Button();
            sur = new TextBox();
            NameC = new TextBox();
            Reser = new Label();
            comServices = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
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
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comServices);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(btnReservationInfo);
            panel1.Controls.Add(sur);
            panel1.Controls.Add(NameC);
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
            // Email
            // 
            Email.BackColor = Color.White;
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Email.ForeColor = Color.DarkMagenta;
            Email.Location = new Point(328, 169);
            Email.Margin = new Padding(3, 4, 3, 4);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.PlaceholderText = "Email";
            Email.Size = new Size(217, 33);
            Email.TabIndex = 5;
            Email.TextAlign = HorizontalAlignment.Center;
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
            btnReservationInfo.Location = new Point(171, 331);
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
            sur.PlaceholderText = " Surname";
            sur.Size = new Size(217, 33);
            sur.TabIndex = 2;
            sur.TextAlign = HorizontalAlignment.Center;
            // 
            // NameC
            // 
            NameC.BackColor = Color.White;
            NameC.BorderStyle = BorderStyle.FixedSingle;
            NameC.Font = new Font("Lucida Handwriting", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameC.ForeColor = Color.DarkMagenta;
            NameC.Location = new Point(32, 105);
            NameC.Margin = new Padding(3, 4, 3, 4);
            NameC.Multiline = true;
            NameC.Name = "NameC";
            NameC.PlaceholderText = " Name";
            NameC.Size = new Size(217, 33);
            NameC.TabIndex = 1;
            NameC.TextAlign = HorizontalAlignment.Center;
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
            // comServices
            // 
            comServices.FormattingEnabled = true;
            comServices.Items.AddRange(new object[] { "Facail", "Spa", "Hair Cut" });
            comServices.Location = new Point(98, 240);
            comServices.Name = "comServices";
            comServices.Size = new Size(151, 28);
            comServices.TabIndex = 14;
            // 
            // label2
            // 
            label2.Font = new Font("Lucida Calligraphy", 6F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(32, 240);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 15;
            label2.Text = "Services";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(307, 241);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
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
            Load += Reservation_Load;
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
        private TextBox NameC;
        private TextBox sur;
        private Button btnReservationInfo;
        private TextBox txtPhoneNumber;
        private TextBox Email;
        private PictureBox pictureBox2;
        private Label label2;
        private ComboBox comServices;
        private DateTimePicker dateTimePicker1;
    }
}