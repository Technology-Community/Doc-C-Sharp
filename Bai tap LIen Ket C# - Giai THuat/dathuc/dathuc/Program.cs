using System;
using System.Collections.Generic;
using System.Text;

namespace dathuc
{
    class Node
    {
        private int mu;
        private int gtri;
        private Node next;
        public int Mu
        {
            get
            {
                return mu;
            }
            set { mu = value; }
        }
        public int GT
        {
            get { return gtri; }
            set { gtri = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node (int mu,int gtri)
        {
            GT = gtri;
            Mu = mu;
            next = null;
        }
    }
    class dthuc
    {
        private Node l = null;
        public void Nhapdt()
        {
            int m, gt;
            Node tg;
            string t1;
            do
            {
                Console.WriteLine("Nhap vao he so:");
                gt = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap vao so mu:");
                m = int.Parse(Console.ReadLine());
                tg = new Node(m, gt);
                if (l != null)
                    tg.Next = l;
                l = tg;
                Console.WriteLine("Ban co nhap tiep hay khong c/k");
                t1 = Console.ReadLine();
            }
            while (t1.Equals("c"));
        }
        public void hien()
        {
            Node tg = l;
            while (tg != null)
            {
                Console.Write("{0}X{1}+", tg.GT, tg.Mu);
                tg = tg.Next;
            }
        }
        public void sapxep()
        {
            Node p = l;
           
            while (p != null)
            {
                Node q = p.Next;
                                
                while (q != null)
                {                    
                  if (p.Mu > q.Mu)
                    { Node tg = new Node();
                        tg.GT = q.GT;
                        tg.Mu = q.Mu;
                        q.GT = p.GT;
                        q.Mu = p.Mu;
                        p.GT = tg.GT;
                        p.Mu = tg.Mu;
                      
                    }
                    q = q.Next;
                }
                    p=p.Next;
            }
        }
        //public void chuanhoa()
        //{
        //    int tg;
        //    Node p = l;
        //    while (p.Next != null)
        //    {
        //        Node q = p;

        //        while (q != null)
        //        {
        //            q = q.Next;
        //            if (p.Mu = q.Mu)
        //            {
        //                tg = p.GT + q.GT;
        //                p.GT = tg;
        //                Console.Write("{0}x{1}+", p.GT, p.Mu);
        //            }
        //        }
        //    }
        //}
    }
    class tester
    {
        static void Main(string[] args)
        {
            dthuc  ds = new dthuc();
            ds.Nhapdt();
            ds.hien();
            ds.sapxep();
            //ds.chuanhoa();
           
            Console.ReadKey();   
        

        }
    }
}
