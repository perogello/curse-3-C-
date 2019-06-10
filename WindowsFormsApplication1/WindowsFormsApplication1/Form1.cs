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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрогреммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вводДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void выборОбработкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.ShowDialog();
        }

        private void выводРезультатаовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 c = new Form4();
            c.Show();
        }
    }
}
