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

namespace Alex_s_lagswitch
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

     

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {

                ProcessStartInfo internetoff = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/C ipconfig /" + "release",
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Process.Start(internetoff);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        
        {
            if (e.KeyCode == Keys.X)
            {
                ProcessStartInfo interneton = new ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/C ipconfig /" + "renew",
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Process.Start(interneton);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo interneton = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C ipconfig /" + "renew",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(interneton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo internetoff = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/C ipconfig /" + "release",
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(internetoff);
        }
    }
}
