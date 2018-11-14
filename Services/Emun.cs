namespace DB2Code
{
    /// <summary>
    /// ��Ƴs������
    /// </summary>
    public enum AccessDataBaseType
    {
        MsSql = 2,
        Access = 3,
        ODBC = 4
    }

    /// <summary>
    /// �{���y��������
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
    /// ��k����
    /// </summary>
    public enum MethodType
    {
        Select,
        Insert,
        Update
    }
}