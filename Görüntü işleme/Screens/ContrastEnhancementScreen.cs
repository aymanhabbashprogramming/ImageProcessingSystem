using Görüntü_işleme.Functions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Görüntü_işleme.Screens
{
    public partial class ContrastEnhancementScreen : Form
    {
        private Bitmap _originalBitmap = null;

        public ContrastEnhancementScreen()
        {
            InitializeComponent();
        }

        private void ContrastEnhancementScreen_Load(object sender, EventArgs e)
        {
            OriginalImage.SizeMode = PictureBoxSizeMode.Zoom;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;

            kryptonTrackBar1.Minimum = -150;
            kryptonTrackBar1.Maximum = 150;
            kryptonTrackBar1.Value = 0;
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";

            if (DialogResult.OK == ofd.ShowDialog())
            {
                _originalBitmap = new Bitmap(ofd.FileName);
                OriginalImage.Image = _originalBitmap;
                EditedImage.Image = null;
            }
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            int kontrastDegeri = kryptonTrackBar1.Value;

            Bitmap giris = new Bitmap(_originalBitmap);
            Bitmap cikis;

            bool sonuc = ContrastEnhancementFunction.KontrastArtir(
                giris,
                out cikis,
                kontrastDegeri
            );

            if (sonuc)
                EditedImage.Image = cikis;
        }

        private void GoPreviousStep_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            EditedImage.Image = new Bitmap(_originalBitmap);
            kryptonTrackBar1.Value = 0;
        
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