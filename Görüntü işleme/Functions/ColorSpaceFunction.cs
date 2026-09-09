using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class ColorSpaceFunction
    {
        public static bool ToYUV(Bitmap giris, out Bitmap cikis)
        {
            try
            {
                cikis = new Bitmap(giris.Width, giris.Height);
                for (int x = 0; x < giris.Width; x++)
                    for (int y = 0; y < giris.Height; y++)
                    {
                        Color c = giris.GetPixel(x, y);

                        int Y = (int)(0.257 * c.R + 0.504 * c.G + 0.098 * c.B + 16);
                        int Cb = (int)(-0.148 * c.R - 0.291 * c.G + 0.439 * c.B + 128);
                        int Cr = (int)(0.439 * c.R - 0.368 * c.G - 0.071 * c.B + 128);

                        Y = Math.Max(0, Math.Min(255, Y));
                        Cb = Math.Max(0, Math.Min(255, Cb));
                        Cr = Math.Max(0, Math.Min(255, Cr));

                        cikis.SetPixel(x, y, Color.FromArgb(Y, Cb, Cr));
                    }
                return true;
            }
            catch { cikis = null; return false; }
        }

        public static bool YUVToRGB(Bitmap giris, out Bitmap cikis)
        {
            try
            {
                cikis = new Bitmap(giris.Width, giris.Height);
                for (int x = 0; x < giris.Width; x++)
                    for (int y = 0; y < giris.Height; y++)
                    {
                        Color c = giris.GetPixel(x, y);

                        double Y = c.R;
                        double Cb = c.G;
                        double Cr = c.B;

                        int R = (int)(1.164 * (Y - 16) + 1.596 * (Cr - 128));
                        int G = (int)(1.164 * (Y - 16) - 0.392 * (Cb - 128) - 0.813 * (Cr - 128));
                        int B = (int)(1.164 * (Y - 16) + 2.017 * (Cb - 128));

                        R = Math.Max(0, Math.Min(255, R));
                        G = Math.Max(0, Math.Min(255, G));
                        B = Math.Max(0, Math.Min(255, B));

                        cikis.SetPixel(x, y, Color.FromArgb(R, G, B));
                    }
                return true;
            }
            catch { cikis = null; return false; }
        }

        public static bool ToHSV(Bitmap giris, out Bitmap cikis)
        {
            try
            {
                cikis = new Bitmap(giris.Width, giris.Height);
                for (int x = 0; x < giris.Width; x++)
                    for (int y = 0; y < giris.Height; y++)
                    {
                        Color c = giris.GetPixel(x, y);

                        double R = c.R / 255.0;
                        double G = c.G / 255.0;
                        double B = c.B / 255.0;

                        double max = Math.Max(R, Math.Max(G, B));
                        double min = Math.Min(R, Math.Min(G, B));
                        double delta = max - min;

                        double H = 0;
                        if (delta != 0)
                        {
                            if (max == R) H = 60 * (((G - B) / delta) % 6);
                            else if (max == G) H = 60 * (((B - R) / delta) + 2);
                            else H = 60 * (((R - G) / delta) + 4);
                        }
                        if (H < 0) H += 360;

                        double S = (max == 0) ? 0 : delta / max;
                        double V = max;

                        int hVal = Math.Max(0, Math.Min(255, (int)(H / 360.0 * 255)));
                        int sVal = Math.Max(0, Math.Min(255, (int)(S * 255)));
                        int vVal = Math.Max(0, Math.Min(255, (int)(V * 255)));

                        cikis.SetPixel(x, y, Color.FromArgb(hVal, sVal, vVal));
                    }
                return true;
            }
            catch { cikis = null; return false; }
        }

        public static bool HSVToRGB(Bitmap giris, out Bitmap cikis)
        {
            try
            {
                cikis = new Bitmap(giris.Width, giris.Height);
                for (int x = 0; x < giris.Width; x++)
                    for (int y = 0; y < giris.Height; y++)
                    {
                        Color c = giris.GetPixel(x, y);

                        double H = c.R / 255.0 * 360.0;
                        double S = c.G / 255.0;
                        double V = c.B / 255.0;

                        double R = 0, G = 0, B = 0;

                        if (S == 0)
                        {
                            R = G = B = V;
                        }
                        else
                        {
                            double h = H / 60.0;
                            int i = (int)Math.Floor(h);
                            double f = h - i;
                            double p = V * (1 - S);
                            double q = V * (1 - S * f);
                            double t = V * (1 - S * (1 - f));

                            switch (i)
                            {
                                case 0: R = V; G = t; B = p; break;
                                case 1: R = q; G = V; B = p; break;
                                case 2: R = p; G = V; B = t; break;
                                case 3: R = p; G = q; B = V; break;
                                case 4: R = t; G = p; B = V; break;
                                default: R = V; G = p; B = q; break;
                            }
                        }

                        int rVal = Math.Max(0, Math.Min(255, (int)(R * 255)));
                        int gVal = Math.Max(0, Math.Min(255, (int)(G * 255)));
                        int bVal = Math.Max(0, Math.Min(255, (int)(B * 255)));

                        cikis.SetPixel(x, y, Color.FromArgb(rVal, gVal, bVal));
                    }
                return true;
            }
            catch { cikis = null; return false; }
        }
    }
}