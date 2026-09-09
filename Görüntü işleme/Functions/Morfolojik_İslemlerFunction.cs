using System;
using System.Drawing;

namespace Görüntü_işleme.Functions
{
    internal class Morfolojik_IslemlerFunction
    {
       
        private int[,] yapisalEleman = new int[,]
        {
            { 0, 1, 0 },
            { 1, 1, 1 },
            { 0, 1, 0 }
        };

        private int YapisalElemanGenisligi => yapisalEleman.GetLength(1);
        private int YapisalElemanYuksekligi => yapisalEleman.GetLength(0);
        private int YapisalElemanMerkezSutunu => YapisalElemanGenisligi / 2;
        private int YapisalElemanMerkezSatiri => YapisalElemanYuksekligi / 2;

       
        public void YapisalElemaniGuncelle(int[,] yeniYapisalEleman)
        {
            yapisalEleman = yeniYapisalEleman;
        }
        
        private bool GorselZatenIkiliMi(Bitmap kontrolEdilecekGorsel)
        {
            int gorselGenisligi = kontrolEdilecekGorsel.Width;
            int gorselYuksekligi = kontrolEdilecekGorsel.Height;

            for (int satirIndeksi = 0; satirIndeksi < gorselYuksekligi; satirIndeksi++)
            {
                for (int sutunIndeksi = 0; sutunIndeksi < gorselGenisligi; sutunIndeksi++)
                {
                    Color mevcutPiksel = kontrolEdilecekGorsel.GetPixel(sutunIndeksi, satirIndeksi);

                    bool kirmiziBileseniIkiliDegil = (mevcutPiksel.R != 0 && mevcutPiksel.R != 255);
                    bool yesilBileseniIkiliDegil = (mevcutPiksel.G != 0 && mevcutPiksel.G != 255);
                    bool maviBlieseniIkiliDegil = (mevcutPiksel.B != 0 && mevcutPiksel.B != 255);

                    if (kirmiziBileseniIkiliDegil || yesilBileseniIkiliDegil || maviBlieseniIkiliDegil)
                        return false;
                }
            }

            return true;
        }
        private Bitmap GorseliIkiliFormaHazirla(Bitmap girdiGorseli)
        {
            if (GorselZatenIkiliMi(girdiGorseli))
                return girdiGorseli;

            int gorselGenisligi = girdiGorseli.Width;
            int gorselYuksekligi = girdiGorseli.Height;

            Bitmap ikiliBitmap = new Bitmap(gorselGenisligi, gorselYuksekligi);

            for (int satirIndeksi = 0; satirIndeksi < gorselYuksekligi; satirIndeksi++)
            {
                for (int sutunIndeksi = 0; sutunIndeksi < gorselGenisligi; sutunIndeksi++)
                {
                    Color mevcutPiksel = girdiGorseli.GetPixel(sutunIndeksi, satirIndeksi);

                    int griTonDegeri = (int)(mevcutPiksel.R * 0.299
                                          + mevcutPiksel.G * 0.587
                                          + mevcutPiksel.B * 0.114);

                    int ikilPikselDegeri = (griTonDegeri >= 128) ? 255 : 0;

                    ikiliBitmap.SetPixel(sutunIndeksi, satirIndeksi,
                        Color.FromArgb(ikilPikselDegeri, ikilPikselDegeri, ikilPikselDegeri));
                }
            }

            return ikiliBitmap;
        }
        private bool PikselBeyazMi(Bitmap kontrolEdilecekGorsel, int sutunIndeksi, int satirIndeksi)
        {
            return kontrolEdilecekGorsel.GetPixel(sutunIndeksi, satirIndeksi).R == 255;
        }
        public Bitmap GenislemeyiUygula(Bitmap girdiGorseli)
        {
            Bitmap ikiliBitmap = GorseliIkiliFormaHazirla(girdiGorseli);
            int gorselGenisligi = ikiliBitmap.Width;
            int gorselYuksekligi = ikiliBitmap.Height;

            Bitmap sonucBitmap = new Bitmap(gorselGenisligi, gorselYuksekligi);

            for (int satirIndeksi = 0; satirIndeksi < gorselYuksekligi; satirIndeksi++)
            {
                for (int sutunIndeksi = 0; sutunIndeksi < gorselGenisligi; sutunIndeksi++)
                {
                    bool yapisalElemanKapsamindaEnAzBirBeyazPikselVarMi = false;

                    for (int elemanSatiri = 0; elemanSatiri < YapisalElemanYuksekligi; elemanSatiri++)
                    {
                        for (int elemanSutunu = 0; elemanSutunu < YapisalElemanGenisligi; elemanSutunu++)
                        {
                            if (yapisalEleman[elemanSatiri, elemanSutunu] == 0) continue;

                            int komsununSutunIndeksi = sutunIndeksi + (elemanSutunu - YapisalElemanMerkezSutunu);
                            int komsununSatirIndeksi = satirIndeksi + (elemanSatiri - YapisalElemanMerkezSatiri);

                            if (komsununSutunIndeksi < 0) komsununSutunIndeksi = 0;
                            if (komsununSutunIndeksi >= gorselGenisligi) komsununSutunIndeksi = gorselGenisligi - 1;
                            if (komsununSatirIndeksi < 0) komsununSatirIndeksi = 0;
                            if (komsununSatirIndeksi >= gorselYuksekligi) komsununSatirIndeksi = gorselYuksekligi - 1;

                            if (PikselBeyazMi(ikiliBitmap, komsununSutunIndeksi, komsununSatirIndeksi))
                            {
                                yapisalElemanKapsamindaEnAzBirBeyazPikselVarMi = true;
                                break;
                            }
                        }
                        if (yapisalElemanKapsamindaEnAzBirBeyazPikselVarMi) break;
                    }

                    sonucBitmap.SetPixel(sutunIndeksi, satirIndeksi,
                        yapisalElemanKapsamindaEnAzBirBeyazPikselVarMi ? Color.White : Color.Black);
                }
            }

            return sonucBitmap;
        }
        public Bitmap AsinmayiUygula(Bitmap girdiGorseli)
        {
            Bitmap ikiliBitmap = GorseliIkiliFormaHazirla(girdiGorseli);
            int gorselGenisligi = ikiliBitmap.Width;
            int gorselYuksekligi = ikiliBitmap.Height;

            Bitmap sonucBitmap = new Bitmap(gorselGenisligi, gorselYuksekligi);

            for (int satirIndeksi = 0; satirIndeksi < gorselYuksekligi; satirIndeksi++)
            {
                for (int sutunIndeksi = 0; sutunIndeksi < gorselGenisligi; sutunIndeksi++)
                {
                    bool yapisalElemanKapsamindakiTumPiksellerBeyazMi = true;

                    for (int elemanSatiri = 0; elemanSatiri < YapisalElemanYuksekligi; elemanSatiri++)
                    {
                        for (int elemanSutunu = 0; elemanSutunu < YapisalElemanGenisligi; elemanSutunu++)
                        {
                            if (yapisalEleman[elemanSatiri, elemanSutunu] == 0) continue;

                            int komsununSutunIndeksi = sutunIndeksi + (elemanSutunu - YapisalElemanMerkezSutunu);
                            int komsununSatirIndeksi = satirIndeksi + (elemanSatiri - YapisalElemanMerkezSatiri);

                            if (komsununSutunIndeksi < 0) komsununSutunIndeksi = 0;
                            if (komsununSutunIndeksi >= gorselGenisligi) komsununSutunIndeksi = gorselGenisligi - 1;
                            if (komsununSatirIndeksi < 0) komsununSatirIndeksi = 0;
                            if (komsununSatirIndeksi >= gorselYuksekligi) komsununSatirIndeksi = gorselYuksekligi - 1;

                            if (!PikselBeyazMi(ikiliBitmap, komsununSutunIndeksi, komsununSatirIndeksi))
                            {
                                yapisalElemanKapsamindakiTumPiksellerBeyazMi = false;
                                break;
                            }
                        }
                        if (!yapisalElemanKapsamindakiTumPiksellerBeyazMi) break;
                    }

                    sonucBitmap.SetPixel(sutunIndeksi, satirIndeksi,
                        yapisalElemanKapsamindakiTumPiksellerBeyazMi ? Color.White : Color.Black);
                }
            }

            return sonucBitmap;
        }
        public Bitmap AcmaIsleminiUygula(Bitmap girdiGorseli)
        {
            Bitmap asinmaUygulanmisGorsel = AsinmayiUygula(girdiGorseli);
            Bitmap genislemeUygulanmisGorsel = GenislemeyiUygula(asinmaUygulanmisGorsel);
            return genislemeUygulanmisGorsel;
        }
        public Bitmap KapamaIsleminiUygula(Bitmap girdiGorseli)
        {
            Bitmap genislemeUygulanmisGorsel = GenislemeyiUygula(girdiGorseli);
            Bitmap asinmaUygulanmisGorsel = AsinmayiUygula(genislemeUygulanmisGorsel);
            return asinmaUygulanmisGorsel;
        }
        public Bitmap IslemlerdKullanilanIkiliGorseliGetir(Bitmap girdiGorseli)
        {
            return GorseliIkiliFormaHazirla(girdiGorseli);
        }
    }
}