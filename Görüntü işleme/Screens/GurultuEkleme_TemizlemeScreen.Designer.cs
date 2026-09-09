namespace Görüntü_işleme.Screens
{
    partial class GurultuEkleme_TemizlemeScreen
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
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            this.NoisyImage = new System.Windows.Forms.PictureBox();
            this.btnBeforeMeanFiltre = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.OpenImage = new Krypton.Toolkit.KryptonButton();
            this.btnMeanFiltre = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.MedianFilteredImage = new System.Windows.Forms.PictureBox();
            this.kryptonGroup4 = new Krypton.Toolkit.KryptonGroup();
            this.MeanFilteredImage = new System.Windows.Forms.PictureBox();
            this.TrackBar1 = new Krypton.Toolkit.KryptonTrackBar();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.btnSaveMedianFiltreliImage = new Krypton.Toolkit.KryptonButton();
            this.btnBeforeMedainFiltre = new Krypton.Toolkit.KryptonButton();
            this.btnGurultuEkle = new Krypton.Toolkit.KryptonButton();
            this.btnBeforeGurultuEkleme = new Krypton.Toolkit.KryptonButton();
            this.btnSaveGurultuluImage = new Krypton.Toolkit.KryptonButton();
            this.btnSaveMeanFiltreliImage = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.Farkli_Gorsel_Mean = new Krypton.Toolkit.KryptonButton();
            this.Farkli_Gorsel_Median = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoisyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedianFilteredImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).BeginInit();
            this.kryptonGroup4.Panel.SuspendLayout();
            this.kryptonGroup4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeanFilteredImage)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(368, 29);
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.NoisyImage);
            this.kryptonGroup3.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonGroup3.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup3.TabIndex = 67;
            // 
            // NoisyImage
            // 
            this.NoisyImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoisyImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoisyImage.Location = new System.Drawing.Point(3, 3);
            this.NoisyImage.Name = "NoisyImage";
            this.NoisyImage.Size = new System.Drawing.Size(300, 300);
            this.NoisyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NoisyImage.TabIndex = 11;
            this.NoisyImage.TabStop = false;
            // 
            // btnBeforeMeanFiltre
            // 
            this.btnBeforeMeanFiltre.Location = new System.Drawing.Point(708, 408);
            this.btnBeforeMeanFiltre.Name = "btnBeforeMeanFiltre";
            this.btnBeforeMeanFiltre.Size = new System.Drawing.Size(144, 43);
            this.btnBeforeMeanFiltre.StateCommon.Border.Rounding = 15F;
            this.btnBeforeMeanFiltre.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeforeMeanFiltre.TabIndex = 60;
            this.btnBeforeMeanFiltre.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBeforeMeanFiltre.Values.Text = "Temizle";
            this.btnBeforeMeanFiltre.Click += new System.EventHandler(this.btnBeforeMeanFiltre_Click);
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(38, 29);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.OriginalImage);
            this.kryptonGroup1.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 66;
            // 
            // OriginalImage
            // 
            this.OriginalImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OriginalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginalImage.Location = new System.Drawing.Point(3, 3);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(300, 300);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalImage.TabIndex = 11;
            this.OriginalImage.TabStop = false;
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(175, 359);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(173, 43);
            this.OpenImage.StateCommon.Border.Rounding = 15F;
            this.OpenImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.TabIndex = 65;
            this.OpenImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.OpenImage.Values.Text = "Görüntü Aç";
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // btnMeanFiltre
            // 
            this.btnMeanFiltre.Location = new System.Drawing.Point(708, 359);
            this.btnMeanFiltre.Name = "btnMeanFiltre";
            this.btnMeanFiltre.Size = new System.Drawing.Size(300, 43);
            this.btnMeanFiltre.StateCommon.Border.Rounding = 15F;
            this.btnMeanFiltre.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeanFiltre.TabIndex = 66;
            this.btnMeanFiltre.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnMeanFiltre.Values.Text = "Mean ile Filtrele";
            this.btnMeanFiltre.Click += new System.EventHandler(this.btnMeanFiltre_Click);
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(1028, 29);
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.MedianFilteredImage);
            this.kryptonGroup2.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonGroup2.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup2.TabIndex = 69;
            // 
            // MedianFilteredImage
            // 
            this.MedianFilteredImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MedianFilteredImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MedianFilteredImage.Location = new System.Drawing.Point(3, 3);
            this.MedianFilteredImage.Name = "MedianFilteredImage";
            this.MedianFilteredImage.Size = new System.Drawing.Size(300, 300);
            this.MedianFilteredImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MedianFilteredImage.TabIndex = 11;
            this.MedianFilteredImage.TabStop = false;
            // 
            // kryptonGroup4
            // 
            this.kryptonGroup4.Location = new System.Drawing.Point(698, 29);
            // 
            // kryptonGroup4.Panel
            // 
            this.kryptonGroup4.Panel.Controls.Add(this.MeanFilteredImage);
            this.kryptonGroup4.Size = new System.Drawing.Size(324, 324);
            this.kryptonGroup4.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.kryptonGroup4.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup4.TabIndex = 70;
            // 
            // MeanFilteredImage
            // 
            this.MeanFilteredImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MeanFilteredImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MeanFilteredImage.Location = new System.Drawing.Point(3, 3);
            this.MeanFilteredImage.Name = "MeanFilteredImage";
            this.MeanFilteredImage.Size = new System.Drawing.Size(300, 300);
            this.MeanFilteredImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MeanFilteredImage.TabIndex = 11;
            this.MeanFilteredImage.TabStop = false;
            // 
            // TrackBar1
            // 
            this.TrackBar1.AutoSize = false;
            this.TrackBar1.Location = new System.Drawing.Point(12, 468);
            this.TrackBar1.Maximum = 100;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(666, 32);
            this.TrackBar1.TabIndex = 71;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 430);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(188, 32);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 72;
            this.kryptonLabel2.Values.Text = "Gürültü Oranı : ";
            // 
            // btnSaveMedianFiltreliImage
            // 
            this.btnSaveMedianFiltreliImage.Location = new System.Drawing.Point(1038, 359);
            this.btnSaveMedianFiltreliImage.Name = "btnSaveMedianFiltreliImage";
            this.btnSaveMedianFiltreliImage.Size = new System.Drawing.Size(300, 43);
            this.btnSaveMedianFiltreliImage.StateCommon.Border.Rounding = 15F;
            this.btnSaveMedianFiltreliImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMedianFiltreliImage.TabIndex = 74;
            this.btnSaveMedianFiltreliImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSaveMedianFiltreliImage.Values.Text = "Median ile Filtrele";
            this.btnSaveMedianFiltreliImage.Click += new System.EventHandler(this.btnMedianFiltre_Click);
            // 
            // btnBeforeMedainFiltre
            // 
            this.btnBeforeMedainFiltre.Location = new System.Drawing.Point(1038, 408);
            this.btnBeforeMedainFiltre.Name = "btnBeforeMedainFiltre";
            this.btnBeforeMedainFiltre.Size = new System.Drawing.Size(144, 43);
            this.btnBeforeMedainFiltre.StateCommon.Border.Rounding = 15F;
            this.btnBeforeMedainFiltre.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeforeMedainFiltre.TabIndex = 73;
            this.btnBeforeMedainFiltre.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBeforeMedainFiltre.Values.Text = "Temizle";
            this.btnBeforeMedainFiltre.Click += new System.EventHandler(this.btnBeforeMedainFiltre_Click);
            // 
            // btnGurultuEkle
            // 
            this.btnGurultuEkle.Location = new System.Drawing.Point(368, 359);
            this.btnGurultuEkle.Name = "btnGurultuEkle";
            this.btnGurultuEkle.Size = new System.Drawing.Size(310, 43);
            this.btnGurultuEkle.StateCommon.Border.Rounding = 15F;
            this.btnGurultuEkle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGurultuEkle.TabIndex = 76;
            this.btnGurultuEkle.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGurultuEkle.Values.Text = "Gürültü Ekle";
            this.btnGurultuEkle.Click += new System.EventHandler(this.btnGurultuEkle_Click);
            // 
            // btnBeforeGurultuEkleme
            // 
            this.btnBeforeGurultuEkleme.Location = new System.Drawing.Point(481, 408);
            this.btnBeforeGurultuEkleme.Name = "btnBeforeGurultuEkleme";
            this.btnBeforeGurultuEkleme.Size = new System.Drawing.Size(99, 43);
            this.btnBeforeGurultuEkleme.StateCommon.Border.Rounding = 15F;
            this.btnBeforeGurultuEkleme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeforeGurultuEkleme.TabIndex = 75;
            this.btnBeforeGurultuEkleme.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBeforeGurultuEkleme.Values.Text = "Geri Al";
            this.btnBeforeGurultuEkleme.Click += new System.EventHandler(this.btnBeforeGurultuEkleme_Click);
            // 
            // btnSaveGurultuluImage
            // 
            this.btnSaveGurultuluImage.Location = new System.Drawing.Point(586, 408);
            this.btnSaveGurultuluImage.Name = "btnSaveGurultuluImage";
            this.btnSaveGurultuluImage.Size = new System.Drawing.Size(92, 43);
            this.btnSaveGurultuluImage.StateCommon.Border.Rounding = 15F;
            this.btnSaveGurultuluImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGurultuluImage.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnSaveGurultuluImage.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnSaveGurultuluImage.TabIndex = 93;
            this.btnSaveGurultuluImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSaveGurultuluImage.Values.Text = "  🖨️";
            this.btnSaveGurultuluImage.Click += new System.EventHandler(this.btnSaveGurultuluImage_Click);
            // 
            // btnSaveMeanFiltreliImage
            // 
            this.btnSaveMeanFiltreliImage.Location = new System.Drawing.Point(864, 408);
            this.btnSaveMeanFiltreliImage.Name = "btnSaveMeanFiltreliImage";
            this.btnSaveMeanFiltreliImage.Size = new System.Drawing.Size(144, 43);
            this.btnSaveMeanFiltreliImage.StateCommon.Border.Rounding = 15F;
            this.btnSaveMeanFiltreliImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMeanFiltreliImage.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnSaveMeanFiltreliImage.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnSaveMeanFiltreliImage.TabIndex = 94;
            this.btnSaveMeanFiltreliImage.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSaveMeanFiltreliImage.Values.Text = "  🖨️";
            this.btnSaveMeanFiltreliImage.Click += new System.EventHandler(this.btnSaveMeanFiltreliImage_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(1194, 408);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(144, 43);
            this.kryptonButton2.StateCommon.Border.Rounding = 15F;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton2.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton2.TabIndex = 95;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Text = "  🖨️";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // Farkli_Gorsel_Mean
            // 
            this.Farkli_Gorsel_Mean.Location = new System.Drawing.Point(708, 457);
            this.Farkli_Gorsel_Mean.Name = "Farkli_Gorsel_Mean";
            this.Farkli_Gorsel_Mean.Size = new System.Drawing.Size(300, 43);
            this.Farkli_Gorsel_Mean.StateCommon.Border.Rounding = 15F;
            this.Farkli_Gorsel_Mean.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Farkli_Gorsel_Mean.TabIndex = 96;
            this.Farkli_Gorsel_Mean.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.Farkli_Gorsel_Mean.Values.Text = "Farklı Görüntü Aç";
            this.Farkli_Gorsel_Mean.Click += new System.EventHandler(this.Farkli_Gorsel_Mean_Click);
            // 
            // Farkli_Gorsel_Median
            // 
            this.Farkli_Gorsel_Median.Location = new System.Drawing.Point(1038, 457);
            this.Farkli_Gorsel_Median.Name = "Farkli_Gorsel_Median";
            this.Farkli_Gorsel_Median.Size = new System.Drawing.Size(300, 43);
            this.Farkli_Gorsel_Median.StateCommon.Border.Rounding = 15F;
            this.Farkli_Gorsel_Median.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Farkli_Gorsel_Median.TabIndex = 97;
            this.Farkli_Gorsel_Median.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.Farkli_Gorsel_Median.Values.Text = "Farklı Görüntü Aç";
            this.Farkli_Gorsel_Median.Click += new System.EventHandler(this.Farkli_Gorsel_Median_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(48, 359);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(121, 43);
            this.kryptonButton1.StateCommon.Border.Rounding = 15F;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 98;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Temizle";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(368, 408);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(107, 43);
            this.kryptonButton3.StateCommon.Border.Rounding = 15F;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 99;
            this.kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton3.Values.Text = "Temizle";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // GurultuEkleme_TemizlemeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 522);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Farkli_Gorsel_Median);
            this.Controls.Add(this.Farkli_Gorsel_Mean);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.btnSaveMeanFiltreliImage);
            this.Controls.Add(this.btnSaveGurultuluImage);
            this.Controls.Add(this.btnGurultuEkle);
            this.Controls.Add(this.btnBeforeGurultuEkleme);
            this.Controls.Add(this.btnSaveMedianFiltreliImage);
            this.Controls.Add(this.btnBeforeMedainFiltre);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.kryptonGroup4);
            this.Controls.Add(this.kryptonGroup2);
            this.Controls.Add(this.btnMeanFiltre);
            this.Controls.Add(this.kryptonGroup3);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.OpenImage);
            this.Controls.Add(this.btnBeforeMeanFiltre);
            this.Name = "GurultuEkleme_TemizlemeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntüye Gürültü Ekleme - Temizleme";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NoisyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedianFilteredImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4.Panel)).EndInit();
            this.kryptonGroup4.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup4)).EndInit();
            this.kryptonGroup4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MeanFilteredImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private System.Windows.Forms.PictureBox NoisyImage;
        private Krypton.Toolkit.KryptonButton btnBeforeMeanFiltre;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private System.Windows.Forms.PictureBox OriginalImage;
        private Krypton.Toolkit.KryptonButton OpenImage;
        private Krypton.Toolkit.KryptonButton btnMeanFiltre;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private System.Windows.Forms.PictureBox MedianFilteredImage;
        private Krypton.Toolkit.KryptonGroup kryptonGroup4;
        private System.Windows.Forms.PictureBox MeanFilteredImage;
        private Krypton.Toolkit.KryptonTrackBar TrackBar1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnSaveMedianFiltreliImage;
        private Krypton.Toolkit.KryptonButton btnBeforeMedainFiltre;
        private Krypton.Toolkit.KryptonButton btnGurultuEkle;
        private Krypton.Toolkit.KryptonButton btnBeforeGurultuEkleme;
        private Krypton.Toolkit.KryptonButton btnSaveGurultuluImage;
        private Krypton.Toolkit.KryptonButton btnSaveMeanFiltreliImage;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton Farkli_Gorsel_Mean;
        private Krypton.Toolkit.KryptonButton Farkli_Gorsel_Median;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}