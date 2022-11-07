
namespace DetectFigure
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
            this.picBox_original = new System.Windows.Forms.PictureBox();
            this.btn_LoadOrigin = new System.Windows.Forms.Button();
            this.picBox_detect = new System.Windows.Forms.PictureBox();
            this.btn_detect = new System.Windows.Forms.Button();
            this.lbl_FiguresCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_detect)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_original
            // 
            this.picBox_original.Location = new System.Drawing.Point(53, 76);
            this.picBox_original.Name = "picBox_original";
            this.picBox_original.Size = new System.Drawing.Size(500, 500);
            this.picBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_original.TabIndex = 0;
            this.picBox_original.TabStop = false;
            // 
            // btn_LoadOrigin
            // 
            this.btn_LoadOrigin.Location = new System.Drawing.Point(164, 597);
            this.btn_LoadOrigin.Name = "btn_LoadOrigin";
            this.btn_LoadOrigin.Size = new System.Drawing.Size(250, 29);
            this.btn_LoadOrigin.TabIndex = 1;
            this.btn_LoadOrigin.Text = "Load Image";
            this.btn_LoadOrigin.UseVisualStyleBackColor = true;
            this.btn_LoadOrigin.Click += new System.EventHandler(this.DoLoadOriginImage);
            // 
            // picBox_detect
            // 
            this.picBox_detect.Location = new System.Drawing.Point(813, 76);
            this.picBox_detect.Name = "picBox_detect";
            this.picBox_detect.Size = new System.Drawing.Size(500, 500);
            this.picBox_detect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_detect.TabIndex = 2;
            this.picBox_detect.TabStop = false;
            // 
            // btn_detect
            // 
            this.btn_detect.Location = new System.Drawing.Point(973, 597);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(250, 29);
            this.btn_detect.TabIndex = 3;
            this.btn_detect.Text = "Detect Image";
            this.btn_detect.UseVisualStyleBackColor = true;
            this.btn_detect.Click += new System.EventHandler(this.DoDetectImage);
            // 
            // lbl_FiguresCount
            // 
            this.lbl_FiguresCount.AutoSize = true;
            this.lbl_FiguresCount.Location = new System.Drawing.Point(813, 26);
            this.lbl_FiguresCount.Name = "lbl_FiguresCount";
            this.lbl_FiguresCount.Size = new System.Drawing.Size(0, 20);
            this.lbl_FiguresCount.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 679);
            this.Controls.Add(this.lbl_FiguresCount);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.picBox_detect);
            this.Controls.Add(this.btn_LoadOrigin);
            this.Controls.Add(this.picBox_original);
            this.Name = "MainForm";
            this.Text = "Markovets Figures Detection";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_detect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_original;
        private System.Windows.Forms.Button btn_LoadOrigin;
        private System.Windows.Forms.PictureBox picBox_detect;
        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.Label lbl_FiguresCount;
    }
}

