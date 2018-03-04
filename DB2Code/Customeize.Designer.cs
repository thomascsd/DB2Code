namespace DB2Code
{
    partial class Customeize
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ckbData = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.clbKeys = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSchemaKeyName = new System.Windows.Forms.TextBox();
            this.btnXml = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.cbxLang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDbType = new System.Windows.Forms.ComboBox();
            this.btnProduce = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbnUpdate = new System.Windows.Forms.RadioButton();
            this.rbnInsert = new System.Windows.Forms.RadioButton();
            this.txtConstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ckbData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.cbxLang);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.cbDbType);
            this.splitContainer1.Panel2.Controls.Add(this.btnProduce);
            this.splitContainer1.Panel2.Controls.Add(this.btnEnter);
            this.splitContainer1.Panel2.Controls.Add(this.txtName);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.rbnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.rbnInsert);
            this.splitContainer1.Panel2.Controls.Add(this.txtConstring);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(731, 496);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 0;
            // 
            // ckbData
            // 
            this.ckbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbData.FormattingEnabled = true;
            this.ckbData.Location = new System.Drawing.Point(0, 0);
            this.ckbData.Name = "ckbData";
            this.ckbData.Size = new System.Drawing.Size(103, 480);
            this.ckbData.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 396);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtContent);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "程式碼";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.AllowDrop = true;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(3, 3);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(610, 365);
            this.txtContent.TabIndex = 8;
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCreateData);
            this.tabPage3.Controls.Add(this.clbKeys);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(616, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "設定主索值";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(3, 0);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(75, 23);
            this.btnCreateData.TabIndex = 1;
            this.btnCreateData.Text = "產生資料";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // clbKeys
            // 
            this.clbKeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbKeys.FormattingEnabled = true;
            this.clbKeys.Location = new System.Drawing.Point(3, 24);
            this.clbKeys.Name = "clbKeys";
            this.clbKeys.Size = new System.Drawing.Size(610, 344);
            this.clbKeys.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSchemaKeyName);
            this.tabPage2.Controls.Add(this.btnXml);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtXml);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSchemaKeyName
            // 
            this.txtSchemaKeyName.Location = new System.Drawing.Point(105, 6);
            this.txtSchemaKeyName.Name = "txtSchemaKeyName";
            this.txtSchemaKeyName.Size = new System.Drawing.Size(107, 22);
            this.txtSchemaKeyName.TabIndex = 15;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(218, 6);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(166, 23);
            this.btnXml.TabIndex = 1;
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
            this.label5.TabIndex = 14;
            this.label5.Text = "SchemaKeyName";
            // 
            // txtXml
            // 
            this.txtXml.BackColor = System.Drawing.SystemColors.Control;
            this.txtXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtXml.Location = new System.Drawing.Point(3, 35);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.ReadOnly = true;
            this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXml.Size = new System.Drawing.Size(610, 333);
            this.txtXml.TabIndex = 0;
            // 
            // cbxLang
            // 
            this.cbxLang.FormattingEnabled = true;
            this.cbxLang.Items.AddRange(new object[] {
            "C#",
            "VB"});
            this.cbxLang.Location = new System.Drawing.Point(511, 35);
            this.cbxLang.Name = "cbxLang";
            this.cbxLang.Size = new System.Drawing.Size(80, 20);
            this.cbxLang.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 38);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "語言";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 38);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "資料表類型";
            // 
            // cbDbType
            // 
            this.cbDbType.FormattingEnabled = true;
            this.cbDbType.Items.AddRange(new object[] {
            "DB2",
            "MSSQL",
            "Access"});
            this.cbDbType.Location = new System.Drawing.Point(345, 35);
            this.cbDbType.Name = "cbDbType";
            this.cbDbType.Size = new System.Drawing.Size(121, 20);
            this.cbDbType.TabIndex = 9;
            // 
            // btnProduce
            // 
            this.btnProduce.Location = new System.Drawing.Point(404, 71);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(75, 23);
            this.btnProduce.TabIndex = 7;
            this.btnProduce.Text = "產生欄位";
            this.btnProduce.UseVisualStyleBackColor = true;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(485, 70);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "確認";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(97, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(167, 22);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 38);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "資料表名稱";
            // 
            // rbnUpdate
            // 
            this.rbnUpdate.AutoSize = true;
            this.rbnUpdate.Location = new System.Drawing.Point(351, 78);
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
            this.rbnInsert.Location = new System.Drawing.Point(298, 78);
            this.rbnInsert.Name = "rbnInsert";
            this.rbnInsert.Size = new System.Drawing.Size(47, 16);
            this.rbnInsert.TabIndex = 5;
            this.rbnInsert.TabStop = true;
            this.rbnInsert.Text = "新增";
            this.rbnInsert.UseVisualStyleBackColor = true;
            // 
            // txtConstring
            // 
            this.txtConstring.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtConstring.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtConstring.Location = new System.Drawing.Point(97, 3);
            this.txtConstring.Name = "txtConstring";
            this.txtConstring.Size = new System.Drawing.Size(494, 22);
            this.txtConstring.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "連線字串";
            // 
            // Customeize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 496);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Customeize";
            this.Text = "自定";
            this.Load += new System.EventHandler(this.Customeize_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConstring;
        private System.Windows.Forms.RadioButton rbnInsert;
        private System.Windows.Forms.RadioButton rbnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.CheckedListBox ckbData;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cbDbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSchemaKeyName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox clbKeys;
        private System.Windows.Forms.Button btnCreateData;
    }
}