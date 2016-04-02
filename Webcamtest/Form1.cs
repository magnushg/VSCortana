using System;
using System.Linq;
using System.Windows.Forms;
using CamCaptureLib;

namespace Webcamtest
{
    public partial class Form1 : Form
    {
        Programmer programmer = new CamCaptureLib.Programmer();
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
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Text =  await programmer.BuildError();
        }
    }
}
