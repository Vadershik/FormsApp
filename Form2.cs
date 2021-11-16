using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //результат
            Label res = new Label();
            res.Text = "Ответ";
            res.Location = new Point(0,0);
            Controls.Add(res);
            //первое число
            TextBox num1 = new TextBox();
            num1.Text = "0";
            num1.Location = new Point(0, 25);
            Controls.Add(num1);
            //второе число
            TextBox num2 = new TextBox();
            num2.Text = "0";
            num2.Location = new Point(0, 50);
            Controls.Add(num2);
            #region Операции
            //плюс
            Button Add = new Button();
            Add.Text = "+";
            Add.Height = 20;
            Add.Width = 20;
            Add.Location = new Point(0,100);
            Add.Click += (c, d) => { res.Text = $"{Convert.ToInt32(num1.Text) + Convert.ToInt32(num2.Text)}"; };
            //минус
            Button Min = new Button();
            Min.Text = "-";
            Min.Height = 20;
            Min.Width = 20;
            Min.Location = new Point(30, 100);
            Min.Click += (c, d) => { res.Text = $"{Convert.ToInt32(num1.Text) - Convert.ToInt32(num2.Text)}"; };
            //умножить
            Button Mul = new Button();
            Mul.Text = "*";
            Mul.Height = 20;
            Mul.Width = 20;
            Mul.Location = new Point(60, 100);
            Mul.Click += (c, d) => { res.Text = $"{Convert.ToInt32(num1.Text) * Convert.ToInt32(num2.Text)}"; };
            //разделить
            Button Div = new Button();
            Div.Text = "/";
            Div.Height = 20;
            Div.Width = 20;
            Div.Location = new Point(90, 100);
            Div.Click += (c, d) => { res.Text = $"{Convert.ToInt32(num1.Text) / Convert.ToInt32(num2.Text)}"; };
            #endregion
            Controls.Add(Add);
            Controls.Add(Min);
            Controls.Add(Mul);
            Controls.Add(Div);
        }
    }
}
