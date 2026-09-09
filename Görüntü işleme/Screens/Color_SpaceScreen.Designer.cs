namespace Görüntü_işleme.Screens
{
    partial class Color_SpaceScreen
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
            this.GoPreviousStep = new Krypton.Toolkit.KryptonButton();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.EditedImage = new System.Windows.Forms.PictureBox();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btn_RGBtoYUV = new Krypton.Toolkit.KryptonButton();
            this.btn_RGBtoHSV = new Krypton.Toolkit.KryptonButton();
            this.btn_YUVtoRGB = new Krypton.Toolkit.KryptonButton();
            this.btn_HSVtoRGB = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoPreviousStep
            // 
            this.GoPreviousStep.Location = new System.Drawing.Point(672, 316);
            this.GoPreviousStep.Name = "GoPreviousStep";
            this.GoPreviousStep.Size = new System.Drawing.Size(163, 43);
            this.GoPreviousStep.StateCommon.Border.Rounding = 15F;
            this.GoPreviousStep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoPreviousStep.TabIndex = 14;
            this.GoPreviousStep.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.GoPreviousStep.Values.Text = "Geri al";
            this.GoPreviousStep.Click += new System.EventHandler(this.GoPreviousStep_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(93, 380);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(163, 43);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 12;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // EditedImage
            // 
            this.EditedImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditedImage.Location = new System.Drawing.Point(3, 39);
            this.EditedImage.Name = "EditedImage";
            this.EditedImage.Size = new System.Drawing.Size(300, 300);
            this.EditedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditedImage.TabIndex = 11;
            this.EditedImage.TabStop = false;
            // 
            // OriginalImage
            // 
            this.OriginalImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginalImage.Location = new System.Drawing.Point(3, 40);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(300, 300);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 10;
            this.OriginalImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(423, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 16;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(12, 11);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroup1.Panel.Controls.Add(this.OriginalImage);
            this.kryptonGroup1.Size = new System.Drawing.Size(324, 363);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 61;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(58, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(173, 31);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 13;
            this.kryptonLabel2.Values.Text = "Orijinal Görüntü";
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(342, 12);
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroup2.Panel.Controls.Add(this.EditedImage);
            this.kryptonGroup2.Size = new System.Drawing.Size(324, 363);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.LightSteelBlue;
            this.kryptonGroup2.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup2.TabIndex = 62;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(123, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(90, 31);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 12;
            this.kryptonLabel1.Values.Text = "Sonuç";
            // 
            // btn_RGBtoYUV
            // 
            this.btn_RGBtoYUV.Location = new System.Drawing.Point(672, 120);
            this.btn_RGBtoYUV.Name = "btn_RGBtoYUV";
            this.btn_RGBtoYUV.Size = new System.Drawing.Size(163, 43);
            this.btn_RGBtoYUV.StateCommon.Border.Rounding = 15F;
            this.btn_RGBtoYUV.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RGBtoYUV.TabIndex = 63;
            this.btn_RGBtoYUV.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_RGBtoYUV.Values.Text = "RGB → YUV";
            this.btn_RGBtoYUV.Click += new System.EventHandler(this.btn_RGBtoYUV_Click);
            // 
            // btn_RGBtoHSV
            // 
            this.btn_RGBtoHSV.Location = new System.Drawing.Point(672, 169);
            this.btn_RGBtoHSV.Name = "btn_RGBtoHSV";
            this.btn_RGBtoHSV.Size = new System.Drawing.Size(163, 43);
            this.btn_RGBtoHSV.StateCommon.Border.Rounding = 15F;
            this.btn_RGBtoHSV.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RGBtoHSV.TabIndex = 64;
            this.btn_RGBtoHSV.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_RGBtoHSV.Values.Text = "RGB → HSV";
            this.btn_RGBtoHSV.Click += new System.EventHandler(this.btn_RGBtoHSV_Click);
            // 
            // btn_YUVtoRGB
            // 
            this.btn_YUVtoRGB.Location = new System.Drawing.Point(672, 218);
            this.btn_YUVtoRGB.Name = "btn_YUVtoRGB";
            this.btn_YUVtoRGB.Size = new System.Drawing.Size(163, 43);
            this.btn_YUVtoRGB.StateCommon.Border.Rounding = 15F;
            this.btn_YUVtoRGB.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_YUVtoRGB.TabIndex = 65;
            this.btn_YUVtoRGB.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_YUVtoRGB.Values.Text = "YUV → RGB";
            this.btn_YUVtoRGB.Click += new System.EventHandler(this.btn_YUVtoRGB_Click);
            // 
            // btn_HSVtoRGB
            // 
            this.btn_HSVtoRGB.Location = new System.Drawing.Point(672, 267);
            this.btn_HSVtoRGB.Name = "btn_HSVtoRGB";
            this.btn_HSVtoRGB.Size = new System.Drawing.Size(163, 43);
            this.btn_HSVtoRGB.StateCommon.Border.Rounding = 15F;
            this.btn_HSVtoRGB.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HSVtoRGB.TabIndex = 66;
            this.btn_HSVtoRGB.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_HSVtoRGB.Values.Text = "HSV → RGB";
            this.btn_HSVtoRGB.Click += new System.EventHandler(this.btn_HSVtoRGB_Click);
            // 
            // Color_SpaceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 437);
            this.Controls.Add(this.btn_HSVtoRGB);
            this.Controls.Add(this.btn_YUVtoRGB);
            this.Controls.Add(this.btn_RGBtoHSV);
            this.Controls.Add(this.btn_RGBtoYUV);
            this.Controls.Add(this.kryptonGroup2);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GoPreviousStep);
            this.Controls.Add(this.OpenImage);
            this.Name = "Color_SpaceScreen";
            this.Text = "Renk Uzayları";
            this.Load += new System.EventHandler(this.Color_SpaceScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            this.kryptonGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton GoPreviousStep;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private System.Windows.Forms.PictureBox EditedImage;
        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private Krypton.Toolkit.KryptonButton btn_RGBtoYUV;
        private Krypton.Toolkit.KryptonButton btn_RGBtoHSV;
        private Krypton.Toolkit.KryptonButton btn_YUVtoRGB;
        private Krypton.Toolkit.KryptonButton btn_HSVtoRGB;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}