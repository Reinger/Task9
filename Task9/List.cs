using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class List
    {
        public int data;
        public List next;

        public List()
        {
            data = 0;
            next = null;
        }

        public List(int d)
        {
            data = d;
            next = null;
        }

        public List New(int n)
        {
            List beg = new List();
            for (int i = 1; i <= n; i++)
            {
                List p = new List(i);
                p.next = beg;
                beg = p;
            }

            return beg;
        }

        public void Show()
        {
            List beg = this;
            while (beg.next!=null)
            {
                Console.Write("{0} ",beg.data);
                beg = beg.next;
            }
            Console.WriteLine();
        }

        public List Delete(int n)
        {
            List beg = this;
            if (beg.data==n)
            {
                beg = beg.next;
                return beg;
            }
            List p = beg;
            for (int i = 1; p.next.data!=n && p != null; i++)
                p = p.next;
            if (p == null)
                return beg;
            p.next = p.next.next;
            return beg;

        }

        public void Search(int n)
        {
            List beg = this;
            while (beg.next != null && beg.data != n)
            {
                beg = beg.next;
            }
            if (beg.data==n) Console.WriteLine("Элемент найден");
            else Console.WriteLine("Элемент не найден");
        }

        public override string ToString()
        {
            return data + " ";
        }

    }
}
