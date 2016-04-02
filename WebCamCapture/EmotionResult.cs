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
            return pickOne(BuildErrorList());
        }

        private static string pickOne(List<string> alternatives)
        {
            if (!alternatives.Any())
                return "";
            var r = new Random();
            var pick = r.Next(alternatives.Count - 1);
            return alternatives[pick];
        }

        public List<string> BuildErrorList()
        {
            var result = new List<string>();
            if (Emotions!= null && Emotions.Any())
            {
                if (Emotions.First().Scores.Surprise > 0.5)
                {
                    result.Add("I'm just as suprised as you, but you broke the build!");
                }
                if (Emotions.First().Scores.Fear > 0.5)
                {
                    result.Add("Dont worry.. nobody will notice you broke the build!");
                    result.Add("Relax, its only ONES and ZEROS!");

                }
                if (Emotions.First().Scores.Anger > 0.5)
                {
                    result.Add("For every minute you remain angry, you give up sixty seconds of peace of mind.");
                    result.Add("When anger rises, think of the consequences.");
                    result.Add("Anger is a momentary madness, so control your passion or it will control you.");
                    result.Add("There's nothing wrong with anger provided you use it constructively.");
                    result.Add("I know how you feel!");
                }

                if (Emotions.First().Scores.Disgust > 0.5)
                {
                     result.Add( "Don’t worry if it doesn’t work right. If everything did, you’d be out of a job.");
                }

                if (Emotions.First().Scores.Happiness > 0.5)
                {
                    result.Add("It's all talk until the code runs.");
                }
                if (Emotions.First().Scores.Sadness > 0.5)
                {
                     result.Add("Cheer up! I Know you can do this!");
                }
            }
            else
            {
                 result.Add("Programmer has left the building!");
            }
            if (!result.Any())
            {
                result.Add("That's right, pretend this never happened!");
            }
            return result;
        }

        public string BuildOK()
        {
            return pickOne(BuildOKList());
        }
        private List<string>  BuildOKList()
        {
            var result = new List<string>
            {
                "In my experience there is no such thing as luck.",
                "Ship it! We'll release patches later.",
                "Hey! It compiles! Ship it!"
            };
            return result;
        }

        public string RunTests()
        {

            return "Well done!";
        }

        public string CopyPaste()
        {
            return "Copy and paste is a design error";
        }

        public string Exception()
        {
            return pickOne(ExceptionList());
        }

        private  List<string> ExceptionList()
        {
            return  new List<string>
            {
                "The great thing about Object Oriented code is that it can make small, simple problems look like large, complex ones",
                "Don’t fix bugs later; fix them now.",
                "Never allow the same bug to bite you twice.",
                "Engineers call them edge cases. I call them: what our users do.",
                "The world is coming to an end... SAVE YOUR BUFFERS !"
            };

        }
    }
}
