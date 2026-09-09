using Görüntü_işleme.Functions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Görüntü_işleme.Screens
{
    public partial class Zoom_In_Out_Screen : Form
    {
        private Bitmap _originalBitmap = null;

        public Zoom_In_Out_Screen()
        {
            InitializeComponent();
        }

        private void Zoom_In_Out_Screen_Load(object sender, EventArgs e)
        {
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
            EditedImage.AutoSize = false;

            trackBar1.Minimum = 0;
            trackBar1.Maximum = 10;
            trackBar1.Value = 5;
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (_originalBitmap == null)
                return;

            double olcekOrani;

            if (trackBar1.Value <= 5)
                olcekOrani = 0.1 + (trackBar1.Value / 5.0) * 0.9;
            else
                olcekOrani = 1.0 + ((trackBar1.Value - 5) / 5.0) * 1.0;

            Bitmap giris = new Bitmap(_originalBitmap);
            Bitmap cikis;

            bool sonuc = Zoom_In_OutFunction.GoruntuYakinlastirUzaklastir(
                giris,
                out cikis,
                olcekOrani
            );

            if (sonuc)
            {
                EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
                EditedImage.Image = cikis;
            }
        }

        private void OpenImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";

            if (DialogResult.OK == ofd.ShowDialog())
            {
                _originalBitmap = new Bitmap(ofd.FileName);

                OriginalImage.Image = _originalBitmap;
                OriginalImage.SizeMode = PictureBoxSizeMode.Zoom;

                Bitmap cikis;
                Zoom_In_OutFunction.GoruntuYakinlastirUzaklastir(
                    new Bitmap(_originalBitmap),
                    out cikis,
                    1.0
                );
                EditedImage.Image = cikis;
                EditedImage.SizeMode = PictureBoxSizeMode.Zoom;

                trackBar1.Value = 5;
            }
        }

        private void GoPreviousStep_Click_1(object sender, EventArgs e)
        {
            if (_originalBitmap == null)
                return;

            Bitmap cikis;
            Zoom_In_OutFunction.GoruntuYakinlastirUzaklastir(
                new Bitmap(_originalBitmap),
                out cikis,
                1.0
            );
            EditedImage.Image = cikis;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
            trackBar1.Value = 5;
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