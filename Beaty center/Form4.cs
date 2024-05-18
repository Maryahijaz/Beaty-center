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
            string recipientPhoneNumber = "+905525420415"; // Your provided Turkish phone number
            //string reservationInfo = txtReservationInfo.Text;
            string carrierDomain = "com.tr"; // Replace this with the actual email-to-SMS gateway domain for the Turkish carrier

            string toEmail = $"{recipientPhoneNumber}@{carrierDomain}";
            string fromEmail = "marirohijazi@gmail.com"; // Your provided email
            string fromPassword = "Mmaria12345"; // Replace with your email password

            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com") // Using Gmail's SMTP server
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromEmail),
                    Subject = "Reservation Information",
                    //Body = reservationInfo,
                    IsBodyHtml = false,
                };
                mailMessage.To.Add(toEmail);

                smtpClient.Send(mailMessage);
                MessageBox.Show("Message sent successfully!");

                ReserList reserList = new ReserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
