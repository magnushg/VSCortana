using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpeechWrapper;

namespace CamCaptureLib
{
    public class Speak
    {
        private SpeechWrapper.SpeechClient client =
            new SpeechClient(new SpeechClient.InputOptions(Locale.en_US, Gender.Female, "1eb07e8b3b324d4d87e4dd5318bc4001"));

        public void SpeakText(string text)
        {
            client.Speak(text, new CancellationToken());
        }
    }
}
