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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerWindow));
            this.viewPanel = new System.Windows.Forms.Panel();
            this.subtitlesLabel = new System.Windows.Forms.Label();
            this.muteButton = new System.Windows.Forms.Button();
            this.muteList = new System.Windows.Forms.ImageList(this.components);
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.playButton = new System.Windows.Forms.Button();
            this.playPause = new System.Windows.Forms.ImageList(this.components);
            this.progressBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.stopList = new System.Windows.Forms.ImageList(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.loadList = new System.Windows.Forms.ImageList(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.closeList = new System.Windows.Forms.ImageList(this.components);
            this.fullscrButton = new System.Windows.Forms.Button();
            this.fullSrcList = new System.Windows.Forms.ImageList(this.components);
            this.playlistButton = new System.Windows.Forms.Button();
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
            this.viewPanel.BackgroundImage = global::AVPlayer.Properties.Resources.logo;
            this.viewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewPanel.Controls.Add(this.subtitlesLabel);
            this.viewPanel.Controls.Add(this.muteButton);
            this.viewPanel.Controls.Add(this.volumeBar);
            this.viewPanel.Location = new System.Drawing.Point(12, 46);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(819, 541);
            this.viewPanel.TabIndex = 0;
            this.viewPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.viewPanel_DragDrop);
            this.viewPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.viewPanel_DragEnter);
            this.viewPanel.DragLeave += new System.EventHandler(this.viewPanel_DragLeave);
            this.viewPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewPanel_MouseDoubleClick);
            this.viewPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPanel_MouseDown);
            this.viewPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPanel_MouseMove);
            this.viewPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPanel_MouseUp);
            // 
            // subtitlesLabel
            // 
            this.subtitlesLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.subtitlesLabel.AutoSize = true;
            this.subtitlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtitlesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subtitlesLabel.Location = new System.Drawing.Point(305, 456);
            this.subtitlesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitlesLabel.Name = "subtitlesLabel";
            this.subtitlesLabel.Size = new System.Drawing.Size(0, 20);
            this.subtitlesLabel.TabIndex = 7;
            // 
            // muteButton
            // 
            this.muteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.muteButton.FlatAppearance.BorderSize = 0;
            this.muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteButton.ImageIndex = 0;
            this.muteButton.ImageList = this.muteList;
            this.muteButton.Location = new System.Drawing.Point(769, 310);
            this.muteButton.Margin = new System.Windows.Forms.Padding(4);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(40, 40);
            this.muteButton.TabIndex = 6;
            this.muteButton.UseVisualStyleBackColor = true;
            this.muteButton.Click += new System.EventHandler(this.muteButton_Click);
            this.muteButton.MouseEnter += new System.EventHandler(this.buttonHoverOn);
            this.muteButton.MouseLeave += new System.EventHandler(this.buttonHoverOut);
            // 
            // muteList
            // 
            this.muteList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("muteList.ImageStream")));
            this.muteList.TransparentColor = System.Drawing.Color.Empty;
            this.muteList.Images.SetKeyName(0, "muteButton.png");
            this.muteList.Images.SetKeyName(1, "muteButton-hover.png");
            this.muteList.Images.SetKeyName(2, "muteButton-on.png");
            this.muteList.Images.SetKeyName(3, "muteButton-on-hover.png");
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.volumeBar.BackColor = System.Drawing.Color.Black;
            this.volumeBar.Location = new System.Drawing.Point(777, 169);
            this.volumeBar.Margin = new System.Windows.Forms.Padding(4);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.Size = new System.Drawing.Size(56, 139);
            this.volumeBar.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.ImageIndex = 0;
            this.playButton.ImageList = this.playPause;
            this.playButton.Location = new System.Drawing.Point(31, 590);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(40, 40);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.buttonHoverOn);
            this.playButton.MouseLeave += new System.EventHandler(this.buttonHoverOut);
            // 
            // playPause
            // 
            this.playPause.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playPause.ImageStream")));
            this.playPause.TransparentColor = System.Drawing.Color.Empty;
            this.playPause.Images.SetKeyName(0, "playButton.png");
            this.playPause.Images.SetKeyName(1, "playButton-hover.png");
            this.playPause.Images.SetKeyName(2, "pauseButton.png");
            this.playPause.Images.SetKeyName(3, "pauseButton-hover.png");
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(242, 597);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(403, 56);
            this.progressBar.TabIndex = 4;
            this.progressBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(170, 602);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(652, 602);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.ImageIndex = 0;
            this.stopButton.ImageList = this.stopList;
            this.stopButton.Location = new System.Drawing.Point(87, 590);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(40, 40);
            this.stopButton.TabIndex = 0;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            this.stopButton.MouseEnter += new System.EventHandler(this.buttonHoverOn);
            this.stopButton.MouseLeave += new System.EventHandler(this.buttonHoverOut);
            // 
            // stopList
            // 
            this.stopList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("stopList.ImageStream")));
            this.stopList.TransparentColor = System.Drawing.Color.Empty;
            this.stopList.Images.SetKeyName(0, "stopButton.png");
            this.stopList.Images.SetKeyName(1, "stopButton-hover.png");
            // 
            // openButton
            // 
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.ImageIndex = 0;
            this.openButton.ImageList = this.loadList;
            this.openButton.Location = new System.Drawing.Point(12, 1);
            this.openButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(40, 40);
            this.openButton.TabIndex = 1;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            this.openButton.MouseEnter += new System.EventHandler(this.buttonHoverOn);
            this.openButton.MouseLeave += new System.EventHandler(this.buttonHoverOut);
            // 
            // loadList
            // 
            this.loadList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("loadList.ImageStream")));
            this.loadList.TransparentColor = System.Drawing.Color.Transparent;
            this.loadList.Images.SetKeyName(0, "loadButton.png");
            this.loadList.Images.SetKeyName(1, "loadButton-hover.png");
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(73, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(84, 25);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "No file :(";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ImageIndex = 0;
            this.closeButton.ImageList = this.closeList;
            this.closeButton.Location = new System.Drawing.Point(781, 2);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 39);
            this.closeButton.TabIndex = 9;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.buttonHoverOn);
            this.closeButton.MouseLeave += new System.EventHandler(this.buttonHoverOut);
            // 
            // closeList
            // 
            this.closeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("closeList.ImageStream")));
            this.closeList.TransparentColor = System.Drawing.Color.Empty;
            this.closeList.Images.SetKeyName(0, "closeButton.png");
            this.closeList.Images.SetKeyName(1, "closeButton-hover.png");
            // 
            // fullscrButton
            // 
            this.fullscrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullscrButton.FlatAppearance.BorderSize = 0;
            this.fullscrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullscrButton.ImageIndex = 0;
            this.fullscrButton.ImageList = this.fullSrcList;
            this.fullscrButton.Location = new System.Drawing.Point(781, 591);
            this.fullscrButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullscrButton.Name = "fullscrButton";
            this.fullscrButton.Size = new System.Drawing.Size(40, 40);
            this.fullscrButton.TabIndex = 6;
            this.fullscrButton.Text = "O";
            this.fullscrButton.UseVisualStyleBackColor = true;
            this.fullscrButton.Click += new System.EventHandler(this.fullscrButton_Click);
            this.fullscrButton.MouseEnter += new System.EventHandler(this.buttonHoverOn);
            this.fullscrButton.MouseLeave += new System.EventHandler(this.buttonHoverOut);
            // 
            // fullSrcList
            // 
            this.fullSrcList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fullSrcList.ImageStream")));
            this.fullSrcList.TransparentColor = System.Drawing.Color.Transparent;
            this.fullSrcList.Images.SetKeyName(0, "fullscreenButton.png");
            this.fullSrcList.Images.SetKeyName(1, "fullscreenButton-hover.png");
            // 
            // playlistButton
            // 
            this.playlistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistButton.FlatAppearance.BorderSize = 0;
            this.playlistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.playlistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.playlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playlistButton.ForeColor = System.Drawing.Color.White;
            this.playlistButton.Location = new System.Drawing.Point(655, 2);
            this.playlistButton.Name = "playlistButton";
            this.playlistButton.Size = new System.Drawing.Size(100, 40);
            this.playlistButton.TabIndex = 10;
            this.playlistButton.Text = "Playlist";
            this.playlistButton.UseVisualStyleBackColor = true;
            this.playlistButton.Click += new System.EventHandler(this.playlistButton_Click);
            // 
            // playerWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(843, 644);
            this.Controls.Add(this.playlistButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(759, 638);
            this.Name = "playerWindow";
            this.RightToLeftLayout = true;
            this.Text = "AVPlayer";
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
        private System.Windows.Forms.ImageList closeList;
        private System.Windows.Forms.ImageList playPause;
        private System.Windows.Forms.ImageList stopList;
        private System.Windows.Forms.ImageList muteList;
        private System.Windows.Forms.ImageList fullSrcList;
        private System.Windows.Forms.ImageList loadList;
        private System.Windows.Forms.Button playlistButton;
    }
}

