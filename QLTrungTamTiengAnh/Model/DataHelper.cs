using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Model
{
    class DataHelper
    {
        public static DataTable ConvertArrayToData(object[] objs)
        {
            DataTable table = new DataTable();
            Type type;
            PropertyInfo[] properties;

            if (objs.Count() == 0)
            {
                return null;
            }
            else
            {
                type = objs[0].GetType();
                properties = type.GetProperties();
            }

            foreach (PropertyInfo prop in properties)
            {
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (object obj in objs)
            {
                DataRow row = table.NewRow();
                for (int cellIndex = 0; cellIndex < table.Columns.Count; cellIndex++)
                {
                    string colName = table.Columns[cellIndex].ColumnName;
                    row[cellIndex] = type.GetProperty(colName).GetValue(obj);
                }
            }

            return table;
        }

        public static object[] ConvertDataToArray(DataTable table, string className)
        {
            Type type = Type.GetType(className, true);
            int colCount = table.Columns.Count;
            int objCount = table.Rows.Count;
            object[] array = new object[objCount];
            string[] colNames = new string[colCount];

            for (int colIndex = 0; colIndex < colCount; colIndex++)
            {
                colNames[colIndex] = table.Columns[colIndex].ColumnName;
            }

            for (int objIndex = 0; objIndex < objCount; objIndex++)
            {
                object[] values = table.Rows[objIndex].ItemArray;
                var instance = Activator.CreateInstance(type);
                for (int colIndex = 0; colIndex < colCount; colIndex++)
                {
                    PropertyInfo prop = type.GetProperty(colNames[colIndex]);
                    if (prop != null)
                    {
                        if (values[colIndex].GetType() == typeof(DBNull))
                        {
                            prop.SetValue(instance, null);
                        }
                        else
                        {
                            prop.SetValue(instance, values[colIndex]);
                        }
                    }
                }
                array[objIndex] = instance;
            }

            return array;
        }
    }
}
