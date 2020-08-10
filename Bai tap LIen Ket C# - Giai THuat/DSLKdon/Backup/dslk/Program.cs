using System;
using System.Collections.Generic;
using System.Text;

    class Node
    {
        private int info;
        private Node next;
        public int INFO
        {
            get { return info; }
            set { info = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        public Node()
        {
            next = null;
        }
        public Node(Node x)
        {
            this.info = x.info;
            this.next = x.next;
        }
        public void Hien()
        {
            Console.Write("{0}\t", INFO);
        }
    }
    class List
    {
        private Node L = null;
        public List()
        {
            L = null;
        }
        public void TaoDS()
        {
            int info;
            Console.WriteLine("nhap thong tin cho DS:");
            do
            {
                Console.Write("nhap gia tri ");
                info = int.Parse(Console.ReadLine());
                if (info != -1)
                {
                    Node tam = new Node();
                    tam.INFO = info;
                    tam.Next = null;
                    if (L != null)
                        tam.Next = L;

                    L = tam;
                }
            }
            while (info != -1);
        }
         class noids
        {
            private list ds;
            public void noi ( node l,node r)
            {
                node tg=ds.l;
                if(tg!=null);
                tg=tg.next;
                tg.next=ds.l;
            }
            public noids()
            {
                ds=new list();
                ds= a.taods();
            }
             hyp

 
        {



        static void Main(string[] args)
        {
        }
    }
}
