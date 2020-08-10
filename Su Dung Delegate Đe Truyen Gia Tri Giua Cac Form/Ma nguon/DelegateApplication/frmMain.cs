using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DelegateApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string _getFirstValue = null;
        private string _getSecondValue = null;

        // 2 Thuộc tính này có nhiệm vụ lấy giá trị từ các Form khác.
        public string GetFirstValue
        {
            get
            {
                return _getFirstValue;
            }

            set
            {
                _getFirstValue = value;
            }
        }

        public string GetSecondValue
        {
            get
            {
                return _getSecondValue;
            }

            set
            {
                _getSecondValue = value;
            }
        }

        public void GetFirstValue(string value)
        {
            txtFirstValue.Text = value;
        }

        public void GetSecondData(string value)
        {
            txtSecondValue.Text = value;
        }

        private void btnGetValue1_Click(object sender, EventArgs e)
        {
            //frmFirstValue first = new frmFirstValue();
            //first.ShowDialog();
            frmFirstValue first = new frmFirstValue();
            first.passData = new frmFirstValue.PassData(GetFirstValue);
            first.Show();

        }

        private void btnGetValue2_Click(object sender, EventArgs e)
        {
            //frmSecondValue second = new frmSecondValue();
            //second.ShowDialog();

            frmSecondValue second = new frmSecondValue();
            second.passSeconddata = new frmSecondValue.PassSeconddata(GetSecondData);
            second.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //txtFirstValue.Text = GetFirstValue;
            //txtSecondValue.Text = GetSecondValue;
        }

       
      
    }
}