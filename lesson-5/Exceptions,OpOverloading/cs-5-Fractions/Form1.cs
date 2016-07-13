using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_5_Fractions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxOp.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a1 = Convert.ToInt32(textBoxA1.Text);
                int b1 = Convert.ToInt32(textBoxB1.Text);
                int a2 = Convert.ToInt32(textBoxA2.Text);
                int b2 = Convert.ToInt32(textBoxB1.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }
    }
}
