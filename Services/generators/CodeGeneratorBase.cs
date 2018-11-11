using Microsoft.CSharp;
using Microsoft.VisualBasic;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace DB2Code.Services.generators
{
    public abstract class CodeGeneratorBase
    {
        #region Field And Property

        private string m_Connectionstring;
        private string m_TableName;
        private List<CodeMemberMethod> m_MemberMethods;
        private CodeTypeDeclaration m_CodeClass;
        private DataTable m_Dt;

        private List<string> m_keyColumnNames;

        /// <summary>
        /// �b��ƪ��c���A��ܸ�����ݩ�D���ޭȪ��W��
        /// </summary>
        private string m_SchemaKeyName;

        /// <summary>
        /// ������Ʈw��DataCommnad���W��
        /// </summary>
        private string m_CommandName;

        /// <summary>
        /// ������Ʈw��DataReader���W��
        /// </summary>
        private string m_DataReaderName;

        private string m_MethodName;

        /// <summary>
        /// �]�A��Ƶ��c��DataTable
        /// </summary>
        public DataTable DataSource
        {
            get { return m_Dt; }
        }

        public abstract AccessDataBaseType DataBaseType { get; }

        #endregion

        #region �غc��

        /// <summary>
        /// �غc��
        /// </summary>
        /// <param name="constring">�s�u�r��</param>
        /// <param name="tableName"></param>
        /// <param name="schemaKeyName">�b��ƪ��c���A��ܸ�����ݩ�D���ޭȪ��W��</param>
        /// <param name="commandName">������Ʈw��DataCommnad���W��</param>
        /// <param name="dataReaderName">������Ʈw��DataReader���W��</param>
        /// <param name="keyColumNames">�۩w���D���ޭȪ����X</param>
        /// <param name="databaseType">��Ƴs������</param>
        public CodeGeneratorBase(string constring, string tableName, string schemaKeyName,
                        string commandName, string dataReaderName, string[] keyColumNames,
                        AccessDataBaseType databaseType)
            : this(tableName, schemaKeyName, commandName, dataReaderName, keyColumNames, databaseType)
        {
            this.m_Connectionstring = constring;
            IDataTool Idb = null;

            switch (databaseType)
            {
                case AccessDataBaseType.MSSQL:
                    Idb = new DataToolMSSQL(this.m_Connectionstring);
                    break;

                case AccessDataBaseType.Access:
                    Idb = new DataToolAccess(this.m_Connectionstring);
                    break;

                case AccessDataBaseType.ODBC:
                    Idb = new DataToolODBC(this.m_Connectionstring);
                    break;

                default:
                    break;
            }

            this.m_Dt = Idb.GetSchema("Select * From " + this.m_TableName);
        }

        /// <summary>
        /// �غc��
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="schemaKeyName">�b��ƪ��c���A��ܸ�����ݩ�D���ޭȪ��W��</param>
        /// <param name="commandName">������Ʈw��DataCommnad���W��</param>
        /// <param name="dataReaderName">������Ʈw��DataReader���W��</param>
        /// <param name="keyColumNames">�۩w���D���ޭȪ����X</param>
        /// <param name="databaseType">��Ƴs������</param>
        public CodeGeneratorBase(string tableName, string schemaKeyName, string commandName,
                        string dataReaderName, string[] keyColumNames, AccessDataBaseType databaseType)
        {
            this.m_TableName = tableName;
            this.m_SchemaKeyName = schemaKeyName;
    
            this.m_CommandName = commandName;
            this.m_DataReaderName = dataReaderName;
            this.InitClassContent(tableName);

            this.m_keyColumnNames = new List<string>(keyColumNames);
            this.m_MemberMethods = new List<CodeMemberMethod>();
        }

        #endregion

        #region �����ݩ�

        /// <summary>
        /// ��l��Class
        /// </summary>
        /// <param name="tableName"></param>
        private void InitClassContent(string tableName)
        {
            CodeConstructor constructor = new CodeConstructor();

            this.m_CodeClass = new CodeTypeDeclaration(string.Format("{0}Data", tableName));
            this.m_CodeClass.IsClass = true;
            this.m_CodeClass.Attributes = MemberAttributes.Public;

            constructor.Attributes = MemberAttributes.Public;

            this.m_CodeClass.Members.Add(constructor);
        }

        /// <summary>
        /// ���ͬ۹������ݩ�(��ƪ�۹��������)
        /// </summary>
        public void CreateDataProperty()
        {
            CodeMemberField field;
            CodeMemberProperty property;

            //this.mCodeClass.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, "Field And Property"));

            foreach (DataRow row in this.m_Dt.Rows)
            {
                string[] types = row["DataType"].ToString().Split(new char[] { ',' });
                string columnName = string.Format("m{0}", row["ColumnName"]);

                //Field
                field = new CodeMemberField(types[0], columnName);
                this.m_CodeClass.Members.Add(field);

                //Property
                property = new CodeMemberProperty();

                property.Attributes = MemberAttributes.Public;
                property.Type = new CodeTypeReference(types[0]);
                property.Name = row["ColumnName"].ToString();

                property.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), columnName)));

                property.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), columnName), new CodePropertySetValueReferenceExpression()));

                this.m_CodeClass.Members.Add(property);
            }

            //this.mCodeClass.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, string.Empty));
        }

        #endregion

        #region �s�W�έק諸����

        public void MethodContent(MethodType methodType)
        {
            this.MethodContent(this.m_Dt, methodType);
        }

        public void MethodContent(DataTable dt, MethodType methodType)
        {
            MethodGenerator mg;
            MethodGenerateOptions options = new MethodGenerateOptions();
            options.CommandName = this.m_CommandName;
            options.DataBaseType = this.DataBaseType;
            options.DataReaderName = this.m_DataReaderName;
            options.DataTable = dt;
            options.KeyColumnNames = this.m_keyColumnNames;
            options.SchemakeyName = this.m_SchemaKeyName;
            options.TableName = this.m_TableName;

            mg = new MethodGenerator(options);
            mg.CreateMethod(methodType);

            this.m_MemberMethods = mg.MemberMethods;
        }

        #endregion

        #region"���͵{���X"

        /// <summary>
        ///  ���͵{���X(���O)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GenerateClassCode(LanguageType type)
        {
            StringBuilder sb = new StringBuilder();
            CodeDomProvider provider;
            string code = string.Empty;

            switch (type)
            {
                case LanguageType.CSharp:
                    provider = new CSharpCodeProvider();
                    code = this.GetCodeString(provider, this.m_CodeClass);
                    break;

                case LanguageType.VB:
                    provider = new VBCodeProvider();
                    code = this.GetCodeString(provider, this.m_CodeClass);
                    break;

                default:
                    break;
            }

            return code;
        }

        /// <summary>
        /// ���͵{���X(��k)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GenerateMethodCode(LanguageType type)
        {
            StringBuilder sb = new StringBuilder();
            CodeDomProvider provider;

            foreach (CodeMemberMethod method in this.m_MemberMethods)
            {
                switch (type)
                {
                    case LanguageType.CSharp:
                        provider = new CSharpCodeProvider();
                        sb.AppendLine(this.GetCodeString(provider, method));
                        break;

                    case LanguageType.VB:
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