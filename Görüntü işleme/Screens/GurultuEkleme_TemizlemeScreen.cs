using System;
using System.Drawing;
using System.Windows.Forms;
using Görüntü_işleme.Functions;

namespace Görüntü_işleme.Screens
{
    public partial class GurultuEkleme_TemizlemeScreen : Form
    {
        private Bitmap orijinalGoruntu = null;
        private Bitmap gurultuluGoruntu = null;
        private Bitmap meanSonucu = null;
        private Bitmap medianSonucu = null;

        // ✅ Mean ve Median icin ayri acilan gorseller
        private Bitmap farkliGorselMean = null;
        private Bitmap farkliGorselMedian = null;

        private GurultuEkleme_TemizlemeFunction gurultuFunction =
            new GurultuEkleme_TemizlemeFunction();

        public GurultuEkleme_TemizlemeScreen()
        {
            InitializeComponent();
        }
        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Resim Dosyalari|*.jpg;*.jpeg;*.png;*.bmp";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                orijinalGoruntu = new Bitmap(dosyaSecici.FileName);
                OriginalImage.Image = orijinalGoruntu;
                OriginalImage.SizeMode = PictureBoxSizeMode.Zoom;

                // Her seyi sifirla
                NoisyImage.Image = null;
                MeanFilteredImage.Image = null;
                MedianFilteredImage.Image = null;

                gurultuluGoruntu = null;
                meanSonucu = null;
                medianSonucu = null;
                farkliGorselMean = null;
                farkliGorselMedian = null;

                TrackBar1.Value = 0;
            }
        }
        private void btnGurultuEkle_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            double gurultuOrani = TrackBar1.Value / 100.0;

            gurultuluGoruntu = gurultuFunction.SaltPepperEkle(orijinalGoruntu, gurultuOrani);
            NoisyImage.Image = gurultuluGoruntu;
            NoisyImage.SizeMode = PictureBoxSizeMode.Zoom;

            // Gurultu degisince filtreleme sonuclari sifirlansin
            MeanFilteredImage.Image = null;
            MedianFilteredImage.Image = null;
            meanSonucu = null;
            medianSonucu = null;
            farkliGorselMean = null;
            farkliGorselMedian = null;
        }
        private void Farkli_Gorsel_Mean_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Resim Dosyalari|*.jpg;*.jpeg;*.png;*.bmp";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                farkliGorselMean = new Bitmap(dosyaSecici.FileName);
                meanSonucu = null;

                MeanFilteredImage.Image = farkliGorselMean;
                MeanFilteredImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void Farkli_Gorsel_Median_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Resim Dosyalari|*.jpg;*.jpeg;*.png;*.bmp";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                farkliGorselMedian = new Bitmap(dosyaSecici.FileName);
                medianSonucu = null;

                MedianFilteredImage.Image = farkliGorselMedian;
                MedianFilteredImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void btnMeanFiltre_Click(object sender, EventArgs e)
        {
            Bitmap kaynak = MeanKaynakBelirle();

            if (kaynak == null )
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            meanSonucu = gurultuFunction.MeanFiltrele(kaynak, 3);
            MeanFilteredImage.Image = meanSonucu;
            MeanFilteredImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btnMedianFiltre_Click(object sender, EventArgs e)
        {
            Bitmap kaynak = MedianKaynakBelirle();

            if (kaynak == null)
            { 
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            medianSonucu = gurultuFunction.MedianFiltrele(kaynak, 3);
            MedianFilteredImage.Image = medianSonucu;
            MedianFilteredImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btnBeforeGurultuEkleme_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null) return;

            gurultuluGoruntu = null;
            NoisyImage.Image = orijinalGoruntu;
            NoisyImage.SizeMode = PictureBoxSizeMode.Zoom;

            MeanFilteredImage.Image = null;
            MedianFilteredImage.Image = null;
            meanSonucu = null;
            medianSonucu = null;
            farkliGorselMean = null;
            farkliGorselMedian = null;
            TrackBar1.Value = 0;
        }
        private void btnBeforeMeanFiltre_Click(object sender, EventArgs e)
        {
            
            MeanFilteredImage.Image = null;
          
        }
        private void btnBeforeMedainFiltre_Click(object sender, EventArgs e)
        {
           
            MedianFilteredImage.Image = null;
        }
        private void btnSaveGurultuluImage_Click(object sender, EventArgs e)
        {
            if (gurultuluGoruntu == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }
            KaydetDialog(gurultuluGoruntu);
        }
        private void btnSaveMeanFiltreliImage_Click(object sender, EventArgs e)
        {
            if (meanSonucu == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }
            KaydetDialog(meanSonucu);
        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (medianSonucu == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }
            KaydetDialog(medianSonucu);
        }
        private Bitmap MeanKaynakBelirle()
        {
            if (farkliGorselMean != null) return farkliGorselMean;
            if (gurultuluGoruntu != null) return gurultuluGoruntu;
            if (orijinalGoruntu != null) return orijinalGoruntu;
            return null;
        }
        private Bitmap MedianKaynakBelirle()
        {
            if (farkliGorselMedian != null) return farkliGorselMedian;
            if (gurultuluGoruntu != null) return gurultuluGoruntu;
            if (orijinalGoruntu != null) return orijinalGoruntu;
            return null;
        }
        private void KaydetDialog(Bitmap goruntu)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                goruntu.Save(sfd.FileName);
                MessageBox.Show("Goruntu basariyla kaydedildi.", "Bilgi");
            }
        }
        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            NoisyImage.Image = null;
            gurultuluGoruntu = null;
            meanSonucu = null;
            medianSonucu = null;
            farkliGorselMean = null;
            farkliGorselMedian = null;
            MeanFilteredImage.Image = null;
            MedianFilteredImage.Image = null;
            TrackBar1.Value = 0;
        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            OriginalImage.Image = null;
            orijinalGoruntu = null;
            gurultuluGoruntu = null;
            NoisyImage.Image = null;
            meanSonucu = null;
            medianSonucu = null;
            farkliGorselMean = null;
            farkliGorselMedian = null;
            MeanFilteredImage.Image = null;
            MedianFilteredImage.Image = null;
            TrackBar1.Value = 0;
        }
    }
}