namespace DB2Code
{
    partial class BaseForm
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
            this.btnBase = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(38, 12);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(120, 60);
            this.btnBase.TabIndex = 0;
            this.btnBase.Text = "普通";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(245, 12);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(120, 60);
            this.btn.TabIndex = 1;
            this.btn.Text = "自訂";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.Location = new System.Drawing.Point(38, 131);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(120, 60);
            this.btnProperty.TabIndex = 2;
            this.btnProperty.Text = "屬性";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 316);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnBase);
            this.Name = "BaseForm";
            this.Text = "ADO.net程式碼產生器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnProperty;
    }
}