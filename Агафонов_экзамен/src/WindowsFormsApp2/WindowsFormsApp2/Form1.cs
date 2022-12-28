using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
        }

       

        void f1()
        {
            try
            {
                Convert.ToDouble(textBox2.Text);
                Convert.ToDouble(textBox1.Text);

            }
            catch
            {
                MessageBox.Show("Введите корректные x и y!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            
                if (x>-1 && x<1 && y>-1 && y<1 && x<y*y && y>x*x)
                {
                    MessageBox.Show("Точка аходится внутри функций");
                    toolStripStatusLabel1.Text = " Точка находится внутри функций";
                return;
            }
                else if (x > -1 && x < 1 && y > -1 && y < 1 && x==y*y && y==x*x)
                {
                    MessageBox.Show("Точка Находится на границах функций");
                    toolStripStatusLabel1.Text = "Точка находится на границах функций";
                return;
            }
                else
                {
                    MessageBox.Show("Точка находится вне функций");
                    toolStripStatusLabel1.Text = "Точка находится вне функций";
                return;
            }
                
           
        }
        void f2()
        {
            try
            {
                Convert.ToDouble(textBox2.Text);
                Convert.ToDouble(textBox1.Text);

            }
            catch
            {
                MessageBox.Show("Введите корректные x и y!");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            if (x>0 && x<6 && (x * x + y * y) < 36){
                if(x>0 && x<3 && y<x)
                {
                    MessageBox.Show("Точка находится внутри функций");
                    toolStripStatusLabel1.Text = "Точка находится внутри функций";
                    return;
                }
            }
                else if (x>0 && x<6 && (x*x+y*y)==36)
                {
                if (x >= 0 && y <= 3 && x == y){
                    if (x == 0 && y >= 3 && y <= 6)
                    { if (y==0 && x<=6 && x >= 3){
                            MessageBox.Show("Точка находится на границах функций");
                            toolStripStatusLabel1.Text = "Точка находится на границах функций";
                            return;
                        }
                    }
                }
                }
                else
                {
                    MessageBox.Show("Точка находится вне функций");
                    toolStripStatusLabel1.Text = "Точка находится вне функций";
                    return;
            }
            
        }

        bool flag = false;
        bool flag2;
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            openFileDialog1.Filter = "TextFiles(*.html)|*.html|AllFiles(*.*)|*.*";
            openFileDialog1.ShowDialog();
            if (!flag)
            {
                this.Height += 100;
                flag = true;
            }
            string[] repSplit = openFileDialog1.FileName.Split('\\');
            string curFile = repSplit[repSplit.Length - 1];
            if (curFile == "1.html")
            {
                webBrowser1.Navigate(openFileDialog1.FileName);
                flag2 = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;
            }
            else if (curFile == "2.html")
            {
                webBrowser1.Navigate(openFileDialog1.FileName);
                flag2 = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show($"Для {curFile} нет решения. Выберите файлы: 1.html или 2.html");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag2)
            {
                f1();
            }
            else
            {
                f2();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу написал Агафонов Д.А. \r \nСтудент группы ПКсп-120\r \n Вариант 9 ");
        }
    }
}
