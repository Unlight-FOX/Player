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
        Player myPlayer = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "video files |*.mp4;*.avi|Audio files|*.mp3;*.ogg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                myPlayer.Play(openFileDialog.FileName, panel1);
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

        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                mouseX = MousePosition.X - 500;
                mouseY = MousePosition.Y - 250;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            myPlayer.Dispose();
            myPlayer = null;
            Close();
        }
    }
}
