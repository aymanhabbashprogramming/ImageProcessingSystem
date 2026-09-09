using System;
using System.Drawing;
using System.Windows.Forms;
using Görüntü_işleme.Functions;

namespace Görüntü_işleme.Screens
{
    public partial class AdditionAndDivisionScreen : Form
    {
        private Bitmap birinciGoruntu = null;
        private Bitmap ikinciGoruntu = null;

        private Bitmap toplamaSonucu = null;
        private Bitmap bolmeSonucu = null;

        private AdditionAndDivisionFunction islemler = new AdditionAndDivisionFunction();

        public AdditionAndDivisionScreen()
        {
            InitializeComponent();
        }

        private void btnOpenImage1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Resim Dosyalari|*.jpg;*.jpeg;*.png;*.bmp";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                birinciGoruntu = new Bitmap(dosyaSecici.FileName);
                OriginalImage1.Image = birinciGoruntu;
                OriginalImage1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void btnOpenImage2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Resim Dosyalari|*.jpg;*.jpeg;*.png;*.bmp";

            if (dosyaSecici.ShowDialog() == DialogResult.OK)
            {
                ikinciGoruntu = new Bitmap(dosyaSecici.FileName);
                OriginalImage2.Image = ikinciGoruntu;
                OriginalImage2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void btnAddImages_Click(object sender, EventArgs e)
        {
            if (birinciGoruntu == null || ikinciGoruntu == null)
            {
                MessageBox.Show("Lutfen her iki gorseli de yukleyin.", "Uyari");
                return;
            }

            toplamaSonucu = islemler.GoruntuTopla(birinciGoruntu, ikinciGoruntu);

            AddImages.Image = toplamaSonucu;
            AddImages.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btnDıvısıonImages_Click(object sender, EventArgs e)
        {
            if (birinciGoruntu == null || ikinciGoruntu == null)
            {
                MessageBox.Show("Lutfen her iki gorseli de yukleyin.", "Uyari");
                return;
            }

            bolmeSonucu = islemler.GoruntuBol(birinciGoruntu, ikinciGoruntu);

            DivisionImages.Image = bolmeSonucu;
            DivisionImages.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btnBeforeAdding_Click(object sender, EventArgs e)
        {
            toplamaSonucu = null;
            AddImages.Image = null;
        }
        private void btnSaveAdding_Click(object sender, EventArgs e)
        {
            if (toplamaSonucu == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }

            SaveFileDialog kaydetPenceresi = new SaveFileDialog();
            kaydetPenceresi.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";

            if (kaydetPenceresi.ShowDialog() == DialogResult.OK)
            {
                toplamaSonucu.Save(kaydetPenceresi.FileName);
                MessageBox.Show("Goruntu basariyla kaydedildi.", "Bilgi");
            }
        }
        private void btnBeforeDivison_Click(object sender, EventArgs e)
        {
            bolmeSonucu = null;
            DivisionImages.Image = null;
        }
        private void btnSaveDivison_Click(object sender, EventArgs e)
        {
            if (bolmeSonucu == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }

            SaveFileDialog kaydetPenceresi = new SaveFileDialog();
            kaydetPenceresi.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";

            if (kaydetPenceresi.ShowDialog() == DialogResult.OK)
            {
                bolmeSonucu.Save(kaydetPenceresi.FileName);
                MessageBox.Show("Goruntu basariyla kaydedildi.", "Bilgi");
            }
        }
    }
}