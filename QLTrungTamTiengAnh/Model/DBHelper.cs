using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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

        public static bool AddItem(object obj, string tableName)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();
            List<string> colNames = new List<string>();
            List<string> commandStrings = new List<string>();

            foreach (PropertyInfo prop in properties)
            {
                if (getCommandString(prop.GetValue(obj)) != null)
                {
                    colNames.Add(prop.Name);
                    commandStrings.Add(getCommandString(prop.GetValue(obj)));
                }
            }

            if (colNames.Count > 0)
            {
                string commandText = "insert into " + tableName + "(" + colNames[0];
                for (int index = 1; index < colNames.Count; index++)
                {
                    commandText += ", " + colNames[index];
                }
                commandText += ") values (" + commandStrings[0];
                for (int index = 1; index < colNames.Count; index++)
                {
                    commandText += ", " + commandStrings[index];
                }
                commandText += ");";
                cmd.CommandText = commandText;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.Connection;
                try
                {
                    con.OpenConn();
                    cmd.ExecuteNonQuery();
                    con.CloseConn();
                    return true;
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
            }
            return false;
        }

        public static string getCommandString(object obj)
        {
            if (obj == null) return null;
            if (obj.GetType() == typeof(string))
            {
                return "N'" + obj.ToString() + "'";
            }
            if (obj.GetType() == typeof(DateTime))
            {
                DateTime dateTime = ((DateTime)obj);
                if (dateTime == new DateTime())
                {
                    return null;
                }
                return "CONVERT(DATE, '" + dateTime.ToShortDateString() + "', 103)";
            }
            return null;
        }
    }
}
