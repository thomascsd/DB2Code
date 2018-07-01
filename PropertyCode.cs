using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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

            this.cd.CreateDataProperty();

            switch (cbxLang.SelectedItem.ToString())
            {
                case "C#":
                    code = this.cd.GenerateClassCode(LanguageType.CSharp);
                    break;
                case "VB":
                    code = this.cd.GenerateClassCode(LanguageType.VB);
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

