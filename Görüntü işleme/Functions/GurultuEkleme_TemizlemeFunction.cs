using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class GurultuEkleme_TemizlemeFunction
    {
        private Random rastgele = new Random();

        public Bitmap SaltPepperEkle(Bitmap goruntu, double gurultuOrani)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;

            Bitmap sonuc = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    double olasilik = rastgele.NextDouble();

                    if (olasilik < gurultuOrani / 2.0)
                        sonuc.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else if (olasilik < gurultuOrani)
                        sonuc.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        sonuc.SetPixel(x, y, goruntu.GetPixel(x, y));
                }
            }

            return sonuc;
        }

        public Bitmap MeanFiltrele(Bitmap goruntu, int MaskeBoyutu)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;
            int yarim = MaskeBoyutu / 2;

            Bitmap sonuc = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    if (x < yarim || x >= genislik - yarim || y < yarim || y >= yukseklik - yarim)
                    {
                        sonuc.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        continue;
                    }

                    int toplamR = 0, toplamG = 0, toplamB = 0;
                    int sayac = 0;

                    for (int ky = -yarim; ky <= yarim; ky++)
                    {
                        for (int kx = -yarim; kx <= yarim; kx++)
                        {
                            Color piksel = goruntu.GetPixel(x + kx, y + ky);
                            toplamR += piksel.R;
                            toplamG += piksel.G;
                            toplamB += piksel.B;
                            sayac++;
                        }
                    }

                    sonuc.SetPixel(x, y, Color.FromArgb(toplamR / sayac, toplamG / sayac, toplamB / sayac));
                }
            }

            return sonuc;
        }

        public Bitmap MedianFiltrele(Bitmap goruntu, int MaskeBoyutu)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;
            int yarim = MaskeBoyutu / 2;
            int kernelAlan = MaskeBoyutu * MaskeBoyutu;

            Bitmap sonuc = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    if (x < yarim || x >= genislik - yarim || y < yarim || y >= yukseklik - yarim)
                    {
                        sonuc.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        continue;
                    }

                    int[] rDegerleri = new int[kernelAlan];
                    int[] gDegerleri = new int[kernelAlan];
                    int[] bDegerleri = new int[kernelAlan];
                    int indeks = 0;

                    for (int ky = -yarim; ky <= yarim; ky++)
                    {
                        for (int kx = -yarim; kx <= yarim; kx++)
                        {
                            Color piksel = goruntu.GetPixel(x + kx, y + ky);
                            rDegerleri[indeks] = piksel.R;
                            gDegerleri[indeks] = piksel.G;
                            bDegerleri[indeks] = piksel.B;
                            indeks++;
                        }
                    }

                    // Bubble sort
                    for (int i = 0; i < kernelAlan - 1; i++)
                    {
                        for (int j = 0; j < kernelAlan - 1 - i; j++)
                        {
                            if (rDegerleri[j] > rDegerleri[j + 1])
                            { int tmp = rDegerleri[j]; rDegerleri[j] = rDegerleri[j + 1]; rDegerleri[j + 1] = tmp; }

                            if (gDegerleri[j] > gDegerleri[j + 1])
                            { int tmp = gDegerleri[j]; gDegerleri[j] = gDegerleri[j + 1]; gDegerleri[j + 1] = tmp; }

                            if (bDegerleri[j] > bDegerleri[j + 1])
                            { int tmp = bDegerleri[j]; bDegerleri[j] = bDegerleri[j + 1]; bDegerleri[j + 1] = tmp; }
                        }
                    }

                    int ortanca = kernelAlan / 2;
                    sonuc.SetPixel(x, y, Color.FromArgb(rDegerleri[ortanca], gDegerleri[ortanca], bDegerleri[ortanca]));
                }
            }

            return sonuc;
        }
    }
}