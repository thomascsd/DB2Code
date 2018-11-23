using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return cbConnectionString.SelectedText;
            }
        }

        public string CurrentTableName
        {
            get
            {
                return txtTableName.Text;
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
