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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }
        private void btnHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Sax = txtSax.Text;
            string star = txtStar.Text;

            MessageBox.Show("Hello !" + name + ",\n" + "英文名字是" + EnglishName + ",\n"
                + "性別是" + Sax + ",\n" + "星座是" + star);

        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Sax = txtSax.Text;
            string star = txtStar.Text;

            MessageBox.Show("Hi !" + name + ",\n" + "英文名字是" + EnglishName + ",\n"
                + "性別是" + Sax + ",\n" + "星座是" + star);
        }
    }
}
