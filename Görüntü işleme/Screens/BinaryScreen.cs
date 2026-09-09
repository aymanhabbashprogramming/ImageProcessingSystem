using Görüntü_işleme.Functions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Görüntü_işleme.Screens
{
    public partial class BinaryScreen : Form
    {
        private Bitmap orijinalGoruntu = null;

        public BinaryScreen()
        {
            InitializeComponent();
        }

        private void btnTo_Binary_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lütfen önce bir görüntü yükleyin.", "Uyarı");
                return;
            }

            // Esik deger bos mu?
            if (string.IsNullOrWhiteSpace(txtEsikDeger.Text))
            {
                MessageBox.Show("Lütfen bir eşik değeri giriniz.", "Uyarı");
                return;
            }

            // Sayi mi?
            if (!int.TryParse(txtEsikDeger.Text, out int esikDeger))
            {
                MessageBox.Show("Eşik değeri geçerli bir sayı olmalıdır.", "Uyarı");
                return;
            }

            // 0-255 arasinda mi?
            if (esikDeger < 0 || esikDeger > 255)
            {
                MessageBox.Show("Eşik değeri 0 ile 255 arasında olmalıdır.", "Uyarı");
                return;
            }

            Bitmap girisGoruntusu = new Bitmap(orijinalGoruntu);
            Bitmap cikisGoruntusu;

            bool sonuc = BinaryFunction.BinaryDonusturme(
                girisGoruntusu,
                out cikisGoruntusu,
                esikDeger
            );

            if (sonuc)
                this.EditedImage.Image = cikisGoruntusu;
            else
                MessageBox.Show("Binary dönüşümü sırasında bir hata oluştu.");
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaPenceresi = new OpenFileDialog();

            if (dosyaPenceresi.ShowDialog() == DialogResult.OK)
            {
                orijinalGoruntu = new Bitmap(dosyaPenceresi.FileName);
                this.OriginalImage.Image = orijinalGoruntu;
            }
        }

        private void GoPreviousStep_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
                return;

            this.EditedImage.Image = new Bitmap(orijinalGoruntu);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EditedImage.Image == null)
            {
                MessageBox.Show(
                    "Kaydedilecek görüntü bulunamadı.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|BMP|*.bmp|JPEG|*.jpg";
            sfd.Title = "Görüntüyü Kaydet";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                EditedImage.Image.Save(sfd.FileName);

                MessageBox.Show(
                    "Görüntü başarıyla kaydedildi.",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}