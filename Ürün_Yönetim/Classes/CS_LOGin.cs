using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Ürün_Yönetim.Classes
{
    internal class CS_LOGin
    {
        DA.DataAccess cs=new DA.DataAccess();
       public DataTable login(string username, string password)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@USERNAME",SqlDbType.NVarChar,50);
            parameters[0].Value = username;

            parameters[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            parameters[1].Value = password;

            DataTable dt = new DataTable();
            dt = cs.SelectData("PR_LOIN", parameters);
            return dt;
        }
    }
}
