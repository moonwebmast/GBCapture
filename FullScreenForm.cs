using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GBCapture
{
    public partial class FullScreenForm : Form
    {

        VideoCaptureDevice videoSource;

        public event EventHandler OnClose;

        public FullScreenForm(VideoCaptureDevice source)
        {
            videoSource = source;
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.videoSourcePlayer1.VideoSource = videoSource;
            this.videoSourcePlayer1.Start();
        }

        private void videoSourcePlayer1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.videoSourcePlayer1.Stop();
                OnClose?.Invoke(this, null);
                this.Close();
            }
        }
    }
}
