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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
            if (Data.firstc)
            {
                textBox1.Visible = true;
                label1.Visible = true;
            }
            if (Data.scndc)
            {
                dataGridView1.Visible = true;
                label2.Visible = true;
            }
            textBox1.Text = Convert.ToString(Data.num);
            
            for (int i = 0; i < Data.n-1; i++)
            {
                for (int j = 0; j < Data.m-1; j++)
                {
                    dataGridView1[j, i].Value = Convert.ToString(Data.new_a[i,j]);
                }
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
            
           
            
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
