using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.IO.Compression;


namespace JanselUI_GFN_GUI
{
    public partial class Programs : Form
    {
        public Programs()
        {
            InitializeComponent();
            if (File.Exists("B:/JanselUI/start.bat"))
            {
                this.Desktop.Enabled = false;
            }
            this.guna2TextBox1.Visible = false;
            this.InputPassword.Visible = false;
        }
       

        private void Schließen_Click(object sender, EventArgs e)
        {
            MainUI form = new MainUI();
            form.Show();
            Hide();
        }

        private void Firefox_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(@"B:/dl/Firefox/Firefox/fire.exe"))
            {
                Process.Start("B:/dl/Firefox/Firefox/fire.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "Firefox.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory("Firefox.zip", @"B:/dl\Firefox");
                Process.Start("B:/dl/Firefox/Firefox/fire.exe");
                File.Delete("/Firefox.zip");
            }
        }

        private void SevenZip_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(@"B:/dl/8zip/8-Zip/8zFM.exe"))
            {
                Process.Start("B:/dl/8zip/8-Zip/8zFM.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "8zip.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory("8zip.zip", "B:/dl/8zip");
                Process.Start("B:/dl/8zip/8-Zip/8zFM.exe");
                File.Delete("8zip.zip");
            }
        }

        private void Desktop_Click(object sender, EventArgs e)
        {
            string remoteUri = "http://janselui.ga/JanselUI/";
            string fileName = "WinXShellB.zip", myStringWebResource = null;
            WebClient myWebClient = new WebClient();
            myStringWebResource = remoteUri + fileName;
            myWebClient.DownloadFile(myStringWebResource, fileName);
            ZipFile.ExtractToDirectory("WinXShellB.zip", "B:/JanselUI");
            Process.Start("B:/JanselUI/start.bat");
            File.Delete("WinXShellB.zip");
            this.Desktop.Enabled = false;
        }

        private void ExplorerPlusPlus_Click(object sender, EventArgs e)
        {
            string remoteUri = "http://janselui.ga/JanselUI/";
            string fileName = "explus.exe", myStringWebResource = null;
            WebClient myWebClient = new WebClient();
            myStringWebResource = remoteUri + fileName;
            myWebClient.DownloadFile(myStringWebResource, fileName);
            Process.Start("explus.exe");
        }
        

        private void ProcessHacker_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("prosexp.exe"))
            {
                Process.Start("prosexp.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "prosexp.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                Process.Start("prosexp.exe");
            }
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(@"B:/dl/Discord/Discord/HERE.exe"))
            {
                Process.Start("B:/dl/Discord/Discord/HERE.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "Discord.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory(@"Discord.zip", @"B:/dl\Discord");
                Process.Start("B:/dl/Discord/Discord/HERE.exe");
                File.Delete("/Discord.zip");
            }
        }

        private void OBSClassic_Click(object sender, EventArgs e)
        {
            
            
            if (File.Exists(@"B:/dl/obs/OBS/64bit/masina.exe"))
            {
                Process.Start("B:/dl/obs/OBS/64bit/masina.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "obs.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory(@"obs.zip", @"B:/dl\obs");
                Process.Start("B:/dl/obs/OBS/64bit/masina.exe");
                File.Delete("obs.zip");
            }
        }

        private void Spotify_Click(object sender, EventArgs e)
        {
            
            
            if (File.Exists("B:/dl/Spotify/Spotify/Muzica.exe"))
            {
                Process.Start("B:/dl/Spotify/Spotify/Muzica.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "Spotify.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory(@"Spotify.zip", @"B:/dl\Spotify");
                Process.Start("B:/dl/Spotify/Spotify/Muzica.exe");
                File.Delete("Spotify.zip");
            }
        }

        private void VisualStudioCode_Click(object sender, EventArgs e)
        {
            if (File.Exists("B:/dl/VSCode/Code/masina.exe"))
            {
                Process.Start("B:/dl/VSCode/Code/masina.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "Code.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory(@"Code.zip", @"B:/dl\VSCode");
                Process.Start("B:/dl/VSCode/Code/masina.exe");
                File.Delete("Code.zip");
            }
        }

        private void TwitchStudio_Click(object sender, EventArgs e)
        {
            if (File.Exists("B:/dl/TwitchStudio/Twitch Studio/Bin/TwitchStudio.exe"))
            {
                Process.Start("B:/dl/TwitchStudio/Twitch Studio/Bin/TwitchStudio.exe");
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "TwitchStudio.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory(@"TwitchStudio.zip", @"B:/dl\TwitchStudio");
                Process.Start("B:/dl/TwitchStudio/Twitch Studio/Bin/TwitchStudio.exe");
                File.Delete("TwitchStudio.zip");
            }
        }

        private void OBSStudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The OBS Studio Method was provided by\nthe GNF and USE Team (F7, Inferus and SRT)", "Information about OBS Studio");
            if (File.Exists("obsstarter.bat"))
            {
                Process.Start("obsstarter.bat");
                Thread.Sleep(2000);
                Process[] _proceses = null;
                _proceses = Process.GetProcessesByName("cmd");
                foreach (Process proces in _proceses)
                {
                    proces.Kill();
                }
            }
            else
            {
                string remoteUri = "http://janselui.ga/JanselUI/";
                string fileName = "obsstudio.zip", myStringWebResource = null;
                string fileName2 = "obsstarter.bat", myStringWebResource2 = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myStringWebResource2 = remoteUri + fileName2;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                myWebClient.DownloadFile(myStringWebResource2, fileName2);
                ZipFile.ExtractToDirectory(@"obsstudio.zip", @"B:/dl\obsstudio");
                Process.Start(fileName2);
                File.Delete(fileName);
                Thread.Sleep(2000);
                Process[] _proceses = null;
                _proceses = Process.GetProcessesByName("cmd");
                foreach (Process proces in _proceses)
                {
                    proces.Kill();
                }
            }
        }

        private void InputPassword_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "dubisteinfetterhurensohn")
            {
                this.OBSStudio.Visible = true;
                guna2TextBox1.Text = "";
            }
            else
            {
                this.OBSStudio.Visible = false;
                guna2TextBox1.Text = "";
            }
        }
    }
}
