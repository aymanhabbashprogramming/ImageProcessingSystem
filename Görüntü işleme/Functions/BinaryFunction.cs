using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class BinaryFunction
    {

        public static bool BinaryDonusturme(
            Bitmap girisGoruntusu,
            out Bitmap cikisGoruntusu,
            int esikDegeri)
        {
            try
            {
                int goruntuGenisligi = girisGoruntusu.Width;
                int goruntuYuksekligi = girisGoruntusu.Height;

                cikisGoruntusu = new Bitmap(goruntuGenisligi, goruntuYuksekligi);

                for (int pikselY = 0; pikselY < goruntuYuksekligi; pikselY++)
                {
                    for (int pikselX = 0; pikselX < goruntuGenisligi; pikselX++)
                    {
               
                        Color mevcutPiksel = girisGoruntusu.GetPixel(pikselX, pikselY);

             
                        int griDeger =
                            (int)(mevcutPiksel.R * 0.299 +
                                  mevcutPiksel.G * 0.587 +
                                  mevcutPiksel.B * 0.114);

                  
                        int yeniDeger = (griDeger > esikDegeri) ? 255 : 0;

                        Color yeniPiksel = Color.FromArgb(yeniDeger, yeniDeger, yeniDeger);

                        cikisGoruntusu.SetPixel(pikselX, pikselY, yeniPiksel);
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
