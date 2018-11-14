using System.Data;

namespace DB2Code.Services.generators
{
    public class MethodGenerateOption : GeneratorOption
    {
        public DataTable DataTable { get; set; }

        public AccessDataBaseType DataBaseType { get; set; }

        public MethodType MethodType  { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool EnableDataObjectMethod { get; set; }
    }
}