using DB2Code.Services.generators;
using System;
using System.Windows.Forms;

namespace DB2Code
{
    public partial class PropertyCode : Form
    {
        private CodeGeneratorBase m_CodeGenerator;

        public PropertyCode()
        {
            InitializeComponent();
        }

        private void PropertyCode_Load(object sender, EventArgs e)
        {
        }

        private void CreateGenerator()
        {
            GeneratorOption option = new GeneratorOption
            {
                ConnectionString = paramsEditor1.CurrentConnectionString,
                TableName = paramsEditor1.CurrentTableName
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

        private void CreateProperty()
        {
            string code = string.Empty;
            txtProperty.Text = string.Empty;

            this.m_CodeGenerator.CreateDataProperty();

            switch (paramsEditor1.CurrentLanguage)
            {
                default:
                case "C#":
                    code = this.m_CodeGenerator.GenerateClassCode(LanguageType.CSharp);
                    break;

                case "VB.NET":
                    code = this.m_CodeGenerator.GenerateClassCode(LanguageType.VB);
                    break;
            }

            txtProperty.Text = code;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.CreateGenerator();
            this.CreateProperty();
        }
    }
}