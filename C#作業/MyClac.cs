using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業
{
    public partial class MyClac : Form
    {
        
        public MyClac()
        {
            InitializeComponent();
        }
        
        private void btnDiv_Click(object sender, EventArgs e)
        {
            CalculateMultiandDivide(false);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            CalculateMultiandDivide(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculate(true);
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            Calculate(false);
        }
        private void Calculate(bool c)
        {
            if (txtNull1.Text == ""
                || txtNull2.Text == "")
            {
                MessageBox.Show("請填入數字");
            }
            else
            {
                decimal a = decimal.Parse(txtNull1.Text);
                decimal b = decimal.Parse(txtNull2.Text);

                if (c)
                {
                    txtAnswer.Text = (a + b).ToString();
                }
                else
                {
                    txtAnswer.Text = (a - b).ToString();
                }
            }
        }
        private void CalculateMultiandDivide(bool d)
        {
            if (txtNull1.Text == ""
                || txtNull2.Text == "")
            {
                MessageBox.Show("請填入數字");
            }
            else
            {
                decimal a = decimal.Parse(txtNull1.Text);
                decimal b = decimal.Parse(txtNull2.Text);

                if (d)
                {
                    txtAnswer.Text = (a * b).ToString();
                }
                else
                {
                    txtAnswer.Text = (a / b).ToString();
                }
            }
           
        }

    }
}

