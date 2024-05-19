using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Beaty_center.funcion;

namespace Beaty_center.All_user_control
{
    public partial class UC_AddServices : UserControl
    {
        private readonly string filePath = @"C:\Users\marir\OneDrive\Desktop\3.6\NDP\Beauty odev\login.text";

        public UC_AddServices()
        {
            InitializeComponent();
            LoadServiceInfo();
        }
        // Assuming this is inside the MainForm class
        // Inside Form1 class
   
        private void LoadServiceInfo()
        {
            var services = ReadServices();

            // Create DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Service Name");
            dt.Columns.Add("Service Type");
            dt.Columns.Add("Price");

            foreach (var service in services)
            {
                dt.Rows.Add(service.ServiceName, service.ServiceType, service.Price);
            }

            // Bind DataTable to DataGridView
            dataGridView1.DataSource = dt;
        }


        private List<ServiceInfo> ReadServices()
        {
            var services = new List<ServiceInfo>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    services.Add(ServiceInfo.FromString(line));
                }
            }

            return services;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddServices_Load(object sender, EventArgs e)
        {

        }

        private void btnAddServices_Click(object sender, EventArgs e)
        {
            var serviceInfo = new ServiceInfo
            {
                ServiceName = textName.Text,
                ServiceType = textType.Text,
                Price = textPrice.Text
            };

            SaveService(serviceInfo);
            UpdateDataGridView(); // Update DataGridView after saving
        }
        private void SaveService(ServiceInfo serviceInfo)
        {
            var services = ReadServices();

            if (!services.Any(s => s.ServiceName.Equals(serviceInfo.ServiceName, StringComparison.OrdinalIgnoreCase)))
            {
                services.Add(serviceInfo);
                WriteServices(services);
                MessageBox.Show("Service saved successfully.");
            }
            else
            {
                MessageBox.Show("Service already exists!");
            }
        }
        private void WriteServices(List<ServiceInfo> services)
        {
            var lines = services.Select(service => service.ToString()).ToArray();
            File.WriteAllLines(filePath, lines);
        }

        private void UpdateDataGridView()
        {
            var services = ReadServices();

            // Create DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Service Name");
            dt.Columns.Add("Service Type");
            dt.Columns.Add("Price");

            foreach (var service in services)
            {
                dt.Rows.Add(service.ServiceName, service.ServiceType,  service.Price);
            }

            // Bind DataTable to DataGridView
            dataGridView1.DataSource = dt;
        }
    }



}

