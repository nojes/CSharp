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
                int a2 = Convert.ToInt32(textBoxA2.Text);
                int b1 = Convert.ToInt32(textBoxB1.Text);
                int b2 = Convert.ToInt32(textBoxB2.Text);

                Fraction a = new Fraction(a1, a2);
                Fraction b = new Fraction(b1, b2);

                //MessageBox.Show(a.toString());
                //MessageBox.Show(b.toString());

                int op = comboBoxOp.SelectedIndex;
                switch (op)
                {
                    case 0:
                        break;

                    case 1:
                        break;

                    case 2:
                        Fraction x = a * b;
                        textBoxC1.Text = x.X.ToString();
                        textBoxC2.Text = x.Y.ToString();
                        break;

                    case 3:
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
