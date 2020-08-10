using System;
using System.Collections.Generic;
using System.Text;

namespace DSLKdon
{
    class Node
    {
        private int x;
        private Node next;
        public int X
        {
            get { return x; }
            set { x = value; }
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
        public Node(int x)
        {
            this.x = x;
            this.next = null;
        }
    }
    class List
    {
        private Node l=null;
        public Node L
        {
            get {
                return l;
            }
            set { l = value; }
        }
        public List()
        { l = null; }
        //Tao danh sach
        public void InitList()
        {
            int gt;
            Node tg;
            do
            {
                Console.Write("Nhap gia tri gt= ");
                gt = int.Parse(Console.ReadLine());
                if (gt != -1)
                {
                    tg = new Node(gt);
                    if (l != null)
                        tg.Next = l;
                    l = tg;
                }
            } while (gt != -1);
        }
        //Hien thi danh sach
        public void Hien()
        {
            Console.WriteLine("Hien thi danh sach");
            Node tg = l;
            while (tg != null)
            {
                Console.WriteLine(tg.x);
                tg = tg.Next;
            }
        }
         //Duyet DS
        public void DuyetDS()
        {
            Console.WriteLine("Danh sach lien ket");
            Node tam = L;
            while (tam != null)
            {
                tam.Hien();
                tam = tam.Next;
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
                if (tg.X == x)
                    return true;
                tg = tg.Next;
            }
            return false;

        }
        //tim kiem va tra ra dia chi
        public void TimKiem1(int x)
        {
            Node tg = L;
            while ((tg != null) && (tg.X != x))
                tg = tg.Next;
            return tg;
        }

        // xoa nut tro boi P
        public void del(Node P)
        {
            Node Q = L;
            if (P != L)
            {
                L = L.Next;
                Q.Next = null;

            }
            else
            {
                while (Q.Next != P)
                {
                    Q = Q.Next;
                }
                Q.Next = P.Next;
            }
        }
        // Xoa nut truoc nut tro boi con tro P
        public void Del1(Node P)
        {
            Node Q = L;
            if (P != L)
            {
                if (P != L.Next)
                {
                    L = L.Next;
                    Q.Next = null;

                }
                else
                {
                    while (Q.Next.Next != P)
                        Q = Q.Next;
                    Q.Next = P;
                }
            }
        }
        // Xoa nut sau nut P
        public void del2(Node P)
        {
            Node Q = L;
            if (P != L)
            {
                L.Next = L.Next.Next;
                Q = L.Next;
                Q.Next = null;
            }
            else
            {
                Q = P.Next;
                P.Next = Q.Next;
                Q.Next = null;
            }
        }
        // xoa nut  gia tri X
        public void Del3(int x)
        {
            if (L != null)
            {
                if (L.X == x)
                    L = null;
                else
                {
                    Node Q = new Node();
                    Q = L;
                    while (Q.Next != null && Q.Next.X != x)
                    {
                        Q = Q.Next;
                    }

                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List DS = new List();
                DS.InitList();
                DS.DuyetDS();
                Console.Write("nhap gia tri can tim:");

                int y = int.Parse(Console.ReadLine());

                Console.WriteLine(DS.TimKiem(y));
                //if (DS.TimKiem(x))
                //    Console.WriteLine("khong co trong Danh sach");
                //else
                //    Console.WriteLine("co trong DS");

                Console.ReadKey();

            }
        }
    }    
}
