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
    public partial class FRM_musteri_liste : Form
    {
        Classes.CLS_customers customers = new Classes.CLS_customers();
        public FRM_musteri_liste()
        {
            InitializeComponent();
        }

        private void FRM_musteri_liste_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customers.Get_all_customers();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
