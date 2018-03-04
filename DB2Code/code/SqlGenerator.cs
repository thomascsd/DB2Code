using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DB2Code
{
    /// <summary>
    ///
    /// </summary>
    internal class SqlGenerator
    {
        /// <summary>
        /// 產生新增的sql字串
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string CreateInsertSql(string tableName, DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            string[] names = new string[dt.Rows.Count];//CollumnsName，欄位名稱
            int j = 0;
            sb.Append("Insert Into ");
            sb.Append(tableName);
            sb.Append("(");

            foreach (DataRow row in dt.Rows)
            {
                names[j] = row["ColumnName"].ToString();
                j++;
            }

            for (int i = 0; i <= names.GetUpperBound(0); i++)
            {
                if (i == names.GetUpperBound(0))
                {
                    sb.Append(names[i]);
                }
                else
                {
                    sb.Append(names[i] + ",");
                }
            }

            sb.Append(") Values(");

            for (int i = 0; i <= names.GetUpperBound(0); i++)
            {
                if (i == names.GetUpperBound(0))
                {
                    sb.Append("@" + names[i]);
                }
                else
                {
                    sb.Append("@" + names[i] + ",");
                }
            }

            sb.Append(")");

            return sb.ToString();
        }

        /// <summary>
        ///  產生修改的sql字串
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="tableName"></param>
        /// <param name="schemaKeyName">在資料表結構中，表示該欄位屬於主索引值的名稱</param>
        /// <param name="keyColumNames">自定的主索引值的集合</param>
        /// <returns></returns>
        public static string CreateUpdateSql(DataTable dt, string tableName,
                                             string schemaKeyName, List<string> keyColumNames)
        {
            StringBuilder sb = new StringBuilder();
            List<string> names = new List<string>(); //欄位名稱
            List<string> keys = new List<string>();//主索引值
            string columnName;

            //有自定的主索引值為優先，沒有才依據SchemaKeyName
            if (keyColumNames.Count > 0)
            {
                //有指定屬於PK的欄位
                keys = keyColumNames;

                foreach (DataRow row in dt.Rows)
                {
                    columnName = row["ColumnName"].ToString();

                    if (!keys.Contains(columnName))
                    {
                        names.Add(columnName);
                    }
                }
            }
            else
            {
                //在資料表結構中，有指定表示該欄位屬於主索引值的名稱
                foreach (DataRow row in dt.Rows)
                {
                    columnName = row["ColumnName"].ToString();
                    if ((bool)row[schemaKeyName])
                    {
                        keys.Add(columnName);
                    }
                    else
                    {
                        names.Add(columnName);
                    }
                }
            }

            //組字串
            sb.Append("Update ");
            sb.Append(tableName);
            sb.Append(" Set ");

            for (int i = 0; i < names.Count; i++)
            {
                if (i == names.Count - 1)
                {
                    sb.Append(names[i] + "= @" + names[i]);
                }
                else
                {
                    sb.Append(names[i] + "= @" + names[i] + ",");
                }
            }

            sb.Append(" Where ");

            for (int i = 0; i < keys.Count; i++)
            {
                if (i == keys.Count - 1)
                {
                    sb.Append(keys[i] + " =@" + keys[i]);
                }
                else
                {
                    sb.Append(keys[i] + " =@" + keys[i] + " And ");
                }
            }
            return sb.ToString();
        }
    }
}