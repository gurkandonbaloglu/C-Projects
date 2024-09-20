using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayac
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
  
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(0,4);
            int b = rnd.Next(0, 4);
            int c = rnd.Next(0, 4);
            int d = rnd.Next(0, 4);
            int h = rnd.Next(0, 4);
            int f = rnd.Next(0, 4);
            label9.Text = a.ToString();
            label8.Text = b.ToString();
            label14.Text = c.ToString();
            label13.Text = d.ToString();
            label18.Text = h.ToString();
            label19.Text = f.ToString();
        }
    }
}
