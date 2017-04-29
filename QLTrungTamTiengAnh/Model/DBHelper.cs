using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Model
{
    public class DBHelper
    {
        private static SqlConnector con = new SqlConnector();
        private static SqlCommand cmd = new SqlCommand();

        public static DataTable GetData(string tableName)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from " + tableName;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
    }
}
