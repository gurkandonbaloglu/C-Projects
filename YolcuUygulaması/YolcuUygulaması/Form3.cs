using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YolcuUygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.204:80/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://160.75.86.29:8088/stream/1/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://160.75.86.29:8088/stream/5/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.mgm.gov.tr/tahmin/turkiye.aspx");
        }
    }
}
//"http://46.20.3.204:80/";
//"http://160.75.86.29:8088/stream/1/";
//"http://160.75.86.29:8088/stream/5/";