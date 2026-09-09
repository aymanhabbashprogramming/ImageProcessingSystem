using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class Konvolusyon_MeanFunction
    {
        public Bitmap MeanUygula(Bitmap goruntu, int MaskelBoyu)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;

            Bitmap sonucGoruntu = new Bitmap(genislik, yukseklik);

            int yarim = MaskelBoyu / 2;

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    int toplamR = 0;
                    int toplamG = 0;
                    int toplamB = 0;
                    int pikselSayisi = 0;

                    for (int ky = -yarim; ky <= yarim; ky++)
                    {
                        for (int kx = -yarim; kx <= yarim; kx++)
                        {
                            int komsuX = x + kx;
                            int komsuY = y + ky;

                            if (komsuX < 0) komsuX = 0;
                            if (komsuX >= genislik) komsuX = genislik - 1;
                            if (komsuY < 0) komsuY = 0;
                            if (komsuY >= yukseklik) komsuY = yukseklik - 1;

                            Color komsuPiksel = goruntu.GetPixel(komsuX, komsuY);
                            toplamR += komsuPiksel.R;
                            toplamG += komsuPiksel.G;
                            toplamB += komsuPiksel.B;
                            pikselSayisi++;
                        }
                    }

                    int ortalamaR = toplamR / pikselSayisi;
                    int ortalamaG = toplamG / pikselSayisi;
                    int ortalamaB = toplamB / pikselSayisi;

                    sonucGoruntu.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                }
            }

            return sonucGoruntu;
        }
    }
}