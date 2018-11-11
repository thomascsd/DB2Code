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
        /// ���ͷs�W��sql�r��
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string CreateInsertSql(string tableName, DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            string[] names = new string[dt.Rows.Count];//CollumnsName�A���W��
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
        ///  ���ͭק諸sql�r��
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="tableName"></param>
        /// <param name="schemaKeyName">�b��ƪ��c���A��ܸ�����ݩ�D���ޭȪ��W��</param>
        /// <param name="keyColumNames">�۩w���D���ޭȪ����X</param>
        /// <returns></returns>
        public static string CreateUpdateSql(DataTable dt, string tableName,
                                             string schemaKeyName, List<string> keyColumNames)
        {
            StringBuilder sb = new StringBuilder();
            List<string> names = new List<string>(); //���W��
            List<string> keys = new List<string>();//�D���ޭ�
            string columnName;

            //���۩w���D���ޭȬ��u���A�S���~�̾�SchemaKeyName
            if (keyColumNames.Count > 0)
            {
                //�����w�ݩ�PK�����
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
                //�b��ƪ��c���A�����w��ܸ�����ݩ�D���ޭȪ��W��
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

            //�զr��
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