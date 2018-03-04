namespace DB2Code
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.txtContent = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCode = new System.Windows.Forms.TabPage();
            this.tbKeyColumn = new System.Windows.Forms.TabPage();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.clbkeys = new System.Windows.Forms.CheckedListBox();
            this.tbXml = new System.Windows.Forms.TabPage();
            this.txtSchemaKeyName = new System.Windows.Forms.TextBox();
            this.btnXml = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnSelect = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLang = new System.Windows.Forms.ComboBox();
            this.cbDbType = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConstring = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnUpdate = new System.Windows.Forms.RadioButton();
            this.rbnInsert = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tbCode.SuspendLayout();
            this.tbKeyColumn.SuspendLayout();
            this.tbXml.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.AllowDrop = true;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(3, 3);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(639, 375);
            this.txtContent.TabIndex = 0;
            this.txtContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCode);
            this.tabControl1.Controls.Add(this.tbKeyColumn);
            this.tabControl1.Controls.Add(this.tbXml);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCode
            // 
            this.tbCode.Controls.Add(this.txtContent);
            this.tbCode.Location = new System.Drawing.Point(4, 21);
            this.tbCode.Name = "tbCode";
            this.tbCode.Padding = new System.Windows.Forms.Padding(3);
            this.tbCode.Size = new System.Drawing.Size(645, 381);
            this.tbCode.TabIndex = 0;
            this.tbCode.Text = "程式碼";
            this.tbCode.UseVisualStyleBackColor = true;
            // 
            // tbKeyColumn
            // 
            this.tbKeyColumn.Controls.Add(this.btnCreateData);
            this.tbKeyColumn.Controls.Add(this.clbkeys);
            this.tbKeyColumn.Location = new System.Drawing.Point(4, 21);
            this.tbKeyColumn.Name = "tbKeyColumn";
            this.tbKeyColumn.Padding = new System.Windows.Forms.Padding(3);
            this.tbKeyColumn.Size = new System.Drawing.Size(645, 381);
            this.tbKeyColumn.TabIndex = 2;
            this.tbKeyColumn.Text = "設定主索引值";
            this.tbKeyColumn.UseVisualStyleBackColor = true;
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(0, 0);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(75, 23);
            this.btnCreateData.TabIndex = 4;
            this.btnCreateData.Text = "產生資料";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // clbkeys
            // 
            this.clbkeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbkeys.FormattingEnabled = true;
            this.clbkeys.Location = new System.Drawing.Point(3, 34);
            this.clbkeys.Name = "clbkeys";
            this.clbkeys.Size = new System.Drawing.Size(639, 344);
            this.clbkeys.TabIndex = 3;
            // 
            // tbXml
            // 
            this.tbXml.Controls.Add(this.txtSchemaKeyName);
            this.tbXml.Controls.Add(this.btnXml);
            this.tbXml.Controls.Add(this.label5);
            this.tbXml.Controls.Add(this.txtXml);
            this.tbXml.Location = new System.Drawing.Point(4, 21);
            this.tbXml.Name = "tbXml";
            this.tbXml.Padding = new System.Windows.Forms.Padding(3);
            this.tbXml.Size = new System.Drawing.Size(645, 381);
            this.tbXml.TabIndex = 1;
            this.tbXml.Text = "XML";
            this.tbXml.UseVisualStyleBackColor = true;
            // 
            // txtSchemaKeyName
            // 
            this.txtSchemaKeyName.Location = new System.Drawing.Point(101, 6);
            this.txtSchemaKeyName.Name = "txtSchemaKeyName";
            this.txtSchemaKeyName.Size = new System.Drawing.Size(107, 22);
            this.txtSchemaKeyName.TabIndex = 3;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(215, 6);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(166, 23);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "產生Table的Schema(XML)";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "SchemaKeyName";
            // 
            // txtXml
            // 
            this.txtXml.BackColor = System.Drawing.SystemColors.Control;
            this.txtXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtXml.Location = new System.Drawing.Point(3, 34);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.ReadOnly = true;
            this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXml.Size = new System.Drawing.Size(639, 344);
            this.txtXml.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnSelect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxLang);
            this.groupBox1.Controls.Add(this.cbDbType);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConstring);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbnUpdate);
            this.groupBox1.Controls.Add(this.rbnInsert);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbnSelect
            // 
            this.rbnSelect.AutoSize = true;
            this.rbnSelect.Location = new System.Drawing.Point(12, 77);
            this.rbnSelect.Name = "rbnSelect";
            this.rbnSelect.Size = new System.Drawing.Size(47, 16);
            this.rbnSelect.TabIndex = 13;
            this.rbnSelect.Text = "查詢";
            this.rbnSelect.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 46);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "語言";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 46);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "資料庫類型";
            // 
            // cbxLang
            // 
            this.cbxLang.FormattingEnabled = true;
            this.cbxLang.Items.AddRange(new object[] {
            "C#",
            "VB"});
            this.cbxLang.Location = new System.Drawing.Point(532, 43);
            this.cbxLang.Name = "cbxLang";
            this.cbxLang.Size = new System.Drawing.Size(90, 20);
            this.cbxLang.TabIndex = 4;
            // 
            // cbDbType
            // 
            this.cbDbType.FormattingEnabled = true;
            this.cbDbType.Items.AddRange(new object[] {
            "DB2",
            "MSSQL",
            "Access"});
            this.cbDbType.Location = new System.Drawing.Point(366, 43);
            this.cbDbType.Name = "cbDbType";
            this.cbDbType.Size = new System.Drawing.Size(121, 20);
            this.cbDbType.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(203, 74);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "確認";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(105, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "連線字串";
            // 
            // txtConstring
            // 
            this.txtConstring.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtConstring.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtConstring.Location = new System.Drawing.Point(105, 15);
            this.txtConstring.Name = "txtConstring";
            this.txtConstring.Size = new System.Drawing.Size(517, 22);
            this.txtConstring.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "資料表名稱";
            // 
            // rbnUpdate
            // 
            this.rbnUpdate.AutoSize = true;
            this.rbnUpdate.Location = new System.Drawing.Point(118, 77);
            this.rbnUpdate.Name = "rbnUpdate";
            this.rbnUpdate.Size = new System.Drawing.Size(47, 16);
            this.rbnUpdate.TabIndex = 6;
            this.rbnUpdate.Text = "修改";
            this.rbnUpdate.UseVisualStyleBackColor = true;
            // 
            // rbnInsert
            // 
            this.rbnInsert.AutoSize = true;
            this.rbnInsert.Checked = true;
            this.rbnInsert.Location = new System.Drawing.Point(65, 77);
            this.rbnInsert.Name = "rbnInsert";
            this.rbnInsert.Size = new System.Drawing.Size(47, 16);
            this.rbnInsert.TabIndex = 5;
            this.rbnInsert.TabStop = true;
            this.rbnInsert.Text = "新增";
            this.rbnInsert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "普通";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tbCode.ResumeLayout(false);
            this.tbCode.PerformLayout();
            this.tbKeyColumn.ResumeLayout(false);
            this.tbXml.ResumeLayout(false);
            this.tbXml.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox txtContent;
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tbCode;
        protected System.Windows.Forms.TabPage tbXml;
        protected System.Windows.Forms.Button btnXml;
        protected System.Windows.Forms.TextBox txtXml;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox txtSchemaKeyName;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.ComboBox cbxLang;
        protected System.Windows.Forms.ComboBox cbDbType;
        protected System.Windows.Forms.Button btnEnter;
        protected System.Windows.Forms.TextBox txtName;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtConstring;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.RadioButton rbnUpdate;
        protected System.Windows.Forms.RadioButton rbnInsert;
        protected System.Windows.Forms.RadioButton rbnSelect;
        private System.Windows.Forms.TabPage tbKeyColumn;
        protected System.Windows.Forms.CheckedListBox clbkeys;
        private System.Windows.Forms.Button btnCreateData;
    }
}

