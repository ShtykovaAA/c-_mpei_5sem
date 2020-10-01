using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*26.Если хотя бы один максимальный элемент   A лежит на главной диагонали, 
 * присвоить начальным элементам  нового массива C значения элементов, 
 * лежащих выше главной диагонали, а остальным элементам   значения прочих элементов  .*/

namespace labwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dataGridView1.RowCount = 3;
            this.dataGridView1.ColumnCount = 3;
            this.button1.Enabled = false;
        }

        private void RowCount_TextChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(RowCount.Text);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
        }

        public static int maxi;
        private void MaxELem_Click(object sender, EventArgs e)
        {
            maxi = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    int elem = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    if (maxi <= elem)
                    {
                        maxi = elem;
                    }
                }
            }
            MaxELement.Text = "" + maxi;
        }

        private void IsMaxELemOnTheMainDiagonal_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int elem = Convert.ToInt32(dataGridView1.Rows[i].Cells[i].Value);
                if (elem == maxi)
                {
                    flag = true;
                    IsCorrect.Text = "Yes";
                    button1.Enabled = true;
                    break;
                }
            }
            if (!flag)
            {
                IsCorrect.Text = "No";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] c = new int[Convert.ToInt32(Math.Pow(dataGridView1.ColumnCount, 2))];
            int kol = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = i; j < dataGridView1.ColumnCount; j++)
                {
                    c[kol++] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
            }

            for (int i = 1; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    c[kol++] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }

            }
            Output.Text = "";
            foreach (int x in c)
            {
                Output.Text += "" + x + "; ";
            }
        }
    }
}
