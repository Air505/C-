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
    public partial class Loan_L3 : Form
    {

        public Loan_L3(string g,string gg, string ggg,string SS,string SSS)
        {
            InitializeComponent();
            label6.Text = g;
            label7.Text = gg;
            label8.Text = ggg;
            label9.Text = SS;
            label10.Text = SSS;

        }

        private void Loan_L3_Load(object sender, EventArgs e)
        {

        }
    }
}
