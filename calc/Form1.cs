using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        decimal v1 = 0, v2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

            private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                v1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {

                MessageBox.Show("Informe um valor!");

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                v1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "MULTI";
                lblOperacao.Text = "*";
            }
            else
            {

                MessageBox.Show("Informe um valor!");

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != "")
            {

                v1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {

                MessageBox.Show("Informe um valor!");

            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            v2 = decimal.Parse(txtResultado.Text);
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(v1 + v2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(v1 - v2);
            }
            else if (operacao == "MULTI")
            {
                txtResultado.Text = Convert.ToString(v1 * v2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(v1 / v2);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            v1 = 0;
            v2 = 0;
            lblOperacao.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
                txtResultado.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {

                v1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor!");
            }
        }














    }

}




