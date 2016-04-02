using System;
using System.Linq;
using System.Windows.Forms;

namespace Webcamtest
{
    public partial class Form1 : Form
    {
        CamCaptureLib.CamCam camcam = new  CamCaptureLib.CamCam();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var emotions = await camcam.GetEmotions();
            if (emotions.Any())
            {
                listBox1.Items.Clear();
                var programmer = emotions.First();
                listBox1.Items.Add("Surprise: " + programmer.Scores.Surprise);
                listBox1.Items.Add("Anger: " + programmer.Scores.Anger);
                listBox1.Items.Add("Contempt: " + programmer.Scores.Contempt);
                listBox1.Items.Add("Fear: " + programmer.Scores.Fear);
                listBox1.Items.Add("Happiness: " + programmer.Scores.Happiness);
                listBox1.Items.Add("Neutral: " + programmer.Scores.Neutral);
                listBox1.Items.Add("Sadness: " + programmer.Scores.Sadness);
                listBox1.Items.Add("Disgust: " + programmer.Scores.Disgust);
            }
        }
    }
}
