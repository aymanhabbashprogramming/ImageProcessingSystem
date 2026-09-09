using Görüntü_işleme.Functions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Görüntü_işleme.Screens
{
    public partial class Color_SpaceScreen : Form
    {
        private Bitmap _originalBitmap = null;

        public Color_SpaceScreen()
        {
            InitializeComponent();
        }

        private void Color_SpaceScreen_Load(object sender, EventArgs e)
        {
            OriginalImage.SizeMode = PictureBoxSizeMode.Zoom;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";

            if (DialogResult.OK == ofd.ShowDialog())
            {
                _originalBitmap = new Bitmap(ofd.FileName);
                OriginalImage.Image = _originalBitmap;
            }
            EditedImage.Image = null;
        }

        private void btn_RGBtoYUV_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            Bitmap cikis;
            bool sonuc = ColorSpaceFunction.ToYUV(new Bitmap(_originalBitmap), out cikis);

            if (sonuc && cikis != null)
                EditedImage.Image = cikis;
        }

        private void btn_RGBtoHSV_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            Bitmap cikis;
            bool sonuc = ColorSpaceFunction.ToHSV(new Bitmap(_originalBitmap), out cikis);

            if (sonuc && cikis != null)
                EditedImage.Image = cikis;
        }

        private void btn_YUVtoRGB_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            Bitmap cikis;
            bool sonuc = ColorSpaceFunction.YUVToRGB(new Bitmap(_originalBitmap), out cikis);

            if (sonuc && cikis != null)
                EditedImage.Image = cikis;
        }

        private void btn_HSVtoRGB_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            Bitmap cikis;
            bool sonuc = ColorSpaceFunction.HSVToRGB(new Bitmap(_originalBitmap), out cikis);

            if (sonuc && cikis != null)
                EditedImage.Image = cikis;
        }

        private void GoPreviousStep_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;
            EditedImage.Image = new Bitmap(_originalBitmap);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EditedImage.Image == null)
            {
                MessageBox.Show("Kaydedilecek görüntü bulunamadı.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|BMP|*.bmp|JPEG|*.jpg";
            sfd.Title = "Görüntüyü Kaydet";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                EditedImage.Image.Save(sfd.FileName);
                MessageBox.Show("Görüntü başarıyla kaydedildi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            EditedImage.Image = null;
            OriginalImage.Image = null;
        }
    }
}