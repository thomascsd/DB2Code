namespace DB2Code
{
    partial class PropertyCode
    {
        /// <summary>
        /// �]�p�u��һݪ��ܼơC
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// �M������ϥΤ����귽�C
        /// </summary>
        /// <param name="disposing">�p�G���Ӥ��} Managed �귽�h�� true�A�_�h�� false�C</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form �]�p�u�㲣�ͪ��{���X

        /// <summary>
        /// �����]�p�u��䴩�һݪ���k - �ФŨϥε{���X�s�边�ק�o�Ӥ�k�����e�C
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
