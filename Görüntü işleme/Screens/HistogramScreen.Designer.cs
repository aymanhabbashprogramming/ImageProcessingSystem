namespace Görüntü_işleme.Screens
{
    partial class HistogramScreen
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
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnPerform = new Krypton.Toolkit.KryptonButton();
            this.GoPreviousStep = new Krypton.Toolkit.KryptonButton();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.OriginalImageHistogram = new System.Windows.Forms.PictureBox();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.stretchingImage = new System.Windows.Forms.PictureBox();
            this.stretchingImageHistogram = new System.Windows.Forms.PictureBox();
            this.genisletmeImage = new System.Windows.Forms.PictureBox();
            this.genisletmeImageHistogram = new System.Windows.Forms.PictureBox();
            this.btnGensiletme = new Krypton.Toolkit.KryptonButton();
            this.btnSave_Genisletme = new Krypton.Toolkit.KryptonButton();
            this.GoPreviousStep2 = new Krypton.Toolkit.KryptonButton();
            this.txtB = new Krypton.Toolkit.KryptonTextBox();
            this.txtA = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stretchingImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stretchingImageHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genisletmeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genisletmeImageHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(922, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 43);
            this.btnSave.StateCommon.Border.Rounding = 15F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 36;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(922, 425);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(117, 43);
            this.btnPerform.StateCommon.Border.Rounding = 15F;
            this.btnPerform.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.TabIndex = 35;
            this.btnPerform.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnPerform.Values.Text = "Uygula";
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // GoPreviousStep
            // 
            this.GoPreviousStep.Location = new System.Drawing.Point(1045, 425);
            this.GoPreviousStep.Name = "GoPreviousStep";
            this.GoPreviousStep.Size = new System.Drawing.Size(117, 43);
            this.GoPreviousStep.StateCommon.Border.Rounding = 15F;
            this.GoPreviousStep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoPreviousStep.TabIndex = 34;
            this.GoPreviousStep.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.GoPreviousStep.Values.Text = "Geri al";
            this.GoPreviousStep.Click += new System.EventHandler(this.GoPreviousStep_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(61, 260);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(148, 42);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 33;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // OriginalImageHistogram
            // 
            this.OriginalImageHistogram.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImageHistogram.Location = new System.Drawing.Point(305, 12);
            this.OriginalImageHistogram.Name = "OriginalImageHistogram";
            this.OriginalImageHistogram.Size = new System.Drawing.Size(606, 242);
            this.OriginalImageHistogram.TabIndex = 32;
            this.OriginalImageHistogram.TabStop = false;
            // 
            // OriginalImage
            // 
            this.OriginalImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginalImage.Location = new System.Drawing.Point(12, 12);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(247, 242);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginalImage.TabIndex = 31;
            this.OriginalImage.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(488, 260);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(280, 32);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 44;
            this.kryptonLabel2.Values.Text = "Orijinal Görüntü histogramı\r\n";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(917, 579);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(248, 31);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 43;
            this.kryptonLabel1.Values.Text = "Genişletme - Histogramı";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = false;
            this.kryptonLabel3.Location = new System.Drawing.Point(917, 326);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(245, 32);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 44;
            this.kryptonLabel3.Values.Text = "Germe - Histogramı";
            // 
            // stretchingImage
            // 
            this.stretchingImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stretchingImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stretchingImage.Location = new System.Drawing.Point(12, 310);
            this.stretchingImage.Name = "stretchingImage";
            this.stretchingImage.Size = new System.Drawing.Size(247, 242);
            this.stretchingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stretchingImage.TabIndex = 31;
            this.stretchingImage.TabStop = false;
            // 
            // stretchingImageHistogram
            // 
            this.stretchingImageHistogram.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stretchingImageHistogram.Location = new System.Drawing.Point(305, 311);
            this.stretchingImageHistogram.Name = "stretchingImageHistogram";
            this.stretchingImageHistogram.Size = new System.Drawing.Size(606, 242);
            this.stretchingImageHistogram.TabIndex = 32;
            this.stretchingImageHistogram.TabStop = false;
            // 
            // genisletmeImage
            // 
            this.genisletmeImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.genisletmeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.genisletmeImage.Location = new System.Drawing.Point(12, 575);
            this.genisletmeImage.Name = "genisletmeImage";
            this.genisletmeImage.Size = new System.Drawing.Size(247, 242);
            this.genisletmeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.genisletmeImage.TabIndex = 46;
            this.genisletmeImage.TabStop = false;
            // 
            // genisletmeImageHistogram
            // 
            this.genisletmeImageHistogram.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.genisletmeImageHistogram.Location = new System.Drawing.Point(305, 576);
            this.genisletmeImageHistogram.Name = "genisletmeImageHistogram";
            this.genisletmeImageHistogram.Size = new System.Drawing.Size(606, 242);
            this.genisletmeImageHistogram.TabIndex = 47;
            this.genisletmeImageHistogram.TabStop = false;
            // 
            // btnGensiletme
            // 
            this.btnGensiletme.Location = new System.Drawing.Point(922, 633);
            this.btnGensiletme.Name = "btnGensiletme";
            this.btnGensiletme.Size = new System.Drawing.Size(117, 43);
            this.btnGensiletme.StateCommon.Border.Rounding = 15F;
            this.btnGensiletme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGensiletme.TabIndex = 49;
            this.btnGensiletme.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGensiletme.Values.Text = "Uygula";
            this.btnGensiletme.Click += new System.EventHandler(this.btnGensiletme_Click);
            // 
            // btnSave_Genisletme
            // 
            this.btnSave_Genisletme.Location = new System.Drawing.Point(922, 682);
            this.btnSave_Genisletme.Name = "btnSave_Genisletme";
            this.btnSave_Genisletme.Size = new System.Drawing.Size(240, 43);
            this.btnSave_Genisletme.StateCommon.Border.Rounding = 15F;
            this.btnSave_Genisletme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Genisletme.TabIndex = 50;
            this.btnSave_Genisletme.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave_Genisletme.Values.Text = "Kaydet";
            this.btnSave_Genisletme.Click += new System.EventHandler(this.btnSave_Genisletme_Click);
            // 
            // GoPreviousStep2
            // 
            this.GoPreviousStep2.Location = new System.Drawing.Point(1045, 633);
            this.GoPreviousStep2.Name = "GoPreviousStep2";
            this.GoPreviousStep2.Size = new System.Drawing.Size(117, 43);
            this.GoPreviousStep2.StateCommon.Border.Rounding = 15F;
            this.GoPreviousStep2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoPreviousStep2.TabIndex = 48;
            this.GoPreviousStep2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.GoPreviousStep2.Values.Text = "Geri al";
            this.GoPreviousStep2.Click += new System.EventHandler(this.GoPreviousStep2_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(1062, 768);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 37);
            this.txtB.StateCommon.Border.Rounding = 15F;
            this.txtB.TabIndex = 53;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(922, 768);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 37);
            this.txtA.StateCommon.Border.Rounding = 15F;
            this.txtA.TabIndex = 54;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.AutoSize = false;
            this.kryptonLabel4.Location = new System.Drawing.Point(922, 731);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(100, 31);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 55;
            this.kryptonLabel4.Values.Text = "Min";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.AutoSize = false;
            this.kryptonLabel5.Location = new System.Drawing.Point(1062, 731);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(100, 31);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 56;
            this.kryptonLabel5.Values.Text = "Max";
            // 
            // HistogramScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 863);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.btnGensiletme);
            this.Controls.Add(this.btnSave_Genisletme);
            this.Controls.Add(this.GoPreviousStep2);
            this.Controls.Add(this.genisletmeImage);
            this.Controls.Add(this.genisletmeImageHistogram);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.stretchingImage);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.stretchingImageHistogram);
            this.Controls.Add(this.OpenImage);
            this.Controls.Add(this.OriginalImage);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.OriginalImageHistogram);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GoPreviousStep);
            this.Name = "HistogramScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stretchingImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stretchingImageHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genisletmeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genisletmeImageHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnPerform;
        private Krypton.Toolkit.KryptonButton GoPreviousStep;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private System.Windows.Forms.PictureBox OriginalImageHistogram;
        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.PictureBox stretchingImage;
        private System.Windows.Forms.PictureBox stretchingImageHistogram;
        private System.Windows.Forms.PictureBox genisletmeImage;
        private System.Windows.Forms.PictureBox genisletmeImageHistogram;
        private Krypton.Toolkit.KryptonButton btnGensiletme;
        private Krypton.Toolkit.KryptonButton btnSave_Genisletme;
        private Krypton.Toolkit.KryptonButton GoPreviousStep2;
        private Krypton.Toolkit.KryptonTextBox txtB;
        private Krypton.Toolkit.KryptonTextBox txtA;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}