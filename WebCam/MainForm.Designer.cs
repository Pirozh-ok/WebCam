
namespace WebCam
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbCamera = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btPlay = new System.Windows.Forms.ToolStripButton();
            this.btPause = new System.Windows.Forms.ToolStripButton();
            this.btStop = new System.Windows.Forms.ToolStripButton();
            this.btScreen = new System.Windows.Forms.ToolStripButton();
            this.ibVideo = new Emgu.CV.UI.ImageBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbCamera,
            this.toolStripSeparator1,
            this.btPlay,
            this.btPause,
            this.btStop,
            this.btScreen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(122, 25);
            this.toolStripLabel1.Text = "Текущая камера";
            // 
            // cbCamera
            // 
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(121, 28);
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btPlay
            // 
            this.btPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btPlay.Image = ((System.Drawing.Image)(resources.GetObject("btPlay.Image")));
            this.btPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(79, 25);
            this.btPlay.Text = "Смотреть";
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btPause
            // 
            this.btPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(54, 25);
            this.btPause.Text = "Пауза";
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btStop
            // 
            this.btStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btStop.Image = ((System.Drawing.Image)(resources.GetObject("btStop.Image")));
            this.btStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(46, 25);
            this.btStop.Text = "Стоп";
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btScreen
            // 
            this.btScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btScreen.Image = ((System.Drawing.Image)(resources.GetObject("btScreen.Image")));
            this.btScreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btScreen.Name = "btScreen";
            this.btScreen.Size = new System.Drawing.Size(140, 25);
            this.btScreen.Text = "Сделать скриншот";
            this.btScreen.Click += new System.EventHandler(this.btScreen_Click);
            // 
            // ibVideo
            // 
            this.ibVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibVideo.Location = new System.Drawing.Point(0, 28);
            this.ibVideo.Name = "ibVideo";
            this.ibVideo.Size = new System.Drawing.Size(800, 470);
            this.ibVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibVideo.TabIndex = 2;
            this.ibVideo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.ibVideo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "WebCam";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbCamera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btPlay;
        private System.Windows.Forms.ToolStripButton btPause;
        private System.Windows.Forms.ToolStripButton btStop;
        private System.Windows.Forms.ToolStripButton btScreen;
        private Emgu.CV.UI.ImageBox ibVideo;
    }
}

