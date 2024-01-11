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
    public partial class urunler_yontemi : Form
    {
        public urunler_yontemi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs.edit_category(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),textBox2.Text);
            dataGridView1.DataSource = cs.show_categories();
        }
        Classes.Category_mang cs = new Classes.Category_mang();

        private void button1_Click(object sender, EventArgs e)
        {
            
            cs.add_category(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            dataGridView1.DataSource = cs.show_categories();
        }

        private void urunler_yontemi_Load(object sender, EventArgs e)
        {
          dataGridView1.DataSource=  cs.show_categories();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyari", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                cs.delete_category(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = cs.show_categories();
            }
        }
    }
}
