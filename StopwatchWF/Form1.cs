using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopwatchWF
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeDisplay.Text = string.Format("{0:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
