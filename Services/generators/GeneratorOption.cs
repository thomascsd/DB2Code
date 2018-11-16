using System.Collections.Generic;

namespace DB2Code.Services.generators
{
    /// <summary>
    ///
    /// </summary>
    public class GeneratorOption
    {
        /// <summary>
        /// 連線字串
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 在資料表結構中，表示該欄位屬於主索引值的名稱
        /// </summary>
        public string SchemaKeyName { get; set; }

        /// <summary>
        /// 相應資料庫的DataCommnad的名稱
        /// </summary>
        public string CommandName { get; set; }

        /// <summary>
        /// 相應資料庫的DataReader的名稱
        /// </summary>
        public string DataReaderName { get; set; }

        /// <summary>
        /// 自定的主索引值的集合
        /// </summary>
        public List<string> KeyColunmNames { get; set; }
    }
}