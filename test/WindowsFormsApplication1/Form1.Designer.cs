namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vdoTrackBar = new System.Windows.Forms.TrackBar();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.loadButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vdoTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // vdoTrackBar
            // 
            this.vdoTrackBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.vdoTrackBar.Location = new System.Drawing.Point(11, 444);
            this.vdoTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.vdoTrackBar.Name = "vdoTrackBar";
            this.vdoTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vdoTrackBar.Size = new System.Drawing.Size(584, 45);
            this.vdoTrackBar.TabIndex = 0;
            this.vdoTrackBar.TabStop = false;
            this.vdoTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.vdoTrackBar.Scroll += new System.EventHandler(this.vdoTrackBar_Scroll_1);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(511, 495);
            this.VolumeTrackBar.Margin = new System.Windows.Forms.Padding(2);
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(84, 45);
            this.VolumeTrackBar.TabIndex = 2;
            this.VolumeTrackBar.TabStop = false;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(11, 493);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(56, 47);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 375);
            this.panel1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(72, 516);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(40, 23);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(118, 516);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(39, 23);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(608, 551);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.vdoTrackBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vdoTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar vdoTrackBar;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
    }
}

