using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Site_Emlak_Projesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DSCENDS;Initial Catalog=siteler;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select *From siteuygulamasi",conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rdr["id"].ToString();
                ekle.SubItems.Add(rdr["site"].ToString());
                ekle.SubItems.Add(rdr["oda"].ToString());
                ekle.SubItems.Add(rdr["metre"].ToString());
                ekle.SubItems.Add(rdr["fiyat"].ToString());
                ekle.SubItems.Add(rdr["blok"].ToString());
                ekle.SubItems.Add(rdr["no"].ToString());
                ekle.SubItems.Add(rdr["adsoyad"].ToString());
                ekle.SubItems.Add(rdr["telefon"].ToString());
                ekle.SubItems.Add(rdr["notlar"].ToString());
                ekle.SubItems.Add(rdr["satkira"].ToString());
                listView1.Items.Add(ekle);
            }
            conn.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Zambak")
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Gül")
            {
                button2.BackColor = Color.Yellow;
                button1.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Menekşe")
            {
                button3.BackColor = Color.Yellow;
                button2.BackColor = Color.Gray;
                button1.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
            }
            if (comboBox1.Text == "Papatya")
            {
                button4.BackColor = Color.Yellow;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button1.BackColor = Color.Gray;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand baglan = new SqlCommand("insert into siteuygulamasi (id,site,oda,metre,fiyat,blok,no,adsoyad,telefon,notlar,satkira) values ('" + textBox8.Text.ToString() + "','"+comboBox1.Text.ToString()+"','"+comboBox3.Text.ToString()+"','"+textBox1.Text.ToString()+"','" + textBox2.Text.ToString()+"','"+comboBox4.Text.ToString()+"','"+textBox7.Text.ToString()+"','" + textBox4.Text.ToString() +"','"+textBox5.Text.ToString()+"','" + textBox6.Text.ToString() + "','" + comboBox2.Text.ToString()+ "' ) ",conn);
            baglan.ExecuteNonQuery();
            conn.Close();
            verilerigoster();
        }
        int id = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from siteuygulamasi where id = ("+id+")",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            verilerigoster();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox8.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update siteuygulamasi set id='" + textBox8.Text.ToString() + "' , site = '" + comboBox1.Text.ToString() + "',oda='" + comboBox3.Text.ToString() + "',metre='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() + "',blok='" + comboBox4.Text.ToString() + "',no='" + textBox7.Text.ToString() + "',adsoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',notlar='" + textBox6.Text.ToString() + "',satkira='" + comboBox2.Text.ToString() + "'where id = " + id + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            verilerigoster();
        }
    }
}
