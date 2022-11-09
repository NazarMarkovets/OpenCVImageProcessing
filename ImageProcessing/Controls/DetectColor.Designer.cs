
namespace ImageProcessing.Controls
{
    partial class DetectColor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgSource = new System.Windows.Forms.PictureBox();
            this.tab1_imgLAB = new System.Windows.Forms.PictureBox();
            this.tab1_imgBRG = new System.Windows.Forms.PictureBox();
            this.tab1_imgYCB = new System.Windows.Forms.PictureBox();
            this.tab1_imgHSV = new System.Windows.Forms.PictureBox();
            this.btnLoadSourceImage = new System.Windows.Forms.Button();
            this.tabFilters = new System.Windows.Forms.TabControl();
            this.tabFilter = new System.Windows.Forms.TabPage();
            this.tabFirst = new System.Windows.Forms.TabPage();
            this.tab2_imgHSV = new System.Windows.Forms.PictureBox();
            this.tab2_imgYCB = new System.Windows.Forms.PictureBox();
            this.tab2_imgBRG = new System.Windows.Forms.PictureBox();
            this.tab2_imgLAB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_imgLAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_imgBRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_imgYCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_imgHSV)).BeginInit();
            this.tabFilters.SuspendLayout();
            this.tabFilter.SuspendLayout();
            this.tabFirst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_imgHSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_imgYCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_imgBRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_imgLAB)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSource
            // 
            this.imgSource.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.imgSource.Location = new System.Drawing.Point(46, 60);
            this.imgSource.Name = "imgSource";
            this.imgSource.Size = new System.Drawing.Size(500, 500);
            this.imgSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSource.TabIndex = 0;
            this.imgSource.TabStop = false;
            // 
            // tab1_imgLAB
            // 
            this.tab1_imgLAB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab1_imgLAB.Location = new System.Drawing.Point(22, 23);
            this.tab1_imgLAB.Name = "tab1_imgLAB";
            this.tab1_imgLAB.Size = new System.Drawing.Size(200, 200);
            this.tab1_imgLAB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tab1_imgLAB.TabIndex = 1;
            this.tab1_imgLAB.TabStop = false;
            // 
            // tab1_imgBRG
            // 
            this.tab1_imgBRG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab1_imgBRG.Location = new System.Drawing.Point(22, 323);
            this.tab1_imgBRG.Name = "tab1_imgBRG";
            this.tab1_imgBRG.Size = new System.Drawing.Size(200, 200);
            this.tab1_imgBRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tab1_imgBRG.TabIndex = 2;
            this.tab1_imgBRG.TabStop = false;
            // 
            // tab1_imgYCB
            // 
            this.tab1_imgYCB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab1_imgYCB.Location = new System.Drawing.Point(303, 23);
            this.tab1_imgYCB.Name = "tab1_imgYCB";
            this.tab1_imgYCB.Size = new System.Drawing.Size(200, 200);
            this.tab1_imgYCB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tab1_imgYCB.TabIndex = 3;
            this.tab1_imgYCB.TabStop = false;
            // 
            // tab1_imgHSV
            // 
            this.tab1_imgHSV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab1_imgHSV.Location = new System.Drawing.Point(303, 323);
            this.tab1_imgHSV.Name = "tab1_imgHSV";
            this.tab1_imgHSV.Size = new System.Drawing.Size(200, 200);
            this.tab1_imgHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tab1_imgHSV.TabIndex = 4;
            this.tab1_imgHSV.TabStop = false;
            // 
            // btnLoadSourceImage
            // 
            this.btnLoadSourceImage.BackColor = System.Drawing.Color.Teal;
            this.btnLoadSourceImage.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadSourceImage.ForeColor = System.Drawing.SystemColors.Info;
            this.btnLoadSourceImage.Location = new System.Drawing.Point(183, 591);
            this.btnLoadSourceImage.Name = "btnLoadSourceImage";
            this.btnLoadSourceImage.Size = new System.Drawing.Size(182, 29);
            this.btnLoadSourceImage.TabIndex = 5;
            this.btnLoadSourceImage.Text = "Load Image";
            this.btnLoadSourceImage.UseVisualStyleBackColor = false;
            this.btnLoadSourceImage.Click += new System.EventHandler(this.DoLoadSourceImage);
            // 
            // tabFilters
            // 
            this.tabFilters.Controls.Add(this.tabFilter);
            this.tabFilters.Controls.Add(this.tabFirst);
            this.tabFilters.Location = new System.Drawing.Point(629, 8);
            this.tabFilters.Name = "tabFilters";
            this.tabFilters.SelectedIndex = 0;
            this.tabFilters.Size = new System.Drawing.Size(552, 612);
            this.tabFilters.TabIndex = 1;
            this.tabFilters.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.DoChangeActiveTab);
            // 
            // tabFilter
            // 
            this.tabFilter.Controls.Add(this.tab1_imgLAB);
            this.tabFilter.Controls.Add(this.tab1_imgBRG);
            this.tabFilter.Controls.Add(this.tab1_imgYCB);
            this.tabFilter.Controls.Add(this.tab1_imgHSV);
            this.tabFilter.Location = new System.Drawing.Point(4, 29);
            this.tabFilter.Name = "tabFilter";
            this.tabFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilter.Size = new System.Drawing.Size(544, 579);
            this.tabFilter.TabIndex = 0;
            this.tabFilter.Text = "Filters";
            this.tabFilter.UseVisualStyleBackColor = true;
            // 
            // tabFirst
            // 
            this.tabFirst.Controls.Add(this.tab2_imgHSV);
            this.tabFirst.Controls.Add(this.tab2_imgYCB);
            this.tabFirst.Controls.Add(this.tab2_imgBRG);
            this.tabFirst.Controls.Add(this.tab2_imgLAB);
            this.tabFirst.Location = new System.Drawing.Point(4, 29);
            this.tabFirst.Name = "tabFirst";
            this.tabFirst.Padding = new System.Windows.Forms.Padding(3);
            this.tabFirst.Size = new System.Drawing.Size(544, 579);
            this.tabFirst.TabIndex = 1;
            this.tabFirst.Text = "Find First Element";
            this.tabFirst.UseVisualStyleBackColor = true;
            // 
            // tab2_imgHSV
            // 
            this.tab2_imgHSV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab2_imgHSV.Location = new System.Drawing.Point(309, 323);
            this.tab2_imgHSV.Name = "tab2_imgHSV";
            this.tab2_imgHSV.Size = new System.Drawing.Size(200, 200);
            this.tab2_imgHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tab2_imgHSV.TabIndex = 5;
            this.tab2_imgHSV.TabStop = false;
            // 
            // tab2_imgYCB
            // 
            this.tab2_imgYCB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab2_imgYCB.Location = new System.Drawing.Point(309, 23);
            this.tab2_imgYCB.Name = "tab2_imgYCB";
            this.tab2_imgYCB.Size = new System.Drawing.Size(200, 200);
            this.tab2_imgYCB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tab2_imgYCB.TabIndex = 4;
            this.tab2_imgYCB.TabStop = false;
            // 
            // tab2_imgBRG
            // 
            this.tab2_imgBRG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab2_imgBRG.Location = new System.Drawing.Point(27, 323);
            this.tab2_imgBRG.Name = "tab2_imgBRG";
            this.tab2_imgBRG.Size = new System.Drawing.Size(200, 200);
            this.tab2_imgBRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tab2_imgBRG.TabIndex = 3;
            this.tab2_imgBRG.TabStop = false;
            // 
            // tab2_imgLAB
            // 
            this.tab2_imgLAB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tab2_imgLAB.Location = new System.Drawing.Point(27, 23);
            this.tab2_imgLAB.Name = "tab2_imgLAB";
            this.tab2_imgLAB.Size = new System.Drawing.Size(200, 200);
            this.tab2_imgLAB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tab2_imgLAB.TabIndex = 2;
            this.tab2_imgLAB.TabStop = false;
            // 
            // DetectColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.btnLoadSourceImage);
            this.Controls.Add(this.imgSource);
            this.Controls.Add(this.tabFilters);
            this.Name = "DetectColor";
            this.Size = new System.Drawing.Size(1375, 645);
            ((System.ComponentModel.ISupportInitialize)(this.imgSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_imgLAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_imgBRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_imgYCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_imgHSV)).EndInit();
            this.tabFilters.ResumeLayout(false);
            this.tabFilter.ResumeLayout(false);
            this.tabFirst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab2_imgHSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_imgYCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_imgBRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_imgLAB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSource;
        private System.Windows.Forms.PictureBox tab1_imgLAB;
        private System.Windows.Forms.PictureBox tab1_imgBRG;
        private System.Windows.Forms.PictureBox tab1_imgYCB;
        private System.Windows.Forms.PictureBox tab1_imgHSV;
        private System.Windows.Forms.Button btnLoadSourceImage;
        private System.Windows.Forms.TabControl tabFilters;
        private System.Windows.Forms.TabPage tabFilter;
        private System.Windows.Forms.TabPage tabFirst;
        private System.Windows.Forms.PictureBox tab2_imgHSV;
        private System.Windows.Forms.PictureBox tab2_imgYCB;
        private System.Windows.Forms.PictureBox tab2_imgBRG;
        private System.Windows.Forms.PictureBox tab2_imgLAB;
    }
}
