using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomatikKapanmaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShutdownComputer(900);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShutdownComputer(1800);
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShutdownComputer(3600);
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShutdownComputer(7200);
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShutdownComputer(10800);
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShutdownComputer(14400);
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CancelShutdown();
            Application.Exit();
        }

        private void ShutdownComputer(int seconds)
        {
            string shutdownCommand = $"/s /f /t {seconds}";
            Process.Start("shutdown", shutdownCommand);
        }

        private void CancelShutdown()
        {
            Process.Start("shutdown", "/a");
        }
    }
}
