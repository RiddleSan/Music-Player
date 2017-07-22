using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    
    public partial class Form1 : Form
    {

        [DllImport("winmm.dll")]
        internal static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        internal static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        string lastMusicPath;
        string lastMusicName;
        string FolderMusicPath;
        string[] MusicInFolder;
        string[] AMusicName;
        string Musics;
        SoundPlayer soundPlayer;
        OpenFileDialog file = new OpenFileDialog();
        WindowsMediaPlayer Controller = new WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
            
            checkBox1.Hide();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Controller.URL = lastMusicPath;
            if (lastMusicPath == "" || lastMusicPath == null)
           {

            }
            else
            {
                if (checkBox1.Checked == false)
                {
                    Controller.controls.play();
                    NowPlaying.Text = "Now Playing: " + lastMusicName;
                }
                else
                {
                    Controller.controls.play();
                }
            }
        }

        private void Pause_Click_1(object sender, EventArgs e)
        {
            Controller.controls.pause();
            Controller.URL = "";
            checkBox1.Checked = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Controller.controls.stop();
            checkBox1.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Settings.Visible == true)
            {
                Settings.Visible = false;
                listBox1.Visible = true;
                label1.Visible = true;
                NowPlaying.Visible = true;
                SongName.Visible = true;
                LabelSearch.Visible = true;
                SearchFolder.Visible = true;
                SearchSong.Visible = true;
            }
            else
            {
                Settings.Visible = true;
                listBox1.Visible = false;
                label1.Visible = false;
                NowPlaying.Visible = false;
                SongName.Visible = false;
                LabelSearch.Visible = false;
                SearchFolder.Visible = false;
                SearchSong.Visible = false;
            }
        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {

        }

        private void SearchSong_Click(object sender, EventArgs e)
        {
            file.Filter = "MP3 File |*.mp3|WAV File |*.wav|AAC File |*.aac|M4A File |*.m4a|WMA File |*.wma";
            
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lastMusicPath = Path.GetDirectoryName(file.FileName);
                lastMusicPath = file.FileName;
                lastMusicName = System.IO.Path.GetFileNameWithoutExtension(file.FileName);
                lastMusicName = Regex.Replace(lastMusicName, @"[\d-]", "");
                SongName.Text = "Selected Song: " + lastMusicName.Replace("_", " ");
                listBox1.Items.Add(lastMusicPath);
            }
                
        }
        

        private void SearchFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Music Folder";

            if(folder.ShowDialog() == DialogResult.OK)
            {
                FolderMusicPath = folder.SelectedPath;
                MusicInFolder = Directory.GetFiles(FolderMusicPath, "*.mp3", SearchOption.AllDirectories);
                Musics = Path.GetFileName(MusicInFolder.ToString());
                listBox1.Items.AddRange(MusicInFolder);

                MusicInFolder = Directory.GetFiles(FolderMusicPath, "*.aac", SearchOption.AllDirectories);
                Musics = Path.GetFileName(MusicInFolder.ToString());
                listBox1.Items.AddRange(MusicInFolder);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                lastMusicPath = listBox1.SelectedItem.ToString();
                soundPlayer = new SoundPlayer(lastMusicPath);
                checkBox1.Checked = false;
                
                lastMusicName = System.IO.Path.GetFileNameWithoutExtension(lastMusicPath);
                AMusicName = lastMusicName.Split('\\');
                lastMusicName = AMusicName.Last();
                SongName.Text = "Selected Song: " + lastMusicName.Replace("_", " ");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            uint CurrVol = ushort.MaxValue / 2;
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            int NewVolume = ((ushort.MaxValue / 100) * trackWave.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
        }

        private void trackWave_ValueChanged(object sender, EventArgs e)
        {
            if (Controller != null && trackWave != null)
                Controller.settings.volume = trackWave.Value * 10;
        }


        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {  

        }
    }
}
