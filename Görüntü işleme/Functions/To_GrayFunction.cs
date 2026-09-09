using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Görüntü_işleme.Functions
{
    internal class To_GrayFunction
    {

        public static bool ChangeColor(Bitmap bits, double x = 0.299, double y = 0.587, double z = 0.114)
        {
            for (int i = 0; i < bits.Width; i++)
            {
                for (int j = 0; j < bits.Height; j++)
                {
                    Color color = bits.GetPixel(i, j);
                    int Gray = color.R;
                    int Gray1 = color.B;
                    int Gray2 = color.G;
                    int colorModify = (byte)((x * Gray) + (y * Gray1) + (z * Gray2));
                    bits.SetPixel(i,j, Color.FromArgb(colorModify,colorModify,colorModify));
                }
            }
            return true;
        }

    }
}
