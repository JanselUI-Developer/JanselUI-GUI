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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1gAKht3aK-3mq29Et3ZxC1daDXK2EZAe4";
                string fileName = "Firefox.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1ua562K36PLlGd4uGLQ-7ZHpXb4uI1_y0";
                string fileName = "8zip.zip";
                WebClient myWebClient = new WebClient();
                
                myWebClient.DownloadFile(remoteUri, fileName);
                ZipFile.ExtractToDirectory("8zip.zip", "B:/dl/8zip");
                Process.Start("B:/dl/8zip/8-Zip/8zFM.exe");
                File.Delete("8zip.zip");
            }
        }

        private void Desktop_Click(object sender, EventArgs e)
        {
            string remoteUri = "https://drive.google.com/uc?export=download&id=19RTwQPWkCfEbtK4sNeJ5yIpQSKO4mwMt";
            string fileName = "WinXShellB.zip", myStringWebResource = null;
            WebClient myWebClient = new WebClient();
            myStringWebResource = remoteUri;
            myWebClient.DownloadFile(myStringWebResource, fileName);
            ZipFile.ExtractToDirectory("WinXShellB.zip", "B:/JanselUI");
            Process.Start("B:/JanselUI/start.bat");
            File.Delete("WinXShellB.zip");
            this.Desktop.Enabled = false;
        }

        private void ExplorerPlusPlus_Click(object sender, EventArgs e)
        {
            string remoteUri = "https://drive.google.com/uc?export=download&id=1rEfhFR3gKO5-vjrSChqXpsc21qCHA9X9";
            string fileName = "explus.exe", myStringWebResource = null;
            WebClient myWebClient = new WebClient();
            myStringWebResource = remoteUri;
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=17jy9uuM9ctl4xWglfiCjDclgrmnBQAm2";
                string fileName = "prosexp.exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1f5SBoeZfMQo6lqNw5YjusmcIg0NbooKe";
                string fileName = "Discord.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                ZipFile.ExtractToDirectory(@"Discord.zip", @"B:/dl\Discord");
                Process.Start("B:/dl/Discord/Discord/HERE.exe");
                File.Delete("/Discord.zip");
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1076ak6xpRe8C0L2VvLyVfqKhlpzWZDtE";
                string fileName = "Spotify.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1QF5mK8wdCclnJKPF0B2EQQjkvR91AtKt";
                string fileName = "Code.zip";
                WebClient myWebClient = new WebClient();
                
                myWebClient.DownloadFile(remoteUri, fileName);
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=1MuCLeSXIV-TopiGAPAMP0qNUnyJgedLC";
                string fileName = "TwitchStudio.zip", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri;
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
                string remoteUri = "https://drive.google.com/uc?export=download&id=";
                string id1 = "1Ll4MD4p-4OoZosFFDTOnC8kdGF-H1Rbc";
                string id2 = "17jT8laiYkSvl9kZPCtjqmZp5tqbJddkc";

                string fileName = "obsstudio.zip", myStringWebResource = null;
                string fileName2 = "obsstarter.bat", myStringWebResource2 = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + id1;
                myStringWebResource2 = remoteUri + id2;
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
