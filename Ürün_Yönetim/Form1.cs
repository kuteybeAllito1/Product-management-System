using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ürün_Yönetim.Classes;

namespace Ürün_Yönetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Login fRM=new FRM_Login();
            fRM.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FRM_urunler_yontemi();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kutuyuTaşıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tahminiKarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void envanterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            satışNoktasıToolStripMenuItem.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_Siparişler f=new FRM_Siparişler();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yeniBirÜrünEklemekToolStripMenuItem.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girisToolStripMenuItem.PerformClick();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            girisToolStripMenuItem.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            hesaplarToolStripMenuItem.Enabled = false;
            tedarikçilerToolStripMenuItem.Enabled = false;
            ürünlerToolStripMenuItem.Enabled = false;
            müşterilerToolStripMenuItem.Enabled = false;
            stokeToolStripMenuItem.Enabled = false;
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunler_yontemi f =new urunler_yontemi();
            f.ShowDialog();
        }

        private void yeniBirÜrünEklemekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FRM_EKLE_URUNLER();
            f.ShowDialog();
        }

        private void müşteriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FRM_Musteriler();
            form.ShowDialog();
        }
    }
}
