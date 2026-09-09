using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class EsiklemeFunction
    {

        public Bitmap TekEsikleme(Bitmap goruntu, int esikDegeri)
        {
            int genislik = goruntu.Width;
            int yukseklik = goruntu.Height;

            Bitmap sonucGoruntu = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color piksel = goruntu.GetPixel(x, y);

                    // Once gri degere donustur
                    int griDeger = (int)(piksel.R * 0.299 + piksel.G * 0.587 + piksel.B * 0.114);

                    // Esik karsilastirmasi
                    int yeniDeger = (griDeger >= esikDegeri) ? 255 : 0;

                    sonucGoruntu.SetPixel(x, y, Color.FromArgb(yeniDeger, yeniDeger, yeniDeger));
                }
            }

            return sonucGoruntu;
        }
    }
}