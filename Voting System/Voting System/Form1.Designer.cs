namespace Voting_System
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
            this.connect_button = new System.Windows.Forms.Button();
            this._videoViewer = new Ozeki.Media.Video.Controls.VideoViewerWF();
            this.state_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.startDetecting_button = new System.Windows.Forms.Button();
            this.detectStatus_textbox = new System.Windows.Forms.TextBox();
            this.detectionStatus_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(163, 483);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(186, 42);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _videoViewer
            // 
            this._videoViewer.BackColor = System.Drawing.Color.DarkGray;
            this._videoViewer.FlipMode = Ozeki.Media.Video.FlipMode.None;
            this._videoViewer.ForeColor = System.Drawing.Color.DarkGray;
            this._videoViewer.Frame = null;
            this._videoViewer.Location = new System.Drawing.Point(12, 12);
            this._videoViewer.Name = "_videoViewer";
            this._videoViewer.RotateAngle = 0;
            this._videoViewer.Size = new System.Drawing.Size(629, 441);
            this._videoViewer.TabIndex = 1;
            this._videoViewer.Text = "videoViewerWF3";
            // 
            // state_textbox
            // 
            this.state_textbox.Enabled = false;
            this.state_textbox.Location = new System.Drawing.Point(12, 483);
            this.state_textbox.Name = "state_textbox";
            this.state_textbox.ReadOnly = true;
            this.state_textbox.Size = new System.Drawing.Size(145, 20);
            this.state_textbox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Cam Status:";
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(355, 483);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(187, 42);
            this.disconnect_button.TabIndex = 38;
            this.disconnect_button.Text = "Disconnect";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // startDetecting_button
            // 
            this.startDetecting_button.Location = new System.Drawing.Point(163, 551);
            this.startDetecting_button.Name = "startDetecting_button";
            this.startDetecting_button.Size = new System.Drawing.Size(185, 41);
            this.startDetecting_button.TabIndex = 39;
            this.startDetecting_button.Text = "Detect QR Code";
            this.startDetecting_button.UseVisualStyleBackColor = true;
            this.startDetecting_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // detectStatus_textbox
            // 
            this.detectStatus_textbox.Enabled = false;
            this.detectStatus_textbox.Location = new System.Drawing.Point(12, 551);
            this.detectStatus_textbox.Name = "detectStatus_textbox";
            this.detectStatus_textbox.ReadOnly = true;
            this.detectStatus_textbox.Size = new System.Drawing.Size(145, 20);
            this.detectStatus_textbox.TabIndex = 40;
            // 
            // detectionStatus_label
            // 
            this.detectionStatus_label.AutoSize = true;
            this.detectionStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectionStatus_label.Location = new System.Drawing.Point(17, 532);
            this.detectionStatus_label.Name = "detectionStatus_label";
            this.detectionStatus_label.Size = new System.Drawing.Size(123, 16);
            this.detectionStatus_label.TabIndex = 42;
            this.detectionStatus_label.Text = "Detection status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.detectionStatus_label);
            this.Controls.Add(this.detectStatus_textbox);
            this.Controls.Add(this.startDetecting_button);
            this.Controls.Add(this.disconnect_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.state_textbox);
            this.Controls.Add(this._videoViewer);
            this.Controls.Add(this.connect_button);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Login Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_button;
        private Ozeki.Media.Video.Controls.VideoViewerWF _videoViewer;
        private System.Windows.Forms.TextBox state_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Button startDetecting_button;
        private System.Windows.Forms.TextBox detectStatus_textbox;
        private System.Windows.Forms.Label detectionStatus_label;

    }
}

