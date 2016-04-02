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
                    return "I'm just as suprised as you, but you broke the build!";
                }
                if (Emotions.First().Scores.Fear > 0.5)
                {
                    //Relax, its only ONES and ZEROS !
                    return "Dont worry.. nobody will notice you broke the build!";
                }
                if (Emotions.First().Scores.Anger > 0.5)
                {
                    //For every minute you remain angry, you give up sixty seconds of peace of mind.
                    //When anger rises, think of the consequences.
                    //Anger is a momentary madness, so control your passion or it will control you.
                    //There's nothing wrong with anger provided you use it constructively.
                    return "I know how you feel!";
                }

                if (Emotions.First().Scores.Disgust > 0.5)
                {
                    return "Don’t worry if it doesn’t work right. If everything did, you’d be out of a job.";
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
            //In my experience there is no such thing as luck.

            return "Hey! It compiles! Ship it!";
        }

        public string RunTests()
        {

            return "Well done!";
        }

        public string Exception()
        {
            return
                "The great thing about Object Oriented code is that it can make small, simple problems look like large, complex ones";
            //Don’t fix bugs later; fix them now.
            //Never allow the same bug to bite you twice.
            //"Engineers call them edge cases. I call them: what our users do.”
            // The world is coming to an end... SAVE YOUR BUFFERS !"


        }
    }
}
