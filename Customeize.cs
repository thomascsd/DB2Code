using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DB2Code
{
    public partial class Customeize : Form
    {
        private DataTable Dt = new DataTable();
        private CodeBase Cd;
        private LogWriter Writer;

        public Customeize()
        {
            this.Writer = new LogWriter();
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                this.GetCodeBase();
                this.CreateCode();
                this.WriteHistoryList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteHistoryList()
        {
            LogData data = new LogData();
            data.ConnectionString = txtConstring.Text;
            data.TableName = txtName.Text;
            this.Writer.Add(data);
        }

        private void CreateCode()
        {
            List<string> columnName = new List<string>();
            List<string> dataType = new List<string>();
            List<bool> IsKey = new List<bool>();
            DataTable dt;
            string ret, keyName, tableName;
            MethodType methodType = MethodType.Insert;

            tableName = txtName.Text;
            keyName = this.GetKeyColumnName();
            ret = string.Empty;

            if (rbnInsert.Checked)
            {
                methodType = MethodType.Insert;
            }
            if (rbnUpdate.Checked)
            {
                methodType = MethodType.Update;
            }

            //在CheckBox中所選擇的欄位
            foreach (object name in ckbData.CheckedItems)
            {
                columnName.Add(name.ToString());
            }

            //比對所選擇的ColumnName與DataTable中ColumnName是否相同
            //相同的話，用List.Add來加入DataType及IsKeyColumn
            foreach (DataRow row in this.Dt.Rows)
            {
                foreach (string name in columnName)
                {
                    if (row["ColumnName"].ToString() == name)
                    {
                        dataType.Add(row["DataType"].ToString());
                        IsKey.Add((bool)row[keyName]);
                    }
                }
            }

            //產生DataTable
            dt = this.CreateDataTable(columnName, dataType, IsKey);

            //產生程式碼
            this.Cd.MethodContent(dt, methodType);

            switch (cbxLang.SelectedItem.ToString())
            {
                case "C#":
                    ret = this.Cd.GenerateMethodCode(LanguageType.CSharp);
                    break;

                case "VB":
                    ret = this.Cd.GenerateMethodCode(LanguageType.VB);
                    break;
            }
            txtContent.Text = ret;
        }

        /// <summary>
        /// 產生欄位
        /// </summary>
        private void btnProduce_Click(object sender, EventArgs e)
        {
            this.GetCodeBase();
            this.Dt = this.Cd.DataSource;

            ckbData.Items.Clear();
            foreach (DataRow row in this.Dt.Rows)
            {
                ckbData.Items.Add(row["ColumnName"]);
            }
        }

        /// <summary>
        /// 產生欄位已勾選的DataTable
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="type"></param>
        /// <param name="isKey"></param>
        /// <returns></returns>
        private DataTable CreateDataTable(List<string> columnName, List<string> type,
                                          List<bool> isKey)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ColumnName", typeof(string));
            dt.Columns.Add("DataType", typeof(string));
            dt.Columns.Add("IsKeyColumn", typeof(bool));

            for (int i = 0; i < columnName.Count; i++)
            {
                DataRow row = dt.NewRow();
                row["ColumnName"] = columnName[i];
                row["DataType"] = type[i];
                row["IsKeyColumn"] = isKey[i];
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            this.Dt.WriteXml(sw);

            txtXml.Text = sb.ToString();
        }

        /// <summary>
        /// 取得程式碼產生物件的實體
        /// </summary>
        private void GetCodeBase()
        {
            string constring = txtConstring.Text;
            string tableName = txtName.Text;
            List<string> keys = new List<string>();

            foreach (object key in clbKeys.CheckedItems)
            {
                keys.Add(key.ToString());
            }

            switch (cbDbType.SelectedItem.ToString())
            {
                case "MSSQL":
                    this.Cd = new CodeMSSQL(constring, tableName, "IsKeyColumn", keys.ToArray());
                    break;

                case "Access":
                    this.Cd = new CodeAccess(constring, tableName, "IsKeyColumn", keys.ToArray());
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 取得索引值的Column Name
        /// </summary>
        /// <returns></returns>
        private string GetKeyColumnName()
        {
            string keyName = string.Empty;

            //主索引值的Column Name
            if (!string.IsNullOrEmpty(txtSchemaKeyName.Text))
            {
                keyName = txtSchemaKeyName.Text;
            }
            else
            {
                switch (cbDbType.SelectedItem.ToString())
                {
                    case "DB2":
                        keyName = "IsKeyColumn";
                        break;

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

            return keyName;
        }

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            DataTable dt = this.Cd.DataSource;
            string columnName;

            if (dt == null)
            {
                this.GetCodeBase();
                dt = this.Cd.DataSource;
            }

            clbKeys.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                columnName = row["ColumnName"].ToString();
                clbKeys.Items.Add(columnName);
            }
        }

        private void Customeize_Load(object sender, EventArgs e)
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

        #region"Key Event"

        private void txtContent_KeyDown(object sender, KeyEventArgs e)
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