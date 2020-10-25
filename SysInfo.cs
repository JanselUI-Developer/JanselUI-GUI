using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace JanselUI_GFN_GUI
{
    public partial class SysInfo : Form
    {
        public SysInfo()
        {
            InitializeComponent();

            ManagementObjectSearcher myGPU = new ManagementObjectSearcher("select * from Win32_VideoController");
            ManagementObjectSearcher myCPU = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject obj in myCPU.Get())
            {
                this.CPUInformation.Text = "CPU: " + obj["Name"];
                this.CoresThreads.Text = "Cores: " + obj["NumberOfCores"] + ", Threads: " + obj["NumberOfLogicalProcessors"];
            }
            foreach (ManagementObject obj in myGPU.Get())
            {
                this.GPUInformation.Text = "GPU: " + obj["Name"];
            }
        }

        private void Schließen_Click(object sender, EventArgs e)
        {
            MainUI form = new MainUI();
            form.Show();
            Hide();
        }
    }
}
