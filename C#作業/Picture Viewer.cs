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
    public partial class Picture_Viewer : Form
    {
        public Picture_Viewer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pc1 p1 = new pc1();
            p1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pc2 p2 = new pc2();
            p2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pc3 p3 = new pc3();
            p3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pc4 p4 = new pc4(); 
            p4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pc5 p5 = new pc5(); 
            p5.Show();  
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pc3 p3 = new pc3();
            p3.Show();

        }
    }     
}
