using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw5
{
    public partial class Form1 : Form
    {
        public static string s1, s2;
        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab;
            ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void newDialog1_Click(object sender, EventArgs e)
        {
            Form2 f2;
            f2 = new Form2();
            f2.textBox1.Text = s1;
            f2.textBox2.Text = s2;
            newDialog1.Enabled = false;
            f2.f1 = this;
            f2.Show();
        }
    }
}
