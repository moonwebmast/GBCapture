/* ==============================================================================
 * 功能描述：    调用电脑摄像头，并进行拍摄、保存。
 * 创 建 者：    泰勒Peano
 * 交流邮箱：    goodzheng@88.com
 * 交流QQ：      656029714
 * 创建日期：    2020.09.04
 *.Net Version  3.5
 * ==============================================================================*/
using AForge.Video.DirectShow;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GBCapture
{
    public partial class MainForm : Form
    {
        #region 变量

        List<FilterInfo> videoDevices = new List<FilterInfo>();
        List<WaveInCapabilities> audioInputDevices = new List<WaveInCapabilities>();
        List<WaveOutCapabilities> audioOutputDevices = new List<WaveOutCapabilities>();
        VideoCaptureDevice videoSource;//捕获设备源
        

        WaveOut audioOut;//= new WaveOut();
        WaveIn audioIn;// = new WaveIn();
        BufferedWaveProvider buffer = new BufferedWaveProvider(new WaveFormat(16000, 16, 1));
        #endregion

        #region 构造函数
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        private void Form1_Load(object sender, EventArgs e)
        {


            #region 绑定视频输入选项
            //先检测电脑所有视频输入设备（摄像头）
            var vds = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            for (int i = 0; i < vds.Count; i++)
            {
                videoDevices.Add(vds[i]);
            }

            select_videoInputDevices.Items.Clear();
            videoDevices.ForEach(x =>
            {
                select_videoInputDevices.Items.Add(x.Name);
            });
            #endregion

            #region 绑定音频输入选项
            for (int waveInDevice = 0; waveInDevice < WaveIn.DeviceCount; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                audioInputDevices.Add(deviceInfo);
            }

            select_audioInputDevices.DisplayMember = "ProductName";
            select_audioInputDevices.DataSource = audioInputDevices;

            #endregion

            #region 绑定音频输出设备列表
            for (int waveOutDevice = 0; waveOutDevice < WaveOut.DeviceCount; waveOutDevice++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(waveOutDevice);
                audioOutputDevices.Add(deviceInfo);
            }
            select_audioOutputDevices.DisplayMember = "ProductName";
            select_audioOutputDevices.DataSource = audioOutputDevices;
            #endregion


            if (audioInputDevices.Count > 0)
            {
                select_audioInputDevices.SelectedIndex = 0;
            }

            if (audioOutputDevices.Count > 0)
            {
                select_audioOutputDevices.SelectedIndex = 0;
            }

            if (select_videoInputDevices.Items.Count > 0)
            {
                select_videoInputDevices.SelectedIndex = 0;
                PlayVideo(select_videoInputDevices.SelectedItem.ToString());
            }


            PlaySound();
        }

        private void PlaySound()
        {

            audioIn?.StopRecording();
            audioOut?.Stop();

            audioOut = new WaveOut();
            audioIn = new WaveIn();

            audioIn.WaveFormat = new WaveFormat(16000, 16, 1);
            audioIn.DeviceNumber = select_audioInputDevices.SelectedIndex;

            audioIn.DataAvailable += (s, e) =>
            {
                buffer.AddSamples(e.Buffer, 0, e.BytesRecorded);
            };

            audioOut.Init(buffer);
            audioOut.DeviceNumber = select_audioOutputDevices.SelectedIndex;
            audioOut.Play();

            audioIn.StartRecording();
        }


        private void PlayVideo(string name)
        {
            ShutCamera();//保证释放摄像头

            var videoDevice = videoDevices.FirstOrDefault(x => x.Name == name);
            videoSource = new VideoCaptureDevice(videoDevice.MonikerString);

            videoPlayer.VideoSource = videoSource;
            videoPlayer.Start();

            //btn_captureImage.Enabled = true;//开启“拍摄功能”
            btn_fullScreen.Enabled = true;//开启投屏功能
        }

        private void VideoDeviceChanged(object sender, EventArgs e)
        {
            PlayVideo(select_videoInputDevices.Text);
        }

        private void AudioInputDevicesChanged(object sender, EventArgs e)
        {
            PlaySound();
        }

        private void AudioOutputDevicesChanged(object sender, EventArgs e)
        {
            PlaySound();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShutCamera();//保证释放摄像头

        }

       

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            FullScreen();
        }
        #endregion

        private void VideoPlayer_DoubleClick(object sender, EventArgs e)
        {
            FullScreen();
        }


        private void FullScreen()
        {
            FullScreenForm form = new FullScreenForm(videoSource);
            form.OnClose += (s, ee) =>
            {
                videoPlayer.Start();
            };
            videoPlayer.Stop();
            form.Show();
        }


        // 关闭并释放摄像头
        private void ShutCamera()
        {
            if (videoPlayer.VideoSource != null)
            {
                videoPlayer.SignalToStop();
                videoPlayer.WaitForStop();
                videoPlayer.VideoSource = null;
            }
        }


    }
}
