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
    public partial class FRM_Siparişler : Form
    {
        Classes.CLS_orders orders = new Classes.CLS_orders();
        DataTable Dt=new DataTable();

        void Tutar()
        {
            if(textBox10.Text!=string.Empty && textBox10.Text !=string.Empty)
                textBox12.Text = (Convert.ToDouble(textBox11.Text) * Convert.ToInt32(textBox10.Text)).ToString();
            
        }
        void CreateDataTable()
        {
            Dt.Columns.Add("Ürün Id");
            Dt.Columns.Add("Ürün Ad");
            Dt.Columns.Add("Ürün Fiat");
            Dt.Columns.Add("Miktar");
            Dt.Columns.Add("Tutar");
            dataGridView1.DataSource = Dt;
        }
        void cleardata()
        {
             textBox8.Clear();
             textBox9.Clear();
             textBox11.Clear();
             textBox10.Clear();
             textBox12.Clear();
            button6.Focus();
        }
        public FRM_Siparişler()
        {
            InitializeComponent();
            CreateDataTable();
            textBox7.Text = Program.saleMan;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = orders.Get_last_order_id().Rows[0][0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_musteri_liste f = new FRM_musteri_liste();
            f.ShowDialog();
            textBox3.Text = f.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = f.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = f.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = f.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void FRM_Siparişler_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FRM_Urunler_liste frm=new FRM_Urunler_liste();
            frm.ShowDialog();
            textBox8.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox9.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void textBox11_KeyUp(object sender, KeyEventArgs e)
        {
            Tutar();
        }

        private void textBox10_KeyUp(object sender, KeyEventArgs e)
        {
            Tutar();
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DataRow r=Dt.NewRow();
              
                r[0] = textBox8.Text;
                r[1] = textBox9.Text;
                r[3] = textBox11.Text;
                r[2] = textBox10.Text;
                r[4] = textBox12.Text;
                Dt.Rows.Add(r);
                dataGridView1.DataSource = Dt;
                cleardata();
                textBox13.Text=(from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[4].FormattedValue.ToString()!= string.Empty
                                select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            textBox13.Text=(from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[4].FormattedValue.ToString()!= string.Empty
                                select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orders.Add_order(Convert.ToInt32(textBox1.Text),dateTimePicker1.Value,Convert.ToInt32(textBox3.Text),textBox2.Text,textBox7.Text);
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                orders.add_order_details(dataGridView1.Rows[i].Cells[0].Value.ToString(),Convert.ToInt32(textBox1.Text),Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) , dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            MessageBox.Show("Sipariş Kaydetme İşlemi Tamamlandı","Sipariş Kaydetme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
