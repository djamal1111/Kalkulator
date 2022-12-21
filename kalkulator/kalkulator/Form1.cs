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
        public string D; //переменная для действия
        public string N1; //переменная для числа 1
        public bool N2; //переменная для числа 2
        public Form1()
        {
            N2 = false; // изначально число 2 не вводится
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length - 1);// удаление одного символа
            if (textBox1.Text == "")
                textBox1.Text = "0"; // при отсутствии символов вывести 0
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (N2) //если число 2...
            {
                N2=false;
                textBox1.Text = "0";//изначально при вводе числа 1 будет ноль
            }
            Button B = (Button)sender;//назначение кнопок ддля ввода цифр
            if (textBox1.Text == "0")//изначально в text box цифра ноль
            textBox1.Text=B.Text;////ввод цифр
            else
                textBox1.Text = textBox1.Text+B.Text;//ввод цифр
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";//изначально в text box цифра ноль
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;//назначение кнопок для действий
            D = B.Text; 
            N1 = textBox1.Text;//ввод числа 1
            N2 = true;//при вводе числа 1 показать ввод числа 2
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dN1, dN2, res;//переменные число 1, число 2, результат
            res = 0; //приравнивание переменной к нули
            dN1 = Convert.ToDouble(N1);
            dN2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")//назначение кнопки для действия
            {
                res = dN1 + dN2;//действие для сложения
            }
            if (D == "-")//назначение кнопки для действия
            {
                res = dN1 - dN2;//действие для вычитания
            }
            if (D == "×")//назначение кнопки для действия
            {
                res = dN1 * dN2;//действие для умножения
            }
            if (D == "÷")//назначение кнопки для действия
            {
                res = dN1 / dN2;//действие для деления
            }
            if (D == "%")//назначение кнопки для действия
            {
                res = dN1 * dN2/100;//действие для процента
            }
            D = "=";//назначение кнопки для действия
            N2 = true;//вывод результата
            textBox1.Text = res.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double dN, res;
            dN = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dN);//выделение квадратного корня
            textBox1.Text = res.ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            double dN, res;
            dN = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dN, 2);//возведение числа в квадрат
            textBox1.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double dN, res;
            dN = Convert.ToDouble(textBox1.Text);
            res = 1/dN; //ввод занака дроби
            textBox1.Text = res.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dN, res; 
            dN = Convert.ToDouble(textBox1.Text);
            res = -dN; //ввод знака минус
            textBox1.Text = res.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))//запрет на написание запятой более одного раза
                textBox1.Text = textBox1.Text + ",";//ввод запятой
        }
    }
}
