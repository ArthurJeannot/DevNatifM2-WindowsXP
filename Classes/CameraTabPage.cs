using AForge.Video.DirectShow;
using AForge.Video;
using System.Drawing;
using System;
using System.Windows.Forms;
using System.Linq;

namespace DevNatifM2.Classes
{
    internal class CameraTabPage
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;
        private ComboBox cbCameraList;
        private PictureBox picCamera;
        private Button btnCamera;
        private Button btnPicture;
        private bool isFilming;

        public CameraTabPage(TabPage tabPage)
        {
            cbCameraList = tabPage.Controls.Find("cbCameraList", true).FirstOrDefault() as ComboBox;
            picCamera = tabPage.Controls.Find("picCamera", true).FirstOrDefault() as PictureBox;
            btnCamera = tabPage.Controls.Find("btnCamera", true).FirstOrDefault() as Button;
            btnPicture = tabPage.Controls.Find("btnPicture", true).FirstOrDefault() as Button;

            btnCamera.Click += BtnCamera_Click;
            btnPicture.Click += BtnPicture_Click;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection) cbCameraList.Items.Add(filterInfo.Name);

            cbCameraList.SelectedIndex = 0;
            cbCameraList.SelectedIndexChanged += cbCameraList_SelectedIndexChanged;
            videoCaptureDevice = new VideoCaptureDevice();
        }


        public void StopCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                isFilming = false;
                picCamera.Image = null;
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                btnCamera.Text = "Allumer";
                btnPicture.Enabled = false;
            }
        }

        private Bitmap ResizeImage(Bitmap source, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                g.DrawImage(source, 0, 0, width, height);
            }

            return result;
        }

        #region event
        private void BtnCamera_Click(object sender, EventArgs e)
        {
            if (!isFilming)
            {
                isFilming = true;
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCameraList.SelectedIndex].MonikerString);

                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();

                btnPicture.Enabled = true;
                btnCamera.Text = "Éteindre";
            }
            else
            {
                StopCamera();
            }
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Fichiers image (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                saveFileDialog.Title = "Enregistrer l'image";
                saveFileDialog.DefaultExt = "jpg";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    if (picCamera.Image != null)
                    {
                        Bitmap imageToSave = (Bitmap)picCamera.Image.Clone();
                        imageToSave.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageToSave.Dispose();
                    }
                }
            }
        }




        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            picCamera.Image = ResizeImage(frame, picCamera.Width, picCamera.Height);
        }

        private void cbCameraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopCamera();
        }
        #endregion

    }
}