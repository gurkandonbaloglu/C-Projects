using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarısı
{
    public partial class Form2 : Form
    {
        private String ad;
        
        public Form2(String ad, String sifre)
        {
            this.ad = ad; 
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            Form3 fm3 = new Form3(ad,comboBox1.Text,sayi);
            fm3.Show();
            //fm3.FormBorderStyle = FormBorderStyle.None;
            Hide();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Veliefendi":
                    this.BackgroundImage = Properties.Resources.Veliefendi; // "Properties.Resources.Resim1" projenizdeki bir resim kaynağı olmalıdır.
                    break;
                case "adana":
                    this.BackgroundImage = Properties.Resources.adana; // Aynı şekilde bu da projenizdeki bir diğer resim kaynağı olmalıdır.
                    break;
                case "izmir":
                    this.BackgroundImage = Properties.Resources.izmir;
                    break;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                textBox1.Focus();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                comboBox2.Focus();
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
