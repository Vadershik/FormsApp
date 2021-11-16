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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Open Calculator";
            btn.Location = new Point(20,20);
            btn.Height = 50;
            btn.Width = 100;
            btn.Click += (a,b) => {
                Form2 form = new Form2();
                form.ShowDialog();
            };
            Controls.Add(btn);
        }
    }
}
