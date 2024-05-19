using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Beaty_center.All_user_control;

namespace Beaty_center
{
    public partial class ReserList : Form
    {
        public ReserList()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            // Clear previous controls if needed
            panelPlaceholder.Controls.Clear();

            UC_Employee emp = new UC_Employee();
            emp.Dock = DockStyle.Fill;

            // Add the user control to the panel
            panelPlaceholder.Controls.Add(emp);
        }

        private void CustomerRegistration_Click(object sender, EventArgs e)
        {
            // Clear previous controls if needed
            panelPlaceholder.Controls.Clear();
            UC_CustomerRegistration customer = new UC_CustomerRegistration();
            customer.Dock = DockStyle.Fill;
            panelPlaceholder.Controls.Add(customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ServicesAdding_DragOver(object sender, DragEventArgs e)
        {

        }

        private void ServicesAdding_Click(object sender, EventArgs e)
        {
            // Clear previous controls if needed
            panelPlaceholder.Controls.Clear();

            // Create an instance of the UC_AddServices control
            UC_AddServices addServicesControl = new UC_AddServices();

            // Set the Dock style if you want it to fill the panel
            addServicesControl.Dock = DockStyle.Fill;

            // Add the user control to the panel
            panelPlaceholder.Controls.Add(addServicesControl);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}

