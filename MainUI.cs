using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO;

namespace JanselUI_GFN_GUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            Directory.CreateDirectory("B:/dl");
        }

        private void SystemInformation_Click(object sender, EventArgs e)
        {
            SysInfo form = new SysInfo();
            form.Show();
            Hide();
        }

        private void Schließen_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Programs_Click(object sender, EventArgs e)
        {
            Programs form = new Programs();
            form.Show();
            Hide();
        }

        private void Games_Click(object sender, EventArgs e)
        {
            Games form = new Games();
            form.Show();
            Hide();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
             
        }

    }
}
