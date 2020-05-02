using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVS.MediaPlayer;

namespace AVPlayer
{
    public partial class Form1 : Form
    {
        Player myPlayer;
        public Form1()
        {
            InitializeComponent();

            myPlayer = new Player();

            myPlayer.Sliders.Position.TrackBar = progressBar;
            myPlayer.Sliders.AudioVolume = volumeBar;

            myPlayer.Events.MediaPositionChanged += myPlayer_MediaPositionChanged;
        }

        private void loadFile(string file)
        {
            myPlayer.Play(file, panel1);
            TimeSpan Stop = myPlayer.Media.Length;
            label2.Text = Stop.ToString(@"hh\:mm\:ss");
            if (myPlayer.LastError) MessageBox.Show(myPlayer.LastErrorString);
        }

        private void myPlayer_MediaPositionChanged(object sender, PositionEventArgs e)
        {
            TimeSpan fromStart = TimeSpan.FromTicks(e.FromStart);
            label1.Text = fromStart.ToString(@"hh\:mm\:ss");
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Video files |*.mp4;*.avi;*.mkv;|Audio files|*.mp3;*.ogg;*.m4a;*.flac;*.wav|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadFile(openFileDialog.FileName);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (myPlayer.Paused == false)
            {
                myPlayer.Pause();
            }
            else
                myPlayer.Paused=false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            myPlayer.Stop();
        }

        //int mouseX = 0;
        //int mouseY = 0;
        //bool mouseDown;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (mouseDown == true)
            //{
            //    mouseX = MousePosition.X - 500;
            //    mouseY = MousePosition.Y - 250;

            //    this.SetDesktopLocation(mouseX, mouseY);
            //}
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //mouseDown = false;
        }


        private void opemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Video files |*.mp4;*.avi;*.mkv;|Audio files|*.mp3;*.ogg;*.m4a;*.flac;*.wav|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadFile(openFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPlayer.Dispose();
            myPlayer = null;
            Close();
        }


    }
}
