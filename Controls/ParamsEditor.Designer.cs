namespace DB2Code.Controls
{
    partial class ParamsEditor
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbnCSharp = new System.Windows.Forms.RadioButton();
            this.rbnVb = new System.Windows.Forms.RadioButton();
            this.cbConnectionString = new System.Windows.Forms.ComboBox();
            this.rbnMsSql = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbnAccess = new System.Windows.Forms.RadioButton();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 11, 5, 4);
            this.label4.Size = new System.Drawing.Size(76, 42);
            this.label4.TabIndex = 20;
            this.label4.Text = "語言";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 11, 5, 4);
            this.label3.Size = new System.Drawing.Size(157, 42);
            this.label3.TabIndex = 19;
            this.label3.Text = "資料庫類型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-201, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 11, 5, 4);
            this.label1.Size = new System.Drawing.Size(130, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "連線字串";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-201, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 11, 5, 4);
            this.label2.Size = new System.Drawing.Size(157, 42);
            this.label2.TabIndex = 18;
            this.label2.Text = "資料表名稱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 11, 5, 4);
            this.label5.Size = new System.Drawing.Size(130, 42);
            this.label5.TabIndex = 21;
            this.label5.Text = "連線字串";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 11, 5, 4);
            this.label6.Size = new System.Drawing.Size(157, 42);
            this.label6.TabIndex = 22;
            this.label6.Text = "資料表名稱";
            // 
            // rbnCSharp
            // 
            this.rbnCSharp.AutoSize = true;
            this.rbnCSharp.Checked = true;
            this.rbnCSharp.Location = new System.Drawing.Point(93, 46);
            this.rbnCSharp.Name = "rbnCSharp";
            this.rbnCSharp.Size = new System.Drawing.Size(73, 31);
            this.rbnCSharp.TabIndex = 23;
            this.rbnCSharp.TabStop = true;
            this.rbnCSharp.Text = "C#";
            this.rbnCSharp.UseVisualStyleBackColor = true;
            // 
            // rbnVb
            // 
            this.rbnVb.AutoSize = true;
            this.rbnVb.Location = new System.Drawing.Point(188, 46);
            this.rbnVb.Name = "rbnVb";
            this.rbnVb.Size = new System.Drawing.Size(134, 31);
            this.rbnVb.TabIndex = 24;
            this.rbnVb.Text = "VB.NET";
            this.rbnVb.UseVisualStyleBackColor = true;
            // 
            // cbConnectionString
            // 
            this.cbConnectionString.FormattingEnabled = true;
            this.cbConnectionString.Location = new System.Drawing.Point(204, 47);
            this.cbConnectionString.Name = "cbConnectionString";
            this.cbConnectionString.Size = new System.Drawing.Size(1298, 35);
            this.cbConnectionString.TabIndex = 25;
            // 
            // rbnMsSql
            // 
            this.rbnMsSql.AutoSize = true;
            this.rbnMsSql.Checked = true;
            this.rbnMsSql.Location = new System.Drawing.Point(174, 47);
            this.rbnMsSql.Name = "rbnMsSql";
            this.rbnMsSql.Size = new System.Drawing.Size(128, 31);
            this.rbnMsSql.TabIndex = 26;
            this.rbnMsSql.TabStop = true;
            this.rbnMsSql.Text = "MSSQL";
            this.rbnMsSql.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rbnCSharp);
            this.panel1.Controls.Add(this.rbnVb);
            this.panel1.Location = new System.Drawing.Point(1141, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 100);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbnAccess);
            this.panel2.Controls.Add(this.rbnMsSql);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(549, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 100);
            this.panel2.TabIndex = 28;
            // 
            // rbnAccess
            // 
            this.rbnAccess.AutoSize = true;
            this.rbnAccess.Location = new System.Drawing.Point(308, 47);
            this.rbnAccess.Name = "rbnAccess";
            this.rbnAccess.Size = new System.Drawing.Size(114, 31);
            this.rbnAccess.TabIndex = 27;
            this.rbnAccess.Text = "Access";
            this.rbnAccess.UseVisualStyleBackColor = true;
            // 
            // txtTableName
            // 
            this.txtTableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTableName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTableName.Location = new System.Drawing.Point(207, 126);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(7);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(271, 40);
            this.txtTableName.TabIndex = 14;
            // 
            // ParamsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbConnectionString);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ParamsEditor";
            this.Size = new System.Drawing.Size(1544, 241);
            this.Load += new System.EventHandler(this.ParamsEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbnCSharp;
        private System.Windows.Forms.RadioButton rbnVb;
        private System.Windows.Forms.ComboBox cbConnectionString;
        private System.Windows.Forms.RadioButton rbnMsSql;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbnAccess;
        protected System.Windows.Forms.TextBox txtTableName;
    }
}
