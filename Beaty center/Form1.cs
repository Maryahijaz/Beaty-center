/*************************************************************************************************************************
                                                  SAKARYA ÜNİVERSİTESİ
                                          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                                                  BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
                                                 NESNEYE DAYALI PROGRAMLAMA DERSİ
                                                     2023-2024 BAHAR DÖNEMİ
                            
                                         ÖĞRENCİ ADI: MARYA KHALED MAHMOUD HIJAZI.
                                         ÖĞRENCİ NUMARASI: G201210573.
                                         DERSİN ALINDIĞI GRUP: 1.B GRUBU.


*************************************************************************************************************************/
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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Reservation_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reservation form4 = new Reservation();
            form4.ShowDialog();
            this.Close();

        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form5 = new Login();
            form5.ShowDialog();
            this.Close();
        }
    }
}
