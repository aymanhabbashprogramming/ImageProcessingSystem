using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Görüntü_işleme.Functions
{
    internal class AdditionAndDivisionFunction
    {
        private Bitmap BoyutuEsitle(Bitmap goruntu, int hedefGenislik, int hedefYukseklik)
        {
            Bitmap yeniBoyut = new Bitmap(hedefGenislik, hedefYukseklik);
            using (Graphics g = Graphics.FromImage(yeniBoyut))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(goruntu, 0, 0, hedefGenislik, hedefYukseklik);
            }
            return yeniBoyut;
        }
        public Bitmap GoruntuTopla(Bitmap birinciGoruntu, Bitmap ikinciGoruntu)
        {
           
            int genislik = Math.Min(birinciGoruntu.Width, ikinciGoruntu.Width);
            int yukseklik = Math.Min(birinciGoruntu.Height, ikinciGoruntu.Height);

        
            Bitmap birinci = BoyutuEsitle(birinciGoruntu, genislik, yukseklik);
            Bitmap ikinci = BoyutuEsitle(ikinciGoruntu, genislik, yukseklik);

            Bitmap sonucGoruntu = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color piksel1 = birinci.GetPixel(x, y);
                    Color piksel2 = ikinci.GetPixel(x, y);

                    int yeniR = piksel1.R + piksel2.R;
                    int yeniG = piksel1.G + piksel2.G;
                    int yeniB = piksel1.B + piksel2.B;

                    if (yeniR > 255) yeniR = 255;
                    if (yeniG > 255) yeniG = 255;
                    if (yeniB > 255) yeniB = 255;

                    sonucGoruntu.SetPixel(x, y, Color.FromArgb(yeniR, yeniG, yeniB));
                }
            }

            return sonucGoruntu;
        }
        public Bitmap GoruntuBol(Bitmap birinciGoruntu, Bitmap ikinciGoruntu)
        {
            int genislik = Math.Min(birinciGoruntu.Width, ikinciGoruntu.Width);
            int yukseklik = Math.Min(birinciGoruntu.Height, ikinciGoruntu.Height);

            Bitmap birinci = BoyutuEsitle(birinciGoruntu, genislik, yukseklik);
            Bitmap ikinci = BoyutuEsitle(ikinciGoruntu, genislik, yukseklik);

            Bitmap sonucGoruntu = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color piksel1 = birinci.GetPixel(x, y);
                    Color piksel2 = ikinci.GetPixel(x, y);

                    int yeniR = (piksel2.R == 0) ? 0 : (piksel1.R * 255 / piksel2.R);
                    int yeniG = (piksel2.G == 0) ? 0 : (piksel1.G * 255 / piksel2.G);
                    int yeniB = (piksel2.B == 0) ? 0 : (piksel1.B * 255 / piksel2.B);

                    if (yeniR > 255) yeniR = 255;
                    if (yeniG > 255) yeniG = 255;
                    if (yeniB > 255) yeniB = 255;

                    sonucGoruntu.SetPixel(x, y, Color.FromArgb(yeniR, yeniG, yeniB));
                }
            }

            return sonucGoruntu;
        }
    }
}