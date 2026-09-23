using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görüntü_işleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private Form _currentScreen = null;



        private void OpenScreen(Form newScreen)
        {

            if (_currentScreen != null && !_currentScreen.IsDisposed)
                _currentScreen.Close();

            _currentScreen = newScreen;
            newScreen.MdiParent = this;
            newScreen.FormClosed += (s, e) => _currentScreen = null;
            newScreen.StartPosition = FormStartPosition.Manual;
            newScreen.Location = new Point(10, 10);
            newScreen.Show();
        }


        private void btnTo_Gray_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.To_GrayScreen());
   
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {

                OpenScreen(new Screens.BinaryScreen());
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.RotateScreen());
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.CropScreen());

        }

        private void btnZoom_In_Out_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.Zoom_In_Out_Screen());

        }

        private void btnColor_Space_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.Color_SpaceScreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

    

        private void btnContrastEnhancement_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.ContrastEnhancementScreen());
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.HistogramScreen());

        }

        private void btnAritmetikİslemler_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.AdditionAndDivisionScreen());

        }

        private void btnKovolusyonİslemler_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.Konvolusyon_MeanScreen());

        }

        private void btnEsikİslemler_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.EsiklemeScreen());
            
        }

        private void btnKenarBulma_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.KenarBulma_prewittScreen());

        }

        private void btnGurultuEklemeTemizleme_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.GurultuEkleme_TemizlemeScreen());

        }

        private void btnFiltreUygulamasi_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.FiltreUygulanması_UnsharpScreen());

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.Morfolojik_İslemlerScreen());

        }

        private void btnMultipleOperations_Click(object sender, EventArgs e)
        {
            OpenScreen(new Screens.MultipleOperationsScreen());
        }
    }
}
