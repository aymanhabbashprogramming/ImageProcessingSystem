using System;
using System.Drawing;
using System.Windows.Forms;
using Görüntü_işleme.Functions;

namespace Görüntü_işleme.Screens
{
    public partial class HistogramScreen : Form
    {
        private Bitmap orijinalGoruntu = null;
        private Bitmap sonucGerme = null;
        private Bitmap sonucGenisletme = null;

        private histogram_germe_genisletmeFunction histogramFunction =
            new histogram_germe_genisletmeFunction();

        public HistogramScreen()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------
        // Goruntu ac
        // -------------------------------------------------------
        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Resim Dosyalari|*.jpg;*.jpeg;*.png;*.bmp";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                orijinalGoruntu = new Bitmap(dosyaSecici.FileName);

                OriginalImage.Image = orijinalGoruntu;
                OriginalImage.SizeMode = PictureBoxSizeMode.Zoom;

                // ✅ Griye donustur ve goster
                Bitmap griyeGoruntu = new Bitmap(orijinalGoruntu.Width, orijinalGoruntu.Height);
                for (int y = 0; y < orijinalGoruntu.Height; y++)
                    for (int x = 0; x < orijinalGoruntu.Width; x++)
                    {
                        Color piksel = orijinalGoruntu.GetPixel(x, y);
                        int griDeger = (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);
                        griyeGoruntu.SetPixel(x, y, Color.FromArgb(griDeger, griDeger, griDeger));
                    }
           

                int[] orijinalHistogram = histogramFunction.HistogramHesapla(orijinalGoruntu);
                OriginalImageHistogram.Image = HistogramCiz(
                    orijinalHistogram,
                    OriginalImageHistogram.Width,
                    OriginalImageHistogram.Height
                );
                OriginalImageHistogram.SizeMode = PictureBoxSizeMode.StretchImage;

                stretchingImage.Image = null;
                stretchingImageHistogram.Image = null;
                sonucGerme = null;

                genisletmeImage.Image = null;
                genisletmeImageHistogram.Image = null;
                sonucGenisletme = null;
            }
        }
        // -------------------------------------------------------
        // GERME — 0 ile 255 arasina ger
        // -------------------------------------------------------
        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            int[] orijinalHistogram;
            int[] gerilmisHistogram;

            sonucGerme = histogramFunction.HistogramGerme(
                orijinalGoruntu,
                out orijinalHistogram,
                out gerilmisHistogram
            );

            stretchingImage.Image = sonucGerme;
            stretchingImage.SizeMode = PictureBoxSizeMode.Zoom;

            stretchingImageHistogram.Image = HistogramCiz(
                gerilmisHistogram,
                stretchingImageHistogram.Width,
                stretchingImageHistogram.Height
            );
            stretchingImageHistogram.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // -------------------------------------------------------
        // GENİŞLETME — a ile b arasina genislet
        // -------------------------------------------------------
        private void btnGensiletme_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            int a, b;
            if (!int.TryParse(txtA.Text, out a) || !int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Lutfen gecerli Min ve Max degerleri giriniz.", "Hata");
                return;
            }

            if (a < 0 || b > 255 || a >= b)
            {
                MessageBox.Show("A ve B degerleri: 0 <= Min < Max <= 255 olmali.", "Hata");
                return;
            }

            int[] orijinalHistogram;
            int[] genisletilmisHistogram;

            sonucGenisletme = histogramFunction.HistogramGenisletme(
                orijinalGoruntu,
                a, b,
                out orijinalHistogram,
                out genisletilmisHistogram
            );

            // ⚠️ genisletmeImage ve genisletmeImageHistogram -> kendi kontrollerinle eslestir
            genisletmeImage.Image = sonucGenisletme;
            genisletmeImage.SizeMode = PictureBoxSizeMode.Zoom;

            genisletmeImageHistogram.Image = HistogramCiz(
                genisletilmisHistogram,
                genisletmeImageHistogram.Width,
                genisletmeImageHistogram.Height
            );
            genisletmeImageHistogram.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // -------------------------------------------------------
        // Germe - Geri al
        // -------------------------------------------------------
        private void GoPreviousStep_Click(object sender, EventArgs e)
        {
            stretchingImage.Image = null;
            stretchingImageHistogram.Image = null;
            sonucGerme = null;
        }

        // -------------------------------------------------------
        // Genisletme - Geri al
        // -------------------------------------------------------
        private void GoPreviousStep2_Click(object sender, EventArgs e)
        {
            // ⚠️ genisletmeImage -> kendi kontrollerinle eslestir
            genisletmeImage.Image = null;
            genisletmeImageHistogram.Image = null;
            sonucGenisletme = null;
        }

        // -------------------------------------------------------
        // Germe - Kaydet
        // -------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sonucGerme == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sonucGerme.Save(sfd.FileName);
                MessageBox.Show("Goruntu basariyla kaydedildi.", "Bilgi");
            }
        }

        // -------------------------------------------------------
        // Genisletme - Kaydet
        // -------------------------------------------------------
        private void btnSave_Genisletme_Click(object sender, EventArgs e)
        {
            if (sonucGenisletme == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sonucGenisletme.Save(sfd.FileName);
                MessageBox.Show("Goruntu basariyla kaydedildi.", "Bilgi");
            }
        }

        // -------------------------------------------------------
        // Histogram cizim fonksiyonu
        // -------------------------------------------------------
        private Bitmap HistogramCiz(int[] histogram, int genislik, int yukseklik)
        {
            Bitmap grafik = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
                for (int x = 0; x < genislik; x++)
                    grafik.SetPixel(x, y, Color.White);

            int enYuksek = 0;
            for (int i = 0; i < 256; i++)
                if (histogram[i] > enYuksek)
                    enYuksek = histogram[i];

            if (enYuksek == 0) return grafik;

            for (int i = 0; i < 256; i++)
            {
                int sutunYuksekligi = histogram[i] * (yukseklik - 2) / enYuksek;
                int xKonum = i * (genislik - 1) / 255;

                for (int y = 0; y < sutunYuksekligi; y++)
                    if (xKonum >= 0 && xKonum < genislik)
                        grafik.SetPixel(xKonum, yukseklik - 1 - y, Color.Black);
            }

            return grafik;
        }
    }
}