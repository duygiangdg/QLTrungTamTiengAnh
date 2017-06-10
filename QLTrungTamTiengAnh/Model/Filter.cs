using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Model
{
    public class Filter
    {
        private List<string> conditions;

        public Filter()
        {
            conditions = new List<string>();
        }
        public void AddCondition(string condition)
        {
            conditions.Add(condition);
        }

        public bool IsEmpty()
        {
            return conditions.Count == 0;
        }

        public void Clear()
        {
            conditions.Clear();
        }

        public string GetWhereClause()
        {
            if (IsEmpty()) return "";
            string whereClause = " WHERE " + conditions[0];
            for (int index = 1; index < conditions.Count; index++)
            {
                whereClause += " AND " + conditions[index];
            }
            return whereClause;
        }
    }
}
