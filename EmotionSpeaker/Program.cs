using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CamCaptureLib;

namespace EmotionSpeaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var cam = new CamCam();

            Task.Run(async () => {
                                     var emotions = await cam.GetEmotions();
                                     Console.WriteLine("error");
                                     Console.ReadLine();

            });
            Thread.Sleep(10000);
        }
    }
}
