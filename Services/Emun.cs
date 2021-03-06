namespace DB2Code
{
    /// <summary>
    /// 資料連結種類
    /// </summary>
    public enum AccessDataBaseType
    {
        MsSql = 2,
        Access = 3,
        ODBC = 4
    }

    /// <summary>
    /// 程式語言的類型
    /// </summary>
    public enum LanguageType
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
    /// 方法類型
    /// </summary>
    public enum MethodType
    {
        Select,
        Insert,
        Update
    }
}