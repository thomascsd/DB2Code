using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2Code
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Customeize fm = new Customeize();
            fm.Show();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            PropertyCode pc = new PropertyCode();
            pc.Show();
        }
    }
}