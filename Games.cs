using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;

namespace JanselUI_GFN_GUI
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }
        

        private void Schließen_Click(object sender, EventArgs e)
        {
            
            MainUI form = new MainUI();
            form.Show();
            Hide();
        }

        private void Minecraft_Click(object sender, EventArgs e)
        {
            if (File.Exists("B:/dl/Minecraft/Minecraft/Minecraft.exe"))
            {
                Process.Start("B:/dl/Minecraft/Minecraft/Minecraft.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "Minecraft.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory("Minecraft.zip", @"B:/dl\Minecraft");
                Process.Start("B:/dl/Minecraft/Minecraft/Minecraft.exe");
                File.Delete("Minecraft.zip");
            }
        }

        private void Roblox_Click(object sender, EventArgs e)
        {
            if (File.Exists("B:/dl/Roblox/Roblox/Versions/version-995b3631bc754ce1/RobloxPlayerLauncher.exe"))
            {
                Process.Start("B:/dl/Roblox/Roblox/Versions/version-995b3631bc754ce1/RobloxPlayerLauncher.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "Roblox.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory("Roblox.zip", @"B:/dl\Roblox");
                Process.Start("B:/dl/Roblox/Roblox/Versions/version-995b3631bc754ce1/RobloxPlayerLauncher.exe");
                File.Delete("Roblox.zip");
            }
        }

        private void DeSmuMe_Click(object sender, EventArgs e)
        {
            if (File.Exists("dsm.exe"))
            {
                Process.Start("dsm.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "dsm.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                Process.Start("dsm.exe");
            }
        }

        private void VisualBoyAdvance_Click(object sender, EventArgs e)
        {
            if (File.Exists("vba.exe"))
            {
                Process.Start("vba.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "vba.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                Process.Start("vba.exe");
            }
        }

        private void Dolphin_Click(object sender, EventArgs e)
        {
            if (File.Exists("dol.exe"))
            {
                Process.Start("/dol.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "dol.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                Process.Start("dol.exe");
            }
        }

        private void AmongUs_Click(object sender, EventArgs e)
        {
            if (File.Exists("B:/dl/AmongUs/AmongUs/Among Us.exe"))
            {
                Process.Start("B:/dl/AmongUs/AmongUs/Among Us.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "AmongUs.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory("AmongUs.zip", @"B:/dl\AmongUs");
                Process.Start("B:/dl/AmongUs/AmongUs/Among Us.exe");
                File.Delete("AmongUs.zip");
            }
        }
    }
}
