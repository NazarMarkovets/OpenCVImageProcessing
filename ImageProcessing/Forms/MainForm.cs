using AppCore.Helpers;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DetectFigure
{
    public partial class MainForm : Form
    {
        ControlHider controlHider = new();
        public MainForm()
        {
            InitializeComponent();
            detectFigureForm.Visible = false;
            detectColorForm.Visible = false;
            controlHider.InitializeHiderControls(detectFigureForm, detectColorForm);
        }

        private void BtnGoDetectFigure_Click(object sender, EventArgs e)
        {
            controlHider.ChangeControlVisability(detectFigureForm, true);
        }

        private void BtnGoDetectColors_Click(object sender, EventArgs e)
        {
            controlHider.ChangeControlVisability(detectColorForm, true);
        }
    }
}
