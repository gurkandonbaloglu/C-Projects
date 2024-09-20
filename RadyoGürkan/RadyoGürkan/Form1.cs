using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadyoGürkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 rady = new Form2();
            rady.Show();
            rady.FormBorderStyle = FormBorderStyle.None;
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doubleClickButton1.DoubleClick += DoubleClickButton1_DoubleClick;
        }

        private void DoubleClickButton1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Afferim sana");
        }

        private void doubleClickButton1_Click(object sender, EventArgs e)
        {
            Form2 rady = new Form2();
            rady.Show();
            Hide();
        }
    }
}
