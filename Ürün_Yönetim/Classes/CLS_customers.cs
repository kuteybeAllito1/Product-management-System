using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Ürün_Yönetim.Classes
{
    internal class CLS_customers
    {
        DA.DataAccess da = new DA.DataAccess();
        public void add_customer(string name, string last, int telefon)
        {
            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@ad", SqlDbType.NVarChar, 50);
            parameters[0].Value = name;

            parameters[1] = new SqlParameter("@soyad", SqlDbType.NVarChar, 50);
            parameters[1].Value = last;

            parameters[2] = new SqlParameter("@telefoN", SqlDbType.Int);
            parameters[2].Value = telefon;

            da.Open();
            da.ExcuteCommend("add_customer", parameters);
            da.Close();
        }
        public void edit_customer(string name, string last, int telefon,int id)
        {
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@ad", SqlDbType.NVarChar, 50);
            parameters[0].Value = name;

            parameters[1] = new SqlParameter("@soyad", SqlDbType.NVarChar, 50);
            parameters[1].Value = last;

            parameters[2] = new SqlParameter("@telefoN", SqlDbType.Int);
            parameters[2].Value = telefon;

            parameters[3] = new SqlParameter("@id", SqlDbType.Int);
            parameters[3].Value = id;

            da.Open();
            da.ExcuteCommend("edit_customer", parameters);
            da.Close();
        }
        public DataTable Get_all_customers()
        {

            DataTable dt = new DataTable();
            dt = da.SelectData("Get_all_customer", null);
            return dt;
        }
        public void Delet_customer(int ID)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value =ID;

            da.Open();
            da.ExcuteCommend("Delet_customer", parameters);
            da.Close();
        }
        public DataTable search_costomer(string key)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@key", SqlDbType.NVarChar, 50);
            p[0].Value = key;
            return da.SelectData("search_costomer", p);
        }
    }
}
