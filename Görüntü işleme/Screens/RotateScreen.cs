using Görüntü_işleme.Functions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Görüntü_işleme.Screens
{
    public partial class RotateScreen : Form
    {
        private Bitmap _originalBitmap = null;
        private double _toplamDerece = 0;

        public RotateScreen()
        {
            InitializeComponent();
        }

        private void RotateScreen_Load(object sender, EventArgs e)
        {
            OriginalImage.SizeMode = PictureBoxSizeMode.Zoom;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;

            cmbDirection.Items.Clear();
            cmbDirection.Items.Add("Saat Yönünde");
            cmbDirection.Items.Add("Saat Yönünün Tersine");
            cmbDirection.SelectedIndex = 0;
            cmbDirection.DropDownStyle = ComboBoxStyle.DropDownList;

            nudAngle.Minimum = 0;
            nudAngle.Maximum = int.MaxValue; // sinirsiz giris, mod alinir
            nudAngle.Value = 0;
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
                _toplamDerece = 0;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            double derece = (double)nudAngle.Value;
            bool saatYonunde = cmbDirection.SelectedIndex == 0;

            if (saatYonunde)
                _toplamDerece += derece;
            else
                _toplamDerece -= derece;

            // Mod 360 — birikimli dereceyi de normalize et
            _toplamDerece = ((_toplamDerece % 360) + 360) % 360;

            Bitmap cikis;
            bool sonuc = RotateFunction.GoruntuDondur(
                new Bitmap(_originalBitmap),
                out cikis,
                _toplamDerece,
                true
            );

            if (sonuc && cikis != null)
                EditedImage.Image = cikis;
        }

        private void GoPreviousStep_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            EditedImage.Image = new Bitmap(_originalBitmap);
            nudAngle.Value = 0;
            _toplamDerece = 0;
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
        }
    }
}