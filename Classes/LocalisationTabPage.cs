using System;
using System.Device.Location;
using System.Linq;
using System.Windows.Forms;

namespace DevNatifM2.Classes
{
    internal class LocalisationTabPage
    {
        private string mapUrl;
        private Label lbLocalisation;
        private GeoCoordinateWatcher geoWatcher;
        private WebBrowser wbMap;
        private Button btnGeo;

        public LocalisationTabPage(TabPage tabPage) {
            lbLocalisation = tabPage.Controls.Find("lbLocalisation", true).FirstOrDefault() as Label;
            wbMap = tabPage.Controls.Find("wbMap", true).FirstOrDefault() as WebBrowser;
            btnGeo = tabPage.Controls.Find("btnGeo", true).FirstOrDefault() as Button;

            mapUrl = string.Empty;
            btnGeo.Click += btnGeo_Click;



            geoWatcher = new GeoCoordinateWatcher();
            geoWatcher.PositionChanged += GeoWatcher_PositionChanged;
            geoWatcher.Start();
        }

        private void GeoWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            double latitude = e.Position.Location.Latitude;
            double longitude = e.Position.Location.Longitude;

            lbLocalisation.Text = $"Latitude : {latitude}, Longitude : {longitude}";

            mapUrl = (string) $"https://www.google.com/maps/search/?api=1&query={latitude}%2C-{longitude}";
        }

        private void btnGeo_Click(object sender, EventArgs e)
        {
            wbMap.Navigate(mapUrl);
        }
    }
}
