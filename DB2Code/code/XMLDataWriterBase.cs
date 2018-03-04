using System.Collections.Generic;
using System.Data;

namespace DB2Code
{
    /// <summary>
    /// Xml操作底礎類別
    /// </summary>
    public abstract class XmlDataWriterBase
    {
        protected DataSet mDs;

        public XmlDataWriterBase()
        {
            this.mDs = new DataSet();
            this.CreateDataSet();
        }

        /// <summary>
        /// 產生裝戴Xml的DataSet
        /// </summary>
        protected void CreateDataSet()
        {
            string file = this.FilePath + this.FileName;

            if (System.IO.File.Exists(file))
            {
                this.mDs.ReadXml(file);
            }
            else
            {
                this.mDs.Tables.Add();
                foreach (string name in this.ColumnNames)
                {
                    this.mDs.Tables[0].Columns.Add(name);
                }
                this.mDs.WriteXml(file, XmlWriteMode.WriteSchema);
            }
        }

        protected abstract string[] ColumnNames
        {
            get;
        }

        /// <summary>
        /// Xml檔案名稱
        /// </summary>
        protected abstract string FileName
        {
            get;
        }

        /// <summary>
        /// Xml檔案路徑
        /// </summary>
        protected abstract string FilePath
        {
            get;
        }

        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        public abstract List<XmlData> LoadData();

        /// <summary>
        /// 依識別值取得資料
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public abstract XmlData LoadData(string key);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="xmlData"></param>
        public abstract void Add(XmlData xmlData);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="xmlData"></param>
        public abstract void Update(XmlData xmlData);

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="xmlData"></param>
        public abstract void Delete(XmlData xmlData);
    }

    /// <summary>
    /// Xml資料的基礎類別
    /// </summary>
    public abstract class XmlData
    {
        /// <summary>
        /// 識別值
        /// </summary>
        public abstract string Key
        {
            get;
            set;
        }
    }
}