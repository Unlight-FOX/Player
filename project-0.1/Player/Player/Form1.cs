using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void play_button_Click(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;

        private void drag_panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void drag_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown==true)
            {
                mouseX = MousePosition.X - 500;
                mouseY = MousePosition.Y-20;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void drag_panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
