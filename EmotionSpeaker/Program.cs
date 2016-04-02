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
            var emotions =  cam.GetEmotions();
            Thread.Sleep(10000);
            if (emotions.IsCompleted)
            {
                Console.WriteLine(emotions.Result.BuildError());
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();
        }
    }
}
