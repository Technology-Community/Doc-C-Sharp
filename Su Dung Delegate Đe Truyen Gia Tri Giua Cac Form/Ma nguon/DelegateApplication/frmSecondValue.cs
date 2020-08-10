using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DelegateApplication
{
    public partial class frmSecondValue : Form
    {
        public frmSecondValue()
        {
            InitializeComponent();
        }

        public delegate void PassSeconddata(string value);
        public PassSeconddata passSeconddata;

        private void btnSend_Click(object sender, EventArgs e)
        {
            //frmMain main = new frmMain();
            //main.GetSecondValue = txtValue.Text;
            //main.ShowDialog();
            //this.Hide();
            if (passSeconddata != null)
            {
                passSeconddata(txtValue.Text);
            }

            this.Hide();
        }
    }
}