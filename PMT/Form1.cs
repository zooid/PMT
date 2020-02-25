using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMT
{
    

    public partial class Form1 : Form
    {
        public double ir = 7.10;
        public int np = 84;
        public double la = 40000;
        public double pmt;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox4.ReadOnly = true;
            textBox1.Text = ir.ToString();
            textBox2.Text = np.ToString();
            textBox3.Text = la.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ir = double.Parse(textBox1.Text);
            int np = Int32.Parse(textBox2.Text);
            double la = double.Parse(textBox3.Text);

            textBox4.Text = (Math.Truncate(PMT(ir, np, la)*1000)/1000).ToString();
        }

        // C# PMT function

        public static double PMT(double irx, int npx, double lax)
        {
            var rate = (double)irx / 100 / 12;
            var denominator = Math.Pow((1 + rate), npx) - 1;
            return (rate + (rate / denominator)) * lax;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.Show();
        }
    }
}
