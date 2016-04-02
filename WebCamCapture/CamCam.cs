using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using WebEye.Controls.WinForms.WebCameraControl;

namespace CamCaptureLib
{
    public class CamCam
    {
        private WebCameraControl cameraControl;
        private Timer timer;

        public CamCam()
        {
            cameraControl = new WebCameraControl();
            timer = new Timer(1000);
            timer.Elapsed += timer_Elapsed;
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
           var x =  cameraControl.GetCurrentImage();
        }

        public bool Start()
        {
            var id = cameraControl.GetVideoCaptureDevices().FirstOrDefault();
            if (id == null)
                return false;
            cameraControl.StartCapture(id);
            timer.Start();
            return true;
        }
    }
}
