namespace GBCapture
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.videoPlayer = new AForge.Controls.VideoSourcePlayer();
            this.select_videoInputDevices = new System.Windows.Forms.ComboBox();
            this.btn_fullScreen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fixButtonBar = new System.Windows.Forms.TableLayoutPanel();
            this.select_audioInputDevices = new System.Windows.Forms.ComboBox();
            this.select_audioOutputDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.fixButtonBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayer.Location = new System.Drawing.Point(2, 2);
            this.videoPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(1183, 579);
            this.videoPlayer.TabIndex = 0;
            this.videoPlayer.Text = "videoSourcePlayer1";
            this.videoPlayer.VideoSource = null;
            this.videoPlayer.DoubleClick += new System.EventHandler(this.VideoPlayer_DoubleClick);
            // 
            // select_videoInputDevices
            // 
            this.select_videoInputDevices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.select_videoInputDevices.FormattingEnabled = true;
            this.select_videoInputDevices.Location = new System.Drawing.Point(100, 7);
            this.select_videoInputDevices.Margin = new System.Windows.Forms.Padding(2);
            this.select_videoInputDevices.Name = "select_videoInputDevices";
            this.select_videoInputDevices.Size = new System.Drawing.Size(180, 20);
            this.select_videoInputDevices.TabIndex = 3;
            this.select_videoInputDevices.SelectedIndexChanged += new System.EventHandler(this.VideoDeviceChanged);
            // 
            // btn_fullScreen
            // 
            this.btn_fullScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_fullScreen.Enabled = false;
            this.btn_fullScreen.Location = new System.Drawing.Point(1083, 2);
            this.btn_fullScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fullScreen.Name = "btn_fullScreen";
            this.btn_fullScreen.Size = new System.Drawing.Size(96, 30);
            this.btn_fullScreen.TabIndex = 2;
            this.btn_fullScreen.Text = "全屏";
            this.btn_fullScreen.UseVisualStyleBackColor = true;
            this.btn_fullScreen.Click += new System.EventHandler(this.BtnFullScreen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.videoPlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fixButtonBar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1187, 623);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // fixButtonBar
            // 
            this.fixButtonBar.ColumnCount = 8;
            this.fixButtonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.fixButtonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.fixButtonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.fixButtonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.fixButtonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.fixButtonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.fixButtonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fixButtonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.fixButtonBar.Controls.Add(this.select_videoInputDevices, 1, 0);
            this.fixButtonBar.Controls.Add(this.btn_fullScreen, 7, 0);
            this.fixButtonBar.Controls.Add(this.select_audioInputDevices, 3, 0);
            this.fixButtonBar.Controls.Add(this.select_audioOutputDevices, 5, 0);
            this.fixButtonBar.Controls.Add(this.label1, 0, 0);
            this.fixButtonBar.Controls.Add(this.label2, 2, 0);
            this.fixButtonBar.Controls.Add(this.label3, 4, 0);
            this.fixButtonBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fixButtonBar.Location = new System.Drawing.Point(3, 586);
            this.fixButtonBar.Name = "fixButtonBar";
            this.fixButtonBar.RowCount = 1;
            this.fixButtonBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fixButtonBar.Size = new System.Drawing.Size(1181, 34);
            this.fixButtonBar.TabIndex = 1;
            // 
            // select_audioInputDevices
            // 
            this.select_audioInputDevices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.select_audioInputDevices.FormattingEnabled = true;
            this.select_audioInputDevices.Location = new System.Drawing.Point(393, 7);
            this.select_audioInputDevices.Name = "select_audioInputDevices";
            this.select_audioInputDevices.Size = new System.Drawing.Size(173, 20);
            this.select_audioInputDevices.TabIndex = 4;
            this.select_audioInputDevices.SelectedIndexChanged += new System.EventHandler(this.AudioInputDevicesChanged);
            // 
            // select_audioOutputDevices
            // 
            this.select_audioOutputDevices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.select_audioOutputDevices.FormattingEnabled = true;
            this.select_audioOutputDevices.Location = new System.Drawing.Point(673, 7);
            this.select_audioOutputDevices.Name = "select_audioOutputDevices";
            this.select_audioOutputDevices.Size = new System.Drawing.Size(194, 20);
            this.select_audioOutputDevices.TabIndex = 5;
            this.select_audioOutputDevices.SelectedIndexChanged += new System.EventHandler(this.AudioOutputDevicesChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "视频来源";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "音频来源";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "声音输出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频采集卡播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.fixButtonBar.ResumeLayout(false);
            this.fixButtonBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoPlayer;
        private System.Windows.Forms.ComboBox select_videoInputDevices;
        private System.Windows.Forms.Button btn_fullScreen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel fixButtonBar;
        private System.Windows.Forms.ComboBox select_audioInputDevices;
        private System.Windows.Forms.ComboBox select_audioOutputDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

