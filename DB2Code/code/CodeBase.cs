using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace DB2Code
{
    public partial class CodeBase
    {
        #region"Field And Property"
        protected string mConstring;
        protected string mTableName;
        protected List<CodeMemberMethod> mMemberMethods;
        protected CodeTypeDeclaration mCodeClass;
        protected DataTable mDt;
        protected AccessDataBaseType mDatabaseType;

        protected List<string> mkeyColumnNames;

        /// <summary>
        /// 在資料表結構中，表示該欄位屬於主索引值的名稱
        /// </summary>
        protected string mSchemaKeyName;

        /// <summary>
        /// 相應資料庫的DataCommnad的名稱
        /// </summary>
        protected string mCommandName;

        /// <summary>
        /// 相應資料庫的DataReader的名稱
        /// </summary>
        protected string mDataReaderName;

        protected string mMethodName;

        /// <summary>
        /// 包括資料結構的DataTable
        /// </summary>
        public DataTable DataSource
        {
            get { return mDt; }
        }

        #endregion

        #region"建構式"

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="constring">連線字串</param>
        /// <param name="tableName"></param>
        /// <param name="schemaKeyName">在資料表結構中，表示該欄位屬於主索引值的名稱</param>
        /// <param name="commandName">相應資料庫的DataCommnad的名稱</param>
        /// <param name="dataReaderName">相應資料庫的DataReader的名稱</param>
        /// <param name="keyColumNames">自定的主索引值的集合</param>
        /// <param name="databaseType">資料連結種類</param>
        public CodeBase(string constring, string tableName, string schemaKeyName,
                        string commandName, string dataReaderName, string[] keyColumNames,
                        AccessDataBaseType databaseType)
            : this(tableName, schemaKeyName, commandName, dataReaderName, keyColumNames, databaseType)
        {
            this.mConstring = constring;
            IDataTool Idb = null;

            switch (databaseType)
            {
                case AccessDataBaseType.MSSQL:
                    Idb = new DataToolMSSQL(this.mConstring);
                    break;

                case AccessDataBaseType.Access:
                    Idb = new DataToolAccess(this.mConstring);
                    break;

                case AccessDataBaseType.ODBC:
                    Idb = new DataToolODBC(this.mConstring);
                    break;

                default:
                    break;
            }

            this.mDt = Idb.GetSchema("Select * From " + this.mTableName);
        }

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="schemaKeyName">在資料表結構中，表示該欄位屬於主索引值的名稱</param>
        /// <param name="commandName">相應資料庫的DataCommnad的名稱</param>
        /// <param name="dataReaderName">相應資料庫的DataReader的名稱</param>
        /// <param name="keyColumNames">自定的主索引值的集合</param>
        /// <param name="databaseType">資料連結種類</param>
        public CodeBase(string tableName, string schemaKeyName, string commandName,
                        string dataReaderName, string[] keyColumNames, AccessDataBaseType databaseType)
        {
            this.mTableName = tableName;
            this.mSchemaKeyName = schemaKeyName;
            this.mDatabaseType = databaseType;
            this.mCommandName = commandName;
            this.mDataReaderName = dataReaderName;
            this.InitClassContent(tableName);

            this.mkeyColumnNames = new List<string>(keyColumNames);
            this.mMemberMethods = new List<CodeMemberMethod>();
        }

        #endregion

        #region"產生屬性"

        /// <summary>
        /// 初始化Class
        /// </summary>
        /// <param name="tableName"></param>
        private void InitClassContent(string tableName)
        {
            CodeConstructor constructor = new CodeConstructor();

            this.mCodeClass = new CodeTypeDeclaration(string.Format("{0}Data", tableName));
            this.mCodeClass.IsClass = true;
            this.mCodeClass.Attributes = MemberAttributes.Public;

            constructor.Attributes = MemberAttributes.Public;

            this.mCodeClass.Members.Add(constructor);
        }

        /// <summary>
        /// 產生相對應的屬性(資料表相對應的欄位)
        /// </summary>
        public void CreateDataProperty()
        {
            CodeMemberField field;
            CodeMemberProperty property;

            //this.mCodeClass.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, "Field And Property"));

            foreach (DataRow row in this.mDt.Rows)
            {
                string[] types = row["DataType"].ToString().Split(new char[] { ',' });
                string columnName = string.Format("m{0}", row["ColumnName"]);

                //Field
                field = new CodeMemberField(types[0], columnName);
                this.mCodeClass.Members.Add(field);

                //Property
                property = new CodeMemberProperty();

                property.Attributes = MemberAttributes.Public;
                property.Type = new CodeTypeReference(types[0]);
                property.Name = row["ColumnName"].ToString();

                property.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), columnName)));

                property.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), columnName), new CodePropertySetValueReferenceExpression()));

                this.mCodeClass.Members.Add(property);
            }

            //this.mCodeClass.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, string.Empty));
        }

        #endregion

        #region"新增或修改的產生"

        public void MethodContent(MethodType methodType)
        {
            this.MethodContent(this.mDt, methodType);
        }

        public void MethodContent(DataTable dt, MethodType methodType)
        {
            MethodGenerator mg;
            MethodGenerateOptions options = new MethodGenerateOptions();
            options.CommandName = this.mCommandName;
            options.DataBaseType = this.mDatabaseType;
            options.DataReaderName = this.mDataReaderName;
            options.DataTable = dt;
            options.KeyColumnNames = this.mkeyColumnNames;
            options.SchemakeyName = this.mSchemaKeyName;
            options.TableName = this.mTableName;

            mg = new MethodGenerator(options);
            mg.CreateMethod(methodType);

            this.mMemberMethods = mg.MemberMethods;
        }

        #endregion

        #region"產生程式碼"

        /// <summary>
        ///  產生程式碼(類別)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GenerateClassCode(languageType type)
        {
            StringBuilder sb = new StringBuilder();
            CodeDomProvider provider;
            string code = string.Empty;

            switch (type)
            {
                case languageType.CSharp:
                    provider = new CSharpCodeProvider();
                    code = this.GetCodeString(provider, this.mCodeClass);
                    break;

                case languageType.VB:
                    provider = new VBCodeProvider();
                    code = this.GetCodeString(provider, this.mCodeClass);
                    break;

                default:
                    break;
            }

            return code;
        }

        /// <summary>
        /// 產生程式碼(方法)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GenerateMethodCode(languageType type)
        {
            StringBuilder sb = new StringBuilder();
            CodeDomProvider provider;

            foreach (CodeMemberMethod method in this.mMemberMethods)
            {
                switch (type)
                {
                    case languageType.CSharp:
                        provider = new CSharpCodeProvider();
                        sb.AppendLine(this.GetCodeString(provider, method));
                        break;

                    case languageType.VB:
                        provider = new VBCodeProvider();
                        sb.AppendLine(this.GetCodeString(provider, method));
                        break;

                    default:
                        break;
                }
            }

            return sb.ToString();
        }

        private string GetCodeString(CodeDomProvider provider, CodeTypeMember typeMember)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            CodeGeneratorOptions options = new CodeGeneratorOptions();
            options.IndentString = "";
            options.BracingStyle = "C";

            provider.GenerateCodeFromMember(typeMember, sw, options);

            return sb.ToString();
        }

        #endregion
    }
}