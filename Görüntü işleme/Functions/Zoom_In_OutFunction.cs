using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Görüntü_işleme.Functions
{
    internal class Zoom_In_OutFunction
    {
        public static bool GoruntuYakinlastirUzaklastir(
            Bitmap girisGoruntusu,
            out Bitmap cikisGoruntusu,
            double olcekOrani)
        {
            try
            {
                int w = girisGoruntusu.Width;
                int h = girisGoruntusu.Height;

                cikisGoruntusu = new Bitmap(w, h);

                using (Graphics g = Graphics.FromImage(cikisGoruntusu))
                {
                    g.Clear(Color.White);
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    if (olcekOrani <= 1.0)
                    {
                        int yeniW = (int)(w * olcekOrani);
                        int yeniH = (int)(h * olcekOrani);
                        if (yeniW < 1) yeniW = 1;
                        if (yeniH < 1) yeniH = 1;

                        int x = (w - yeniW) / 2;
                        int y = (h - yeniH) / 2;

                        g.DrawImage(girisGoruntusu, x, y, yeniW, yeniH);
                    }
                    else
                    {
                        double tersOran = 1.0 / olcekOrani;
                        int srcW = (int)(w * tersOran);
                        int srcH = (int)(h * tersOran);
                        int srcX = (w - srcW) / 2;
                        int srcY = (h - srcH) / 2;

                        Rectangle srcRect = new Rectangle(srcX, srcY, srcW, srcH);
                        Rectangle destRect = new Rectangle(0, 0, w, h);

                        g.DrawImage(girisGoruntusu, destRect, srcRect, GraphicsUnit.Pixel);
                    }
                }


                return true;
            }
            catch
            {
                cikisGoruntusu = null;
                return false;
            }
        }
    }
}