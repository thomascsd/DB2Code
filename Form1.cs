using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DB2Code
{
    public partial class Form1 : Form
    {
        protected CodeBase cd;
        protected LogWriter Writer;

        public Form1()
        {
            this.Writer = new LogWriter();
            InitializeComponent();
        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                this.GetCodeBase();
                this.CreateCode();
                this.SaveHistoryList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 儲存歷史資料
        /// </summary>
        protected void SaveHistoryList()
        {
            LogData data = new LogData
            {
                ConnectionString = txtConstring.Text,
                TableName = txtName.Text
            };
            this.Writer.Add(data);
        }

        /// <summary>
        /// 產生程式碼
        /// </summary>
        protected virtual void CreateCode()
        {
            string constring = txtConstring.Text;
            string tableName = txtName.Text;
            string ret;
            MethodType methodType = MethodType.Insert;

            txtContent.Text = string.Empty;

            if (rbnInsert.Checked)
            {
                methodType = MethodType.Insert;
            }

            if (rbnUpdate.Checked)
            {
                methodType = MethodType.Update;
            }

            if (rbnSelect.Checked)
            {
                methodType = MethodType.Select;
            }

            if (constring != string.Empty && tableName != string.Empty)
            {
                ret = string.Empty;

                this.cd.MethodContent(methodType);

                switch (cbxLang.SelectedItem.ToString())
                {
                    case "C#":
                        ret = cd.GenerateMethodCode(LanguageType.CSharp);
                        break;

                    case "VB":
                        ret = cd.GenerateMethodCode(LanguageType.VB);
                        break;
                }

                txtContent.Text = ret;
            }
        }

        /// <summary>
        /// 取得程式碼產生物件的實體
        /// </summary>
        protected void GetCodeBase()
        {
            string constring = txtConstring.Text;
            string tableName = txtName.Text;
            string keyName = string.Empty;
            List<string> keys = new List<string>();

            //主索引值的Column Name
            if (!string.IsNullOrEmpty(txtSchemaKeyName.Text))
            {
                keyName = txtSchemaKeyName.Text;
            }
            else
            {
                switch (cbDbType.SelectedItem.ToString())
                {
                    case "MSSQL":
                        keyName = "IsKey";
                        break;

                    case "Access":
                        keyName = "IsKey";
                        break;

                    default:
                        break;
                }
            }
            //自定的主索引值
            foreach (object key in clbkeys.CheckedItems)
            {
                keys.Add(key.ToString());
            }

            switch (cbDbType.SelectedItem.ToString())
            {
                case "MSSQL":
                    this.cd = new CodeMSSQL(constring, tableName, keyName, keys.ToArray());
                    break;

                case "Access":
                    this.cd = new CodeAccess(constring, tableName, keyName, keys.ToArray());
                    break;

                default:
                    break;
            }
        }

        protected void btnXml_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            this.cd.DataSource.WriteXml(sw);

            txtXml.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<XmlData> datas;
            datas = this.Writer.LoadData();
            AutoCompleteStringCollection acsConn = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acsName = new AutoCompleteStringCollection();

            foreach (XmlData xmlData in datas)
            {
                LogData data = xmlData as LogData;

                acsConn.Add(data.ConnectionString);
                acsName.Add(data.TableName);
            }

            txtConstring.AutoCompleteCustomSource = acsConn;
            txtName.AutoCompleteCustomSource = acsName;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            DataTable dt = this.cd.DataSource;
            string columnName;

            if (dt == null)
            {
                this.GetCodeBase();
                dt = this.cd.DataSource;
            }

            clbkeys.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                columnName = row["ColumnName"].ToString();
                clbkeys.Items.Add(columnName);
            }
        }

        #region"鍵盤事件"

        protected void txtContent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtContent.SelectAll();
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                txtContent.Copy();
            }
        }

        #endregion


    }
}