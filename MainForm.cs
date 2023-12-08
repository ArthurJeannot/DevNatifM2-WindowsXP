using System;
using System.Windows.Forms;
using DevNatifM2.Classes;

namespace DevNatifM2
{
    public partial class MainForm : Form
    {
        private CameraTabPage cameraTabPage;
        private LocalisationTabPage localisationTabPage;
        private MicroTabPage microTabPage;
        private CompteTabPage compteTabPage;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cameraTabPage = new CameraTabPage(tabCamera);
            localisationTabPage = new LocalisationTabPage(tabLocalisation);
            microTabPage = new MicroTabPage(tabMicro);
            compteTabPage = new CompteTabPage(tabCompte);
        }

        private void reset()
        {
            cameraTabPage.StopCamera();
            microTabPage.StopRepeat();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reset();
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();
        }
    }
}
