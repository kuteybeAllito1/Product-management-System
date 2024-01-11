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
    public partial class FRM_urunler_yontemi : Form
    {
        public FRM_urunler_yontemi()
        {
            InitializeComponent();
        }
        Classes.CLS_product cs=new Classes.CLS_product();
        private void FRM_urunler_yontemi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cs.Get_all_product();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FRM_EKLE_URUNLER();
            form.ShowDialog();
            dataGridView1.DataSource=cs.Get_all_product();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=cs.search_product(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ürün Silmek Istediğiniz Eminmısınız","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            cs.Delete_product(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView1.DataSource= cs.Get_all_product();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
