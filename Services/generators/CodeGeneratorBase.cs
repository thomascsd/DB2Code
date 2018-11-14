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

        private GeneratorOption m_Option;

        private List<CodeMemberMethod> m_MemberMethods;
        private CodeTypeDeclaration m_CodeClass;
        private DataTable m_Dt;

        private List<string> m_keyColumnNames;

        private string m_MethodName;

        /// <summary>
        /// �]�A��Ƶ��c��DataTable
        /// </summary>
        public DataTable DataSource
        {
            get { return m_Dt; }
        }

        /// <summary>
        /// ��Ƴs������
        /// </summary>
        public abstract AccessDataBaseType DataBaseType { get; }

        #endregion

        #region �غc��

        /// <summary>
        /// �غc��
        /// </summary>
        public CodeGeneratorBase(GeneratorOption option)
        {
            this.m_Option = option;
            this.InitClassContent(option.TableName);
            this.m_keyColumnNames = new List<string>(option.KeyColunmNames);
            this.m_MemberMethods = new List<CodeMemberMethod>();
            this.Initialize();
        }

        #endregion

        public void Initialize()
        {
            IDataTool Idb;

            switch (this.DataBaseType)
            {
                default:
                case AccessDataBaseType.MsSql:
                    Idb = new DataToolMSSQL(this.m_Option.Connectionstring);
                    break;

                case AccessDataBaseType.Access:
                    Idb = new DataToolAccess(this.m_Option.Connectionstring);
                    break;

                case AccessDataBaseType.ODBC:
                    Idb = new DataToolODBC(this.m_Option.Connectionstring);
                    break;
            }

            this.m_Dt = Idb.GetSchema("Select * From " + this.m_Option.TableName);
        }

        #region �����ݩ�

        /// <summary>
        /// ��l��Class
        /// </summary>
        /// <param name="tableName"></param>
        private void InitClassContent(string tableName)
        {
            CodeConstructor constructor = new CodeConstructor();

            this.m_CodeClass = new CodeTypeDeclaration($"{tableName}Data")
            {
                IsClass = true,
                Attributes = MemberAttributes.Public
            };

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
                string columnName = $"m{row["ColumnName"]}";

                //Field
                field = new CodeMemberField(types[0], columnName);
                this.m_CodeClass.Members.Add(field);

                //Property
                property = new CodeMemberProperty
                {
                    Attributes = MemberAttributes.Public,
                    Type = new CodeTypeReference(types[0]),
                    Name = row["ColumnName"].ToString()
                };

                property.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), columnName)));

                property.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), columnName), new CodePropertySetValueReferenceExpression()));

                this.m_CodeClass.Members.Add(property);
            }

            //this.mCodeClass.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, string.Empty));
        }

        #endregion

        #region �s�W�έק諸����

        public void MethodContent(MethodType methodType, bool enableDataObjectMethod)
        {
            this.MethodContent(this.m_Dt, methodType, enableDataObjectMethod);
        }

        public void MethodContent(DataTable dt, MethodType methodType, bool enableDataObjectMethod)
        {
            MethodGenerator mg;
            MethodGenerateOption option = new MethodGenerateOption
            {
                CommandName = this.m_Option.CommandName,
                DataBaseType = this.DataBaseType,
                DataReaderName = this.m_Option.DataReaderName,
                DataTable = dt,
                KeyColunmNames = this.m_keyColumnNames,
                SchemaKeyName = this.m_Option.SchemaKeyName,
                TableName = this.m_Option.TableName,
                MethodType = methodType
            };

            mg = new MethodGenerator();
            mg.CreateMethod(option);

            this.m_MemberMethods = mg.MemberMethods;
        }

        #endregion

        #region ���͵{���X

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
                default:
                case LanguageType.CSharp:
                    provider = new CSharpCodeProvider();
                    code = this.GetCodeString(provider, this.m_CodeClass);
                    break;

                case LanguageType.VB:
                    provider = new VBCodeProvider();
                    code = this.GetCodeString(provider, this.m_CodeClass);
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
                    default:
                    case LanguageType.CSharp:
                        provider = new CSharpCodeProvider();
                        sb.AppendLine(this.GetCodeString(provider, method));
                        break;

                    case LanguageType.VB:
                        provider = new VBCodeProvider();
                        sb.AppendLine(this.GetCodeString(provider, method));
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