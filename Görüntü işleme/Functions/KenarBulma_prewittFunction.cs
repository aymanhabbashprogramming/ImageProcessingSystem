using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class KenarBulma_prewittFunction
    {
        private int GriDegerHesapla(Color piksel)
        {
            return (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);
        }

        private int SinirKontrol(int deger, int maksimum)
        {
            if (deger < 0) return 0;
            if (deger >= maksimum) return maksimum - 1;
            return deger;
        }
        public Bitmap PrewittGx(Bitmap goruntu)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;

            Bitmap sonuc = new Bitmap(genislik, yukseklik);

            int[,] kernelGx = new int[3, 3]
            {
                { -1,  0,  1 },
                { -1,  0,  1 },
                { -1,  0,  1 }
            };

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    int toplam = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            int komsuX = SinirKontrol(x + kx, genislik);
                            int komsuY = SinirKontrol(y + ky, yukseklik);

                            int griDeger = GriDegerHesapla(goruntu.GetPixel(komsuX, komsuY));
                            toplam += griDeger * kernelGx[ky + 1, kx + 1];
                        }
                    }

                    // Mutlak deger al ve sinirla
                    int yeniDeger = Math.Abs(toplam);
                    if (yeniDeger > 255) yeniDeger = 255;

                    sonuc.SetPixel(x, y, Color.FromArgb(yeniDeger, yeniDeger, yeniDeger));
                }
            }

            return sonuc;
        }
        public Bitmap PrewittGy(Bitmap goruntu)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;

            Bitmap sonuc = new Bitmap(genislik, yukseklik);

            int[,] kernelGy = new int[3, 3]
            {
                { -1, -1, -1 },
                {  0,  0,  0 },
                {  1,  1,  1 }
            };

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    int toplam = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            int komsuX = SinirKontrol(x + kx, genislik);
                            int komsuY = SinirKontrol(y + ky, yukseklik);

                            int griDeger = GriDegerHesapla(goruntu.GetPixel(komsuX, komsuY));
                            toplam += griDeger * kernelGy[ky + 1, kx + 1];
                        }
                    }

                    int yeniDeger = Math.Abs(toplam);
                    if (yeniDeger > 255) yeniDeger = 255;

                    sonuc.SetPixel(x, y, Color.FromArgb(yeniDeger, yeniDeger, yeniDeger));
                }
            }

            return sonuc;
        }
        public Bitmap PrewittBirlesik(Bitmap goruntu)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;

            Bitmap sonuc = new Bitmap(genislik, yukseklik);

            int[,] kernelGx = new int[3, 3]
            {
                { -1,  0,  1 },
                { -1,  0,  1 },
                { -1,  0,  1 }
            };

            int[,] kernelGy = new int[3, 3]
            {
                { -1, -1, -1 },
                {  0,  0,  0 },
                {  1,  1,  1 }
            };

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    int toplamGx = 0;
                    int toplamGy = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            int komsuX = SinirKontrol(x + kx, genislik);
                            int komsuY = SinirKontrol(y + ky, yukseklik);

                            int griDeger = GriDegerHesapla(goruntu.GetPixel(komsuX, komsuY));
                            toplamGx += griDeger * kernelGx[ky + 1, kx + 1];
                            toplamGy += griDeger * kernelGy[ky + 1, kx + 1];
                        }
                    }

                    // Birlesik: sqrt(Gx² + Gy²)
                    int yeniDeger = (int)Math.Sqrt(toplamGx * toplamGx + toplamGy * toplamGy);
                    if (yeniDeger > 255) yeniDeger = 255;

                    sonuc.SetPixel(x, y, Color.FromArgb(yeniDeger, yeniDeger, yeniDeger));
                }
            }

            return sonuc;
        }
    }
}