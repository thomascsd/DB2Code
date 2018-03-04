namespace DB2Code
{
    /// <summary>
    /// DB2
    /// </summary>
    public class CodeDB2 : CodeBase
    {
        public CodeDB2(string constring, string tableName, string schemaKeyName, string[] keyColumNames)
            : base(constring, tableName, schemaKeyName, "iDB2Command", "iDB2DataReader",
                   keyColumNames, AccessDataBaseType.DB2)
        {
        }

        public CodeDB2(string tableName, string schemaKeyName, string[] keyColumNames)
            : base(tableName, schemaKeyName, "iDB2Command", "iDB2DataReader", keyColumNames,
                    AccessDataBaseType.DB2)
        { }
    }

    /// <summary>
    /// MsSql
    /// </summary>
    public class CodeMSSQL : CodeBase
    {
        /// <summary>
        /// �غc��
        /// </summary>
        /// <param name="constring"></param>
        /// <param name="tableName"></param>
        /// <param name="schemaKeyName">�b��ƪ��c���A��ܸ�����ݩ�D���ޭȪ��W��</param>
        public CodeMSSQL(string constring, string tableName, string schemaKeyName, string[] keyColumNames)
            : base(constring, tableName, schemaKeyName, "SqlCommand", "SqlDataReader", keyColumNames,
            AccessDataBaseType.MSSQL)
        {
        }

        /// <summary>
        /// �غc��
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="schemaKeyName">�b��ƪ��c���A��ܸ�����ݩ�D���ޭȪ��W��</param>
        public CodeMSSQL(string tableName, string schemaKeyName, string[] keyColumNames)
            : base(tableName, schemaKeyName, "SqlCommand", "SqlDataReader", keyColumNames,
                    AccessDataBaseType.MSSQL)
        { }
    }

    /// <summary>
    /// Access
    /// </summary>
    public class CodeAccess : CodeBase
    {
        public CodeAccess(string constring, string tableName, string schemaKeyName, string[] keyColumNames)
            : base(constring, tableName, schemaKeyName, "OleDbCommand", "OleDbDataReader", keyColumNames,
            AccessDataBaseType.Access)
        {
        }

        public CodeAccess(string tableName, string schemaKeyName, string[] keyColumNames)
            : base(tableName, schemaKeyName, "OleDbCommand", "OleDbDataReader", keyColumNames,
                    AccessDataBaseType.Access)
        { }
    }
}