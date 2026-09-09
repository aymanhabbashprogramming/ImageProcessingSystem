using System;
using System.Drawing;
using System.Windows.Forms;
using Görüntü_işleme.Functions;

namespace Görüntü_işleme.Screens
{
    public partial class KenarBulma_prewittScreen : Form
    {
        private Bitmap orijinalGoruntu = null;
        private Bitmap gxSonucu = null;
        private Bitmap gySonucu = null;
        private Bitmap birlesikSonucu = null;

        private KenarBulma_prewittFunction prewittFunction = new KenarBulma_prewittFunction();

        public KenarBulma_prewittScreen()
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

                // Onceki sonuclari temizle
                GxResult.Image = null;
                GyResult.Image = null;
                BirlesikSonuc.Image = null;

                gxSonucu = null;
                gySonucu = null;
                birlesikSonucu = null;
            }
        }

        // -------------------------------------------------------
        // Prewitt uygula
        // -------------------------------------------------------
        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            // Uc sonucu hesapla
            gxSonucu = prewittFunction.PrewittGx(orijinalGoruntu);
            gySonucu = prewittFunction.PrewittGy(orijinalGoruntu);
            birlesikSonucu = prewittFunction.PrewittBirlesik(orijinalGoruntu);

            // Goster
            GxResult.Image = gxSonucu;
            GxResult.SizeMode = PictureBoxSizeMode.Zoom;

            GyResult.Image = gySonucu;
            GyResult.SizeMode = PictureBoxSizeMode.Zoom;

            BirlesikSonuc.Image = birlesikSonucu;
            BirlesikSonuc.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // -------------------------------------------------------
        // Geri al
        // -------------------------------------------------------
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            gxSonucu = null;
            gySonucu = null;
            birlesikSonucu = null;

         
            GxResult.Image = null;
            GyResult.Image = null;
            BirlesikSonuc.Image = null;
        }

        // -------------------------------------------------------
        // Kaydet — birlesik sonucu kaydeder
        // -------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (birlesikSonucu == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }

            SaveFileDialog kaydetPenceresi = new SaveFileDialog();
            kaydetPenceresi.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";

            if (kaydetPenceresi.ShowDialog() == DialogResult.OK)
            {
                birlesikSonucu.Save(kaydetPenceresi.FileName);
                MessageBox.Show("Goruntu basariyla kaydedildi.", "Bilgi");
            }
        }
    }
}