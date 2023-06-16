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
    public partial class Loan : Form
    {
        private void btnTotal_Click(object sender, EventArgs e)
        {
            Looan(false);
        }

        public Loan()
        {
            InitializeComponent();
        }

        private void btnMonthpay_Click(object sender, EventArgs e)
        {
            Looan(true);
        }

        private void Looan(bool h)
        {
            

            if (txtLoan.Text == "" || txtRate.Text == "" || 
                txtFristpay.Text == "" || txtYears.Text == "")
            {
                MessageBox.Show("請填入數字");
            }
            else
            {
                double x = double.Parse(txtLoan.Text);
                double years = double.Parse(txtYears.Text);
                double rate = double.Parse(txtRate.Text);
                double FirstPay = double.Parse(txtFristpay.Text);


                double r = 1.0 + ((rate / 12 / 100));
                double n = (double)(years * 12);
                double rpn = Math.Pow(r, n);
                double PMT = x * rpn * (r - 1) / (rpn - 1);
                double Total = PMT * n + FirstPay;


                int a = (int)Math.Ceiling(PMT);
                int b = (int)Math.Ceiling(Total);

                string SS = a.ToString();
                string SSS = b.ToString();

                string g = txtLoan.Text.ToString();
                string gg = txtYears.Text.ToString();
                string ggg = txtRate.Text.ToString();

                if (h)
                {
                    MessageBox.Show("金額:" + SS + "元");
                }
                else
                {
                    MessageBox.Show("金額:" + SSS + "元");
                }                              
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (txtLoan.Text == "" || txtRate.Text == "" ||
                txtFristpay.Text == "" || txtYears.Text == "")
            {
                MessageBox.Show("請填入數字");
            }
            else
            {
                double x = double.Parse(txtLoan.Text);
                double years = double.Parse(txtYears.Text);
                double rate = double.Parse(txtRate.Text);
                double FirstPay = double.Parse(txtFristpay.Text);


                double r = 1.0 + ((rate / 12 / 100));
                double n = (double)(years * 12);
                double rpn = Math.Pow(r, n);
                double PMT = x * rpn * (r - 1) / (rpn - 1);
                double Total = PMT * n + FirstPay;


                int a = (int)Math.Ceiling(PMT);
                int b = (int)Math.Ceiling(Total);

                string SS = a.ToString();
                string SSS = b.ToString();

                string g = txtLoan.Text.ToString();
                string gg = txtYears.Text.ToString();
                string ggg = txtRate.Text.ToString();

                Loan_L3 LL = new Loan_L3(g, gg, ggg, SS, SSS);
                LL.Show();
            }
        }
    }
}
