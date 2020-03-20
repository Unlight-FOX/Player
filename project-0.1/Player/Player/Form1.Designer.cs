namespace Player
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.drag_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.play_button);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 491);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Black;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.Transparent;
            this.close_button.Image = global::Player.Properties.Resources.close;
            this.close_button.Location = new System.Drawing.Point(1249, 3);
            this.close_button.Margin = new System.Windows.Forms.Padding(0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(40, 40);
            this.close_button.TabIndex = 2;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.Black;
            this.play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.play_button.FlatAppearance.BorderSize = 0;
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.ForeColor = System.Drawing.Color.Transparent;
            this.play_button.Image = global::Player.Properties.Resources.play1;
            this.play_button.Location = new System.Drawing.Point(60, 431);
            this.play_button.Margin = new System.Windows.Forms.Padding(0);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(60, 60);
            this.play_button.TabIndex = 1;
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // drag_panel
            // 
            this.drag_panel.Controls.Add(this.close_button);
            this.drag_panel.Controls.Add(this.panel1);
            this.drag_panel.Location = new System.Drawing.Point(3, 6);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(1296, 533);
            this.drag_panel.TabIndex = 3;
            this.drag_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_panel_MouseDown);
            this.drag_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drag_panel_MouseMove);
            this.drag_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drag_panel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1301, 534);
            this.Controls.Add(this.drag_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.drag_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Panel drag_panel;
    }
}

