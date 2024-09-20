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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "kullanıcı" && textBox2.Text == "1234")
            {
                Form3 fm3 = new Form3();
                fm3.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş Yaptınız.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
