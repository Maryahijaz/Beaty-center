using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beaty_center
{
    public partial class Login : Form
    {
        public Login()
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

        private void Reservation_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reservation form4 = new Reservation();
            form4.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login1_Click(object sender, EventArgs e)
        {
            if (Stuffname.Text == "Marya" && StuffPass.Text == "Mari")
            {
                this.Hide();
                ReserList form6 = new ReserList();
                form6.ShowDialog();
                this.Close();
            }
            else
            {
                StuffLable.Visible = true;
                Stuffname.Clear();
                StuffPass.Clear();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
