using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        double a, b, m, random;
        int action;
        bool flag;
        Random ob;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (textBox1.Text == "")
                b = 0;
            if (textBox2.Text == "")
                m = 0;
            flag = true;
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }



        //Ввод
        private void Button10_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                textBox1.Clear();
                flag = true;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
            textBox1.Text += (sender as Button).Text;
                
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                textBox1.Clear();
                flag = true;
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text += "0,";
            if (textBox1.Text.IndexOf(',') == -1)
                textBox1.Text += ",";          
        }



        //Арифметические действия
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            action = 1;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            flag = true;
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            action = 2;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            flag = true;
        }

        private void ButtonDelenie_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            action = 3;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            flag = true;
        }
        
        private void ButtonUmno_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            action = 4;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            flag = true;
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void ButtonZnak_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * (-1));
        }

        private void ButtonExp_Click(object sender, EventArgs e)
        {
            action = 5;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }




        //МММ
        private void Button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            m = 0;
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                b = 0;
                m = 0;
                textBox2.Text = (m - b).ToString();
            }
            else if (textBox1.Text == "")
            {
                b = 0;
                m = Convert.ToDouble(textBox2.Text);
                textBox2.Text = (m - b).ToString();
            }
            else if (textBox2.Text == "")
            {
                m = 0;
                b = Convert.ToDouble(textBox1.Text);
                textBox2.Text = (m - b).ToString();
            }
            else
            {
                m = Convert.ToDouble(textBox2.Text);
                b = Convert.ToDouble(textBox1.Text);
                textBox2.Text = (m - b).ToString();
            }
        }
        private void Button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                b = 0;
                m = 0;
                textBox2.Text = (m + b).ToString();
            }
            else if (textBox1.Text == "")
            {
                b = 0;
                m = Convert.ToDouble(textBox2.Text);
                textBox2.Text = (m + b).ToString();
            }
            else if (textBox2.Text == "")
            {
                m = 0;
                b = Convert.ToDouble(textBox1.Text);
                textBox2.Text = (m + b).ToString();
            }
            else
            {
                m = Convert.ToDouble(textBox2.Text);
                b = Convert.ToDouble(textBox1.Text);
                textBox2.Text = (m + b).ToString();
            }
        }




        //Функции
        private void ButtonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
            a = Convert.ToDouble(textBox1.Text);
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(a).ToString();
            a = Convert.ToDouble(textBox1.Text);
        }

        private void ButtonTg_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(a).ToString();
            a = Convert.ToDouble(textBox1.Text);
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            if (a <= 0)
                textBox1.Text = "Логарифм не существует";
            else
            {
                textBox1.Text = Math.Log(a).ToString();
                a = Convert.ToDouble(textBox1.Text);
            }
            flag = false;
        }

        private void ButtonSin_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(a).ToString();
            a = Convert.ToDouble(textBox1.Text);
        }



        //Рандом
        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            ob = new Random();
            random = ob.NextDouble();
            random = ob.NextDouble() * 9999;
            textBox1.Text = Math.Round(random, 3).ToString();
        }



        //Равно
        private void Button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            flag = false;
            switch (action)
            {               
                case 1:
                    b = Convert.ToDouble(textBox1.Text);
                    b = a - b;
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = Convert.ToDouble(textBox1.Text);
                    b += a;
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = Convert.ToDouble(textBox1.Text);
                    if (b == 0)
                        textBox1.Text = "Нельзя делить на ноль!";
                    else
                    {
                        b = a / b;
                        textBox1.Text = b.ToString();
                    }
                    break;
                case 4:                    
                    b = Convert.ToDouble(textBox1.Text);
                    b *= a;
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = Convert.ToDouble(textBox1.Text);
                    b = Math.Pow(a, b);
                    textBox1.Text = b.ToString();
                    break;
            }
        }

    }
}
