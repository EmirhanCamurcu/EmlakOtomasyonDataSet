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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\EmlakOtomasyon\EmlakOtomasyon\emlak.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor");
            }
            else
            {
                con.Open();
                SqlCommand komut = new SqlCommand("insert into login(k_ad,sifre) values(@k_ad,@sifre) ", con);
                komut.Parameters.AddWithValue("k_ad", textBox1.Text);
                komut.Parameters.AddWithValue("sifre", textBox2.Text);
                komut.ExecuteNonQuery();
                con.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
