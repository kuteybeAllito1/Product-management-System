using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ürün_Yönetim
{

    public partial class FRM_Musteriler : Form
    {
        Classes.CLS_customers cs=new Classes.CLS_customers();
        int ID;
        public FRM_Musteriler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cs.search_costomer(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cs.add_customer(txt_ad.Text, txt_soyad.Text,Convert.ToInt32(txt_telefon.Text) ); 
            txt_telefon.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            MessageBox.Show("Müşteri Ekleme İŞlemi Tamamlandı", "Müşteri Ekleme", MessageBoxButtons.OK);
            dataGridView1.DataSource = cs.Get_all_customers();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FRM_Musteriler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cs.Get_all_customers();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ID=Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_telefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs.edit_customer(txt_ad.Text, txt_soyad.Text, Convert.ToInt32(txt_telefon.Text),ID);
            MessageBox.Show("Müşteri Güncelleme İŞlemi Tamamlandı", "Müşteri Güncelleme", MessageBoxButtons.OK);
            dataGridView1.DataSource = cs.Get_all_customers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Müşteri Silmek Istediğiniz Eminmısınız", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                cs.Delet_customer(ID);
            MessageBox.Show("Müşteri Silme İŞlemi Tamamlandı", "Silme Güncelleme", MessageBoxButtons.OK);
            dataGridView1.DataSource = cs.Get_all_customers();
        }
    }
}
