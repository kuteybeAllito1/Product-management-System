using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace Ürün_Yönetim.Classes
{
    internal class CLS_orders

    {
        DA.DataAccess da = new DA.DataAccess();
        public DataTable Get_last_order_id()
        {

            DataTable dt = new DataTable();
            dt = da.SelectData("Get_last_order_id", null);
            return dt;
        }
        public void Add_order(int id_order, DateTime order_date, int id_customer,string not,string selman_name)
        {
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@id_order", SqlDbType.Int);
            parameters[0].Value = id_order;

            parameters[1] = new SqlParameter("@order_date", SqlDbType.DateTime);
            parameters[1].Value = order_date;

            parameters[2] = new SqlParameter("@id_customer", SqlDbType.Int);
            parameters[2].Value = id_customer;

            parameters[3] = new SqlParameter("@not ", SqlDbType.NVarChar, 50);
            parameters[3].Value = not;

            parameters[4] = new SqlParameter("@selman_name ", SqlDbType.NVarChar, 50);
            parameters[4].Value = selman_name;

            da.Open();
            da.ExcuteCommend("Add_order", parameters);
            da.Close();
        }
        public void add_order_details(string id_product, int id_order, int price, string qty, string tutal)
        {
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@id_product", SqlDbType.NVarChar, 50);
            parameters[0].Value = id_product;

            parameters[1] = new SqlParameter("@id_order", SqlDbType.Int);
            parameters[1].Value = id_order;

            parameters[2] = new SqlParameter("@price", SqlDbType.NVarChar, 50);
            parameters[2].Value = price;

            parameters[3] = new SqlParameter("@qty ", SqlDbType.Int);
            parameters[3].Value = qty;

            parameters[4] = new SqlParameter("@tutal ", SqlDbType.NVarChar, 50);
            parameters[4].Value = tutal;

            da.Open();
            da.ExcuteCommend("add_order_details", parameters);
            da.Close();
        }
    }
}
