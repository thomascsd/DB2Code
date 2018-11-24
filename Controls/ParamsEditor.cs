using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB2Code.Controls
{
    public partial class ParamsEditor : UserControl
    {
        private LogWriter m_Writer;

        public string CurrentConnectionString
        {
            get
            {
                return cbConnectionString.Text;
            }
        }

        public string CurrentTableName
        {
            get
            {
                return txtTableName.Text;
            }
        }

        public string CurrentDbType
        {
            get
            {
                if (rbnMsSql.Checked)
                {
                    return rbnMsSql.Text;
                }
                if (rbnAccess.Checked)
                {
                    return rbnAccess.Text;
                }

                return rbnMsSql.Text;
            }
        }

        public string CurrentLanguage
        {
            get
            {
                if (rbnCSharp.Checked)
                {
                    return rbnCSharp.Text;
                }
                if (rbnVb.Checked)
                {
                    return rbnVb.Text;
                }

                return rbnCSharp.Text;
            }
        }

        public ParamsEditor()
        {
            InitializeComponent();
        }

        private void ParamsEditor_Load(object sender, EventArgs e)
        {
            List<XmlData> datas;
            List<string> conns = new List<string>();
            AutoCompleteStringCollection acsName = new AutoCompleteStringCollection();
            this.m_Writer = new LogWriter();

            datas = this.m_Writer.LoadData();

            foreach (XmlData xmlData in datas)
            {
                LogData logData = xmlData as LogData;

                conns.Add(logData.ConnectionString);
                acsName.Add(logData.TableName);
            }

            cbConnectionString.DataSource = conns;
            txtTableName.AutoCompleteCustomSource = acsName;
        }

        /// <summary>
        /// 儲存歷史資料
        /// </summary>
        public void SaveHistoryList()
        {
            LogData data = new LogData
            {
                ConnectionString = this.CurrentConnectionString,
                TableName = this.CurrentTableName
            };
            this.m_Writer.Add(data);
        }
    }
}