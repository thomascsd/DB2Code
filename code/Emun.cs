namespace DB2Code
{
    /// <summary>
    /// ��Ƴs������
    /// </summary>
    public enum AccessDataBaseType
    {
        DB2 = 1,
        MSSQL = 2,
        Access = 3,
        ODBC = 4
    }

    /// <summary>
    /// �{���y��������
    /// </summary>
    public enum languageType
    {
        /// <summary>
        /// C#
        /// </summary>
        CSharp,

        /// <summary>
        /// VB.Net
        /// </summary>
        VB,
    }

    /// <summary>
    /// ��k����
    /// </summary>
    public enum MethodType
    {
        Select,
        Insert,
        Update
    }
}