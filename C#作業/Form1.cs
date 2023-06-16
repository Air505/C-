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
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hello A = new Hello();            
            A.Show();
            A.Location = new Point(400,100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loan b = new Loan();
            b.Show();
            b.Location = new Point(400, 100);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student c = new Student();
            c.Show();
            c.Location = new Point(400, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyClac d = new MyClac();
            d.Show();
            d.Location = new Point(400, 100);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Picture_Viewer h = new Picture_Viewer();
            h.Show();
            h.Location = new Point(400, 100);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Guess_Number f = new Guess_Number();
            f.Show();
            f.Location = new Point(400, 100);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Alarm g = new Alarm();
            g.Show();
            g.Location = new Point(400, 100);
        }

    }
}
