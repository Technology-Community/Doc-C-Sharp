using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Bai1_UngdungA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
           // thuc hien xac dinh dia chi cua may chu
            //xac dinh dia chi may b de gui
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2008);
            UdpClient Sender = new UdpClient();
            byte[] data = Encoding.UTF8.GetBytes(txtXaugui.Text);

            Sender.Send(data, data.Length, iep);
        }
    }
}
