namespace Görüntü_işleme
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKovolusyonİslemler = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.btnColor_Space = new Krypton.Toolkit.KryptonButton();
            this.btnTo_Gray = new Krypton.Toolkit.KryptonButton();
            this.btnZoom_In_Out = new Krypton.Toolkit.KryptonButton();
            this.btnEsikİslemler = new Krypton.Toolkit.KryptonButton();
            this.btnFiltreUygulamasi = new Krypton.Toolkit.KryptonButton();
            this.btnRotate = new Krypton.Toolkit.KryptonButton();
            this.btnCrop = new Krypton.Toolkit.KryptonButton();
            this.btnContrastEnhancement = new Krypton.Toolkit.KryptonButton();
            this.btnKenarBulma = new Krypton.Toolkit.KryptonButton();
            this.btnHistogram = new Krypton.Toolkit.KryptonButton();
            this.btnGurultuEklemeTemizleme = new Krypton.Toolkit.KryptonButton();
            this.btnBinary = new Krypton.Toolkit.KryptonButton();
            this.btnAritmetikİslemler = new Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(75)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.btnKovolusyonİslemler);
            this.panel1.Controls.Add(this.kryptonButton2);
            this.panel1.Controls.Add(this.btnZoom_In_Out);
            this.panel1.Controls.Add(this.btnColor_Space);
            this.panel1.Controls.Add(this.btnTo_Gray);
            this.panel1.Controls.Add(this.btnEsikİslemler);
            this.panel1.Controls.Add(this.btnFiltreUygulamasi);
            this.panel1.Controls.Add(this.btnRotate);
            this.panel1.Controls.Add(this.btnCrop);
            this.panel1.Controls.Add(this.btnContrastEnhancement);
            this.panel1.Controls.Add(this.btnKenarBulma);
            this.panel1.Controls.Add(this.btnHistogram);
            this.panel1.Controls.Add(this.btnGurultuEklemeTemizleme);
            this.panel1.Controls.Add(this.btnBinary);
            this.panel1.Controls.Add(this.btnAritmetikİslemler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 767);
            this.panel1.TabIndex = 0;
            // 
            // btnKovolusyonİslemler
            // 
            this.btnKovolusyonİslemler.Location = new System.Drawing.Point(12, 462);
            this.btnKovolusyonİslemler.Name = "btnKovolusyonİslemler";
            this.btnKovolusyonİslemler.Size = new System.Drawing.Size(348, 39);
            this.btnKovolusyonİslemler.StateCommon.Border.Rounding = 15F;
            this.btnKovolusyonİslemler.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKovolusyonİslemler.TabIndex = 11;
            this.btnKovolusyonİslemler.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnKovolusyonİslemler.Values.Text = "Konvolüsyon İşlemi";
            this.btnKovolusyonİslemler.Click += new System.EventHandler(this.btnKovolusyonİslemler_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(12, 12);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(348, 39);
            this.kryptonButton2.StateCommon.Border.Rounding = 15F;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 16;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Text = "Morfolojik İşlemler";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // btnColor_Space
            // 
            this.btnColor_Space.Location = new System.Drawing.Point(12, 642);
            this.btnColor_Space.Name = "btnColor_Space";
            this.btnColor_Space.Size = new System.Drawing.Size(348, 39);
            this.btnColor_Space.StateCommon.Border.Rounding = 15F;
            this.btnColor_Space.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor_Space.TabIndex = 6;
            this.btnColor_Space.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnColor_Space.Values.Text = "Renk Uzayı Dönüşümleri";
            this.btnColor_Space.Click += new System.EventHandler(this.btnColor_Space_Click);
            // 
            // btnTo_Gray
            // 
            this.btnTo_Gray.Location = new System.Drawing.Point(12, 282);
            this.btnTo_Gray.Name = "btnTo_Gray";
            this.btnTo_Gray.Size = new System.Drawing.Size(348, 39);
            this.btnTo_Gray.StateCommon.Border.Rounding = 15F;
            this.btnTo_Gray.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTo_Gray.TabIndex = 1;
            this.btnTo_Gray.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnTo_Gray.Values.Text = "Gri Dönüşüm";
            this.btnTo_Gray.Click += new System.EventHandler(this.btnTo_Gray_Click);
            // 
            // btnZoom_In_Out
            // 
            this.btnZoom_In_Out.Location = new System.Drawing.Point(12, 507);
            this.btnZoom_In_Out.Name = "btnZoom_In_Out";
            this.btnZoom_In_Out.Size = new System.Drawing.Size(348, 39);
            this.btnZoom_In_Out.StateCommon.Border.Rounding = 15F;
            this.btnZoom_In_Out.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom_In_Out.TabIndex = 5;
            this.btnZoom_In_Out.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnZoom_In_Out.Values.Text = "Görüntü Yaklaştırma/Uzaklaştırma";
            this.btnZoom_In_Out.Click += new System.EventHandler(this.btnZoom_In_Out_Click);
            // 
            // btnEsikİslemler
            // 
            this.btnEsikİslemler.Location = new System.Drawing.Point(12, 417);
            this.btnEsikİslemler.Name = "btnEsikİslemler";
            this.btnEsikİslemler.Size = new System.Drawing.Size(348, 39);
            this.btnEsikİslemler.StateCommon.Border.Rounding = 15F;
            this.btnEsikİslemler.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsikİslemler.TabIndex = 12;
            this.btnEsikİslemler.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEsikİslemler.Values.Text = "Eşikleme İşlemleri";
            this.btnEsikİslemler.Click += new System.EventHandler(this.btnEsikİslemler_Click);
            // 
            // btnFiltreUygulamasi
            // 
            this.btnFiltreUygulamasi.Location = new System.Drawing.Point(12, 597);
            this.btnFiltreUygulamasi.Name = "btnFiltreUygulamasi";
            this.btnFiltreUygulamasi.Size = new System.Drawing.Size(348, 39);
            this.btnFiltreUygulamasi.StateCommon.Border.Rounding = 15F;
            this.btnFiltreUygulamasi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltreUygulamasi.TabIndex = 15;
            this.btnFiltreUygulamasi.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnFiltreUygulamasi.Values.Text = "Filtre Uygulaması";
            this.btnFiltreUygulamasi.Click += new System.EventHandler(this.btnFiltreUygulamasi_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(12, 192);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(348, 39);
            this.btnRotate.StateCommon.Border.Rounding = 15F;
            this.btnRotate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.TabIndex = 3;
            this.btnRotate.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRotate.Values.Text = "Görüntü Döndürme";
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(12, 147);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(348, 39);
            this.btnCrop.StateCommon.Border.Rounding = 15F;
            this.btnCrop.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrop.TabIndex = 2;
            this.btnCrop.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCrop.Values.Text = "Görüntü Kırpma";
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnContrastEnhancement
            // 
            this.btnContrastEnhancement.Location = new System.Drawing.Point(12, 372);
            this.btnContrastEnhancement.Name = "btnContrastEnhancement";
            this.btnContrastEnhancement.Size = new System.Drawing.Size(348, 39);
            this.btnContrastEnhancement.StateCommon.Border.Rounding = 15F;
            this.btnContrastEnhancement.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContrastEnhancement.TabIndex = 8;
            this.btnContrastEnhancement.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnContrastEnhancement.Values.Text = "Kontrast Artırma";
            this.btnContrastEnhancement.Click += new System.EventHandler(this.btnContrastEnhancement_Click);
            // 
            // btnKenarBulma
            // 
            this.btnKenarBulma.Location = new System.Drawing.Point(12, 552);
            this.btnKenarBulma.Name = "btnKenarBulma";
            this.btnKenarBulma.Size = new System.Drawing.Size(348, 39);
            this.btnKenarBulma.StateCommon.Border.Rounding = 15F;
            this.btnKenarBulma.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKenarBulma.TabIndex = 13;
            this.btnKenarBulma.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnKenarBulma.Values.Text = "Kenar Bulma";
            this.btnKenarBulma.Click += new System.EventHandler(this.btnKenarBulma_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(12, 237);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(348, 39);
            this.btnHistogram.StateCommon.Border.Rounding = 15F;
            this.btnHistogram.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistogram.TabIndex = 9;
            this.btnHistogram.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnHistogram.Values.Text = "Histogram İşlemleri";
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // btnGurultuEklemeTemizleme
            // 
            this.btnGurultuEklemeTemizleme.Location = new System.Drawing.Point(12, 57);
            this.btnGurultuEklemeTemizleme.Name = "btnGurultuEklemeTemizleme";
            this.btnGurultuEklemeTemizleme.Size = new System.Drawing.Size(348, 39);
            this.btnGurultuEklemeTemizleme.StateCommon.Border.Rounding = 15F;
            this.btnGurultuEklemeTemizleme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGurultuEklemeTemizleme.TabIndex = 14;
            this.btnGurultuEklemeTemizleme.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGurultuEklemeTemizleme.Values.Text = "Gürültü Ekleme - Temizleme";
            this.btnGurultuEklemeTemizleme.Click += new System.EventHandler(this.btnGurultuEklemeTemizleme_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(12, 327);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(348, 39);
            this.btnBinary.StateCommon.Border.Rounding = 15F;
            this.btnBinary.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinary.TabIndex = 4;
            this.btnBinary.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBinary.Values.Text = "Binary Dönüşüm";
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnAritmetikİslemler
            // 
            this.btnAritmetikİslemler.Location = new System.Drawing.Point(12, 102);
            this.btnAritmetikİslemler.Name = "btnAritmetikİslemler";
            this.btnAritmetikİslemler.Size = new System.Drawing.Size(348, 39);
            this.btnAritmetikİslemler.StateCommon.Border.Rounding = 15F;
            this.btnAritmetikİslemler.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAritmetikİslemler.TabIndex = 10;
            this.btnAritmetikİslemler.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAritmetikİslemler.Values.Text = "Aritmetik İşlemler";
            this.btnAritmetikİslemler.Click += new System.EventHandler(this.btnAritmetikİslemler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 767);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü İşleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnColor_Space;
        private Krypton.Toolkit.KryptonButton btnZoom_In_Out;
        private Krypton.Toolkit.KryptonButton btnBinary;
        private Krypton.Toolkit.KryptonButton btnRotate;
        private Krypton.Toolkit.KryptonButton btnCrop;
        private Krypton.Toolkit.KryptonButton btnTo_Gray;
        private Krypton.Toolkit.KryptonButton btnContrastEnhancement;
        private Krypton.Toolkit.KryptonButton btnHistogram;
        private Krypton.Toolkit.KryptonButton btnKovolusyonİslemler;
        private Krypton.Toolkit.KryptonButton btnAritmetikİslemler;
        private Krypton.Toolkit.KryptonButton btnGurultuEklemeTemizleme;
        private Krypton.Toolkit.KryptonButton btnKenarBulma;
        private Krypton.Toolkit.KryptonButton btnEsikİslemler;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton btnFiltreUygulamasi;
    }
}

