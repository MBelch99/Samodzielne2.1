using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samodzielne2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                float x = float.Parse(textBox1.Text);
                label3.Text = (x - 100).ToString();
            }
            else if (checkBox2.Checked && radioButton1.Checked)
            {
                float x = float.Parse(textBox1.Text);
                label3.Text = ((x - 100) * 0.85).ToString();
            }
            else if (checkBox2.Checked && radioButton2.Checked)
            {
                float x = float.Parse(textBox1.Text);
                label3.Text = ((x - 100) * 0.9).ToString();
            }

        }
    }
}
