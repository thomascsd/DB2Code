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
            this.btnEnter.Text = "�T�{";
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
            this.Text = "����ݩ�";
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
