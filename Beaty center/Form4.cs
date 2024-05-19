using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Beaty_center.All_user_control;
using System.Xml.Linq;

namespace Beaty_center
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Services_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Close();
        }

        private void ContactUs_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form3 = new Form3();
            form3.ShowDialog();

            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Reser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string customerName = NameC.Text;
            string customerSurname = sur.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = Email.Text;
            string Services = comServices.Text;

            // Add reservation information to UC_CustomerRegistration
            UC_CustomerRegistration ucCustomerRegistration = new UC_CustomerRegistration();
            ucCustomerRegistration.AddReservationFromForm4(customerName, customerSurname, phoneNumber, email, Services);

            // Add UC_CustomerRegistration to the form if not already added
            if (!this.Controls.Contains(ucCustomerRegistration))
            {
                this.Controls.Add(ucCustomerRegistration);
                ucCustomerRegistration.Dock = DockStyle.Fill;
            }

            // Display successful message
            MessageBox.Show("Reservation added successfully!");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }
    }
}
