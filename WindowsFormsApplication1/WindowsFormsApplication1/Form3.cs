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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Data.firstc)
                checkBox1.Checked = true;
            if (Data.scndc)
                checkBox2.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Data.firstc = true;
            else Data.firstc = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
          
            Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Data.scndc = true;
                Data.flag = true;
                Data.flag = true;
            }
            else
            {
                Data.scndc = false;
                Data.flag = false;
                Data.flag = false;

            }

        }

        
    }

}
