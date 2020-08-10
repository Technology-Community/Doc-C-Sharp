using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


class Program
{
   
    
    static void Main(string[] args)
    {
      TcpListener server= new TcpListener(IPAddress.Parse("127.0.0.1"),2007);
        server.Start();
        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
           new clientthreat(client);
        }

    }
}
class clientthreat
{
    private Thread th;
    private TcpClient client;
    public clientthreat(TcpClient client)
    {
        this.client = client;
        th = new Thread(new ThreadStart(run));
        th.Start();
    }
    private void run()
    {
        StreamReader sr = new StreamReader(client.GetStream());
        StreamWriter sw = new StreamWriter(client.GetStream());
        string rep, res;
        while (true)
        {
            rep = sr.ReadLine();
            string [] tam = rep.Split(' '); // cat tu ky tu dau cach
            switch (tam[0].ToUpper())
            {
                case "MD":
                    {
                        try
                        {
                            Directory.CreateDirectory(tam[1]);// lenh tao tep tin

                            res = " OK thu muc da duoc tao";
                        }
                        catch (IOException)
                        {
                            res = " ERR khong tao duoc thu muc";

                        }
                        sw.WriteLine(res);
                        sw.Flush();
                        break;

                    }
                case "DEL":
                    {
                        try
                        {
                            File.Delete(tam[1]);// lenh tao tep tin

                            res = " OK tep tin da duoc xoa";
                        }
                        catch (IOException)
                        {
                            res = " ERR khong xoa duoc tep tin";

                        }
                        sw.WriteLine(res);
                        sw.Flush();
                        break;

                    }
                case "QUIT":
                    {
                        break;
                    }
                default:
                    {
                        sw.WriteLine("Khong hieu lenh");
                        sw.Flush();
                        break;
                    }

            }
            if (tam[0].ToUpper().Equals("QUIT")) break;
        }
        sr.Close();
        sw.Close();
        client.Close();
    }
}
