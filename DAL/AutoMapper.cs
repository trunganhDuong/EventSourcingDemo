using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class AutoMapper<T>
    {
        public static List<T> Map(DataTable table)
        {
            var result = new List<T>();

            if (table == null || table.Columns.Count <= 0)
            {
                return result;
            }

            foreach (DataRow row in table.Rows)
            {
                result.Add(MapRow(row));
            }

            return result;
        }

        public static T MapRow(DataRow row)
        {
            var result = (T)Activator.CreateInstance(typeof(T));

            if (row == null)
            {
                return result;
            }

            var columnNames = row.Table.Columns
                .Cast<DataColumn>()
                .Select(x => x.ColumnName)
                .ToList();

            var properties = result.GetType().GetProperties();
            foreach (var property in properties)
            {
                foreach (var columnName in columnNames)
                {
                    if (property.Name.Contains(columnName) && row[columnName] != null)
                    {
                        property.SetValue(result, row[columnName]);
                    }
                }
            }

            return result;
        }
    }
}
