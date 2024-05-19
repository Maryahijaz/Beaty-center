namespace Beaty_center.All_user_control
{
    partial class UC_AddServices
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
            Add = new Label();
            dataGridView1 = new DataGridView();
            ServiceName = new Label();
            ServiceType = new Label();
            textName = new TextBox();
            textPrice = new TextBox();
            textType = new ComboBox();
            Price = new Label();
            btnAddServices = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Add
            // 
            Add.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Add.ForeColor = SystemColors.ActiveCaption;
            Add.Location = new Point(3, 24);
            Add.Name = "Add";
            Add.Size = new Size(402, 42);
            Add.TabIndex = 0;
            Add.Text = "Add Services ";
            Add.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(558, 636);
            dataGridView1.TabIndex = 1;
            // 
            // ServiceName
            // 
            ServiceName.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ServiceName.ForeColor = SystemColors.ActiveCaption;
            ServiceName.Location = new Point(617, 106);
            ServiceName.Name = "ServiceName";
            ServiceName.Size = new Size(184, 27);
            ServiceName.TabIndex = 2;
            ServiceName.Text = "Service Name";
            // 
            // ServiceType
            // 
            ServiceType.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ServiceType.ForeColor = SystemColors.ActiveCaption;
            ServiceType.Location = new Point(617, 236);
            ServiceType.Name = "ServiceType";
            ServiceType.Size = new Size(160, 29);
            ServiceType.TabIndex = 3;
            ServiceType.Text = "Service Type";
            // 
            // textName
            // 
            textName.Location = new Point(617, 136);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.PlaceholderText = "Enter Service Name";
            textName.Size = new Size(306, 34);
            textName.TabIndex = 5;
            textName.TextAlign = HorizontalAlignment.Center;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(617, 434);
            textPrice.Multiline = true;
            textPrice.Name = "textPrice";
            textPrice.PlaceholderText = "Enter Price";
            textPrice.Size = new Size(306, 34);
            textPrice.TabIndex = 6;
            textPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // textType
            // 
            textType.FormattingEnabled = true;
            textType.Items.AddRange(new object[] { "Facail", "Hair Cut", "Spa" });
            textType.Location = new Point(617, 268);
            textType.Name = "textType";
            textType.Size = new Size(306, 28);
            textType.TabIndex = 8;
            // 
            // Price
            // 
            Price.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Price.ForeColor = SystemColors.ActiveCaption;
            Price.Location = new Point(617, 372);
            Price.Name = "Price";
            Price.Size = new Size(93, 23);
            Price.TabIndex = 9;
            Price.Text = "Price";
            // 
            // btnAddServices
            // 
            btnAddServices.BackColor = SystemColors.Window;
            btnAddServices.FlatAppearance.BorderColor = Color.White;
            btnAddServices.FlatAppearance.BorderSize = 10;
            btnAddServices.FlatStyle = FlatStyle.Popup;
            btnAddServices.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddServices.ForeColor = SystemColors.ActiveCaption;
            btnAddServices.Location = new Point(675, 531);
            btnAddServices.Name = "btnAddServices";
            btnAddServices.Size = new Size(197, 39);
            btnAddServices.TabIndex = 10;
            btnAddServices.Text = "Add Service";
            btnAddServices.UseVisualStyleBackColor = false;
            btnAddServices.Click += btnAddServices_Click;
            // 
            // UC_AddServices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(btnAddServices);
            Controls.Add(Price);
            Controls.Add(textType);
            Controls.Add(textPrice);
            Controls.Add(textName);
            Controls.Add(ServiceType);
            Controls.Add(ServiceName);
            Controls.Add(dataGridView1);
            Controls.Add(Add);
            Name = "UC_AddServices";
            Size = new Size(936, 724);
            Load += UC_AddServices_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Add;
        private DataGridView dataGridView1;
        private Label ServiceName;
        private Label ServiceType;
        private TextBox textName;
        private TextBox textPrice;
        private ComboBox textType;
        private Label Price;
        private Button btnAddServices;
    }
}
