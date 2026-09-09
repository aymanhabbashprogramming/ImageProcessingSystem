using Görüntü_işleme.Functions;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Görüntü_işleme.Screens
{
    public partial class CropScreen : Form
    {
        private Bitmap _originalBitmap = null;
        private Point _startPoint;
        private Point _endPoint;
        private bool _isDrawing = false;
        private Rectangle _selectionRect = Rectangle.Empty;

        public CropScreen()
        {
            InitializeComponent();
            OriginalImage.SizeMode = PictureBoxSizeMode.Zoom;
            EditedImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void OriginalImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (_originalBitmap == null) return;

            _isDrawing = true;
            _startPoint = e.Location;
            _endPoint = e.Location;
            _selectionRect = Rectangle.Empty;
        }

        private void OriginalImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            _endPoint = e.Location;

            int x = Math.Min(_startPoint.X, _endPoint.X);
            int y = Math.Min(_startPoint.Y, _endPoint.Y);
            int w = Math.Abs(_endPoint.X - _startPoint.X);
            int h = Math.Abs(_endPoint.Y - _startPoint.Y);

            _selectionRect = new Rectangle(x, y, w, h);
            OriginalImage.Invalidate();
        }

        private void OriginalImage_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
        }

        private void OriginalImage_Paint(object sender, PaintEventArgs e)
        {
            if (_selectionRect.Width <= 0 || _selectionRect.Height <= 0)
                return;

            using (SolidBrush dark = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(dark,
                    0, 0,
                    OriginalImage.Width, _selectionRect.Y);

                e.Graphics.FillRectangle(dark,
                    0, _selectionRect.Bottom,
                    OriginalImage.Width, OriginalImage.Height - _selectionRect.Bottom);

                e.Graphics.FillRectangle(dark,
                    0, _selectionRect.Y,
                    _selectionRect.X, _selectionRect.Height);

                e.Graphics.FillRectangle(dark,
                    _selectionRect.Right, _selectionRect.Y,
                    OriginalImage.Width - _selectionRect.Right, _selectionRect.Height);
            }

            using (Pen pen = new Pen(Color.DeepSkyBlue, 2))
            {
                pen.DashStyle = DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, _selectionRect);
            }
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null || _selectionRect.IsEmpty) return;

            Rectangle realRect = ConvertToImageCoordinates(_selectionRect);
            if (realRect.Width <= 0 || realRect.Height <= 0) return;

            Bitmap result;

            bool sonuc = CropFunction.GoruntuKirma(
                _originalBitmap,
                out result,
                realRect.X,
                realRect.Y,
                realRect.Width,
                realRect.Height
            );

            if (sonuc)
                EditedImage.Image = result;
        }

        private Rectangle ConvertToImageCoordinates(Rectangle picBoxRect)
        {
            if (_originalBitmap == null) return Rectangle.Empty;

            float imgW = _originalBitmap.Width;
            float imgH = _originalBitmap.Height;
            float boxW = OriginalImage.Width;
            float boxH = OriginalImage.Height;

            float scale = Math.Min(boxW / imgW, boxH / imgH);
            float offsetX = (boxW - imgW * scale) / 2;
            float offsetY = (boxH - imgH * scale) / 2;

            int realX = (int)((picBoxRect.X - offsetX) / scale);
            int realY = (int)((picBoxRect.Y - offsetY) / scale);
            int realW = (int)(picBoxRect.Width / scale);
            int realH = (int)(picBoxRect.Height / scale);

            realX = Math.Max(0, realX);
            realY = Math.Max(0, realY);
            realW = Math.Min(realW, _originalBitmap.Width - realX);
            realH = Math.Min(realH, _originalBitmap.Height - realY);

            return new Rectangle(realX, realY, realW, realH);
        }


        private void OpenImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";

            if (DialogResult.OK == ofd.ShowDialog())
            {
                _originalBitmap = new Bitmap(ofd.FileName);
                OriginalImage.Image = _originalBitmap;
                _selectionRect = Rectangle.Empty;
                OriginalImage.Invalidate();
            }
        }

        private void GoPreviousStep_Click_1(object sender, EventArgs e)
        {
           

            EditedImage.Image = null;
          
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null || _selectionRect.IsEmpty) return;

            Rectangle realRect = ConvertToImageCoordinates(_selectionRect);
            if (realRect.Width <= 0 || realRect.Height <= 0) return;

            Bitmap result;

            bool sonuc = CropFunction.GoruntuKirma(
                _originalBitmap,
                out result,
                realRect.X,
                realRect.Y,
                realRect.Width,
                realRect.Height
            );

            if (sonuc)
                EditedImage.Image = result;
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (_originalBitmap == null) return;

            EditedImage.Image = null;
            _selectionRect = Rectangle.Empty;
            OriginalImage.Invalidate();
        }
    }
}