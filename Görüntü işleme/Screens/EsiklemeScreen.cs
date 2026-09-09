using System;
using System.Drawing;
using System.Windows.Forms;
using Görüntü_işleme.Functions;

namespace Görüntü_işleme.Screens
{
    public partial class EsiklemeScreen : Form
    {
        private Bitmap orijinalGoruntu = null;
        private Bitmap sonucGoruntu = null;

        private EsiklemeFunction esiklemeFunction = new EsiklemeFunction();

        public EsiklemeScreen()
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

                EditedImage.Image = null;
                sonucGoruntu = null;

                // Goruntu yuklenince hemen esikleme uygula
                //EsiklemeUygula();
            }
        }

        // -------------------------------------------------------
        // TrackBar degisince otomatik uygula
        // -------------------------------------------------------
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            EsiklemeUygula();
        }

        // -------------------------------------------------------
        // Esikleme islemini uygula
        // -------------------------------------------------------
        private void EsiklemeUygula()
        {
            if (orijinalGoruntu == null) return;

            int esikDegeri = TrackBar1.Value;

            sonucGoruntu = esiklemeFunction.TekEsikleme(orijinalGoruntu, esikDegeri);

            EditedImage.Image = sonucGoruntu;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // -------------------------------------------------------
        // Varsayilan — esik degerini 128 e sifirla
        // -------------------------------------------------------
        private void btnDefault_Click(object sender, EventArgs e)
        {
            TrackBar1.Value = 128;
            EsiklemeUygula();
        }

        // -------------------------------------------------------
        // Geri al
        // -------------------------------------------------------
        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (orijinalGoruntu == null) return;

            EditedImage.Image = orijinalGoruntu;
            sonucGoruntu = null;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
            TrackBar1.Value = 128;
        }

        // -------------------------------------------------------
        // Kaydet
        // -------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sonucGoruntu == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }

            SaveFileDialog kaydetPenceresi = new SaveFileDialog();
            kaydetPenceresi.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";

            if (kaydetPenceresi.ShowDialog() == DialogResult.OK)
            {
                sonucGoruntu.Save(kaydetPenceresi.FileName);
                MessageBox.Show("Goruntu basariyla kaydedildi.", "Bilgi");
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            EsiklemeUygula();
        }
    }
}