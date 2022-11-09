using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class DetectFigureForm : UserControl
    {
        Mat srcImage;
        private readonly Scalar[] colors =
            new Scalar[] {  new Scalar(255,0,0),
                            new Scalar(0,255,0),
                            new Scalar(0,0,255),
                            new Scalar(255,255,0),
                            new Scalar(255,0,255),
                            new Scalar(0,255,255),
                            new Scalar(180,120,0),
                            new Scalar(0,120,180),
                            new Scalar(120,0,180),
                            new Scalar(60,180,20),
                            new Scalar(180,120,5),
                            new Scalar(25,180,255)};
        public DetectFigureForm()
        {
            InitializeComponent();
        }

        private void DoLoadOriginImage(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (DialogResult.OK == fileDialog.ShowDialog())
            {
                picBox_original.Image = Image.FromFile(fileDialog.FileName);
                srcImage = Cv2.ImRead(fileDialog.FileName, ImreadModes.Grayscale);
            }
        }

        private void DoDetectImage(object sender, EventArgs e)
        {
            // Finding edges
            Mat image = new();
            Cv2.Canny(srcImage, image, 40, 120, 3);

            Mat hierarchy = new();
            Cv2.FindContours(image, out Mat[] figures, hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxNone);

            Mat result = new(srcImage.Rows, srcImage.Cols, MatType.CV_8UC3);
            for (int i = 0; i < figures.Length; i++)
            {
                // Draw rectangle border
                Cv2.DrawContours(result, figures, i, colors[i < colors.Length ? i : 10], 1, LineTypes.AntiAlias);
                if (figures.Length != 32)
                {
                    Rect border = Cv2.BoundingRect(figures[i]);
                    border.Width += 30;
                    border.Height += 30;
                    border.Location = new OpenCvSharp.Point(border.Location.X - 15, border.Location.Y - 15);
                    Cv2.Rectangle(result, border, new Scalar(255, 255, 51), 2, LineTypes.AntiAlias);

                    Mat ApproxPolyDPResult = new();
                    Cv2.ApproxPolyDP(figures[i], ApproxPolyDPResult, 0.01 * Cv2.ArcLength(figures[0], true), true);

                    switch (ApproxPolyDPResult.Rows * ApproxPolyDPResult.Cols)
                    {
                        case 3:
                            Cv2.PutText(result, "Triangle", border.Location, HersheyFonts.HersheyPlain, 5, color: new Scalar(204, 255, 204));
                            break;
                        case 4:
                            Cv2.PutText(result, "Rectangle", border.Location, HersheyFonts.HersheyPlain, 5, color: new Scalar(204, 255, 204));
                            break;
                        case 5:
                            Cv2.PutText(result, "Pentagon", border.Location, HersheyFonts.HersheyPlain, 5, color: new Scalar(204, 255, 204));
                            break;
                        case 10:
                            Cv2.PutText(result, "Star", border.Location, HersheyFonts.HersheyPlain, 5, color: new Scalar(204, 255, 204));
                            break;
                        default:
                            Cv2.PutText(result, "Circle", border.Location, HersheyFonts.HersheyPlain, 5, color: new Scalar(204, 255, 204));
                            break;
                    }
                }
                else
                {
                    var blobParams = new SimpleBlobDetector.Params
                    {
                        FilterByArea = true,
                        FilterByCircularity = true,
                        FilterByConvexity = true,
                        FilterByInertia = true,
                        MinArea = 100,
                        MinCircularity = 0.9F,
                        MinConvexity = 0.2F,
                        MinInertiaRatio = 0.01F
                    };

                    var detector = SimpleBlobDetector.Create(blobParams);
                    var keypoints = detector.Detect(srcImage);
                    Cv2.DrawKeypoints(result, keypoints, result, new Scalar(0, 0, 255), DrawMatchesFlags.DrawRichKeypoints);
                    Cv2.PutText(result, $"Number of Circles: {keypoints.Length}", new OpenCvSharp.Point(20, 550), HersheyFonts.HersheySimplex, 1, colors[new Random().Next(0, colors.Length)], 2);

                }
            }
            lbl_FiguresCount.Text = $"Figures count: {figures.Length}";

            picBox_detect.Image = BitmapConverter.ToBitmap(result);
        }
    }
}
