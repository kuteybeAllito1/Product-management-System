using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_Yönetim
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Classes.CS_LOGin cS_LO = new Classes.CS_LOGin();
           dt = cS_LO.login(textBox1.Text,textBox2.Text);

            if (dt.Rows.Count > 0)
            {
                Form1 f = Application.OpenForms["Form1"] as Form1;
                f.button1.Enabled = false;
                f.button2.Enabled = true;
                f.button3.Enabled = true;
                f.button4.Enabled = true;
                f.hesaplarToolStripMenuItem.Enabled = true;
                f.girisToolStripMenuItem.Enabled = false;
                f.ürünlerToolStripMenuItem.Enabled = true;
                f.müşterilerToolStripMenuItem.Enabled = true;
                f.tedarikçilerToolStripMenuItem.Enabled = true;
                f.stokeToolStripMenuItem.Enabled = true;
                f.cikisToolStripMenuItem.Enabled = true;
                Program.saleMan = dt.Rows[0]["Ad"].ToString();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Kullanci Adi Veya Şifre Yanlış");
                
            }
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
