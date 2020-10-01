using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw5
{
    public partial class Form2 : Form
    {
        public Form1 f1;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dataGridView1.RowCount = 3;
            this.dataGridView1.ColumnCount = 3;
        }

        private bool IsPrimer(int elem)
        {
            if (elem == 0 || elem == 1)
            {
                return true;
            }
            for (int i = 2; i + 1 < elem; i++)
            {
                if (elem % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int elem = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    if (IsPrimer(elem))
                    {
                        counter++;
                    }
                }
            }
            textBox3.Text = "" + counter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.newDialog1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form1.s1 = textBox1.Text;
            int n = Convert.ToInt32(Form1.s1);
            dataGridView1.RowCount = n;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Form1.s2 = textBox2.Text;
            int m = Convert.ToInt32(Form1.s2);
            dataGridView1.ColumnCount = m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                for (int j = dataGridView1.ColumnCount - 1; j + i + 1 > dataGridView1.ColumnCount; j--)
                {
                    int elem = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    if (IsPrimer(elem))
                    {
                        counter++;
                    }
                }
            }
            textBox4.Text = "" + counter;
        }
    }
}
