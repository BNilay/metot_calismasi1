using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";    
            textBox3.Text= " ";
            textBox4.Text = " ";

            textBox1.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }
         void renklendir()
        {
            textBox1.BackColor = Color.Red;
            textBox2.BackColor= Color.Green;

            textBox3.BackColor= Color.Blue;
            textBox4.BackColor = Color.Pink;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
        void yazdır()
        {
            textBox1.Text = "Belkıs Nilay";
            textBox2.Text = "Yılmaz";
            textBox3.Text = "20";
            textBox4.Text = "Mühendis";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            yazdır();
        }
    }
}
