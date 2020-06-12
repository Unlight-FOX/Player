using System;
using System.IO;
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
    public partial class playerWindow : Form
    {
        Player myPlayer;
        bool fullScreen = false;

        public playerWindow()
        {
            InitializeComponent();

            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "";
            myPlayer = new Player();
            myPlayer.Events.MediaSubtitleChanged += MyPlayer_MediaSubtitleChanged;
            myPlayer.Subtitles.DirectoryDepth = 1;
            myPlayer.Sliders.Position.TrackBar = progressBar;
            myPlayer.Sliders.AudioVolume = volumeBar;
            myPlayer.Events.MediaPositionChanged += myPlayer_MediaPositionChanged;
    }

        private bool mouseDown;
        private Point lastLocation;

        private void ViewPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ViewPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ViewPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void myPlayer_MediaPositionChanged(object sender, PositionEventArgs e)
        {
            TimeSpan fromStart = TimeSpan.FromTicks(e.FromStart);
            label1.Text = fromStart.ToString(@"hh\:mm\:ss");
        }

        private void MyPlayer_MediaSubtitleChanged(object sender, SubtitleEventArgs e)
        {
            subtitlesLabel.Text = e.Subtitle;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Video files |*.mp4;*.avi;*.mkv;|Audio files|*.mp3;*.ogg;*.m4a;*.flac;*.wav";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadFile(openFileDialog.FileName);
            }
        }

        private void loadFile(string file)
        {
            myPlayer.Play(file, viewPanel);
            titleLabel.Text = Path.GetFileName(file);
            TimeSpan Stop = myPlayer.Media.Length;
            label2.Text = Stop.ToString(@"hh\:mm\:ss");
            if (myPlayer.LastError) MessageBox.Show(myPlayer.LastErrorString);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (myPlayer.Paused == false)
            {
                myPlayer.Pause();
                playButton.Text = "Play";
            }
            else { 
                myPlayer.Paused = false;
                playButton.Text = "Pause";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            myPlayer.Stop();
            titleLabel.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            myPlayer.Dispose();
            myPlayer = null;
            Close();
        }

        private void fullScr()
        {
            if (fullScreen == false)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                fullScreen = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                fullScreen = false;

            }

        }
        private void fullscrButton_Click(object sender, EventArgs e)
        {
            fullScr();
        }

        private void ViewPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            fullScr();
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            myPlayer.Mute = !myPlayer.Mute;
        }

        private void viewPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void viewPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = e.Data.GetData(DataFormats.FileDrop) as string[];
            string path = s[0];
            loadFile(path);
        }
    }
}
