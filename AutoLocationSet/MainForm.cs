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

namespace AutoLocationSet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Display> displays = new List<Display>();
            int i = 1;
            foreach (var screen in Screen.AllScreens)
            {
                displays.Add(new Display(screen.DeviceName, screen.Bounds.Width, screen.Bounds.Height, screen.Primary));
                i++;
            }
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    listBox1.Items.Add("Process name: " + process.ProcessName);
                    listBox1.Items.Add("ID: " + process.Id);
                    listBox1.Items.Add("Window title: " + process.MainWindowTitle);
                    listBox1.Items.Add("---------------------------------------");
                }
            }

        }
    }
}
