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
using System.Threading;

namespace Bai2_UngdungB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        // thuc hien nhan du lieu ve
        public void nhan()
        {
            // khi may A nhan tren cong 2009 thi tren may B phai gui tren cong 2009

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2008);
            // khi nhan ve thi ta phai  xac dinh duoc dia chi cua may gui cho ta
            UdpClient receveid = new UdpClient(ipe);

            IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
            // tao mot mang byte de nhan du lieu ve
            byte[] data = new byte[1024];
            // thuc hien nhan tren cong bat ky minh lang nghe
            while (true)
            {
                data = receveid.Receive(ref remote);
               txtTV.Text = Encoding.UTF8.GetString(data, 0, data.Length);
            }

        }
        // thuc hien gui di
        private void btngui_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2009);
            // khi thuc hien gui di thi ta thuc hien gui  tren cong bat ky
            UdpClient Send = new UdpClient();
            byte[] data = new byte[1024];
            data = Encoding.UTF8.GetBytes(txtTA.Text);
            Send.Send(data,data.Length, iep);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(nhan));
            th.Start();
        }
       
        
    }
}
