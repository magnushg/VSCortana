using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using WebEye.Controls.WinForms.WebCameraControl;

namespace CamCaptureLib
{
    public class CamCam
    {
        private WebCameraControl cameraControl;
        private Microsoft.ProjectOxford.Emotion.EmotionServiceClient emotionServiceClient;
        private Timer timer;

        public CamCam()
        {
            cameraControl = new WebCameraControl();
            emotionServiceClient = new EmotionServiceClient("8b4b168fcc6a49fa89ad9ae67cc245f4");
           
            timer = new Timer(10000);
            timer.Elapsed += timer_Elapsed;
            Start();
        }

        async void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var result = await GetEmotions();
            var data = result.ToList();
        }

        public async Task<Emotion[]> GetEmotions()
        {
            var x = cameraControl.GetCurrentImage();
            var tmpFile = Path.GetTempFileName();
            x.Save(tmpFile);
            var result = await emotionServiceClient.RecognizeAsync(File.OpenRead(tmpFile));
            return result;
        }

        public bool Start()
        {
            var id = cameraControl.GetVideoCaptureDevices().FirstOrDefault();
            if (id == null)
                return false;
            cameraControl.StartCapture(id);
      //      timer.Start();
            return true;
        }
    }
}
