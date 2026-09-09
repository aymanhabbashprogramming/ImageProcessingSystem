using System;
using System.Drawing;
using System.Windows.Forms;
using Görüntü_işleme.Functions;

namespace Görüntü_işleme.Screens
{
    public partial class Konvolusyon_MeanScreen : Form
    {
        private Bitmap orijinalGoruntu = null;
        private Bitmap sonucGoruntu = null;
        private Bitmap oncekiSonuc = null;

        private Konvolusyon_MeanFunction meanFunction = new Konvolusyon_MeanFunction();

        public Konvolusyon_MeanScreen()
        {
            InitializeComponent();
        }

        private void Konvolusyon_MeanScreen_Load(object sender, EventArgs e)
        {
            
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
                oncekiSonuc = null;
            }
        }

        // -------------------------------------------------------
        // Mean konvolusyon uygula
        // -------------------------------------------------------
        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            // Mevcut sonucu gecmise kaydet
            oncekiSonuc = sonucGoruntu;

            int kernelBoyu = 3;
            if (RadioButton_5.Checked) kernelBoyu = 5;
            if (RadioButton_7.Checked) kernelBoyu = 7;

            sonucGoruntu = meanFunction.MeanUygula(orijinalGoruntu, kernelBoyu);

            EditedImage.Image = sonucGoruntu;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // -------------------------------------------------------
        // Geri al
        // -------------------------------------------------------
        private void GoPreviousStep_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null) return;

            sonucGoruntu = null;
            oncekiSonuc = null;
            EditedImage.Image = orijinalGoruntu;
            RadioButton_3.Checked = false;
            RadioButton_5.Checked = false;
            RadioButton_7.Checked = false;
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