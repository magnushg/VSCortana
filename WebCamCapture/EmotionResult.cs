using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Emotion.Contract;

namespace CamCaptureLib
{
    public class EmotionResult
    {
        public Emotion[] Emotions { get; set; }
        public Image Image { get; set; }



        public string BuildError()
        {

            if (Emotions!= null && Emotions.Any())
            {
                if (Emotions.First().Scores.Surprise > 0.5)
                {
                    return "Dont look so supprised, you broke the build!";
                }
                if (Emotions.First().Scores.Fear > 0.5)
                {
                    return "Dont worry.. nobody will notice you broke the build!";
                }
                if (Emotions.First().Scores.Anger > 0.5)
                {
                    return "I know how you feel!";
                }

                if (Emotions.First().Scores.Disgust > 0.5)
                {
                    return "Dont worry.. nobody will notice you broke the build!";
                }

                if (Emotions.First().Scores.Happiness > 0.5)
                {
                    return "Dont worry.. nobody will notice you broke the build!";
                }
                if (Emotions.First().Scores.Sadness > 0.5)
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

        public string BuildOK()
        {
            return "Way to go!";
        }

        public string RunTests()
        {
            return "Well done!";
        }
    }
}
