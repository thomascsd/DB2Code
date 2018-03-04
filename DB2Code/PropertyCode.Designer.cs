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
            this.tabControl1.SuspendLayout();
            this.tbCode.SuspendLayout();
            this.tbXml.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Size = new System.Drawing.Size(654, 375);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 102);
            this.tabControl1.Size = new System.Drawing.Size(668, 406);
            // 
            // tbCode
            // 
            this.tbCode.Size = new System.Drawing.Size(660, 381);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(668, 96);
            // 
            // PropertyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(668, 508);
            this.Name = "PropertyCode";
            this.Load += new System.EventHandler(this.PropertyCode_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbCode.ResumeLayout(false);
            this.tbCode.PerformLayout();
            this.tbXml.ResumeLayout(false);
            this.tbXml.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
