using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class FiltreUygulanmasi_UnsharpFunction
    {
        private Bitmap BlurlastirmaUygula(Bitmap goruntu)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;

            Bitmap sonuc = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    int toplamR = 0;
                    int toplamG = 0;
                    int toplamB = 0;
                    int sayac = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            int komsuX = x + kx;
                            int komsuY = y + ky;

                            if (komsuX < 0) komsuX = 0;
                            if (komsuX >= genislik) komsuX = genislik - 1;
                            if (komsuY < 0) komsuY = 0;
                            if (komsuY >= yukseklik) komsuY = yukseklik - 1;

                            Color piksel = goruntu.GetPixel(komsuX, komsuY);
                            toplamR += piksel.R;
                            toplamG += piksel.G;
                            toplamB += piksel.B;
                            sayac++;
                        }
                    }

                    sonuc.SetPixel(x, y, Color.FromArgb(
                        toplamR / sayac,
                        toplamG / sayac,
                        toplamB / sayac
                    ));
                }
            }

            return sonuc;
        }
        public Bitmap UnsharpUygula(Bitmap goruntu, int miktar)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;

            Bitmap bulanikGoruntu = BlurlastirmaUygula(goruntu);

            Bitmap sonuc = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color orijinalPiksel = goruntu.GetPixel(x, y);
                    Color bulanikPiksel = bulanikGoruntu.GetPixel(x, y);

                    int kenarR = orijinalPiksel.R - bulanikPiksel.R;
                    int kenarG = orijinalPiksel.G - bulanikPiksel.G;
                    int kenarB = orijinalPiksel.B - bulanikPiksel.B;

                    int yeniR = orijinalPiksel.R + kenarR * miktar;
                    int yeniG = orijinalPiksel.G + kenarG * miktar;
                    int yeniB = orijinalPiksel.B + kenarB * miktar;

                    if (yeniR < 0) yeniR = 0;
                    if (yeniR > 255) yeniR = 255;
                    if (yeniG < 0) yeniG = 0;
                    if (yeniG > 255) yeniG = 255;
                    if (yeniB < 0) yeniB = 0;
                    if (yeniB > 255) yeniB = 255;

                    sonuc.SetPixel(x, y, Color.FromArgb(yeniR, yeniG, yeniB));
                }
            }

            return sonuc;
        }
    }
}