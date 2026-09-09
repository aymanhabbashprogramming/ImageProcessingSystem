using Görüntü_işleme.Functions;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Görüntü_işleme.Screens
{
    public partial class FiltreUygulanması_UnsharpScreen : Form
    {
        private Bitmap orijinalGoruntu = null;
        private Bitmap sonucGoruntu = null;

        private FiltreUygulanmasi_UnsharpFunction unsharpFunction = new FiltreUygulanmasi_UnsharpFunction();

        public FiltreUygulanması_UnsharpScreen()
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
            }
        }

        // -------------------------------------------------------
        // Unsharp uygula
        // -------------------------------------------------------
        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            int miktar = TrackBar1.Value;

            sonucGoruntu = unsharpFunction.UnsharpUygula(orijinalGoruntu, miktar);
            EditedImage.Image = sonucGoruntu;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // -------------------------------------------------------
        // Geri al
        // -------------------------------------------------------
        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (orijinalGoruntu == null) return;

            sonucGoruntu = null;
            EditedImage.Image = orijinalGoruntu;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
            TrackBar1.Value = 1;
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
    }
}