using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CamCaptureLib
{
    public class Programmer
    {
        CamCam camcam = new CamCam();
        public Programmer()
        {
        }

        public async  Task<string> BuildError()
        {
          var emotion = await  camcam.GetEmotions();
            if (emotion.Any())
            {
                if (emotion.First().Scores.Surprise > 0.5)
                {
                    return "Dont look so supprised, you broke the build!";
                }
                if (emotion.First().Scores.Fear > 0.5)
                {
                    return "Dont worry.. nobody will notice you broke the build!";
                }
                if (emotion.First().Scores.Anger > 0.5)
                {
                    return "I know how you feel!";
                }

                if (emotion.First().Scores.Disgust > 0.5)
                {
                    return "Dont worry.. nobody will notice you broke the build!";
                }

                if (emotion.First().Scores.Happiness > 0.5)
                {
                    return "Dont worry.. nobody will notice you broke the build!";
                }
                if (emotion.First().Scores.Sadness > 0.5)
                {
                    return "Cheer up! I Know you can do this!";
                }
            }
            else
            {
                return "Programmer has left the building!";
            }
            return "That's right, pretend this never happened!";
        }
    }
}
