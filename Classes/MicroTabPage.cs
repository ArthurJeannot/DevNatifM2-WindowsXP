using System;
using System.Linq;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using NAudio.Wave;

namespace DevNatifM2.Classes
{
    internal class MicroTabPage
    {
        private Button btnRecord;
        private ComboBox cbListMicro;
        private WaveIn sourceStream = null;
        private DirectSoundOut waveOut = null;
        private WaveFileWriter waveWriter = null;
        private FilterInfoCollection filterInfoCollection;

        private bool isRepeating = false;

        public MicroTabPage(TabPage tabPage)
        {
            btnRecord = tabPage.Controls.Find("btnRecord", true).FirstOrDefault() as Button;
            cbListMicro = tabPage.Controls.Find("cbListMicro", true).FirstOrDefault() as ComboBox;

            filterInfoCollection = new FilterInfoCollection(FilterCategory.AudioInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection) cbListMicro.Items.Add(filterInfo.Name);

            cbListMicro.SelectedIndex = 0;

            btnRecord.Click += BtnRepeat_Click;
        }

        public void StopRepeat()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.DataAvailable -= SourceStream_DataAvailable;
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (isRepeating)
            {
                isRepeating = false;
                btnRecord.Text = "Activer la répétition";
            }
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            if (!isRepeating)
            {
                int deviceNumber = cbListMicro.SelectedIndex;

                sourceStream = new WaveIn();
                sourceStream.DeviceNumber = deviceNumber;
                sourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceNumber).Channels);

                sourceStream.DataAvailable += SourceStream_DataAvailable;

                waveOut = new DirectSoundOut();
                waveOut.Init(new WaveInProvider(sourceStream));

                sourceStream.StartRecording();
                waveOut.Play();

                isRepeating = true;
                btnRecord.Text = "Arrêter la répétition";
            }
            else
            {
                StopRepeat();
            }
        }

        //WIP enregistrement
        private void SourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveWriter == null)
            {
                waveWriter = new WaveFileWriter("output.wav", sourceStream.WaveFormat);
            }

            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }
    }
}
