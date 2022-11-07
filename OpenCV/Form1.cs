using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV
{

    public partial class MainForm : Form
    {
        private bool _isZoom;
        private bool _isCameraRunning = true;
        private int _angle;
        private delegate void SafeCallDelegate(bool state, bool enable, string control);
        private event SafeCallDelegate OnStreamReady;
        private Thread cameraThread;
        private VideoCapture videoStream;

        private enum PressedKeys
        {
            Enter,
            Esc = 27,
        }

        public MainForm()
        {
            Application.ApplicationExit += OnApplicationExit;
            InitializeComponent();
            OnStreamReady += ConfigureControls;
            progressBar.Value = 0;
            progressBarTimer.Start();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            switch (e)
            {
                case KeyPressEventArgs key when (int)PressedKeys.Esc == Convert.ToInt32(key.KeyChar):
                case FormClosedEventArgs _:
                    cameraThread.Abort();
                    break;
            }
        }

        private void ConfigureControls(bool visible = true, bool enable = true, string control = null)
        {
            switch (control)
            {
                case nameof(chb_Blur):
                    if (chb_Blur.InvokeRequired) chb_Blur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else chb_Blur.Enabled = enable;
                    return;
                case nameof(chb_Threst):
                    if (chb_Threst.InvokeRequired) chb_Threst.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else chb_Threst.Enabled = enable;
                    return;
                case nameof(chb_Contur):
                    if (chb_Contur.InvokeRequired) chb_Contur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else chb_Contur.Enabled = enable;
                    return;
                default:
                    if (chb_Blur.InvokeRequired) chb_Blur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else chb_Blur.Visible = true;

                    if (chb_Threst.InvokeRequired) chb_Threst.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else chb_Threst.Visible = true;

                    if (chb_Contur.InvokeRequired) chb_Contur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else chb_Contur.Visible = true;

                    if (!progressBar.IsDisposed)
                    {
                        if (progressBar.InvokeRequired) progressBar.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                        else ProgressBarManagement(true);
                    }
                    if (btn_Zoom.InvokeRequired) btn_Zoom.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else btn_Zoom.Visible = true;

                    if (btn_Rotate.InvokeRequired) btn_Rotate.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else btn_Rotate.Visible = true;

                    if (btn_ResumePause.InvokeRequired) btn_ResumePause.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else btn_ResumePause.Visible = true;

                    if (btn_ScreenShot.InvokeRequired) btn_ScreenShot.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { visible, enable, control });
                    else btn_ScreenShot.Visible = true;

                    break;
            }


        }

        private void CaptureCamera()
        {
            cameraThread = new Thread(new ThreadStart(CaptureCameraCallback));
            cameraThread.Start();
        }

        private void CaptureCameraCallback()
        {
            videoStream = new VideoCapture(0);
            using (Mat frame = new Mat())
            {
                if (videoStream.IsOpened())
                {

                    OnStreamReady?.Invoke(true, true, null);
                    while (_isCameraRunning)
                    {
                        videoStream.Read(frame);
                        if (frame.Empty()) break;
                        Blur(frame);
                        Threst(frame);
                        GetContour(frame);
                        Zoom(frame);
                        Rotate(frame);
                        TakeAreaVision(frame);
                        cameraPictureBox.Image = BitmapConverter.ToBitmap(frame);
                        int key = Cv2.WaitKey(30);
                        if (key == (int)PressedKeys.Esc) break;
                    }
                }
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CaptureCamera();
        }

        private void Threst(Mat image)
        {
            if (chb_Threst.Checked)
            {
                Cv2.CvtColor(image, image, ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(image, image, 0, 255, ThresholdTypes.Tozero);
            }
            chb_Contur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { true, !chb_Threst.Checked, nameof(chb_Contur) });
        }

        private void GetContour(Mat image)
        {
            if (chb_Contur.Checked)
            {
                Cv2.CvtColor(image, image, ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(image, image, 0, 255, ThresholdTypes.Otsu);
                Point[][] contorous = Cv2.FindContoursAsArray(image, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                foreach (Point[] points in contorous)
                {
                    for (int i = 0; i < points.Length; i++)
                    {
                        Cv2.Line(image, points[i], points[(i + 1) % points.Length], Scalar.Gray, 2);
                    }
                }
            }
            chb_Threst.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { true, !chb_Contur.Checked, nameof(chb_Threst) });
        }

        private void Blur(Mat image)
        {
            if (chb_Blur.Checked) Cv2.GaussianBlur(image, image, new Size(31, 31), 0);
        }

        private void btn_Zoom_Click(object sender, EventArgs e) => _isZoom = !_isZoom;
        private void Zoom(Mat image)
        {
            if (_isZoom)
                using (Mat subMatrix = image.SubMat(new Rect(image.Width / 4, image.Height / 2, image.Width / 2, image.Height / 2)))
                {
                    Cv2.Resize(subMatrix, subMatrix, image.Size());
                    subMatrix.CopyTo(image);
                }
        }

        private void btn_Rotate_Click(object sender, EventArgs e) => _angle += 30;
        private void Rotate(Mat image)
        {
            using (Mat subMatrix = Cv2.GetRotationMatrix2D(new Point2f(image.Width / 2, image.Height / 2), _angle, 1))
                Cv2.WarpAffine(image, image, subMatrix, image.Size());
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            ProgressBarManagement();
            if (progressBar.Value >= 100) return;
            progressBar.Value += 1;
            progressBar.Text = progressBar.Value + " %";
        }

        private void DoPauseResume(object sender, EventArgs e)
        {
            if (btn_ResumePause.Text.Equals("Start"))
            {
                CaptureCamera();
                btn_ResumePause.Text = "Stop";
                _isCameraRunning = true;
            }
            else
            {
                videoStream.Release();
                btn_ResumePause.Text = "Start";
                _isCameraRunning = false;
            }
        }

        private void btn_ScreenShot_Click(object sender, EventArgs e)
        {
            if (!_isCameraRunning)
            {
                System.Drawing.Bitmap snapshot = new System.Drawing.Bitmap(cameraPictureBox.Image);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG files(*.jpeg)|*.jpeg";
                if(DialogResult.OK == saveFileDialog.ShowDialog())
                    snapshot.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            
        }

        
        private void ProgressBarManagement(bool forceDisable = false)
        {
            if (progressBar.Value >= 100 || forceDisable)
            {
                progressBar.Visible = false;
                progressBarTimer.Stop();
                progressBarTimer.Dispose();
                progressBar.Dispose();
            }
        }

        private Point dragStartPoint, dragEndPoint;
        private Mat picImage, template;

        private void cameraPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            dragStartPoint = new Point(e.X + 150, e.Y+90);
        }

        private void cameraPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            dragEndPoint = new Point(e.X + 150, e.Y+90);
        }

        private void cameraPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if(dragStartPoint.X > 0 && dragStartPoint.Y > 0 && dragEndPoint.X > 0 && dragEndPoint.Y > 0)
            {
                Rect rect = Cv2.BoundingRect(new Point[] {dragStartPoint, dragEndPoint});
                if(picImage != null)
                {
                    template = picImage.SubMat(rect).Clone();
                    //Cv2.ImShow("Template", template);
                    //Cv2.WaitKey(1);
                }
            }

            dragStartPoint = new Point(0, 0);
            dragEndPoint = new Point(0, 0);
        }

        private void TakeAreaVision(Mat image)
        {
            if (picImage == null) picImage = image.Clone();
            else image.CopyTo(picImage);

            if (template != null)
            {
                using (Mat result = new Mat())
                {
                    Cv2.MatchTemplate(image, template, result, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(result, out double min, out double max, out Point minLock, out Point maxLock);
                    if (max >= 0.7)
                    {
                        image.Rectangle(new Rect(maxLock, template.Size()), Scalar.Red, 2);
                        image.PutText(max.ToString(), maxLock, HersheyFonts.HersheyDuplex, 1, Scalar.Red);
                    }
                }
            }

            if (dragStartPoint.X > 0 && dragStartPoint.Y > 0 && dragEndPoint.X > 0 && dragEndPoint.Y > 0)
            {
                Rect r = Cv2.BoundingRect(new Point[] { dragStartPoint, dragEndPoint });
                image.Rectangle(r, Scalar.Lime, 2);
            }
        }

    }
}
