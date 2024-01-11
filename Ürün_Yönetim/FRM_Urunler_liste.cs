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
    public partial class FRM_Urunler_liste : Form
    {
        Classes.CLS_product cs=new Classes.CLS_product();
        public FRM_Urunler_liste()
        {
            InitializeComponent();
            dataGridView1.DataSource = cs.Get_all_product();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
