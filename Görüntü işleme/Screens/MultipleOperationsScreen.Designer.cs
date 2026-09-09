namespace Görüntü_işleme.Screens
{
    partial class MultipleOperationsScreen
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
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.btnReset = new Krypton.Toolkit.KryptonButton();
            this.GoPreviousStep = new Krypton.Toolkit.KryptonButton();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBinary = new Krypton.Toolkit.KryptonButton();
            this.btnGrayscale = new Krypton.Toolkit.KryptonButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColorSpace = new Krypton.Toolkit.KryptonButton();
            this.cmbColorSpace = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRotate = new Krypton.Toolkit.KryptonButton();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtContrast = new System.Windows.Forms.TextBox();
            this.btnApplyContrast = new Krypton.Toolkit.KryptonButton();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.Zoom = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Zoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalImage
            // 
            this.OriginalImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImage.Location = new System.Drawing.Point(12, 12);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(371, 346);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 20;
            this.OriginalImage.TabStop = false;
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(12, 410);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(148, 43);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 22;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(221, 412);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(206, 43);
            this.btnReset.StateCommon.Border.Rounding = 15F;
            this.btnReset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.TabIndex = 23;
            this.btnReset.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnReset.Values.Text = "Temizle";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // GoPreviousStep
            // 
            this.GoPreviousStep.Location = new System.Drawing.Point(632, 410);
            this.GoPreviousStep.Name = "GoPreviousStep";
            this.GoPreviousStep.Size = new System.Drawing.Size(117, 43);
            this.GoPreviousStep.StateCommon.Border.Rounding = 15F;
            this.GoPreviousStep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoPreviousStep.TabIndex = 24;
            this.GoPreviousStep.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.GoPreviousStep.Values.Text = "Geri al";
            this.GoPreviousStep.Click += new System.EventHandler(this.GoPreviousStep_Click);
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(6, 41);
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(137, 30);
            this.nudAngle.TabIndex = 26;
            this.nudAngle.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
            // 
            // EditedImage
            // 
            this.EditedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditedImage.Location = new System.Drawing.Point(393, 12);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(356, 346);
            this.EditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditedImage.TabIndex = 21;
            this.EditedImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBinary);
            this.groupBox1.Controls.Add(this.btnGrayscale);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(766, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 186);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renk Dönüşümü";
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(6, 133);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(227, 39);
            this.btnBinary.StateCommon.Border.Rounding = 15F;
            this.btnBinary.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinary.TabIndex = 29;
            this.btnBinary.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBinary.Values.Text = "Binary Dönüşüm";
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(6, 51);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(227, 39);
            this.btnGrayscale.StateCommon.Border.Rounding = 15F;
            this.btnGrayscale.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrayscale.TabIndex = 28;
            this.btnGrayscale.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGrayscale.Values.Text = "Gri Dönüşüm";
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColorSpace);
            this.groupBox2.Controls.Add(this.cmbColorSpace);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(772, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 154);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Renk Uzayı";
            // 
            // btnColorSpace
            // 
            this.btnColorSpace.Location = new System.Drawing.Point(5, 109);
            this.btnColorSpace.Name = "btnColorSpace";
            this.btnColorSpace.Size = new System.Drawing.Size(227, 39);
            this.btnColorSpace.StateCommon.Border.Rounding = 15F;
            this.btnColorSpace.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorSpace.TabIndex = 29;
            this.btnColorSpace.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnColorSpace.Values.Text = "Uygula";
            this.btnColorSpace.Click += new System.EventHandler(this.btnColorSpace_Click);
            // 
            // cmbColorSpace
            // 
            this.cmbColorSpace.FormattingEnabled = true;
            this.cmbColorSpace.Location = new System.Drawing.Point(5, 41);
            this.cmbColorSpace.Name = "cmbColorSpace";
            this.cmbColorSpace.Size = new System.Drawing.Size(227, 31);
            this.cmbColorSpace.TabIndex = 31;
            this.cmbColorSpace.SelectedIndexChanged += new System.EventHandler(this.cmbColorSpace_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRotate);
            this.groupBox4.Controls.Add(this.nudAngle);
            this.groupBox4.Controls.Add(this.cmbDirection);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1058, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 176);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Döndürme";
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(6, 123);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(227, 39);
            this.btnRotate.StateCommon.Border.Rounding = 15F;
            this.btnRotate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.TabIndex = 29;
            this.btnRotate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRotate.Values.Text = "Uygula";
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // cmbDirection
            // 
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Location = new System.Drawing.Point(6, 86);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(227, 31);
            this.cmbDirection.TabIndex = 31;
            this.cmbDirection.SelectedIndexChanged += new System.EventHandler(this.cmbDirection_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtContrast);
            this.groupBox3.Controls.Add(this.btnApplyContrast);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1047, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 154);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrast Artırma";
            // 
            // txtContrast
            // 
            this.txtContrast.Location = new System.Drawing.Point(6, 36);
            this.txtContrast.Multiline = true;
            this.txtContrast.Name = "txtContrast";
            this.txtContrast.Size = new System.Drawing.Size(172, 43);
            this.txtContrast.TabIndex = 33;
            // 
            // btnApplyContrast
            // 
            this.btnApplyContrast.Location = new System.Drawing.Point(6, 109);
            this.btnApplyContrast.Name = "btnApplyContrast";
            this.btnApplyContrast.Size = new System.Drawing.Size(227, 39);
            this.btnApplyContrast.StateCommon.Border.Rounding = 15F;
            this.btnApplyContrast.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyContrast.TabIndex = 29;
            this.btnApplyContrast.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnApplyContrast.Values.Text = "Uygula";
            this.btnApplyContrast.Click += new System.EventHandler(this.btnApplyContrast_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(493, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 33;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Zoom
            // 
            this.Zoom.Controls.Add(this.trackBar1);
            this.Zoom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zoom.Location = new System.Drawing.Point(777, 400);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(519, 97);
            this.Zoom.TabIndex = 32;
            this.Zoom.TabStop = false;
            this.Zoom.Text = "Zoom";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 29);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(497, 56);
            this.trackBar1.TabIndex = 34;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // MultipleOperationsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 529);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GoPreviousStep);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.OpenImage);
            this.Controls.Add(this.EditedImage);
            this.Controls.Add(this.OriginalImage);
            this.Name = "MultipleOperationsScreen";
            this.Text = "MultipleOperationsScreen";
            this.Load += new System.EventHandler(this.MultipleOperationsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Zoom.ResumeLayout(false);
            this.Zoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private Krypton.Toolkit.KryptonButton btnReset;
        private Krypton.Toolkit.KryptonButton GoPreviousStep;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.PictureBox EditedImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private Krypton.Toolkit.KryptonButton btnBinary;
        private Krypton.Toolkit.KryptonButton btnGrayscale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbColorSpace;
        private Krypton.Toolkit.KryptonButton btnColorSpace;
        private System.Windows.Forms.GroupBox groupBox4;
        private Krypton.Toolkit.KryptonButton btnRotate;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.GroupBox groupBox3;
        private Krypton.Toolkit.KryptonButton btnApplyContrast;
        private System.Windows.Forms.TextBox txtContrast;
        private Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.GroupBox Zoom;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}