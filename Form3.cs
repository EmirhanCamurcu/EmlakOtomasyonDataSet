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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
   

        private void Form3_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'dataSet1.musteri_bilgi' table. You can move, or remove it, as needed.
            this.musteri_bilgiTableAdapter.Fill(this.dataSet1.musteri_bilgi);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            yenimusteri m = new yenimusteri();
            m.yeni = true;
            m.ShowDialog();
           

            //DataSet1.musteri_bilgiRow r = dataSet1.musteri_bilgi.Newmusteri_bilgiRow();
            //if (m.ShowDialog() == DialogResult.OK)
            //{
            //    dataSet1.musteri_bilgi.Addmusteri_bilgiRow(r);
            //    musteri_bilgiTableAdapter.Update(r);
            //}
            //DataSet1.musteri_bilgiRow r = dataSet1.musteri_bilgi.Newmusteri_bilgiRow();
            //r.Ad = "hasan";
            //r.Soyad = "dağlı";
            //r.Email = "sadsa@gmail.com";
            //r.Telefon="12334234";
            //dataSet1.musteri_bilgi.Addmusteri_bilgiRow(r);
            //musteri_bilgiTableAdapter.Update(r);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet1.musteri_bilgiRow r = dataSet1.musteri_bilgi.Newmusteri_bilgiRow();
            for(int i=0;i<=dataGridView1.SelectedRows.Count;i++)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                r = dataSet1.musteri_bilgi.FindById(id);
                r.Delete();
                musteri_bilgiTableAdapter.Update(r);
            }
        }

        private void button2_Click(object sender, EventArgs e)//müsteri düzenle
        {
            yenimusteri y = new yenimusteri();
            y.yeni = false;
            int id=(int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DataSet1.musteri_bilgiRow r = dataSet1.musteri_bilgi.FindById(id);
            y.r = r;
            if(y.ShowDialog()==DialogResult.OK)
            {
                musteri_bilgiTableAdapter.Update(r);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.musteri_bilgiTableAdapter.Fill(this.dataSet1.musteri_bilgi);
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            
        }

       
    }
}
