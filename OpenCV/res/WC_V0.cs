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
        private bool _closeStream, _isZoom;
        private int _angle;
        private delegate void SafeCallDelegate(bool state, string control);
        private event SafeCallDelegate OnStreamReady;

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
                case FormClosedEventArgs formClosedArg:
                    _closeStream = true;
                    break;
            }
        }

        private void ConfigureControls(bool state = true, string control = null)
        {
            switch (control)
            {
                case nameof(chb_Blur):
                    if (chb_Blur.InvokeRequired) chb_Blur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                    else chb_Blur.Enabled = state;
                    return;
                case nameof(chb_Threst):
                    if (chb_Threst.InvokeRequired) chb_Threst.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                    else chb_Threst.Enabled = state;
                    return;
                case nameof(chb_Contur):
                    if (chb_Contur.InvokeRequired) chb_Contur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                    else chb_Contur.Enabled = state;
                    return;
                default:
                    if (chb_Blur.InvokeRequired) chb_Blur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                    else chb_Blur.Visible = true;

                    if (chb_Threst.InvokeRequired) chb_Threst.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                    else chb_Threst.Visible = true;

                    if (chb_Contur.InvokeRequired) chb_Contur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                    else chb_Contur.Visible = true;

                    if (!progressBar.IsDisposed)
                    {
                        if (progressBar.InvokeRequired) progressBar.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                        else ProgressBarManagement(true);
                    }
                    if (btn_Zoom.InvokeRequired) btn_Zoom.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                    else btn_Zoom.Visible = true;

                    if (btn_Rotate.InvokeRequired) btn_Rotate.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { state, control });
                    else btn_Rotate.Visible = true;
                    break;
            }

            
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
            Task.Run(() =>
            {
                using (VideoCapture videoStream = new VideoCapture(0))
                using (Mat image = new Mat())
                {
                    OnStreamReady?.Invoke(true, null);
                    while (true && !_closeStream)
                    {
                        videoStream.Read(image);
                        if (image.Empty()) break;
                        Blur(image);
                        Threst(image);
                        GetContour(image);
                        Zoom(image);
                        Rotate(image);

                        cameraPictureBox.Image = BitmapConverter.ToBitmap(image);
                        int key = Cv2.WaitKey(30);
                        if (key == (int)PressedKeys.Esc) break;
                    }
                }
            });
        }

        private void Threst(Mat image)
        {
            if (chb_Threst.Checked)
            {
                Cv2.CvtColor(image, image, ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(image, image, 0, 255, ThresholdTypes.Otsu);
            }
            chb_Contur.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { !chb_Threst.Checked, nameof(chb_Contur) });
        }

        private void GetContour(Mat image)
        {
            if (chb_Contur.Checked)
            {
                using (Mat gray = new Mat(image.Size(), MatType.CV_8UC3))
                {
                    Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);
                    Cv2.Threshold(gray, gray, 0, 255, ThresholdTypes.Otsu);
                    Point[][] contorous = Cv2.FindContoursAsArray(gray, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                    foreach (Point[] points in contorous)
                    {
                        for (int i = 0; i < points.Length; i++)
                        {
                            Cv2.Line(image, points[i], points[(i + 1) % points.Length], Scalar.Gray, 2);
                        }
                    }
                }
            }
            chb_Threst.Invoke(new SafeCallDelegate(ConfigureControls), new object[] { !chb_Contur.Checked, nameof(chb_Threst) });
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
            using (Mat subMatrix = Cv2.GetRotationMatrix2D(new Point2f(image.Width/2, image.Height/2), _angle, 1))
                Cv2.WarpAffine(image, image, subMatrix, image.Size());
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            ProgressBarManagement();
            if (progressBar.Value >= 100) return;
            progressBar.Value += 1;
            progressBar.Text = progressBar.Value + " %";
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
    }
}
