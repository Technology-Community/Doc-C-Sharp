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
using System.Threading;
using System.Diagnostics;

namespace Bai1_UngdungB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // tao from load phai tao mot tuyen
            Thread th = new Thread(new ThreadStart(guinhan));
            th.Start();
        }
        public void guinhan()
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2008);
            UdpClient recv = new UdpClient(ipe);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
          
            while(true)
            {
                byte [] data=new byte[1024];
                data=recv.Receive(ref ep);
                txtNhanve.Text="";
                string s=Encoding.UTF8.GetString(data,0,data.Length);
                txtNhanve.Text = s.ToString();
                if (txtNhanve.Text.ToUpper().StartsWith("OPEN"))
                {
                    Process.Start(txtNhanve.Text.Substring(5, txtNhanve.Text.Length - 5));
                }
                if (txtNhanve.Text.ToUpper().StartsWith("SHUTDOWNS"))
                    Process.Start("Shutdown", "-s");
                if (txtNhanve.Text.ToUpper().StartsWith("RESTART"))
                    Process.Start("Shutdown", "-r");
                if (txtNhanve.Text.ToUpper().StartsWith("NOSHUT"))
                    Process.Start("Shutdown", "-a");
            }
        }
    }
}
