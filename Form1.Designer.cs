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
            this.ckbObject = new System.Windows.Forms.CheckBox();
            this.rbnSelect = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.rbnUpdate = new System.Windows.Forms.RadioButton();
            this.rbnInsert = new System.Windows.Forms.RadioButton();
            this.paramsEditor1 = new DB2Code.Controls.ParamsEditor();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbCode.SuspendLayout();
            this.tbKeyColumn.SuspendLayout();
            this.tbXml.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCode);
            this.tabControl1.Controls.Add(this.tbKeyColumn);
            this.tabControl1.Controls.Add(this.tbXml);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 374);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1614, 850);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCode
            // 
            this.tbCode.Controls.Add(this.txtContent);
            this.tbCode.Location = new System.Drawing.Point(10, 46);
            this.tbCode.Margin = new System.Windows.Forms.Padding(7);
            this.tbCode.Name = "tbCode";
            this.tbCode.Padding = new System.Windows.Forms.Padding(7);
            this.tbCode.Size = new System.Drawing.Size(1594, 794);
            this.tbCode.TabIndex = 0;
            this.tbCode.Text = "程式碼";
            this.tbCode.UseVisualStyleBackColor = true;
            // 
            // tbKeyColumn
            // 
            this.tbKeyColumn.Controls.Add(this.btnCreateData);
            this.tbKeyColumn.Controls.Add(this.clbkeys);
            this.tbKeyColumn.Location = new System.Drawing.Point(10, 46);
            this.tbKeyColumn.Margin = new System.Windows.Forms.Padding(7);
            this.tbKeyColumn.Name = "tbKeyColumn";
            this.tbKeyColumn.Padding = new System.Windows.Forms.Padding(7);
            this.tbKeyColumn.Size = new System.Drawing.Size(1594, 794);
            this.tbKeyColumn.TabIndex = 2;
            this.tbKeyColumn.Text = "設定主索引值";
            this.tbKeyColumn.UseVisualStyleBackColor = true;
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(0, 0);
            this.btnCreateData.Margin = new System.Windows.Forms.Padding(7);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(175, 52);
            this.btnCreateData.TabIndex = 4;
            this.btnCreateData.Text = "產生資料";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // clbkeys
            // 
            this.clbkeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbkeys.FormattingEnabled = true;
            this.clbkeys.Location = new System.Drawing.Point(7, 48);
            this.clbkeys.Margin = new System.Windows.Forms.Padding(7);
            this.clbkeys.Name = "clbkeys";
            this.clbkeys.Size = new System.Drawing.Size(1580, 739);
            this.clbkeys.TabIndex = 3;
            // 
            // tbXml
            // 
            this.tbXml.Controls.Add(this.txtSchemaKeyName);
            this.tbXml.Controls.Add(this.btnXml);
            this.tbXml.Controls.Add(this.label5);
            this.tbXml.Controls.Add(this.txtXml);
            this.tbXml.Location = new System.Drawing.Point(10, 46);
            this.tbXml.Margin = new System.Windows.Forms.Padding(7);
            this.tbXml.Name = "tbXml";
            this.tbXml.Padding = new System.Windows.Forms.Padding(7);
            this.tbXml.Size = new System.Drawing.Size(1594, 794);
            this.tbXml.TabIndex = 1;
            this.tbXml.Text = "XML";
            this.tbXml.UseVisualStyleBackColor = true;
            // 
            // txtSchemaKeyName
            // 
            this.txtSchemaKeyName.Location = new System.Drawing.Point(235, 26);
            this.txtSchemaKeyName.Margin = new System.Windows.Forms.Padding(7);
            this.txtSchemaKeyName.Name = "txtSchemaKeyName";
            this.txtSchemaKeyName.Size = new System.Drawing.Size(244, 40);
            this.txtSchemaKeyName.TabIndex = 3;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(502, 27);
            this.btnXml.Margin = new System.Windows.Forms.Padding(7);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(387, 52);
            this.btnXml.TabIndex = 3;
            this.btnXml.Text = "產生Table的Schema(XML)";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 11, 5, 4);
            this.label5.Size = new System.Drawing.Size(204, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "SchemaKeyName";
            // 
            // txtXml
            // 
            this.txtXml.BackColor = System.Drawing.SystemColors.Control;
            this.txtXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtXml.Location = new System.Drawing.Point(7, 7);
            this.txtXml.Margin = new System.Windows.Forms.Padding(7);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.ReadOnly = true;
            this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXml.Size = new System.Drawing.Size(1580, 780);
            this.txtXml.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paramsEditor1);
            this.groupBox1.Controls.Add(this.ckbObject);
            this.groupBox1.Controls.Add(this.rbnSelect);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.rbnUpdate);
            this.groupBox1.Controls.Add(this.rbnInsert);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(1614, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ckbObject
            // 
            this.ckbObject.AutoSize = true;
            this.ckbObject.Location = new System.Drawing.Point(692, 252);
            this.ckbObject.Name = "ckbObject";
            this.ckbObject.Size = new System.Drawing.Size(285, 31);
            this.ckbObject.TabIndex = 14;
            this.ckbObject.Text = "啟用ComponentObject";
            this.ckbObject.UseVisualStyleBackColor = true;
            // 
            // rbnSelect
            // 
            this.rbnSelect.AutoSize = true;
            this.rbnSelect.Location = new System.Drawing.Point(41, 251);
            this.rbnSelect.Margin = new System.Windows.Forms.Padding(7);
            this.rbnSelect.Name = "rbnSelect";
            this.rbnSelect.Size = new System.Drawing.Size(97, 31);
            this.rbnSelect.TabIndex = 13;
            this.rbnSelect.Text = "查詢";
            this.rbnSelect.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(480, 240);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(7);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(175, 52);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "確認";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // rbnUpdate
            // 
            this.rbnUpdate.AutoSize = true;
            this.rbnUpdate.Location = new System.Drawing.Point(288, 251);
            this.rbnUpdate.Margin = new System.Windows.Forms.Padding(7);
            this.rbnUpdate.Name = "rbnUpdate";
            this.rbnUpdate.Size = new System.Drawing.Size(97, 31);
            this.rbnUpdate.TabIndex = 6;
            this.rbnUpdate.Text = "修改";
            this.rbnUpdate.UseVisualStyleBackColor = true;
            // 
            // rbnInsert
            // 
            this.rbnInsert.AutoSize = true;
            this.rbnInsert.Checked = true;
            this.rbnInsert.Location = new System.Drawing.Point(165, 251);
            this.rbnInsert.Margin = new System.Windows.Forms.Padding(7);
            this.rbnInsert.Name = "rbnInsert";
            this.rbnInsert.Size = new System.Drawing.Size(97, 31);
            this.rbnInsert.TabIndex = 5;
            this.rbnInsert.TabStop = true;
            this.rbnInsert.Text = "新增";
            this.rbnInsert.UseVisualStyleBackColor = true;
            // 
            // paramsEditor1
            // 
            this.paramsEditor1.Location = new System.Drawing.Point(0, 0);
            this.paramsEditor1.Name = "paramsEditor1";
            this.paramsEditor1.Size = new System.Drawing.Size(1524, 207);
            this.paramsEditor1.TabIndex = 15;
            // 
            // txtContent
            // 
            this.txtContent.AllowDrop = true;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContent.Location = new System.Drawing.Point(7, 0);
            this.txtContent.Margin = new System.Windows.Forms.Padding(7);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(1580, 787);
            this.txtContent.TabIndex = 0;
            this.txtContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1614, 1224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "普通";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tbCode;
        protected System.Windows.Forms.TabPage tbXml;
        protected System.Windows.Forms.Button btnXml;
        protected System.Windows.Forms.TextBox txtXml;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox txtSchemaKeyName;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnEnter;
        protected System.Windows.Forms.RadioButton rbnUpdate;
        protected System.Windows.Forms.RadioButton rbnInsert;
        protected System.Windows.Forms.RadioButton rbnSelect;
        private System.Windows.Forms.TabPage tbKeyColumn;
        protected System.Windows.Forms.CheckedListBox clbkeys;
        private System.Windows.Forms.Button btnCreateData;
        private System.Windows.Forms.CheckBox ckbObject;
        private Controls.ParamsEditor paramsEditor1;
        protected System.Windows.Forms.TextBox txtContent;
    }
}

