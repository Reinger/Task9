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
        }

        public override string ToString()
        {
            return data + " ";
        }

    }
}
