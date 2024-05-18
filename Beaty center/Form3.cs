using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beaty_center
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Sender's email address and password
                string senderEmail = "marmarhijazi@gmail.com";
                string senderPassword = "marmarhijazi@gmail.com";

                // Recipient's email address
                string recipientEmail = "marirohijazi@gmail.com";

                // Create and configure the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.example.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };
                // Create the email message
                MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail)
                {
                    Subject = "Message from " + textBox3.Text,
                    Body = "Name: " + textBox2.Text + "\nEmail: " + textBox3.Text + "\nMessage: " + textBox3.Text
                };
                // Send the email
                smtpClient.Send(mailMessage);

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void Reservation_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reservation form4 = new Reservation();
            form4.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
