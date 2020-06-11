namespace AVPlayer
{
    partial class playerWindow
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
            this.viewPanel = new System.Windows.Forms.Panel();
            this.muteButton = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.playButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.fullscrButton = new System.Windows.Forms.Button();
            this.subtitlesLabel = new System.Windows.Forms.Label();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPanel
            // 
            this.viewPanel.AllowDrop = true;
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewPanel.Controls.Add(this.subtitlesLabel);
            this.viewPanel.Controls.Add(this.muteButton);
            this.viewPanel.Controls.Add(this.volumeBar);
            this.viewPanel.Location = new System.Drawing.Point(9, 37);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(2);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(614, 436);
            this.viewPanel.TabIndex = 0;
            this.viewPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewPanel_MouseDoubleClick);
            this.viewPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPanel_MouseDown);
            this.viewPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPanel_MouseMove);
            this.viewPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPanel_MouseUp);
            // 
            // muteButton
            // 
            this.muteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.muteButton.Location = new System.Drawing.Point(585, 255);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(28, 24);
            this.muteButton.TabIndex = 6;
            this.muteButton.Text = "M";
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volumeBar.BackColor = System.Drawing.Color.Black;
            this.volumeBar.Location = new System.Drawing.Point(583, 136);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.Size = new System.Drawing.Size(45, 113);
            this.volumeBar.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.Location = new System.Drawing.Point(10, 477);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(46, 32);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(194, 481);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(302, 45);
            this.progressBar.TabIndex = 4;
            this.progressBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(140, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(502, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopButton.Location = new System.Drawing.Point(66, 477);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(46, 32);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(9, 1);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(30, 32);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "L";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(55, 5);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(66, 20);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "No file :(";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(599, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 32);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // fullscrButton
            // 
            this.fullscrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscrButton.Location = new System.Drawing.Point(592, 477);
            this.fullscrButton.Margin = new System.Windows.Forms.Padding(2);
            this.fullscrButton.Name = "fullscrButton";
            this.fullscrButton.Size = new System.Drawing.Size(30, 32);
            this.fullscrButton.TabIndex = 6;
            this.fullscrButton.Text = "O";
            this.fullscrButton.UseVisualStyleBackColor = true;
            this.fullscrButton.Click += new System.EventHandler(this.fullscrButton_Click);
            // 
            // subtitlesLabel
            // 
            this.subtitlesLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.subtitlesLabel.AutoSize = true;
            this.subtitlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtitlesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subtitlesLabel.Location = new System.Drawing.Point(229, 367);
            this.subtitlesLabel.Name = "subtitlesLabel";
            this.subtitlesLabel.Size = new System.Drawing.Size(0, 17);
            this.subtitlesLabel.TabIndex = 7;
            this.subtitlesLabel.Click += new System.EventHandler(this.subtitlesLabel_Click);
            // 
            // playerWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(632, 520);
            this.Controls.Add(this.fullscrButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.viewPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(574, 527);
            this.Name = "playerWindow";
            this.RightToLeftLayout = true;
            this.Text = "AVPlayer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlayerWindow_DragDrop);
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TrackBar progressBar;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button fullscrButton;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.Label subtitlesLabel;
    }
}

