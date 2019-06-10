using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (Data.flag)
            {
                label3.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                textBox3.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Int32.Parse(textBox1.Text);
            dataGridView1.ColumnCount = Int32.Parse(textBox2.Text);
            dataGridView1.Visible = true;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j, n, m; 
            n = Int32.Parse(textBox1.Text);//строки
            m = Int32.Parse(textBox2.Text);//столбцы
            int temp = 0; int max = Int32.MinValue;
            Data.n = n;
            Data.m = m;
                int[,] a = new int[n, m];
            int[] sort = new int[n];
            for (i = 0; i < n-1; i++)
            {
                for (j = 0; j < m-1; j++)
                {
                    a[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                }
            }

            for (j = 0; j < m-1; j++)
            {
                for (i = 0; i < n-1; i++)
                {
                    temp = temp + a[i, j];
                }
                if (temp > max)
                    Data.num = j;
            }
            if (((Data.stolb <= 0) || (Data.stolb > Data.m)) && (Data.flag))
                MessageBox.Show("Введите корректный номер столбца");
            else
            {
                //сортировка--------------------------------------------------------------
                for (i = 0; i < n-1; i++)
                    sort[i] = a[i, Data.stolb-1];
                Data.BubbleSort(sort);
                //перенос новой матрицы-----------------------------------------------
                for (j = 0; j < m-1; j++)
                    for (i = 0; i < n-1; i++)
                    {
                        if (j == Data.stolb-1)
                        {
                            Data.new_a[i, j] = sort[i];
                        }
                        Data.new_a[i, j] = a[i, j];
                    }
            }



        }   


        private void Form2_Load(object sender, EventArgs e)
        {

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                Data.stolb = Convert.ToInt32(textBox3.Text);
            }
            catch { }
        }
    }
}
