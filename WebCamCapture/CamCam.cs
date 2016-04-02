using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;
using WebEye.Controls.WinForms.WebCameraControl;
using Timer = System.Timers.Timer;

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
     
        }

        async void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var result = await GetEmotions();
            var data = result.Emotions.ToList();
        }

        public async Task<EmotionResult> GetEmotions()
        {
            Start();
            for (int xi = 0; xi < 10; xi++)
            {
                var t = cameraControl.GetCurrentImage();
               
            }
            var x = cameraControl.GetCurrentImage();
            Stop();
            var tmpFile = Path.GetTempFileName();
            x.Save(tmpFile);
            var result = await emotionServiceClient.RecognizeAsync(File.OpenRead(tmpFile));
            return new EmotionResult
            {
                Emotions = result,
                Image = x
            };
        }

        private bool Start()
        {
            var id = cameraControl.GetVideoCaptureDevices().FirstOrDefault();
            if (id == null)
                return false;
            cameraControl.StartCapture(id);
      //      timer.Start();
            return true;
        }

        private void  Stop()
        {
            cameraControl.StopCapture();
        }

    }
}
