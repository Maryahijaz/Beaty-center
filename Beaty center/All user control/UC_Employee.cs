using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beaty_center.All_user_control
{
    public partial class UC_Employee : UserControl
    {
        private readonly string staffFilePath = @"C:\Users\marir\OneDrive\Desktop\3.6\NDP\Beauty odev\staff.txt";

        public UC_Employee()
        {
            InitializeComponent();
            InitializeDataGridView();

        }
        private void InitializeDataGridView()
        {
            // Add columns to the DataGridView
            dataGridViewStaff.Columns.Add("ColumnName", "Name");
            dataGridViewStaff.Columns.Add("ColumnPhoneNumber", "Phone Number");
            dataGridViewStaff.Columns.Add("ColumnEmail", "Email");
            dataGridViewStaff.Columns.Add("ColumnGender", "Gender");
            dataGridViewStaff.Columns.Add("ColumnUsername", "Username");
            dataGridViewStaff.Columns.Add("ColumnPassword", "Password");
        }


        private bool IsStaffInfoValid(string[] staffInfo)
        {
            // Check if the length is correct
            if (staffInfo.Length != 6)
                return false;

            // Check uniqueness of staff information
            bool isUnique = dataGridViewStaff.Rows.Cast<DataGridViewRow>().All(row =>
            {
                bool isNameUnique = row.Cells["ColumnName"].Value != null &&
                                    !row.Cells["ColumnName"].Value.ToString().Equals(staffInfo[0], StringComparison.OrdinalIgnoreCase);

                bool isPhoneNumUnique = row.Cells["ColumnPhoneNumber"].Value != null &&
                                        !row.Cells["ColumnPhoneNumber"].Value.ToString().Equals(staffInfo[1], StringComparison.OrdinalIgnoreCase);

                bool isEmailUnique = row.Cells["ColumnEmail"].Value != null &&
                                     !row.Cells["ColumnEmail"].Value.ToString().Equals(staffInfo[2], StringComparison.OrdinalIgnoreCase);

                bool isUsernameUnique = row.Cells["ColumnUsername"].Value != null &&
                                        !row.Cells["ColumnUsername"].Value.ToString().Equals(staffInfo[4], StringComparison.OrdinalIgnoreCase);

                bool isPasswordUnique = row.Cells["ColumnPassword"].Value != null &&
                                        !row.Cells["ColumnPassword"].Value.ToString().Equals(staffInfo[5], StringComparison.OrdinalIgnoreCase);

                return isNameUnique && isPhoneNumUnique && isEmailUnique && isUsernameUnique && isPasswordUnique;
            });

            // Validate gender
            bool isValidGender = staffInfo[3].Trim().Equals("Male", StringComparison.OrdinalIgnoreCase) ||
                                 staffInfo[3].Trim().Equals("Female", StringComparison.OrdinalIgnoreCase);

            return isUnique &&
                   staffInfo[1].Trim().Length == 11 && // Check phone number length
                   IsValidEmail(staffInfo[2]) && // Check valid email format
                   staffInfo[4].Trim().Length >= 6 && // Check minimum password length
                   isValidGender; // Check valid gender
        }

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

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            UpdateStaffDataGridView();
        }
        private void AddStaff(string staffInfo)
        {
            try
            {
                string[] staffDetails = staffInfo.Split(',');

                // Check if the staff info is valid
                if (IsStaffInfoValid(staffDetails))
                {
                    // Append staff information to the file
                    using (StreamWriter writer = File.AppendText(staffFilePath))
                    {
                        writer.WriteLine(staffInfo);
                    }

                    // Add staff information to the dataGridView
                    dataGridViewStaff.Rows.Add(staffDetails);

                    MessageBox.Show("Staff added successfully!");
                }
                else
                {
                    MessageBox.Show("Invalid staff information. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsUsernameUnique(string username)
        {
            foreach (DataGridViewRow row in dataGridViewStaff.Rows)
            {
                if (row.Cells["ColumnUsername"].Value != null &&
                    row.Cells["ColumnUsername"].Value.ToString().Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsNameUnique(string name)
        {
            foreach (DataGridViewRow row in dataGridViewStaff.Rows)
            {
                if (row.Cells["ColumnName"].Value != null &&
                    row.Cells["ColumnName"].Value.ToString().Trim().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }
        private void DeleteStaff(string nameToDelete)
        {
            try
            {
                string[] staffLines = File.ReadAllLines(staffFilePath);

                // Rewrite the file excluding the line with staff information to delete
                using (StreamWriter writer = new StreamWriter(staffFilePath))
                {
                    foreach (string line in staffLines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length > 0 && !parts[0].Trim().Equals(nameToDelete, StringComparison.OrdinalIgnoreCase))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                // Remove the selected staff row from the dataGridView
                dataGridViewStaff.Rows.RemoveAt(dataGridViewStaff.SelectedRows[0].Index);

                MessageBox.Show("Staff deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateStaffDataGridView()
        {
            try
            {
                // Clear the existing rows in the dataGridView
                dataGridViewStaff.Rows.Clear();

                // Read the updated staff information from the file and add it to the dataGridView
                if (File.Exists(staffFilePath))
                {
                    string[] lines = File.ReadAllLines(staffFilePath);
                    foreach (string line in lines)
                    {
                        string[] staffInfo = line.Split(',');
                        if (staffInfo.Length == 6)
                        {
                            dataGridViewStaff.Rows.Add(staffInfo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputFields()
        {
            textStaffName.Text = "";
            textPhoneNumber.Text = "";
            textEmail.Text = "";
            comboBoxGender.SelectedIndex = -1;
            textUsername.Text = "";
            textPassword.Text = "";
        }
        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {
            string staffInfo = $"{textStaffName.Text.Trim()}, {textPhoneNumber.Text.Trim()}, {textEmail.Text.Trim()}, " +
                      $"{comboBoxGender.SelectedItem}, {textUsername.Text.Trim()}, {textPassword.Text.Trim()}";

            AddStaff(staffInfo);

        }

        private void btnDeleteStaff_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewStaff.SelectedRows.Count > 0)
            {
                string staffNameToDelete = dataGridViewStaff.SelectedRows[0].Cells["ColumnName"].Value.ToString();
                DeleteStaff(staffNameToDelete);
            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
