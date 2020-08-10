using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DelegateApplication
{
    public partial class frmFirstValue : Form
    {
        public frmFirstValue()
        {
            InitializeComponent();
        }

        public delegate void PassData(string value);
        public PassData passData;

        private void btnSend_Click(object sender, EventArgs e)
        {
            //frmMain main = new frmMain();
            //main.GetFirstValue = txtValue.Text;
            //main.ShowDialog();
            //this.Hide();
            if (passData != null)
            {
                passData(txtValue.Text);
            } 
            this.Hide();

        }

       
      
    }
}