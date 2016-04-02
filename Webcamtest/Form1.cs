using System;
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
            camcam.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
        }
    }
}
