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
            this.ckbObject = new System.Windows.Forms.CheckBox();
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
            this.btnProduce = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.rbnUpdate = new System.Windows.Forms.RadioButton();
            this.rbnInsert = new System.Windows.Forms.RadioButton();
            this.paramsEditor1 = new DB2Code.Controls.ParamsEditor();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ckbData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.paramsEditor1);
            this.splitContainer1.Panel2.Controls.Add(this.ckbObject);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.btnProduce);
            this.splitContainer1.Panel2.Controls.Add(this.btnEnter);
            this.splitContainer1.Panel2.Controls.Add(this.rbnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.rbnInsert);
            this.splitContainer1.Size = new System.Drawing.Size(1706, 1116);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 0;
            // 
            // ckbData
            // 
            this.ckbData.FormattingEnabled = true;
            this.ckbData.Location = new System.Drawing.Point(0, 0);
            this.ckbData.Margin = new System.Windows.Forms.Padding(7);
            this.ckbData.Name = "ckbData";
            this.ckbData.Size = new System.Drawing.Size(240, 1089);
            this.ckbData.TabIndex = 0;
            // 
            // ckbObject
            // 
            this.ckbObject.AutoSize = true;
            this.ckbObject.Location = new System.Drawing.Point(673, 263);
            this.ckbObject.Name = "ckbObject";
            this.ckbObject.Size = new System.Drawing.Size(285, 31);
            this.ckbObject.TabIndex = 15;
            this.ckbObject.Text = "啟用ComponentObject";
            this.ckbObject.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 327);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1457, 789);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtContent);
            this.tabPage1.Location = new System.Drawing.Point(10, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage1.Size = new System.Drawing.Size(1437, 733);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "程式碼";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.AllowDrop = true;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Location = new System.Drawing.Point(7, 7);
            this.txtContent.Margin = new System.Windows.Forms.Padding(7);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(1423, 719);
            this.txtContent.TabIndex = 8;
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCreateData);
            this.tabPage3.Controls.Add(this.clbKeys);
            this.tabPage3.Location = new System.Drawing.Point(10, 46);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage3.Size = new System.Drawing.Size(1437, 835);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "設定主索值";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(7, 0);
            this.btnCreateData.Margin = new System.Windows.Forms.Padding(7);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(175, 52);
            this.btnCreateData.TabIndex = 1;
            this.btnCreateData.Text = "產生資料";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // clbKeys
            // 
            this.clbKeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbKeys.FormattingEnabled = true;
            this.clbKeys.Location = new System.Drawing.Point(7, 89);
            this.clbKeys.Margin = new System.Windows.Forms.Padding(7);
            this.clbKeys.Name = "clbKeys";
            this.clbKeys.Size = new System.Drawing.Size(1423, 739);
            this.clbKeys.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSchemaKeyName);
            this.tabPage2.Controls.Add(this.btnXml);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtXml);
            this.tabPage2.Location = new System.Drawing.Point(10, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(7);
            this.tabPage2.Size = new System.Drawing.Size(1437, 835);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSchemaKeyName
            // 
            this.txtSchemaKeyName.Location = new System.Drawing.Point(245, 14);
            this.txtSchemaKeyName.Margin = new System.Windows.Forms.Padding(7);
            this.txtSchemaKeyName.Name = "txtSchemaKeyName";
            this.txtSchemaKeyName.Size = new System.Drawing.Size(244, 40);
            this.txtSchemaKeyName.TabIndex = 15;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(509, 14);
            this.btnXml.Margin = new System.Windows.Forms.Padding(7);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(387, 52);
            this.btnXml.TabIndex = 1;
            this.btnXml.Text = "產生Table的Schema(XML)";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 11, 5, 4);
            this.label5.Size = new System.Drawing.Size(204, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "SchemaKeyName";
            // 
            // txtXml
            // 
            this.txtXml.BackColor = System.Drawing.SystemColors.Control;
            this.txtXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtXml.Location = new System.Drawing.Point(7, 84);
            this.txtXml.Margin = new System.Windows.Forms.Padding(7);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.ReadOnly = true;
            this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXml.Size = new System.Drawing.Size(1423, 744);
            this.txtXml.TabIndex = 0;
            // 
            // btnProduce
            // 
            this.btnProduce.Location = new System.Drawing.Point(270, 249);
            this.btnProduce.Margin = new System.Windows.Forms.Padding(7);
            this.btnProduce.Name = "btnProduce";
            this.btnProduce.Size = new System.Drawing.Size(175, 52);
            this.btnProduce.TabIndex = 7;
            this.btnProduce.Text = "產生欄位";
            this.btnProduce.UseVisualStyleBackColor = true;
            this.btnProduce.Click += new System.EventHandler(this.btnProduce_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(459, 249);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(7);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(175, 52);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "確認";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // rbnUpdate
            // 
            this.rbnUpdate.AutoSize = true;
            this.rbnUpdate.Location = new System.Drawing.Point(159, 262);
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
            this.rbnInsert.Location = new System.Drawing.Point(35, 262);
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
            this.paramsEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.paramsEditor1.Location = new System.Drawing.Point(0, 0);
            this.paramsEditor1.Name = "paramsEditor1";
            this.paramsEditor1.Size = new System.Drawing.Size(1457, 218);
            this.paramsEditor1.TabIndex = 16;
            // 
            // Customeize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 1116);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Customeize";
            this.Text = "自定";
            this.Load += new System.EventHandler(this.Customeize_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
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
        private System.Windows.Forms.RadioButton rbnInsert;
        private System.Windows.Forms.RadioButton rbnUpdate;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnProduce;
        private System.Windows.Forms.CheckedListBox ckbData;
        private System.Windows.Forms.TextBox txtContent;
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
        private System.Windows.Forms.CheckBox ckbObject;
        private Controls.ParamsEditor paramsEditor1;
    }
}