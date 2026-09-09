using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class histogram_germe_genisletmeFunction
    {
        public int[] HistogramHesapla(Bitmap goruntu)
        {
            int[] histogram = new int[256];
            for (int y = 0; y < goruntu.Height; y++)
                for (int x = 0; x < goruntu.Width; x++)
                {
                    Color piksel = goruntu.GetPixel(x, y);
                    int griDeger = (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);
                    histogram[griDeger]++;
                }
            return histogram;
        }

        public Bitmap HistogramGerme(
            Bitmap goruntu,
            out int[] orijinalHistogram,
            out int[] gerilmisHistogram)
        {
            orijinalHistogram = HistogramHesapla(goruntu);

            int minDeger = 255, maxDeger = 0;
            for (int y = 0; y < goruntu.Height; y++)
                for (int x = 0; x < goruntu.Width; x++)
                {
                    Color piksel = goruntu.GetPixel(x, y);
                    int griDeger = (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);
                    if (griDeger < minDeger) minDeger = griDeger;
                    if (griDeger > maxDeger) maxDeger = griDeger;
                }

            if (maxDeger == minDeger)
            {
                gerilmisHistogram = HistogramHesapla(goruntu);
                return goruntu;
            }

            Bitmap sonuc = new Bitmap(goruntu.Width, goruntu.Height);
            for (int y = 0; y < goruntu.Height; y++)
                for (int x = 0; x < goruntu.Width; x++)
                {
                    Color piksel = goruntu.GetPixel(x, y);
                    int griDeger = (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);
                    int yeniDeger = (griDeger - minDeger) * 255 / (maxDeger - minDeger);
                    yeniDeger = Math.Max(0, Math.Min(255, yeniDeger));
                    sonuc.SetPixel(x, y, Color.FromArgb(yeniDeger, yeniDeger, yeniDeger));
                }

            gerilmisHistogram = HistogramHesapla(sonuc);
            return sonuc;
        }

        public Bitmap HistogramGenisletme(
            Bitmap goruntu,
            int a, int b,
            out int[] orijinalHistogram,
            out int[] genisletilmisHistogram)
        {
            orijinalHistogram = HistogramHesapla(goruntu);

            int minDeger = 255, maxDeger = 0;
            for (int y = 0; y < goruntu.Height; y++)
                for (int x = 0; x < goruntu.Width; x++)
                {
                    Color piksel = goruntu.GetPixel(x, y);
                    int griDeger = (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);
                    if (griDeger < minDeger) minDeger = griDeger;
                    if (griDeger > maxDeger) maxDeger = griDeger;
                }

            if (maxDeger == minDeger)
            {
                genisletilmisHistogram = HistogramHesapla(goruntu);
                return goruntu;
            }

            Bitmap sonuc = new Bitmap(goruntu.Width, goruntu.Height);
            for (int y = 0; y < goruntu.Height; y++)
                for (int x = 0; x < goruntu.Width; x++)
                {
                    Color piksel = goruntu.GetPixel(x, y);
                    int griDeger = (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);
                    int yeniDeger = ((griDeger - minDeger) * (b - a) / (maxDeger - minDeger)) + a;
                    yeniDeger = Math.Max(0, Math.Min(255, yeniDeger));
                    sonuc.SetPixel(x, y, Color.FromArgb(yeniDeger, yeniDeger, yeniDeger));
                }

            genisletilmisHistogram = HistogramHesapla(sonuc);
            return sonuc;
        }
    }
}