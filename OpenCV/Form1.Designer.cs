
using System.Windows.Forms;

namespace OpenCV
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cameraPictureBox = new System.Windows.Forms.PictureBox();
            this.chb_Blur = new System.Windows.Forms.CheckBox();
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Zoom = new System.Windows.Forms.Button();
            this.btn_Rotate = new System.Windows.Forms.Button();
            this.chb_Threst = new System.Windows.Forms.CheckBox();
            this.chb_Contur = new System.Windows.Forms.CheckBox();
            this.btn_ResumePause = new System.Windows.Forms.Button();
            this.btn_ScreenShot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraPictureBox
            // 
            this.cameraPictureBox.ErrorImage = null;
            this.cameraPictureBox.Location = new System.Drawing.Point(21, 28);
            this.cameraPictureBox.Name = "cameraPictureBox";
            this.cameraPictureBox.Size = new System.Drawing.Size(400, 400);
            this.cameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cameraPictureBox.TabIndex = 0;
            this.cameraPictureBox.TabStop = false;
            this.cameraPictureBox.WaitOnLoad = true;
            this.cameraPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cameraPictureBox_MouseDown);
            this.cameraPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cameraPictureBox_MouseMove);
            this.cameraPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cameraPictureBox_MouseUp);
            // 
            // chb_Blur
            // 
            this.chb_Blur.AutoSize = true;
            this.chb_Blur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chb_Blur.Location = new System.Drawing.Point(668, 54);
            this.chb_Blur.Name = "chb_Blur";
            this.chb_Blur.Size = new System.Drawing.Size(62, 22);
            this.chb_Blur.TabIndex = 1;
            this.chb_Blur.Text = "Blur";
            this.chb_Blur.UseVisualStyleBackColor = true;
            this.chb_Blur.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(228, 73);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.Gray;
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBar.ProgressWidth = 15;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar.Size = new System.Drawing.Size(320, 320);
            this.progressBar.StartAngle = 270;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar.SubscriptText = "";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "";
            this.progressBar.TabIndex = 3;
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.progressBar.UseWaitCursor = true;
            this.progressBar.Value = 68;
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // btn_Zoom
            // 
            this.btn_Zoom.Location = new System.Drawing.Point(686, 154);
            this.btn_Zoom.Name = "btn_Zoom";
            this.btn_Zoom.Size = new System.Drawing.Size(75, 23);
            this.btn_Zoom.TabIndex = 4;
            this.btn_Zoom.Text = "Zoom";
            this.btn_Zoom.UseVisualStyleBackColor = true;
            this.btn_Zoom.Visible = false;
            this.btn_Zoom.Click += new System.EventHandler(this.btn_Zoom_Click);
            // 
            // btn_Rotate
            // 
            this.btn_Rotate.Location = new System.Drawing.Point(686, 198);
            this.btn_Rotate.Name = "btn_Rotate";
            this.btn_Rotate.Size = new System.Drawing.Size(75, 23);
            this.btn_Rotate.TabIndex = 5;
            this.btn_Rotate.Text = "Rotate";
            this.btn_Rotate.UseVisualStyleBackColor = true;
            this.btn_Rotate.Visible = false;
            this.btn_Rotate.Click += new System.EventHandler(this.btn_Rotate_Click);
            // 
            // chb_Threst
            // 
            this.chb_Threst.AutoSize = true;
            this.chb_Threst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chb_Threst.Location = new System.Drawing.Point(668, 82);
            this.chb_Threst.Name = "chb_Threst";
            this.chb_Threst.Size = new System.Drawing.Size(62, 22);
            this.chb_Threst.TabIndex = 6;
            this.chb_Threst.Text = "Gray";
            this.chb_Threst.UseVisualStyleBackColor = true;
            this.chb_Threst.Visible = false;
            // 
            // chb_Contur
            // 
            this.chb_Contur.AutoSize = true;
            this.chb_Contur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chb_Contur.Location = new System.Drawing.Point(668, 110);
            this.chb_Contur.Name = "chb_Contur";
            this.chb_Contur.Size = new System.Drawing.Size(102, 22);
            this.chb_Contur.TabIndex = 7;
            this.chb_Contur.Text = "Contorous";
            this.chb_Contur.UseVisualStyleBackColor = true;
            this.chb_Contur.Visible = false;
            // 
            // btn_ResumePause
            // 
            this.btn_ResumePause.Location = new System.Drawing.Point(454, 28);
            this.btn_ResumePause.Name = "btn_ResumePause";
            this.btn_ResumePause.Size = new System.Drawing.Size(75, 23);
            this.btn_ResumePause.TabIndex = 8;
            this.btn_ResumePause.Text = "Stop";
            this.btn_ResumePause.UseVisualStyleBackColor = true;
            this.btn_ResumePause.Visible = false;
            this.btn_ResumePause.Click += new System.EventHandler(this.DoPauseResume);
            // 
            // btn_ScreenShot
            // 
            this.btn_ScreenShot.Location = new System.Drawing.Point(454, 73);
            this.btn_ScreenShot.Name = "btn_ScreenShot";
            this.btn_ScreenShot.Size = new System.Drawing.Size(151, 23);
            this.btn_ScreenShot.TabIndex = 10;
            this.btn_ScreenShot.Text = "Screen Shot";
            this.btn_ScreenShot.UseVisualStyleBackColor = true;
            this.btn_ScreenShot.Visible = false;
            this.btn_ScreenShot.Click += new System.EventHandler(this.btn_ScreenShot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btn_ScreenShot);
            this.Controls.Add(this.btn_ResumePause);
            this.Controls.Add(this.chb_Contur);
            this.Controls.Add(this.chb_Threst);
            this.Controls.Add(this.btn_Rotate);
            this.Controls.Add(this.btn_Zoom);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.chb_Blur);
            this.Controls.Add(this.cameraPictureBox);
            this.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnApplicationExit);
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnApplicationExit);
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraPictureBox;
        private CheckBox chb_Blur;
        private CircularProgressBar.CircularProgressBar progressBar;
        private Timer progressBarTimer;
        private Button btn_Zoom;
        private Button btn_Rotate;
        private CheckBox chb_Threst;
        private CheckBox chb_Contur;
        private Button btn_ResumePause;
        private Button btn_ScreenShot;
    }
}

