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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("1");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            if(radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button7.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("2");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("3");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button4.Enabled =  false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("4");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("5");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox7.Items.Add("6");
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button6.Enabled = false;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear() ;
            button1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 geri = new Form3();
            geri.Show();
            Hide();
        }
    }
}
