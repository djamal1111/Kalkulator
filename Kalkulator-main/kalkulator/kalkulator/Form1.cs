using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool N2;
        public Form1()
        {
            N2 = false;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (N2) 
            {
                N2=false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(textBox1.Text == "0")
            textBox1.Text=B.Text;
            else
                textBox1.Text = textBox1.Text+B.Text;
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            N2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dN1, dN2, res;
            res = 0;
            dN1 = Convert.ToDouble(N1);
            dN2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dN1 + dN2;
            }
            if (D == "-")
            {
                res = dN1 - dN2;
            }
            if (D == "×")
            {
                res = dN1 * dN2;
            }
            if (D == "÷")
            {
                res = dN1 / dN2;
            }
            if (D == "%")
            {
                res = dN1 * dN2/100;
            }
            D = "=";
            N2 = true;
            textBox1.Text = res.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double dN, res;
            dN = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dN);
            textBox1.Text = res.ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            double dN, res;
            dN = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dN, 2);
            textBox1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double dN, res;
            dN = Convert.ToDouble(textBox1.Text);
            res = 1/dN;
            textBox1.Text = res.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dN, res;
            dN = Convert.ToDouble(textBox1.Text);
            res = -dN;
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }
    }
}
