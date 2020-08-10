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
                    tam.INFO = info;
                    tam.l = null;
                    tam.r = null;
                    if (L != null)
                    {
                        tam.r = L;
                        L.l = tam;
                    }
                    L = tam;
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
                Node tam = L;
                while (tam != null)
                {
                    tam.Hien();
                    tam = tam.r; ;
                }
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
        public bool TimKiem(int x)
        {
            Node tg = L;
            while (tg != null)
            {
                if (tg.INFO == x)
                    return true;
                tg = tg.r;
            }
            return false;

        }
        //tim kiem va tra ra dia chi
        public Node TimKiem1(int x)
        {
            Node tg = L;
            while ((tg != null) && (tg.INFO != x))
                tg = tg.r;
            return tg;
        }

        // xoa nut tro boi P
        public void del(Node P)
        {
            if (P != null)
            {
                Node Q = new Node();
                Node T = new Node();
                if (L != null)
                {
                    if (L.r == null && P == L)
                        L = null;
                    else
                    {
                        if (L.r != null)
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
            }
        }
        // Xoa nut truoc nut tro boi con tro P
        public void Delbefo(Node P)
        {
            if (P != null)
            {
                Node Q = new Node();
                Node T = new Node();
                if (L != null)
                {
                    if (P != L)
                    {
                        if (P == L.r)
                        {
                            Q = L;
                            L = L.r;
                            L.l = null;
                            Q.r = null;
                        }
                        else
                        {
                            Q = P.l.l;
                            T = Q.r;
                            Q.r = P;
                            P.l = Q;

                            T.l = null;
                            T.r = null;
                        }
                    }
                }

            }
        }
        // Xoa nut sau nut P
        public void delaf(Node P)
        {
            if (P != null)
            {
                Node Q = new Node();
                Node T = new Node();
                if (L != null)
                {
                    if (P.r != null)
                    {
                        Q = P.r;
                        if (Q.r == null)
                        {
                            P.r = null;
                            Q.l = null;
                        }
                        else
                        {
                            T = Q.r;
                            P.r = T;
                            T.l = P;
                            Q.l = null;
                            Q.r = null;
                        }
                    }
                }
            }
        }
        // xoa nut  gia tri X
        public void Delx(int x)
        {
            if (L != null)
            {
                if (L.INFO == x)
                {

                    L = L.r;
                    L.l = null;
                }
                else
                {
                    Node Q = new Node();
                    Q = L;
                    while (Q!= null && Q.INFO != x)
                    {
                        Q = Q.r;
                    }
                    if (Q != null)
                    {
                        Node T = new Node();
                        Node P = new Node();
                        
                        T = Q.l;

                        if (Q.r == null)
                        {
                            T.r = null;
                            Q.l = null;
                        }
                        else
                        {
                            P = Q.r;
                            T.r = Q.r;
                            P.l = T;
                            Q.l = null;
                            Q.r = null;
                        }
                    }
                }
            }
        }
        public void InsertBefo(int x, Node T)
        {
            if (T != null)
            {
                Node P = new Node();
                Node Q = new Node();
                P.INFO = x;
                P.l = null;
                P.r = null;
                if (L == null)
                    L = P;
                else
                {
                    if (L.r != null)
                    {
                        if (T == L.r)
                        {
                            P.r = L;
                            L.l = P;
                            L = P;
                        }
                        else
                        {
                            Q = T.l.l;
                            P.r = Q.r;
                            P.l = Q;
                            Q.r = P; T.l.l = P;
                        }
                    }
                }
            }
        }
        public void Insert(int x, Node T)
        {
            if (T != null)
            {
                Node P = new Node();
                P.INFO = x;
                P.l = null;
                P.r = null;
                if (L == null)
                    L = P;
                else
                {
                    if (T == L)
                    {
                        P.r = L;
                        L.l = P;
                        L = P;
                    }
                    else
                    {
                        Node Q = new Node();
                        Q = T.l;
                        P.r = T;
                        P.l = Q;
                        Q.r = P;
                        T.l = P;
                    }
                }
            }
        }
        public void InsertAf(int x,Node T)
        {
            if (T != null)
            {
                Node P = new Node();
                P.INFO = x;
                P.l = null;
                P.r = null;
                if (L == null)
                    L = P;
                else
                {
                    if (T.r != null)
                    {
                        Node Q = new Node();
                        Q = T.r;
                        P.r = Q;
                        P.l = T;
                        T.r = P;
                        Q.l = P;
                    }
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
                DS.InsertAf(9, DS.TimKiem1(4));
                DS.DuyetDS();
                Console.ReadKey();

            }
        }
    }
}