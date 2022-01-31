using System;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using DirectShowLib;
using System.Drawing.Imaging;

namespace WebCam
{
    public partial class MainForm : Form
    {
        private VideoCapture _capture = null;
        private DsDevice[] _webCams = null;
        private int _selectedCameraId = 0; 

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ibVideo.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            _webCams = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);

            for (int i = 0; i < _webCams.Length; i++)
            {
                cbCamera.Items.Add(_webCams[i].Name);
            }
        }

        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCameraId = cbCamera.SelectedIndex;
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
           try
            {
                if (_webCams.Length == 0)
                    throw new Exception("Нет доступных для подключения камер!");
                else if (cbCamera.SelectedIndex == -1)
                    throw new Exception("Необходимо выбрать камеру!");
                else if (_capture != null)
                    _capture.Start();
                else
                {
                    ibVideo.Visible = true; 
                    _capture = new VideoCapture(_selectedCameraId);
                    _capture.ImageGrabbed += _capture_ImageGrabbed;
                    _capture.Start(); 
                }
                 
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void _capture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {      
                Mat mat = new Mat();
                _capture.Retrieve(mat, 0);
                ibVideo.Image = mat.ToImage<Rgb, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (_capture != null)
                    _capture.Pause(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (_capture != null && _capture.IsOpened)
                {
                    _capture.Stop();
                    ibVideo.Image = null;
                    ibVideo.Visible = false; 
                    _capture = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btScreen_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap bmpSave = new System.Drawing.Bitmap(ibVideo.Width, ibVideo.Height);
            ibVideo.DrawToBitmap(bmpSave, ibVideo.ClientRectangle);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "bmp";
            sfd.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
                bmpSave.Save(sfd.FileName, ImageFormat.Bmp);
        }
    }
}
