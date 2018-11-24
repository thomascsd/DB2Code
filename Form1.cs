using DB2Code.Services.generators;
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
        private CodeGeneratorBase m_CodeGenerator;

        public Form1()
        {
            InitializeComponent();
        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                this.GetCodeBase();
                this.CreateCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 產生程式碼
        /// </summary>
        protected virtual void CreateCode()
        {
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

            if (!string.IsNullOrEmpty(paramsEditor1.CurrentConnectionString) &&
                !string.IsNullOrEmpty(paramsEditor1.CurrentTableName))
            {
                ret = string.Empty;

                this.m_CodeGenerator.MethodContent(methodType, ckbObject.Checked);

                switch (paramsEditor1.CurrentLanguage)
                {
                    case "C#":
                        ret = this.m_CodeGenerator.GenerateMethodCode(LanguageType.CSharp);
                        break;

                    case "VB.NET":
                        ret = this.m_CodeGenerator.GenerateMethodCode(LanguageType.VB);
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
            string keyName = string.Empty;
            List<string> keys = new List<string>();
            GeneratorOption option;

            //主索引值的Column Name
            if (!string.IsNullOrEmpty(txtSchemaKeyName.Text))
            {
                keyName = txtSchemaKeyName.Text;
            }
            else
            {
                keyName = "IsKey";
            }
            //自定的主索引值
            foreach (object key in clbkeys.CheckedItems)
            {
                keys.Add(key.ToString());
            }

            option = new GeneratorOption
            {
                ConnectionString = paramsEditor1.CurrentConnectionString,
                TableName = paramsEditor1.CurrentTableName,
                SchemaKeyName = keyName,
                KeyColunmNames = keys
            };

            switch (paramsEditor1.CurrentDbType)
            {
                default:
                case "MSSQL":
                    this.m_CodeGenerator = new CodeGeneratorMsSql(option);
                    break;

                case "Access":
                    this.m_CodeGenerator = new CodeGeneratorAccess(option);
                    break;
            }
        }

        protected void btnXml_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            this.m_CodeGenerator.DataSource.WriteXml(sw);

            txtXml.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnCreateData_Click(object sender, EventArgs e)
        {
            DataTable dt = this.m_CodeGenerator.DataSource;
            string columnName;

            if (dt == null)
            {
                this.GetCodeBase();
                dt = this.m_CodeGenerator.DataSource;
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