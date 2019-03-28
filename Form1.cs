using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\EmlakOtomasyon\EmlakOtomasyon\emlak.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Form2 frm = new Form2();
           
                SqlCommand komut = new SqlCommand("select * from login where k_ad=@k_ad and sifre=@sifre",con);
                komut.Parameters.AddWithValue("k_ad",textBox1.Text);
                komut.Parameters.AddWithValue("sifre", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("hatalı giriş");
                }
              
          

            con.Close(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
