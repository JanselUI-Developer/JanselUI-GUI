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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1Ppxxh1LVECTD4oDc3Io0gDEFb-JLkMGk";
                string fileName = "Minecraft.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory("Minecraft.zip", @"B:/dl\Minecraft");
                Process.Start("B:/dl/Minecraft/Minecraft/Minecraft.exe");
                File.Delete("Minecraft.zip");
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1CS_1QuNAd2zf6cMU8L2jUsnigNUXknVj";
                string fileName = "dsm.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1XouhBXkQvgqr1Vs-pglc6gO4CEWab4W2";
                string fileName = "vba.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1v8YOwgDwZ1bNF24EKpzsYbsa9OAYb2sH";
                string fileName = "dol.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1EmDjic2vFyeu2DTpB6L8XKyF28IDEAyB";
                string fileName = "AmongUs.zip";
                WebClient myWebClient = new WebClient();
                myWebClient.DownloadFile(remoteUri, fileName);
                ZipFile.ExtractToDirectory("AmongUs.zip", @"B:/dl\AmongUs");
                Process.Start("B:/dl/AmongUs/AmongUs/Among Us.exe");
                File.Delete("AmongUs.zip");
            }
        }
    }
}
