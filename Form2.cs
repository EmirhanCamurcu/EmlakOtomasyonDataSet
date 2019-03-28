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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void müşteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 frm2 = new Form3();
            frm2.Show();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;//tam ekran yapma

        }

        private void Form2_Load(object sender, EventArgs e)
        {

           IsMdiContainer = true;

  
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Devam etmek istiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }

           else if (cikis == DialogResult.No)
            {
                MessageBox.Show("Program kapatılmadı.");
            }
 
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void gayrimenkulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gayrimenkul g = new gayrimenkul();
            g.Show();
        }
    }
}
