using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Internal.Vectors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing.Controls
{
    public partial class DetectColor : UserControl
    {
        private Mat _originaImage;

        private Mat _imageBRG = new Mat(),
                    _imageYCB = new Mat(),
                    _imageHSV = new Mat(),
                    _imageLAB = new Mat();
        private int _activeTab;

        public DetectColor()
        {
            InitializeComponent();
            _activeTab = tabFilters.SelectedIndex;
        }

        private void DoLoadSourceImage(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (DialogResult.OK == fileDialog.ShowDialog())
            {
                SetImageFromSource(fileDialog.FileName);
                if (_activeTab == 0) DoChangeActiveTab(tabFilters, new TabControlCancelEventArgs(tabFilter, 0, false, default));
            }
        }

        
        private void SetImageFromSource(string fileName)
        {
            imgSource.Image = Image.FromFile(fileName);
            _originaImage = Cv2.ImRead(fileName, ImreadModes.Color);
        }

        private void SetImageColorFilters(in Mat originalImage, out Mat brg, out Mat ycb, out Mat hsv, out Mat lab)
        {
            brg = new();
            Cv2.CvtColor(originalImage, brg, ColorConversionCodes.BGR2Lab);
            brg.CopyTo(_imageBRG);

            ycb = new();
            Cv2.CvtColor(originalImage, ycb, ColorConversionCodes.BGR2YCrCb);
            ycb.CopyTo(_imageYCB);

            hsv = new Mat();
            Cv2.CvtColor(originalImage, hsv, ColorConversionCodes.BGR2HSV);
            hsv.CopyTo(_imageHSV);

            lab = new();
            Cv2.CvtColor(originalImage, lab, ColorConversionCodes.BGR2Lab);
            lab.CopyTo(_imageLAB);
        }

        private void SetImageContorous(in Mat originalImage, out Mat brg, out Mat ycb, out Mat hsv, out Mat lab)
        {
            brg = new();
            hsv = new();
            ycb = new();
            lab = new();
            
            // BRG
            (int p1, int p2, int p3) brgVector = (40, 158, 16);
            int threst = 40;

            {
                Scalar minBGR = new Scalar(brgVector.p1 - threst, brgVector.p2 - threst, brgVector.p3 - threst);
                Scalar maxBGR = new Scalar(brgVector.p1 + threst, brgVector.p2 + threst, brgVector.p3 + threst);
                Mat mask = new();
                Cv2.InRange(originalImage, minBGR, maxBGR, mask);
                Cv2.BitwiseAnd(originalImage, originalImage, brg, mask);
            }

            //HSV
            Cv2.CvtColor(brg, hsv, ColorConversionCodes.BGR2HSV);
            (int p1, int p2, int p3) hsvVector = (65, 299, 158);
            {
                Scalar minHSV = new Scalar(hsvVector.p1 - threst, hsvVector.p2 - threst, hsvVector.p3 - threst);
                Scalar maxHSV = new Scalar(hsvVector.p1 + threst, hsvVector.p2 + threst, hsvVector.p3 + threst);
                Mat mask = new();
                Cv2.InRange(_imageHSV, minHSV, maxHSV, mask);
                Cv2.BitwiseAnd(_imageHSV, _imageHSV, hsv, mask);
            }
            // YCB
            Cv2.CvtColor(originalImage, _imageYCB, ColorConversionCodes.BGR2YCrCb);
            (int p1, int p2, int p3) ycbVector = (102, 67, 93);
            {
                Scalar minYCB = new Scalar(ycbVector.p1 - threst, ycbVector.p2 - threst, ycbVector.p3 - threst);
                Scalar maxYCB = new Scalar(ycbVector.p1 + threst, ycbVector.p2 + threst, ycbVector.p3 + threst);
                Mat mask = new();
                Cv2.InRange(_imageYCB, minYCB, maxYCB, mask);
                Cv2.BitwiseAnd(_imageYCB, _imageYCB, ycb, mask);
            }

            // LAB
            Cv2.CvtColor(originalImage, _imageLAB, ColorConversionCodes.BGR2Lab);
            (int p1, int p2, int p3) labVector = (145, 71, 177);
            {
                Scalar minYCB = new Scalar(labVector.p1 - threst, labVector.p2 - threst, labVector.p3 - threst);
                Scalar maxYCB = new Scalar(labVector.p1 + threst, labVector.p2 + threst, labVector.p3 + threst);
                Mat mask = new();
                Cv2.InRange(_imageLAB, minYCB, maxYCB, mask);
                Cv2.BitwiseAnd(_imageLAB, _imageLAB, lab, mask);
            }
        }

        
        private void SetTabImageSource(int tabIndex)
        {
            _activeTab = tabIndex;
            if(_activeTab == 0)
            {
                SetImageColorFilters(_originaImage, out Mat brg, out Mat ycb, out Mat hsv, out Mat lab);
                tab1_imgBRG.Image = BitmapConverter.ToBitmap(brg);
                tab1_imgYCB.Image = BitmapConverter.ToBitmap(ycb);
                tab1_imgHSV.Image = BitmapConverter.ToBitmap(hsv);
                tab1_imgLAB.Image = BitmapConverter.ToBitmap(lab);
                return;
            }

            if(_activeTab == 1)
            {
                SetImageContorous(_originaImage, out Mat brg, out Mat ycb, out Mat hsv, out Mat lab);
                tab2_imgBRG.Image = BitmapConverter.ToBitmap(brg);
                tab2_imgYCB.Image = BitmapConverter.ToBitmap(ycb);
                tab2_imgHSV.Image = BitmapConverter.ToBitmap(hsv);
                tab2_imgLAB.Image = BitmapConverter.ToBitmap(lab);
                return;
            }
        }


        private void DoChangeActiveTab(object sender, TabControlCancelEventArgs e)
        {
            SetTabImageSource(e.TabPageIndex);
        }
    }
}
