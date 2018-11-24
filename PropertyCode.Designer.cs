namespace DB2Code
{
    partial class PropertyCode
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
            this.paramsEditor1 = new DB2Code.Controls.ParamsEditor();
            this.txtProperty = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paramsEditor1
            // 
            this.paramsEditor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.paramsEditor1.Location = new System.Drawing.Point(0, 0);
            this.paramsEditor1.Name = "paramsEditor1";
            this.paramsEditor1.Size = new System.Drawing.Size(1518, 198);
            this.paramsEditor1.TabIndex = 0;
            // 
            // txtProperty
            // 
            this.txtProperty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtProperty.Location = new System.Drawing.Point(0, 292);
            this.txtProperty.Multiline = true;
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.Size = new System.Drawing.Size(1518, 557);
            this.txtProperty.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(16, 208);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(7);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(175, 52);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "確認";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // PropertyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1518, 849);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtProperty);
            this.Controls.Add(this.paramsEditor1);
            this.MaximizeBox = false;
            this.Name = "PropertyCode";
            this.Text = "資料屬性";
            this.Load += new System.EventHandler(this.PropertyCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ParamsEditor paramsEditor1;
        private System.Windows.Forms.TextBox txtProperty;
        protected System.Windows.Forms.Button btnEnter;
    }
}
