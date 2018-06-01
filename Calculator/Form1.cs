using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int part = 0;
        int total = 0;
        char oper = '+';
        public Form1()
        {
            InitializeComponent();
        }

        //Ввод чисел
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }
        //Конец ввода цифр
        //"/"
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += "/";
        }

        //*
        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
        }
        //+
        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length>0)
            {
                oper = '+';
                int a = Convert.ToInt32(Convert.ToString(label1.Text[0]));
                int b = Convert.ToInt32(Convert.ToString(label1.Text[2]));
                for (int i = 0; i < label1.Text.Length; i++)
                {
                    if (label1.Text[i] == '*')
                    {
                        part = a * b;
                    }
                    else if (label1.Text[i] == '/')
                    {
                        part = a / b;
                    }
                }
                total += part;
                part = 0;
                label1.Text = "";

            }
        }
        //=
        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length>0)
            {
                int a = Convert.ToInt32(Convert.ToString(label1.Text[0]));
                int b = Convert.ToInt32(Convert.ToString(label1.Text[2]));
                for (int i = 0; i < label1.Text.Length; i++)
                {
                    if (label1.Text[i] == '*')
                    {
                        part = a * b;
                    }
                    else if (label1.Text[i] == '/')
                    {
                        part = a / b;
                    }
                }
                total += part;
                part = 0;

            }
            label1.Text = Convert.ToString(total);
        }
        //C
        private void button16_Click(object sender, EventArgs e)
        {
            total = 0;
            part = 0;
            oper = '0';
            label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length>0)
            {
                oper = '-';
                int a = Convert.ToInt32(Convert.ToString(label1.Text[0]));
                int b = Convert.ToInt32(Convert.ToString(label1.Text[2]));
                if (label1.Text[1]=='*')
                {
                    part = a * b;
                }
                else
                {
                    part = a / b;
                }
            }
            total += part;
            part = 0;
            label1.Text = "";
        }
    }
}
