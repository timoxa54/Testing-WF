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

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void top_Click(object sender, EventArgs e)
        {
            TB1.Text = "Hello World!";
        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {
            TB2.Text = TB1.Text + " Coffee";
        }

        private void TB3_Click(object sender, EventArgs e)
        {
            TB3.Text = null;
        }

        private void TB3_KeyDown(object sender, KeyEventArgs e)
        {
            tbValue.Text = e.KeyCode.ToString() + "  " + e.KeyValue.ToString();
        }

        private void ScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            TBscroll_A.Text = SB_A.Value.ToString();
            TB_del.Text = Math.Round(((double)SB_A.Value / SB_B.Value),3).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void SB_B_ValueChanged(object sender, EventArgs e)
        {
            TBscroll_B.Text = SB_B.Value.ToString();
            TB_del.Text = Math.Round(((double)SB_A.Value / SB_B.Value), 3).ToString();
        }
    }
}
