using System;
using System.Linq;
using System.Windows.Forms;
using CamCaptureLib;

namespace Webcamtest
{
    public partial class Form1 : Form
    {
        CamCam camcam = new CamCaptureLib.CamCam();
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


        private async void button2_Click(object sender, EventArgs e)
        {
            var result = await camcam.GetEmotions();
            label1.Text = result.BuildError();
            Speak s = new Speak();
            s.SpeakText(label1.Text);
            pictureBox1.Image = result.Image;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await camcam.GetEmotions();
            label1.Text = result.BuildOK();
            pictureBox1.Image = result.Image;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var result = await camcam.GetEmotions();
            label1.Text = result.RunTests();
            pictureBox1.Image = result.Image;
        }
    }
}
