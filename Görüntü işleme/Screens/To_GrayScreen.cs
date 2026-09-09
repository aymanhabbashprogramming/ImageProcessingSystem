using Görüntü_işleme.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görüntü_işleme.Screens
{
    public partial class To_GrayScreen : Form
    {
        private Bitmap _originalBitmap = null;
        public To_GrayScreen()
        {
            InitializeComponent();
        }

        private void btnTo_Gray_Click_1(object sender, EventArgs e)
        {
            if (_originalBitmap == null)
                return;
            Bitmap bitmap = new Bitmap(_originalBitmap);
            To_GrayFunction.ChangeColor(bitmap);
            this.EditedImage.Image = bitmap;
        }
        private void GoPreviousStep_Click_1(object sender, EventArgs e)
        {
            if (_originalBitmap == null)
                return;
            this.EditedImage.Image = new Bitmap(_originalBitmap);
        }
        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                _originalBitmap = new Bitmap(ofd.FileName);
                this.OriginalImage.Image = _originalBitmap;
            }
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
