using System;

namespace DB2Code
{
    public partial class PropertyCode : DB2Code.Form1
    {
        public PropertyCode()
        {
            InitializeComponent();
        }

        protected override void CreateCode()
        {
            string code = string.Empty;
            txtContent.Text = string.Empty;

            this.CodeGenerator.CreateDataProperty();

            switch (cbxLang.SelectedItem.ToString())
            {
                case "C#":
                    code = this.CodeGenerator.GenerateClassCode(LanguageType.CSharp);
                    break;

                case "VB":
                    code = this.CodeGenerator.GenerateClassCode(LanguageType.VB);
                    break;

                default:
                    break;
            }

            txtContent.Text = code;
        }

        private void PropertyCode_Load(object sender, EventArgs e)
        {
            this.Text = "¸ê®ÆÄÝ©Ê";
            rbnInsert.Visible = false;
            rbnUpdate.Visible = false;
            rbnSelect.Visible = false;
            this.Width = base.Width;
            this.Height = base.Height;
        }
    }
}