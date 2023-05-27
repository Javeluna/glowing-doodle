using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToString();
            string date = textBox2.Text.ToString();
            string purpose = textBox3.Text.ToString();
            string receiver = textBox4.Text.ToString();

            dataGridView1 = new DataGridView();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The toolbox has been added to the list");
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The wire cutter has been added to the list");
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The soldiring iron has been added to the list");
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The resistor has been added to the list");
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The wire has been added to the list");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Light Bulb has been added to the list");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The IC has been added to the list");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Digital Trainer has been added to the list");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Screw Driver has been added to the list");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Arduino Kit has been added to the list");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Borrowers().Show();
            this.Hide();
        }
    }
}
