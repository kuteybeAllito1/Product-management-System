using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ürün_Yönetim.Classes
{
    internal class Category_mang
    {
        DA.DataAccess da = new DA.DataAccess();
        public void add_category(string name)
        {
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@category_name", SqlDbType.NVarChar, 50);
            parameter[0].Value = name;

            da.Open();
            da.ExcuteCommend("add_category", parameter);
            da.Close();
        }
        public  DataTable show_categories()
        {
           
            DataTable dt = new DataTable();
            dt = da.SelectData("show_cataories", null);
            return dt;
        }
        public void edit_category(int id,string name)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            parameters[1] = new SqlParameter("@new_name", SqlDbType.NVarChar,50);
            parameters[1].Value = name;

            da.Open();
            da.ExcuteCommend("edit_cataegory", parameters);
            da.Close();


        }
        public void delete_category(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            da.Open();
            da.ExcuteCommend("delet_catagory", parameters);
            da.Close();
        }
    }
}
