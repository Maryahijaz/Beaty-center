namespace Beaty_center
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            txtName = new TextBox();
            txtMessage = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Send = new Button();
            HOME = new Button();
            Reservation = new Button();
            Services = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightGray;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.DarkMagenta;
            txtName.Location = new Point(34, 191);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(265, 34);
            txtName.TabIndex = 0;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.LightGray;
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.ForeColor = Color.DarkMagenta;
            txtMessage.Location = new Point(34, 309);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Message";
            txtMessage.Size = new Size(265, 153);
            txtMessage.TabIndex = 1;
            txtMessage.TextChanged += textBox2_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.DarkMagenta;
            txtEmail.Location = new Point(34, 252);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(265, 34);
            txtEmail.TabIndex = 2;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            txtEmail.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Silver;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(532, 66);
            label1.TabIndex = 3;
            label1.Text = "CHERRY BEAUTY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(273, 115);
            label2.Name = "label2";
            label2.Size = new Size(221, 47);
            label2.TabIndex = 4;
            label2.Text = "CONTACT US";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(463, 252);
            label3.Name = "label3";
            label3.Size = new Size(442, 211);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.BackColor = Color.LightGray;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkMagenta;
            label4.Location = new Point(463, 191);
            label4.Name = "label4";
            label4.Size = new Size(333, 47);
            label4.TabIndex = 6;
            label4.Text = "Questions or Comments?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Send
            // 
            Send.BackColor = Color.LightGray;
            Send.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Send.ForeColor = Color.DarkMagenta;
            Send.Location = new Point(34, 489);
            Send.Name = "Send";
            Send.Size = new Size(265, 35);
            Send.TabIndex = 7;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = false;
            Send.Click += Send_Click;
            // 
            // HOME
            // 
            HOME.BackColor = Color.Silver;
            HOME.FlatStyle = FlatStyle.Popup;
            HOME.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HOME.ForeColor = Color.DarkMagenta;
            HOME.Location = new Point(555, 15);
            HOME.Name = "HOME";
            HOME.Size = new Size(94, 29);
            HOME.TabIndex = 8;
            HOME.Text = "Home";
            HOME.UseVisualStyleBackColor = false;
            HOME.Click += HOME_Click;
            // 
            // Reservation
            // 
            Reservation.BackColor = Color.Silver;
            Reservation.FlatStyle = FlatStyle.Popup;
            Reservation.Font = new Font("Magneto", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Reservation.ForeColor = Color.DarkMagenta;
            Reservation.Location = new Point(778, 15);
            Reservation.Name = "Reservation";
            Reservation.Size = new Size(88, 29);
            Reservation.TabIndex = 9;
            Reservation.Text = "Reservation";
            Reservation.UseVisualStyleBackColor = false;
            Reservation.Click += Reservation_Click;
            // 
            // Services
            // 
            Services.BackColor = Color.Silver;
            Services.FlatStyle = FlatStyle.Popup;
            Services.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Services.ForeColor = Color.DarkMagenta;
            Services.Location = new Point(666, 15);
            Services.Name = "Services";
            Services.Size = new Size(94, 29);
            Services.TabIndex = 10;
            Services.Text = "Services";
            Services.UseVisualStyleBackColor = false;
            Services.Click += Services_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(898, -1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 797);
            Controls.Add(pictureBox2);
            Controls.Add(Services);
            Controls.Add(Reservation);
            Controls.Add(HOME);
            Controls.Add(Send);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtMessage);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cherry beauty";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtMessage;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Send;
        private Button HOME;
        private Button Reservation;
        private Button Services;
        private PictureBox pictureBox2;
    }
}