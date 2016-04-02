using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamCaptureLib
{
    class CamCoder
    {
        CamCam camcam = new CamCam();

        public CamCoder()
        {
            camcam.Start();
        }


        public string BuildFailed()
        {

            return "";
        }

    }
}
