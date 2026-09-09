using System;
using System.Drawing;
using System.Windows.Forms;
using Görüntü_işleme.Functions;

namespace Görüntü_işleme.Screens
{
    public partial class Morfolojik_İslemlerScreen : Form
    {
        private Bitmap orijinalGoruntu = null;
        private Bitmap genislemeSonucGorseli = null;
        private Bitmap asinmaSonucGorseli = null;
        private Bitmap acmaSonucGorseli = null;
        private Bitmap kapamaSonucGorseli = null;

        private Morfolojik_IslemlerFunction morfolojikIslemlerFonksiyonu = new Morfolojik_IslemlerFunction();

        public Morfolojik_İslemlerScreen()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------
        // Goruntu ac
        // -------------------------------------------------------
        private void OpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog gorselSecmeDiyalogu = new OpenFileDialog();
            gorselSecmeDiyalogu.Filter = "Resim Dosyalari|*.jpg;*.jpeg;*.png;*.bmp";

            if (gorselSecmeDiyalogu.ShowDialog() == DialogResult.OK)
            {
                orijinalGoruntu = new Bitmap(gorselSecmeDiyalogu.FileName);
                OrijinalImage.Image = orijinalGoruntu;
                OrijinalImage.SizeMode = PictureBoxSizeMode.Zoom;

                GenislemeImage.Image = null;
                AsinmaImage.Image = null;
                AcmaImage.Image = null;
                KapamaImage.Image = null;
                PicikiliGorsel.Image = null;

                genislemeSonucGorseli = null;
                asinmaSonucGorseli = null;
                acmaSonucGorseli = null;
                kapamaSonucGorseli = null;
            }
        }

        // -------------------------------------------------------
        // Yapısal Eleman → Kare (3x3 tüm hücreler 1)
        // -------------------------------------------------------
        private void KareYapisalElemanSec_Click(object sender, EventArgs e)
        {
            int[,] kareYapisalEleman = new int[,]
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };
            morfolojikIslemlerFonksiyonu.YapisalElemaniGuncelle(kareYapisalEleman);
            MessageBox.Show("Yapısal eleman: 3x3 Kare olarak ayarlandı.", "Bilgi");
        }

        // -------------------------------------------------------
        // Yapısal Eleman → Artı (+) şekli
        // -------------------------------------------------------
        private void ArtisYapisalElemanSec_Click(object sender, EventArgs e)
        {
            int[,] artisYapisalEleman = new int[,]
            {
                { 0, 1, 0 },
                { 1, 1, 1 },
                { 0, 1, 0 }
            };
            morfolojikIslemlerFonksiyonu.YapisalElemaniGuncelle(artisYapisalEleman);
            MessageBox.Show("Yapısal eleman: Artı (+) şekli olarak ayarlandı.", "Bilgi");
        }

        // -------------------------------------------------------
        // Genisleme
        // -------------------------------------------------------
        private void btnPerformGenisleme_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            genislemeSonucGorseli = morfolojikIslemlerFonksiyonu.GenislemeyiUygula(orijinalGoruntu);
            GenislemeImage.Image = genislemeSonucGorseli;
            GenislemeImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnBeforeGenisleme_Click(object sender, EventArgs e)
        {
            genislemeSonucGorseli = null;
            GenislemeImage.Image = null;
        }

        private void btnSaveGenisleme_Click(object sender, EventArgs e)
        {
            GorseliDosyayaKaydet(genislemeSonucGorseli);
        }

        // -------------------------------------------------------
        // Asinma
        // -------------------------------------------------------
        private void btnPerformAsinma_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            asinmaSonucGorseli = morfolojikIslemlerFonksiyonu.AsinmayiUygula(orijinalGoruntu);
            AsinmaImage.Image = asinmaSonucGorseli;
            AsinmaImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnBeforeAsinma_Click(object sender, EventArgs e)
        {
            asinmaSonucGorseli = null;
            AsinmaImage.Image = null;
        }

        private void btnSaveAsinma_Click(object sender, EventArgs e)
        {
            GorseliDosyayaKaydet(asinmaSonucGorseli);
        }

        // -------------------------------------------------------
        // Acma
        // -------------------------------------------------------
        private void btnPerformAcma_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            acmaSonucGorseli = morfolojikIslemlerFonksiyonu.AcmaIsleminiUygula(orijinalGoruntu);
            AcmaImage.Image = acmaSonucGorseli;
            AcmaImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnBeforeAcma_Click(object sender, EventArgs e)
        {
            acmaSonucGorseli = null;
            AcmaImage.Image = null;
        }

        private void btnSaveAcma_Click(object sender, EventArgs e)
        {
            GorseliDosyayaKaydet(acmaSonucGorseli);
        }

        // -------------------------------------------------------
        // Kapama
        // -------------------------------------------------------
        private void btnPerformKapama_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            kapamaSonucGorseli = morfolojikIslemlerFonksiyonu.KapamaIsleminiUygula(orijinalGoruntu);
            KapamaImage.Image = kapamaSonucGorseli;
            KapamaImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnBeforeKapama_Click(object sender, EventArgs e)
        {
            kapamaSonucGorseli = null;
            KapamaImage.Image = null;
        }

        private void btnSaveKapama_Click(object sender, EventArgs e)
        {
            GorseliDosyayaKaydet(kapamaSonucGorseli);
        }

        // -------------------------------------------------------
        // Kaydet — ortak fonksiyon
        // -------------------------------------------------------
        private void GorseliDosyayaKaydet(Bitmap kaydedilecekGorsel)
        {
            if (kaydedilecekGorsel == null)
            {
                MessageBox.Show("Kaydedilecek goruntu bulunamadi.", "Uyari");
                return;
            }

            SaveFileDialog gorselKaydetmeDiyalogu = new SaveFileDialog();
            gorselKaydetmeDiyalogu.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";

            if (gorselKaydetmeDiyalogu.ShowDialog() == DialogResult.OK)
            {
                kaydedilecekGorsel.Save(gorselKaydetmeDiyalogu.FileName);
                MessageBox.Show("Goruntu basariyla kaydedildi.", "Bilgi");
            }
        }

        // -------------------------------------------------------
        // İşlemlerde kullanılan ikili görseli PicikiliGorsel'de göster
        // -------------------------------------------------------
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (orijinalGoruntu == null)
            {
                MessageBox.Show("Lutfen once bir goruntu yukleyin.", "Uyari");
                return;
            }

            Bitmap islemlerdKullanilanIkiliGorsel =
                morfolojikIslemlerFonksiyonu.IslemlerdKullanilanIkiliGorseliGetir(orijinalGoruntu);

            PicikiliGorsel.Image = islemlerdKullanilanIkiliGorsel;
            PicikiliGorsel.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}