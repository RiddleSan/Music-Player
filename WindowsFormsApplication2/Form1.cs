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
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);



        string lastMusicPath;
        string lastMusicName;
        string FolderMusicPath;
        string[] MusicInFolder;
        string Musics;
        SoundPlayer soundPlayer;
        OpenFileDialog file = new OpenFileDialog();
        WindowsMediaPlayer Controller = new WindowsMediaPlayer();


        public Form1()
        {
            InitializeComponent();
            // By the default set the volume to 0
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
            trackWave.Value = CalcVol / (ushort.MaxValue / 10);
            checkBox1.Hide();
        }

        private void Sound_Click(object sender, EventArgs e)
        {

        }

        private void Pause_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (lastMusicPath == "" || lastMusicPath == null)
            {

            }
            else
            {
                if (checkBox1.Checked == false)
                {
                    Controller.URL = lastMusicPath;
                    Controller.controls.play();
                }
                else
                {
                    Controller.controls.play();
                }
                checkBox1.Checked = false;
            }
        }

        private void Pause_Click_1(object sender, EventArgs e)
        {
            Controller.controls.pause();
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
            }
            else
            {
                Settings.Visible = true;
                listBox1.Visible = false;
            }
        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {

        }

        private void SearchSong_Click(object sender, EventArgs e)
        {
            lastMusicPath = file.FileName;
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lastMusicPath = file.FileName;
                Controller.URL = lastMusicPath;
                Controller.controls.stop();
                lastMusicName = System.IO.Path.GetFileNameWithoutExtension(file.FileName);
                lastMusicName = Regex.Replace(lastMusicName, @"[\d-]", "");
                SongName.Text = lastMusicName.Replace("_", " ");
                listBox1.Items.Add(lastMusicName.Replace("_", " "));
            }
                
        }

        private void trackWave_Scroll(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 10) * trackWave.Value);
            // Set the same volume for both the left and the right channels
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            // Set the volume
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void SearchFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "Music Folder";

            if(folder.ShowDialog() == DialogResult.OK)
            {
                FolderMusicPath = folder.SelectedPath;
                MusicInFolder = Directory.GetFiles(FolderMusicPath);
                Musics = Path.GetFileName(MusicInFolder.ToString());
                listBox1.Items.AddRange(MusicInFolder);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                lastMusicPath = listBox1.SelectedItem.ToString();
                SongName.Text = lastMusicPath;
                soundPlayer = new SoundPlayer(lastMusicPath);
                checkBox1.Checked = false;
            }
        }

        
    }
}
