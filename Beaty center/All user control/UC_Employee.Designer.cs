namespace Beaty_center.All_user_control
{
    partial class UC_Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewStaff = new DataGridView();
            CustomerRegistration = new Label();
            ServiceName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textStaffName = new TextBox();
            textEmail = new TextBox();
            textPhoneNumber = new TextBox();
            textUsername = new TextBox();
            textPassword = new TextBox();
            comboBoxGender = new ComboBox();
            btnAddStaff = new Button();
            btnDeleteStaff = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewStaff.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Location = new Point(0, 117);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.RowHeadersWidth = 51;
            dataGridViewStaff.RowTemplate.Height = 29;
            dataGridViewStaff.Size = new Size(558, 658);
            dataGridViewStaff.TabIndex = 3;
            // 
            // CustomerRegistration
            // 
            CustomerRegistration.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CustomerRegistration.ForeColor = SystemColors.ActiveCaption;
            CustomerRegistration.Location = new Point(3, 37);
            CustomerRegistration.Name = "CustomerRegistration";
            CustomerRegistration.Size = new Size(402, 42);
            CustomerRegistration.TabIndex = 4;
            CustomerRegistration.Text = "         Employee";
            // 
            // ServiceName
            // 
            ServiceName.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ServiceName.ForeColor = SystemColors.ActiveCaption;
            ServiceName.Location = new Point(574, 163);
            ServiceName.Name = "ServiceName";
            ServiceName.Size = new Size(184, 27);
            ServiceName.TabIndex = 8;
            ServiceName.Text = "Staff Name";
            // 
            // label1
            // 
            label1.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(887, 163);
            label1.Name = "label1";
            label1.Size = new Size(184, 27);
            label1.TabIndex = 9;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(574, 311);
            label2.Name = "label2";
            label2.Size = new Size(184, 27);
            label2.TabIndex = 10;
            label2.Text = "Phone No";
            // 
            // label3
            // 
            label3.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(887, 311);
            label3.Name = "label3";
            label3.Size = new Size(184, 27);
            label3.TabIndex = 11;
            label3.Text = "User Name";
            // 
            // label4
            // 
            label4.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(574, 465);
            label4.Name = "label4";
            label4.Size = new Size(184, 27);
            label4.TabIndex = 12;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(887, 465);
            label5.Name = "label5";
            label5.Size = new Size(184, 27);
            label5.TabIndex = 13;
            label5.Text = "Password";
            // 
            // textStaffName
            // 
            textStaffName.Location = new Point(574, 220);
            textStaffName.Multiline = true;
            textStaffName.Name = "textStaffName";
            textStaffName.PlaceholderText = "Enter  Name";
            textStaffName.Size = new Size(184, 34);
            textStaffName.TabIndex = 14;
            textStaffName.TextAlign = HorizontalAlignment.Center;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(887, 220);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Enter  Email";
            textEmail.Size = new Size(184, 34);
            textEmail.TabIndex = 15;
            textEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textPhoneNumber
            // 
            textPhoneNumber.Location = new Point(574, 359);
            textPhoneNumber.Multiline = true;
            textPhoneNumber.Name = "textPhoneNumber";
            textPhoneNumber.PlaceholderText = "Enter  Phone No";
            textPhoneNumber.Size = new Size(184, 34);
            textPhoneNumber.TabIndex = 16;
            textPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(887, 359);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Enter  User  Name";
            textUsername.Size = new Size(184, 34);
            textUsername.TabIndex = 17;
            textUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(887, 495);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.PlaceholderText = "Enter  Password";
            textPassword.Size = new Size(210, 34);
            textPassword.TabIndex = 19;
            textPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Mail", "Fmail" });
            comboBoxGender.Location = new Point(574, 501);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(184, 28);
            comboBoxGender.TabIndex = 20;
            // 
            // btnAddStaff
            // 
            btnAddStaff.BackColor = SystemColors.Window;
            btnAddStaff.FlatAppearance.BorderColor = Color.White;
            btnAddStaff.FlatAppearance.BorderSize = 10;
            btnAddStaff.FlatStyle = FlatStyle.Popup;
            btnAddStaff.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStaff.ForeColor = SystemColors.ActiveCaption;
            btnAddStaff.Location = new Point(632, 619);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(197, 39);
            btnAddStaff.TabIndex = 21;
            btnAddStaff.Text = "Add Customer";
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += btnAddStaff_Click_1;
            // 
            // btnDeleteStaff
            // 
            btnDeleteStaff.BackColor = SystemColors.Window;
            btnDeleteStaff.FlatAppearance.BorderColor = Color.White;
            btnDeleteStaff.FlatAppearance.BorderSize = 10;
            btnDeleteStaff.FlatStyle = FlatStyle.Popup;
            btnDeleteStaff.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteStaff.ForeColor = SystemColors.ActiveCaption;
            btnDeleteStaff.Location = new Point(857, 619);
            btnDeleteStaff.Name = "btnDeleteStaff";
            btnDeleteStaff.Size = new Size(197, 39);
            btnDeleteStaff.TabIndex = 22;
            btnDeleteStaff.Text = "Delete Customer";
            btnDeleteStaff.UseVisualStyleBackColor = false;
            btnDeleteStaff.Click += btnDeleteStaff_Click_1;
            // 
            // UC_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeleteStaff);
            Controls.Add(btnAddStaff);
            Controls.Add(comboBoxGender);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(textPhoneNumber);
            Controls.Add(textEmail);
            Controls.Add(textStaffName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ServiceName);
            Controls.Add(CustomerRegistration);
            Controls.Add(dataGridViewStaff);
            Name = "UC_Employee";
            Size = new Size(1112, 774);
            Load += UC_Employee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStaff;
        private Label CustomerRegistration;
        private Label ServiceName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textStaffName;
        private TextBox textEmail;
        private TextBox textPhoneNumber;
        private TextBox textUsername;
        private TextBox textPassword;
        private ComboBox comboBoxGender;
        private Button btnAddStaff;
        private Button btnDeleteStaff;
    }
}
