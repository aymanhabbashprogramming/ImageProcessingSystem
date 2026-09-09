using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class RotateFunction
    {
        public static bool GoruntuDondur(
            Bitmap giris,
            out Bitmap cikis,
            double derece,
            bool saatYonunde)
        {
            try
            {
                derece = ((derece % 360) + 360) % 360;

                if (!saatYonunde)
                    derece = -derece;

                double radyan = derece * Math.PI / 180.0;
                double cos = Math.Cos(radyan);
                double sin = Math.Sin(radyan);

                int girisW = giris.Width;
                int girisH = giris.Height;

                double cx = girisW / 2.0;
                double cy = girisH / 2.0;

                int yeniW = (int)(girisW * Math.Abs(cos) + girisH * Math.Abs(sin));
                int yeniH = (int)(girisW * Math.Abs(sin) + girisH * Math.Abs(cos));

                cikis = new Bitmap(yeniW, yeniH);

                double newCx = yeniW / 2.0;
                double newCy = yeniH / 2.0;

                for (int x = 0; x < yeniW; x++)
                {
                    for (int y = 0; y < yeniH; y++)
                    {
                        double srcX = cos * (x - newCx) + sin * (y - newCy) + cx;
                        double srcY = -sin * (x - newCx) + cos * (y - newCy) + cy;

                        int kaynakX = (int)Math.Round(srcX);
                        int kaynakY = (int)Math.Round(srcY);

                        if (kaynakX >= 0 && kaynakX < girisW &&
                            kaynakY >= 0 && kaynakY < girisH)
                            cikis.SetPixel(x, y, giris.GetPixel(kaynakX, kaynakY));
                        else
                            cikis.SetPixel(x, y, Color.White);
                    }
                }

                return true;
            }
            catch
            {
                cikis = null;
                return false;
            }
        }
    }
}