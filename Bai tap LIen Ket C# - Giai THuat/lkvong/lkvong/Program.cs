using System;
using System.Collections.Generic;
using System.Text;

namespace DSLK
{
    class Node
    {
        private int info;
        private Node left;
        private Node right;
        public int INFO
        {
            get { return info; }
            set { info = value; }
        }
        public Node l
        {
            get { return left; }
            set { left = value; }
        }
        public Node r
        {
            get { return right; }
            set { right = value; }
        }
        public Node()
        {
            left = null;
            right = null;
        }
        public Node(Node x)
        {
            this.info = x.info;
            this.left = x.left;
            this.right = x.right;
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
                    Node T = new Node();
                    tam.INFO = info;
                    tam.l = null;
                    tam.r = null;
                    if (L == null)
                    {
                        L = tam;
                        L.l = L;
                        L.r = L;                      
                    }
                    else
                    {
                        L.r.l = tam;
                        tam.r = L.r;
                        L.r = tam;
                        tam.l = L;
                    }
                }
            }
            while (info != -1);
        }

        //Duyet DS
        public void DuyetDS()
        {

            Console.WriteLine("Danh sach lien ket");
            if (L == null)
                Console.WriteLine("DS rong");
            else
            {
                Node tam = L.r;
                while (tam != L)
                {
                    tam.Hien();
                    tam = tam.r; ;
                }
                tam.Hien();
            }
            Console.WriteLine();
        }
        //Kien tra DS rong
        public bool EmptyList(List L)
        {
            if (L == null)
                return true;
            else
                return false;
        }
        //tim kiem trong DS co gia tri x khong
       
        //tim kiem va tra ra dia chi
        public Node TimKiem1(int x)
        {
            if (L.INFO == x)
                return L;
            else
            {
                Node tg = L.l;
                while ((tg != L) && (tg.INFO != x))
                    tg = tg.l;
                if (tg == L)
                    return null;
                else
                return tg;
            }
        }

        // xoa nut tro boi P
        public void del(Node P)
        {
            if (P != null)
            {
                Node Q = new Node();
                Node T = new Node();
                if (P == L)
                {
                    Q = L.l;
                    L.r.l = Q ;
                    Q.r = L.r;
                    L.l = null;
                    L = Q ;
                }
                else
                {
                    Q = P.l;
                    T = P.r;
                    Q.r = T;
                    T.l = Q;
                    P.l = null;
                    P.r = null;
                }
            }
        }     
        class Program
        {
            static void Main(string[] args)
            {
                List DS = new List();
                DS.TaoDS();
                DS.DuyetDS();
                DS.del(DS.TimKiem1(3));
                DS.DuyetDS();   
                Console.ReadKey();

            }
        }
    }
}

