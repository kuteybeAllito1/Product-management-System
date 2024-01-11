using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ürün_Yönetim.DA
{
    internal class DataAccess
    {
        SqlConnection con;
        public DataAccess()
        {
            con = new SqlConnection("data source =DESKTOP-2A28FUC\\SQLEXPRESS ; initial catalog =Products ; integrated security = true;");
        }

        public void Open()
        {
            if(con.State == ConnectionState.Closed)
                con.Open();
        }
        public void Close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable SelectData(String proc_name, SqlParameter[] parameters )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = proc_name;
            if( parameters != null )
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.Add(parameters[i]);
                }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public void ExcuteCommend(String proc_name, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = proc_name;
            if (parameters != null)
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.Add(parameters[i]);
                }
            cmd.ExecuteNonQuery();
        }
    }
}
