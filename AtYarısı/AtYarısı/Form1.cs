using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtYarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == "Gurkan" &&  textBox2.Text == "971365")
            {
                Form2 frm2 = new Form2(textBox1.Text, textBox2.Text);
                frm2.Show();
                //frm2.FormBorderStyle = FormBorderStyle.None;
                Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giris yaptınız.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down) 
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode  == Keys.Down) 
            {
                button1.Focus();
            }
        }
    }
}
