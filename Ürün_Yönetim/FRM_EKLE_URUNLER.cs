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
    
    public partial class FRM_EKLE_URUNLER : Form
    {
        Classes.Category_mang csca = new Classes.Category_mang();
        
        public FRM_EKLE_URUNLER()
        {
            InitializeComponent();
            comboBox1.DataSource = csca.show_categories();
            comboBox1.DisplayMember = "kategori_ad";
            comboBox1.ValueMember = "ID_KATEGORILER";
        }

        private void FRM_EKLE_URUNLER_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        Classes.CLS_product cs = new Classes.CLS_product();
        private void button1_Click(object sender, EventArgs e)
        {
            
                cs.add_product(txt_id.Text, txt_name.Text, int.Parse(numericUpDown1.Value.ToString()), int.Parse(txt_buy.Text), int.Parse(txt_sel.Text), int.Parse(comboBox1.SelectedValue.ToString()));
                txt_sel.Clear();
                txt_buy.Clear();
                txt_id.Clear();
                txt_name.Clear();
                numericUpDown1.Value = 0;
                txt_id.Focus();
                MessageBox.Show("Ürün Ekleme İŞlemi Tamamlandı", "Ürün Ekleme",MessageBoxButtons.OK);
            
            

        }
    }
}
