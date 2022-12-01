using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace countdownwclock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DateTime st;
        public int timp;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            st = DateTime.Now;
            timp  = Int16.Parse(textBox1.Text);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            timp--;
            textBox2.Text = timp.ToString();
            if (timp==0) { MessageBox.Show("times up"); timer1.Stop(); } 
        }
    }
}
