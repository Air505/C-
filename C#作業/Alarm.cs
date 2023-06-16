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
    public partial class Alarm : Form
    {
        private Timer timer;
        public Alarm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1000毫秒 = 1秒
            timer.Tick += Timer_Tick;
        }
        private void Alarm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }
    }
}
