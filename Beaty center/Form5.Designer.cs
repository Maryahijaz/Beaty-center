namespace Beaty_center
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            HOME = new Button();
            label1 = new Label();
            Services = new Button();
            Reservation = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            StuffLable = new Label();
            pictureBox4 = new PictureBox();
            Login1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            StuffPass = new TextBox();
            Stuffname = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // HOME
            // 
            HOME.BackColor = Color.Silver;
            HOME.FlatStyle = FlatStyle.Popup;
            HOME.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HOME.ForeColor = Color.DarkMagenta;
            HOME.Location = new Point(587, 15);
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
            label1.TabIndex = 5;
            label1.Text = "CHERRY BEAUTY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Services
            // 
            Services.BackColor = Color.Silver;
            Services.FlatStyle = FlatStyle.Popup;
            Services.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Services.ForeColor = Color.DarkMagenta;
            Services.Location = new Point(703, 15);
            Services.Name = "Services";
            Services.Size = new Size(94, 29);
            Services.TabIndex = 12;
            Services.Text = "Services";
            Services.UseVisualStyleBackColor = false;
            Services.Click += Services_Click;
            // 
            // Reservation
            // 
            Reservation.BackColor = Color.Silver;
            Reservation.FlatStyle = FlatStyle.Popup;
            Reservation.Font = new Font("Magneto", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Reservation.ForeColor = Color.DarkMagenta;
            Reservation.Location = new Point(813, 15);
            Reservation.Name = "Reservation";
            Reservation.Size = new Size(88, 29);
            Reservation.TabIndex = 13;
            Reservation.Text = "Reservation";
            Reservation.UseVisualStyleBackColor = false;
            Reservation.Click += Reservation_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(StuffLable);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(Login1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(StuffPass);
            panel1.Controls.Add(Stuffname);
            panel1.Location = new Point(201, 151);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 415);
            panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // StuffLable
            // 
            StuffLable.Font = new Font("Lucida Calligraphy", 6F, FontStyle.Bold, GraphicsUnit.Point);
            StuffLable.ForeColor = Color.DarkMagenta;
            StuffLable.Location = new Point(253, 331);
            StuffLable.Name = "StuffLable";
            StuffLable.Size = new Size(203, 31);
            StuffLable.TabIndex = 8;
            StuffLable.Text = "Just Staff Can Login";
            StuffLable.TextAlign = ContentAlignment.MiddleCenter;
            StuffLable.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 85);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(206, 277);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Login1
            // 
            Login1.AllowDrop = true;
            Login1.BackColor = SystemColors.Window;
            Login1.FlatStyle = FlatStyle.Popup;
            Login1.ForeColor = Color.Gray;
            Login1.Location = new Point(253, 256);
            Login1.Margin = new Padding(3, 4, 3, 4);
            Login1.Name = "Login1";
            Login1.Size = new Size(203, 41);
            Login1.TabIndex = 5;
            Login1.Text = "Login";
            Login1.UseVisualStyleBackColor = false;
            Login1.Click += Login1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(253, 185);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 115);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Lucida Calligraphy", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(126, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 65);
            label2.TabIndex = 2;
            label2.Text = "Employee Login";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StuffPass
            // 
            StuffPass.ForeColor = Color.DarkMagenta;
            StuffPass.Location = new Point(253, 185);
            StuffPass.Margin = new Padding(3, 4, 3, 4);
            StuffPass.Multiline = true;
            StuffPass.Name = "StuffPass";
            StuffPass.PasswordChar = '*';
            StuffPass.PlaceholderText = "Staff Password";
            StuffPass.Size = new Size(203, 36);
            StuffPass.TabIndex = 1;
            StuffPass.TextAlign = HorizontalAlignment.Center;
            StuffPass.TextChanged += textBox2_TextChanged;
            // 
            // Stuffname
            // 
            Stuffname.ForeColor = Color.DarkMagenta;
            Stuffname.Location = new Point(253, 115);
            Stuffname.Margin = new Padding(3, 4, 3, 4);
            Stuffname.Multiline = true;
            Stuffname.Name = "Stuffname";
            Stuffname.PlaceholderText = "Staff Name";
            Stuffname.Size = new Size(203, 40);
            Stuffname.TabIndex = 0;
            Stuffname.TextAlign = HorizontalAlignment.Center;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(Reservation);
            Controls.Add(Services);
            Controls.Add(label1);
            Controls.Add(HOME);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HOME;
        private Label label1;
        private Button Services;
        private Button Reservation;
        private Panel panel1;
        private Label label2;
        private TextBox StuffPass;
        private TextBox Stuffname;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button Login1;
        private PictureBox pictureBox4;
        private Label StuffLable;
        private PictureBox pictureBox2;
    }
}