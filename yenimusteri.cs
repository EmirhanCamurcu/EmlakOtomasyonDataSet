using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class yenimusteri : Form
    {
       public bool yeni;
       public DataSet1.musteri_bilgiRow r;
        public yenimusteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//yeni müşteri kaydet
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
            else
            {
               src_to_db();
                DialogResult = DialogResult.OK;
           
               //DataSet1.musteri_bilgiRow r = dataSet1.musteri_bilgi.Newmusteri_bilgiRow();
              
              //r.Ad = textBox1.Text;
              //r.Soyad = textBox2.Text;
              //r.Email = textBox3.Text;
              //r.Telefon = textBox4.Text;
              //dataSet1.musteri_bilgi.Addmusteri_bilgiRow(r);

              //musteri_bilgiTableAdapter1.Update(r);
         

            }
            
        }

        private void yenimusteri_Shown(object sender, EventArgs e)
        {
            if (yeni)
                temizle();
            else
                db_to_src();
        }
        private void db_to_src()
        {
            textBox1.Text = r.Ad;
            textBox2.Text = r.Soyad;
            textBox3.Text = r.Email;
            textBox4.Text = r.Telefon;
           
        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }
        private void src_to_db()
        {
           
            r.Ad = textBox1.Text;
            r.Soyad = textBox2.Text;
            r.Email = textBox3.Text;
            r.Telefon = textBox4.Text;
          
      
        }

        private void yenimusteri_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
