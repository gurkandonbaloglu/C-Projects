using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Windows.Forms.VisualStyles;
//using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtYarısı
{
    public partial class Form3 : Form
    {
        private String isim, atAdı;
        private int para;
        

        public Form3(String ad, String atAdı, int para)
        {
            this.isim = ad;
            this.atAdı = atAdı;
            InitializeComponent();
            listBox1.Items.Add(ad);
            listBox2.Items.Add(atAdı);
            this.para = para;
            
        }
        int dakika = 0;
        int birSol, ikiSol, ucSol;
        Random rnd = new Random();
        //private object openFileDialog1;



        //private WaveOutEvent waveOut;
        //private WaveStream audioFileStream;
        SoundPlayer ses = new SoundPlayer();
        private int sayi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi++;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            timer1.Enabled = true;
            
            String dizin = Application.StartupPath + "\\Ses.wav";
            ses.SoundLocation = dizin;
            ses.Play();
            button2.Enabled = false;
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            sayi++;
            if(sayi > 6)
            {
                button2.Enabled = false;
            }
            //MessageBox.Show(sayi.ToString());
            button1.Enabled = false;
            /*Form3 fm3 = new Form3(isim,atAdı,para);
            fm3.Show();
            Hide();*/
            //timer1.Stop();
            pictureBox1.Enabled = false;
            pictureBox1.Left = 0;
            pictureBox2.Enabled = false;
            pictureBox2.Left = 0;
            pictureBox3.Enabled = false;
            pictureBox3.Left = 0;
            //label7.Text = "0.0";
            timer1.Start();
            int süre = 0;
            if (dakika > 0)
            {
                dakika = 0;
            }
            if (label7.Text.Contains("."))
            {
                süre = Convert.ToInt32(label7.Text.Split('.')[1]);
            }
            else
            {
                süre = Convert.ToInt32(label7.Text);
            }

            süre++;

            if (süre == 10) // Eğer 10 saniye olduğunda bir dakika olacaksa
            {
                süre = 0;
                dakika++;
            }
            

            label7.Text = dakika.ToString() + "." + süre.ToString("0");
            ses.Play();
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ses.Stop();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count != listBox4.Items.Count)
            {
                MessageBox.Show("Üzgünüz Altılıyı Tutturamadınız.");
            }
            else
            {
                MessageBox.Show("Tebrikler " + (para*100).ToString() + " Kazandınız.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            

            /*int sure = Convert.ToInt32(label7.Text);
            sure++;
            label7.Text = sure.ToString();*/
            int süre;

            if (label7.Text.Contains("."))
            {
                süre = Convert.ToInt32(label7.Text.Split('.')[1]);
            }
            else
            {
                süre = Convert.ToInt32(label7.Text);
            }

            süre++;

            if (süre == 10) // Eğer 10 saniye olduğunda bir dakika olacaksa
            {
                süre = 0;
                dakika++;
            }

            label7.Text = dakika.ToString() + "." + süre.ToString("0");
            int birGenislik = pictureBox1.Width;
            int ikiGenislik = pictureBox2.Width;
            int ucGenislik = pictureBox3.Width;
            pictureBox1.Left += rnd.Next(5, 20);
            pictureBox2.Left += rnd.Next(5, 20);
            pictureBox3.Left += rnd.Next(5, 20);
            int bitisUzaklıgı = label5.Left;
            progressBar4.Maximum = label1.Width + 20 - pictureBox1.Width;
            progressBar4.Value = pictureBox1.Left;
            progressBar3.Maximum = label1.Width + 20 - pictureBox2.Width;
            progressBar3.Value = pictureBox2.Left;
            progressBar2.Maximum = label1.Width + 20 - pictureBox3.Width;
            progressBar2.Value = pictureBox3.Left;
            if (pictureBox1.Left  > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                
                progressBar1.Maximum = label1.Width + 20 - pictureBox1.Width;
                progressBar1.Value = pictureBox1.Left;
                label6.Text = "BoldPilot Önde Gidiyor";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                
                progressBar1.Maximum = label1.Width + 20 - pictureBox2.Width;
                progressBar1.Value = pictureBox2.Left;
                label6.Text = "YalıGüzeli Önde Gidiyor";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                
                progressBar1.Maximum = label1.Width + 20 - pictureBox3.Width;
                progressBar1.Value = pictureBox3.Left;
                label6.Text = "Esmerim Önde Gidiyor";
            }
            
            if (birGenislik + pictureBox1.Left >= bitisUzaklıgı)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                button2.Enabled = true;
                ses.Stop();
                label6.Text = "BoldPilot Kazandı";
                listBox3.Items.Add("BoldPilot");
               

                timer1.Enabled = false;
                if (atAdı == "BoldPilot")
                {
                    int oran = rnd.Next(10, 40);
                    double bahis = (oran * para) / 10.0;
                    label10.Text = bahis.ToString();
                    label10.Text = bahis.ToString() + "TL Kazandınız.";
                    listBox4.Items.Add("BoldPilot");
       

                }
                else
                {
                    label10.Text = "Kaybettiniz.";
                }
                button1.Enabled = false;
           
            }
            if(ikiGenislik + pictureBox2.Left >= bitisUzaklıgı)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                button2.Enabled = true;
                ses.Stop();
                
                timer1.Enabled=false;
                
                label6.Text = "YalıGüzeli Kazandı";
                listBox3.Items.Add("YalıGüzeli");
                if (atAdı == "YalıGüzeli")
                {
                    int oran = rnd.Next(10, 40);
                    double bahis = (oran * para) / 10.0;
                    label10.Text = bahis.ToString();
                    label10.Text = bahis.ToString() + "TL Kazandınız.";
                    listBox4.Items.Add("YalıGüzeli");

                }
                else
                {
                    label10.Text = "Kaybettiniz.";
                }
                button1.Enabled = true;
            }
            if(ucGenislik + pictureBox3.Left >= bitisUzaklıgı)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                button2.Enabled = true;
                ses.Stop();
                
                timer1.Enabled = false;
                label6.Text = "Esmerim Kazandı";
                listBox3.Items.Add("Esmerim");
                if (atAdı == "Esmerim")
                {
                    int oran = rnd.Next(10, 40);
                    double bahis = (oran * para) / 10.0;
                    label10.Text = bahis.ToString();
                    label10.Text = bahis.ToString() + "TL Kazandınız.";
                    listBox4.Items.Add("Esmerim");

                }
                else
                {
                    label10.Text = "Kaybettiniz.";
                }
                button1.Enabled = false;
                if(sayi > 6)
                {
                    button2.Enabled = false;
                }

            }


        }

       
    private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            birSol = pictureBox1.Left;
            ikiSol = pictureBox2.Left;
            ucSol = pictureBox3.Left;
           
        }
    }
}
