using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace RadyoGürkan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;  // Maksimum ses seviyesi %100 olarak ayarlanır
            trackBar1.Value = 50;
        }
 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
  
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://160.75.86.29:8088/stream/1/";
            axWindowsMediaPlayer1.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://160.75.86.29:8088/stream/5/";
            axWindowsMediaPlayer1.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.204:80/";
            axWindowsMediaPlayer1.Visible = false;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }

            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = { radioButton1, radioButton2, radioButton3, radioButton4, };
            Random rnd = new Random();
            int selectedIndex = rnd.Next(0, 4);
            RadioButton selectedRadioButton = radioButtons[selectedIndex];
            selectedRadioButton.Checked = true;
        }
    }
}
