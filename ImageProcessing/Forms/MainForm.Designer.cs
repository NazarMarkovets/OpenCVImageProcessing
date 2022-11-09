
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoDetectColors = new System.Windows.Forms.Button();
            this.btnGoDetectFigure = new System.Windows.Forms.Button();
            this.detectFigureForm = new ImageProcessing.DetectFigureForm();
            this.detectColorForm = new ImageProcessing.Controls.DetectColor();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btnGoDetectColors);
            this.panel1.Controls.Add(this.btnGoDetectFigure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 645);
            this.panel1.TabIndex = 0;
            // 
            // btnGoDetectColors
            // 
            this.btnGoDetectColors.BackColor = System.Drawing.Color.Teal;
            this.btnGoDetectColors.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGoDetectColors.Location = new System.Drawing.Point(63, 149);
            this.btnGoDetectColors.Name = "btnGoDetectColors";
            this.btnGoDetectColors.Size = new System.Drawing.Size(138, 51);
            this.btnGoDetectColors.TabIndex = 1;
            this.btnGoDetectColors.Text = "Detect Colors";
            this.btnGoDetectColors.UseVisualStyleBackColor = false;
            this.btnGoDetectColors.Click += new System.EventHandler(this.BtnGoDetectColors_Click);
            // 
            // btnGoDetectFigure
            // 
            this.btnGoDetectFigure.BackColor = System.Drawing.Color.Teal;
            this.btnGoDetectFigure.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGoDetectFigure.Location = new System.Drawing.Point(63, 79);
            this.btnGoDetectFigure.Name = "btnGoDetectFigure";
            this.btnGoDetectFigure.Size = new System.Drawing.Size(138, 51);
            this.btnGoDetectFigure.TabIndex = 0;
            this.btnGoDetectFigure.Text = "Detect Figures";
            this.btnGoDetectFigure.UseVisualStyleBackColor = false;
            this.btnGoDetectFigure.Click += new System.EventHandler(this.BtnGoDetectFigure_Click);
            // 
            // detectFigureForm
            // 
            this.detectFigureForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detectFigureForm.Location = new System.Drawing.Point(276, 0);
            this.detectFigureForm.Name = "detectFigureForm";
            this.detectFigureForm.Size = new System.Drawing.Size(1377, 645);
            this.detectFigureForm.TabIndex = 1;
            this.detectFigureForm.Visible = false;
            // 
            // detectColorForm
            // 
            this.detectColorForm.BackColor = System.Drawing.SystemColors.Info;
            this.detectColorForm.Location = new System.Drawing.Point(278, 0);
            this.detectColorForm.Name = "detectColorForm";
            this.detectColorForm.Size = new System.Drawing.Size(1375, 645);
            this.detectColorForm.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1653, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detectColorForm);
            this.Controls.Add(this.detectFigureForm);
            this.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Markovets Figures Detection";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoDetectColors;
        private System.Windows.Forms.Button btnGoDetectFigure;
        private ImageProcessing.DetectFigureForm detectFigureForm;
        private ImageProcessing.Controls.DetectColor detectColorForm;
    }
}

