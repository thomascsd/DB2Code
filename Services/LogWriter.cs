using System.Collections.Generic;
using System.Data;

namespace DB2Code
{
    /// <summary>
    /// 記錄輸入過的資訊
    /// </summary>
    public class LogWriter : XmlDataWriterBase
    {
        protected override string[] ColumnNames
        {
            get { return new string[] { "key", "ConnectionString", "TableName" }; }
        }

        protected override string FileName
        {
            get { return "Log.xml"; }
        }

        protected override string FilePath
        {
            get { return "D:\\"; }
        }

        public override List<XmlData> LoadData()
        {
            LogData data;
            List<XmlData> datas = new List<XmlData>();

            foreach (DataRow row in this.mDs.Tables[0].Rows)
            {
                data = new LogData
                {
                    ConnectionString = row["ConnectionString"].ToString(),
                    Key = row["Key"].ToString(),
                    TableName = row["TableName"].ToString()
                };

                datas.Add(data);
            }
            return datas;
        }

        public override XmlData LoadData(string key)
        {
            LogData data;
            DataView dv = new DataView(this.mDs.Tables[0]);
            dv.RowFilter = string.Format("key = '{0}'", key);

            if (dv.Count > 0)
            {
                data = new LogData
                {
                    Key = dv[0]["Key"].ToString(),
                    ConnectionString = dv[0]["ConnectionString"].ToString(),
                    TableName = dv[0]["TableName"].ToString()
                };
                return data;
            }

            return null;
        }

        public override void Add(XmlData xmlData)
        {
            LogData data = xmlData as LogData;
            XmlData xd;
            DataRow row = this.mDs.Tables[0].NewRow();
            string key = data.ConnectionString + data.TableName;

            xd = this.LoadData(key);

            if (xd == null)
            {
                row["Key"] = key;
                row["ConnectionString"] = data.ConnectionString;
                row["TableName"] = data.TableName;

                this.mDs.Tables[0].Rows.Add(row);
                this.mDs.AcceptChanges();
                this.mDs.WriteXml(this.FileName);
            }
        }

        public override void Update(XmlData xmlData)
        {
            return;
        }

        public override void Delete(XmlData xmlData)
        {
            return;
        }
    }

    public class LogData : XmlData
    {
        private string mKey;

        public override string Key
        {
            get { return mKey; }
            set { mKey = value; }
        }

        public string ConnectionString { get; set; }

        public string TableName { get; set; }
    }
}