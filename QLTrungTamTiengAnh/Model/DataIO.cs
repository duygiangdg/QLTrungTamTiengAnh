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
    public class DataIO
    {
        private static SqlConnector con = new SqlConnector();
        private static SqlCommand cmd = new SqlCommand();

        public static bool Execute(string query)
        {
            cmd.CommandText = query;
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
                return false;
            }
        }

        public static DataTable GetData(string selectQuery)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = selectQuery;
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

        public static object GetItem(string tableName, string condition, Type type)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from " + tableName + " where " + condition;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            object obj = null;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                obj = DataConverter.ConvertDataToArray(dt, type)[0];
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return obj;
        }

        public static bool AddItem(object obj, string tableName)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();
            List<string> colNames = new List<string>();
            List<string> commandStrings = new List<string>();

            foreach (PropertyInfo prop in properties)
            {
                if (GetCommandString(prop.GetValue(obj)) != null)
                {
                    colNames.Add(prop.Name);
                    commandStrings.Add(GetCommandString(prop.GetValue(obj)));
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

        public static object UpdateItem(object obj, string tableName, string primaryKey)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();
            List<string> colNames = new List<string>();
            List<string> commandStrings = new List<string>();
            String keyValue = type.GetProperty(primaryKey).GetValue(obj).ToString();

            foreach (PropertyInfo prop in properties)
            {
                if (!prop.Name.Equals(primaryKey) && GetCommandString(prop.GetValue(obj)) != null)
                {
                    colNames.Add(prop.Name);
                    commandStrings.Add(GetCommandString(prop.GetValue(obj)));
                }
            }

            if (colNames.Count > 0)
            {
                string commandText = "update " + tableName + " set " + colNames[0] + "=" + commandStrings[0];
                for (int index = 1; index < colNames.Count; index++)
                {
                    commandText += ", " + colNames[index] + "=" + commandStrings[index];
                }
                commandText += " where " + primaryKey + "='" + keyValue + "';";
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

        public static bool DeleteItem(string tableName, string condition)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "delete from " + tableName + " where " + condition + ";";
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

            return false;
        }

        public static DataTable RunStoredProcParams(string procedure, string param, object value)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = procedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con.Connection;
            cmd.Parameters.Add(new SqlParameter(param, value));

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

        public static object AddItem(Type type, string procedure, string param1, string param2, string param3, string value1, string value2, string value3)
        {
            object obj = null;
            DataTable dt = RunStoredProcParams(procedure, param1, param2, param3, value1, value2, value3);
            if (dt != null)
            {
                obj = DataConverter.ConvertDataToArray(dt, type)[0];
            }
            return obj;
        }

        public static DataTable RunStoredProcParams(string procedure, string param1, string param2, string param3, string value1, string value2, string value3)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = procedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con.Connection;
            cmd.Parameters.Add(new SqlParameter(param1, value1));
            cmd.Parameters.Add(new SqlParameter(param2, value2));
            cmd.Parameters.Add(new SqlParameter(param3, value3));

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

        public static string GetCommandString(object obj)
        {
            if (obj == null) return null;
            else if (obj.GetType() == typeof(string))
            {
                if (obj.ToString().Trim().Equals("")) return "NULL";
                return "N'" + obj.ToString() + "'";
            }
            else if (obj.GetType() == typeof(bool))
            {
                if ((bool)obj) return "1";
                else return "0";
            }
            else if (obj.GetType() == typeof(DateTime))
            {
                DateTime dateTime = ((DateTime)obj);
                if (dateTime == new DateTime())
                {
                    return "NULL";
                }
                return "CONVERT(DATE, '" + dateTime.ToShortDateString() + "', 103)";
            }
            return obj.ToString();
        }
    }
}
