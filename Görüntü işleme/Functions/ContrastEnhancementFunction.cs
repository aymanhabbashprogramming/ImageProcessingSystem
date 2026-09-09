using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class ContrastEnhancementFunction
    {
        public static bool KontrastArtir(
            Bitmap giris,
            out Bitmap cikis,
            int kontrastDegeri)
        {
            try
            {
                cikis = new Bitmap(giris.Width, giris.Height);

                double faktor = (259.0 * (kontrastDegeri + 255)) / (255.0 * (259 - kontrastDegeri));

                for (int x = 0; x < giris.Width; x++)
                {
                    for (int y = 0; y < giris.Height; y++)
                    {
                        Color c = giris.GetPixel(x, y);

                        int r = Clip((int)(faktor * (c.R - 128) + 128));
                        int g = Clip((int)(faktor * (c.G - 128) + 128));
                        int b = Clip((int)(faktor * (c.B - 128) + 128));

                        cikis.SetPixel(x, y, Color.FromArgb(r, g, b));
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

        private static int Clip(int deger)
        {
            return Math.Max(0, Math.Min(255, deger));
        }
    }
}