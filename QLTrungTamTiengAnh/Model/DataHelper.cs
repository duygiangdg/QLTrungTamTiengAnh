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
                    String colName = table.Columns[cellIndex].ColumnName;
                    row[cellIndex] = type.GetProperty(colName).GetValue(obj);
                }
            }

            return table;
        }

        public static object[] ConvertDataToArray(DataTable table, String className)
        {
            Type type = Type.GetType(className, true);
            int propCount = table.Columns.Count;
            int objCount = table.Rows.Count;
            object[] array = new object[objCount];
            String[] propNames = new String[propCount];

            for (int propIndex = 0; propIndex < propCount; propIndex++)
            {
                propNames[propIndex] = table.Columns[propIndex].ColumnName;
            }

            for (int objIndex = 0; objIndex < objCount; objIndex++)
            {
                object[] values = table.Rows[objIndex].ItemArray;
                var instance = Activator.CreateInstance(type);
                for (int propIndex = 0; propIndex < propCount; propIndex++)
                {
                    PropertyInfo prop = type.GetProperty(propNames[propIndex]);
                    prop.SetValue(instance, values[propIndex]);
                }
                array[objIndex] = instance;
            }

            return array;
        }
    }
}
