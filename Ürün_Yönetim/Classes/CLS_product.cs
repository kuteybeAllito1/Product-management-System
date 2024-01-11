using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Ürün_Yönetim.Classes
{
    internal class CLS_product
    {
        DA.DataAccess da=new DA.DataAccess();
        public void add_product(string id,string name,int qte,int buy,int sale,int id_category)
        {
            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@id",SqlDbType.NVarChar,50);
            parameters[0].Value = id;

            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parameters[1].Value = name;

            parameters[2] = new SqlParameter("@qte", SqlDbType.Int);
            parameters[2].Value = qte;

            parameters[3] = new SqlParameter("@buy", SqlDbType.Int);
            parameters[3].Value = buy;

            parameters[4] = new SqlParameter("@sale", SqlDbType.Int);
            parameters[4].Value = sale;

            parameters[5] = new SqlParameter("@id_category", SqlDbType.Int);
            parameters[5].Value = id_category;

            da.Open();
            da.ExcuteCommend("add_product", parameters);
            da.Close();
        }
        public DataTable Get_all_product()
        {
            return da.SelectData("Get_all_product", null);
        }


        public DataTable search_product(string keyword)
        {
            SqlParameter[] p=new SqlParameter[1];
            p[0] = new SqlParameter("@keyword",SqlDbType.NVarChar,50);
            p[0].Value = keyword;
            return da.SelectData("search_product", p);
        }
        public void Delete_product(int id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id;
            da.Open();
            da.ExcuteCommend("Delete_prduct", p);
            da.Close();
        }
        
    }
}
