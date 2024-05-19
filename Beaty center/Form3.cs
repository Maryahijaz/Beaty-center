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
using System.Text.RegularExpressions;

namespace Beaty_center
{
    public partial class Form3 : Form
    {
        private readonly string filePath = @"C:\Users\marir\OneDrive\Desktop\3.6\NDP\Beauty odev\contact_info.txt";

        public Form3()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string message = txtMessage.Text.Trim();

            // Regular expression for email addresses
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if name, email, and message are not empty
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(message) && Regex.IsMatch(email, emailPattern))
            {
                try
                {
                    // Add contact information to the file
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine($"Name: {name}");
                        writer.WriteLine($"Email: {email}");
                        writer.WriteLine($"Message: {message}");
                        writer.WriteLine();
                    }


                    MessageBox.Show("Message sent successfully!");

                    // Clear the text boxes after sending the message
                    txtName.Clear();
                    txtEmail.Clear();
                    txtMessage.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields with valid information.", "Incomplete or Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
