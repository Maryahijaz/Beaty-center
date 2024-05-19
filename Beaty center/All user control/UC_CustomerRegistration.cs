using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Beaty_center.All_user_control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        private readonly string filePath = @"C:\Users\marir\OneDrive\Desktop\3.6\NDP\Beauty odev\customer.txt";

        public UC_CustomerRegistration()
        {
            InitializeComponent();
            InitializeDataGridView();

        }

        private void InitializeDataGridView()
        {
            // Add columns to the DataGridView
            dataGridView2.Columns.Add("ColumnName", "Name");
            dataGridView2.Columns.Add("ColumnSurname", "Surname");
            dataGridView2.Columns.Add("ColumnPhoneNumber", "Phone Number");
            dataGridView2.Columns.Add("ColumnEmail", "Email");
            dataGridView2.Columns.Add("ColumnServices", "Services");
        }
        public void AddReservationFromForm4(string customerName, string customerSurname, string phoneNumber, string email, string Services)
        {
            // Add a new row to the DataGridView with reservation information
            dataGridView2.Rows.Add(customerName, customerSurname, phoneNumber, email, Services);
            this.Hide();
        }
        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomer(string customerInfo)
        {
            try
            {
                string[] customerDetails = customerInfo.Split(',');

                // Check if the phone number has exactly 11 characters
                if (customerDetails.Length >= 4 && customerDetails[2].Trim().Length == 11)
                {
                    // Check if the email address is valid
                    if (!IsValidEmail(customerDetails[3].Trim()))
                    {
                        MessageBox.Show("Invalid email address format.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check if a customer with the same name, surname, and phone number already exists
                    bool customerExists = dataGridView2.Rows.Cast<DataGridViewRow>().Any(row =>
                    {
                        var nameCell = row.Cells["ColumnName"];
                        var surnameCell = row.Cells["ColumnSurname"];
                        var phoneCell = row.Cells["ColumnPhoneNumber"];
                        var servicesCell = row.Cells["ColumnServices"];

                        // Check if any cell is null
                        if (nameCell == null || surnameCell == null || phoneCell == null || servicesCell == null)
                            return false;

                        // Check if all cell values are not null and match the customer details
                        return (nameCell.Value?.ToString().Trim().Equals(customerDetails[0].Trim(), StringComparison.OrdinalIgnoreCase) ?? false) &&
                               (surnameCell.Value?.ToString().Trim().Equals(customerDetails[1].Trim(), StringComparison.OrdinalIgnoreCase) ?? false) &&
                               (phoneCell.Value?.ToString().Trim().Equals(customerDetails[2].Trim(), StringComparison.OrdinalIgnoreCase) ?? false) &&
                               (servicesCell.Value?.ToString().Trim().Equals(customerDetails[4].Trim(), StringComparison.OrdinalIgnoreCase) ?? false);
                    });

                    if (!customerExists)
                    {
                        // Append customer information to the file
                        using (StreamWriter writer = File.AppendText(filePath))
                        {
                            writer.WriteLine(customerInfo);
                        }

                        // Add customer information to the dataGridView2
                        dataGridView2.Rows.Add(customerDetails);

                        // Display success message
                        MessageBox.Show("Customer added successfully!");

                        // Clear input fields after successful addition
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Customer with the same name, surname, and phone number already exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Phone number should consist of exactly 11 characters.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to validate email address
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ClearInputFields()
        {
            textName.Text = "";
            SurnameC.Text = "";
            phonNum.Text = "";
            Emailtext.Text = "";
            comServices.SelectedIndex = -1; // Clear the selected item in the ComboBox
        }
        private void DeleteCustomer(string nameToDelete)
        {
            string[] lines = File.ReadAllLines(filePath);

            // Rewrite the file excluding the line with customer information to delete
            using (StreamWriter writer = new StreamWriter(@"C:\Users\marir\OneDrive\Desktop\3.6\NDP\Beauty odev\customer_temp.txt"))
            {
                foreach (string line in lines)
                {
                    // Split the line into its components (name, surname, phone number, email)
                    string[] parts = line.Split(',');

                    // Check if the name matches the name to be deleted
                    if (parts.Length > 0 && parts[0].Trim().Equals(nameToDelete, StringComparison.OrdinalIgnoreCase))
                    {
                        // Skip writing this line to the temporary file
                        continue;
                    }

                    // Write the line to the temporary file
                    writer.WriteLine(line);
                }
            }

            // Replace the original file with the temporary file
            File.Delete(filePath);
            File.Move(@"C:\Users\marir\OneDrive\Desktop\3.6\NDP\Beauty odev\customer_temp.txt", filePath);

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            // Clear the existing rows in the dataGridView2
            dataGridView2.Rows.Clear();

            // Read the updated customer information from the file and add it to the dataGridView2
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 4)
                {
                    dataGridView2.Rows.Add(parts);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string customer = $"{textName.Text.Trim()},{SurnameC.Text.Trim()},{phonNum.Text.Trim()},{Emailtext.Text.Trim()},{comServices.Text.Trim()}";
            AddCustomer(customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameToDelete = textName.Text.Trim();
            DeleteCustomer(nameToDelete);
        }
    }

}

