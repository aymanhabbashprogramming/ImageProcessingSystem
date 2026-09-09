using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class CropFunction
    {

        public static bool GoruntuKirma(
            Bitmap girisGoruntusu,
            out Bitmap cikisGoruntusu,
            int baslangicX,
            int baslangicY,
            int genislik,
            int yukseklik)
        {
            try
            {
                cikisGoruntusu = new Bitmap(genislik, yukseklik);

                for (int yeniY = 0; yeniY < yukseklik; yeniY++)
                {
                    for (int yeniX = 0; yeniX < genislik; yeniX++)
                    {
                        int kaynakX = baslangicX + yeniX;
                        int kaynakY = baslangicY + yeniY;

                        Color kaynakPiksel = girisGoruntusu.GetPixel(kaynakX, kaynakY);

                        cikisGoruntusu.SetPixel(yeniX, yeniY, kaynakPiksel);
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