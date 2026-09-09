using Görüntü_işleme.Functions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Görüntü_işleme.Screens
{
    public partial class MultipleOperationsScreen : Form
    {
        private Bitmap _originalBitmap = null;
        private Bitmap _currentBitmap = null;
        private Stack<Bitmap> _history = new Stack<Bitmap>();

        public MultipleOperationsScreen()
        {
            InitializeComponent();
        }

        private void MultipleOperationsScreen_Load(object sender, EventArgs e)
        {
            OriginalImage.SizeMode = PictureBoxSizeMode.Zoom;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;

            cmbColorSpace.Items.Clear();
           
            cmbColorSpace.Items.Add("RGB → YUV");
            cmbColorSpace.Items.Add("RGB → HSV");
            cmbColorSpace.SelectedIndex = 0;
            cmbColorSpace.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbDirection.Items.Clear();
            cmbDirection.Items.Add("Saat Yönünde");
            cmbDirection.Items.Add("Saat Yönünün Tersine");
            cmbDirection.SelectedIndex = 0;
            cmbDirection.DropDownStyle = ComboBoxStyle.DropDownList;

            nudAngle.Minimum = 0;
            nudAngle.Maximum = 360;
            nudAngle.Value = 0;

            txtContrast.Text = "0";

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            trackBar1.Value = 11;
            trackBar1.TickFrequency = 2;
        }

        // -------------------------------------------------------
        // Yardimci metodlar
        // -------------------------------------------------------
        private void SaveToHistory()
        {
            if (_currentBitmap != null)
                _history.Push(new Bitmap(_currentBitmap));
        }

        private void UpdateEditedImage(Bitmap result)
        {
            if (result != null)
            {
                _currentBitmap = result;
                EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
                EditedImage.Image = _currentBitmap;
            }
        }

        // -------------------------------------------------------
        // Goruntu ac
        // -------------------------------------------------------
        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";

            if (DialogResult.OK == ofd.ShowDialog())
            {
                _originalBitmap = new Bitmap(ofd.FileName);
                _currentBitmap = new Bitmap(_originalBitmap);
                OriginalImage.Image = _originalBitmap;
                EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
                EditedImage.Image = _currentBitmap;
                _history.Clear();
                nudAngle.Value = 0;
                txtContrast.Text = "0";
                trackBar1.Value = 11;
            }
        }

        // -------------------------------------------------------
        // Sifirla
        // -------------------------------------------------------
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            _currentBitmap = new Bitmap(_originalBitmap);
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
            EditedImage.Image = _currentBitmap;
            _history.Clear();
            nudAngle.Value = 0;
            txtContrast.Text = "0";
            trackBar1.Value = 11;
        }

        // -------------------------------------------------------
        // Geri al
        // -------------------------------------------------------
        private void GoPreviousStep_Click(object sender, EventArgs e)
        {
            if (_history.Count == 0) return;

            _currentBitmap = _history.Pop();
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
            EditedImage.Image = _currentBitmap;
        }

        // -------------------------------------------------------
        // Gri donusum
        // -------------------------------------------------------
        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (_currentBitmap == null) return;

            SaveToHistory();

            Bitmap giris = new Bitmap(_currentBitmap);
            bool sonuc = To_GrayFunction.ChangeColor(giris);

            if (sonuc)
                UpdateEditedImage(giris);
        }

        // -------------------------------------------------------
        // Binary donusum
        // -------------------------------------------------------
        private void btnBinary_Click(object sender, EventArgs e)
        {
            if (_currentBitmap == null) return;

            SaveToHistory();

            Bitmap giris = new Bitmap(_currentBitmap);
            Bitmap cikis;

            bool sonuc = BinaryFunction.BinaryDonusturme(giris, out cikis, 128);

            if (sonuc)
                UpdateEditedImage(cikis);
        }

        // -------------------------------------------------------
        // Renk uzayi donusumu
        // -------------------------------------------------------
        private void btnColorSpace_Click(object sender, EventArgs e)
        {
            if (_currentBitmap == null) return;

            SaveToHistory();

            Bitmap giris = new Bitmap(_currentBitmap);
            Bitmap cikis;
            bool sonuc = false;

            switch (cmbColorSpace.SelectedIndex)
            {
              
                case 1: sonuc = ColorSpaceFunction.ToYUV(giris, out cikis); break;
                case 2: sonuc = ColorSpaceFunction.ToHSV(giris, out cikis); break;
                default: cikis = null; break;
            }

            if (sonuc)
                UpdateEditedImage(cikis);
        }

        // -------------------------------------------------------
        // Dondurme — her uygulamada _currentBitmap uzerinden degil
        // _originalBitmap uzerinden birikimli aci ile calis
        // -------------------------------------------------------
        private double _birikimliDerece = 0;

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            SaveToHistory();

            double eklenecekDerece = (double)nudAngle.Value;
            bool saatYonunde = cmbDirection.SelectedIndex == 0;

            if (!saatYonunde)
                _birikimliDerece -= eklenecekDerece;
            else
                _birikimliDerece += eklenecekDerece;

            // Her zaman orijinalden dondurup kuculmesini onle
            Bitmap giris = new Bitmap(_originalBitmap);
            Bitmap cikis;

            bool sonuc = RotateFunction.GoruntuDondur(
                giris,
                out cikis,
                Math.Abs(_birikimliDerece),
                _birikimliDerece >= 0
            );

            if (sonuc)
                UpdateEditedImage(cikis);
        }

        // -------------------------------------------------------
        // Kontrast — her uygulamada _currentBitmap uzerinden calis
        // -------------------------------------------------------
        private void btnApplyContrast_Click_1(object sender, EventArgs e)
        {
            if (_currentBitmap == null) return;

            int kontrastDegeri;
            if (!int.TryParse(txtContrast.Text, out kontrastDegeri))
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kontrastDegeri < 0 || kontrastDegeri > 255)
            {
                MessageBox.Show("Değer 0 ile 255 arasında olmalıdır.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrast.Text = "0";
                return;
            }

            SaveToHistory();

            Bitmap giris = new Bitmap(_currentBitmap);
            Bitmap cikis;

            bool sonuc = ContrastEnhancementFunction.KontrastArtir(giris, out cikis, kontrastDegeri);

            if (sonuc)
                UpdateEditedImage(cikis);
        }

        // -------------------------------------------------------
        // Zoom — gecici gosterim, history'e kaydedilmez
        // -------------------------------------------------------
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            if (_currentBitmap == null) return;

            double olcek = trackBar1.Value / 10.0;

            Bitmap giris = new Bitmap(_currentBitmap);
            Bitmap cikis;

            bool sonuc = Zoom_In_OutFunction.GoruntuYakinlastirUzaklastir(
                giris, out cikis, olcek);

            if (sonuc && cikis != null)
            {
                EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
                EditedImage.Image = cikis;
            }
        }

        // -------------------------------------------------------
        // Kaydet
        // -------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_currentBitmap == null)
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
                _currentBitmap.Save(sfd.FileName);
                MessageBox.Show("Görüntü başarıyla kaydedildi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // -------------------------------------------------------
        // Bos event handler'lar
        // -------------------------------------------------------
        private void nudAngle_ValueChanged(object sender, EventArgs e) { }
        private void cmbColorSpace_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbDirection_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtContrast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}