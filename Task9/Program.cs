using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static int ReadInt(string s)
        {
            int k;
            bool ok;

            do
            {
                Console.Write("{0}", s);
                ok = Int32.TryParse(Console.ReadLine(), out k);
                if (!ok || k<=0)
                {
                    Console.WriteLine("Ошибка ввода. Нужно ввести целое число больше 0");
                    Console.ReadLine();
                    Console.Clear();
                    ok = false;
                }
            } while (!ok);

            return k;
        }

        static void Main(string[] args)
        {
            int n = ReadInt("n=");
            List l=new List();
            l=l.New(n);
            Console.Clear();

            l.Show();


            int k = ReadInt("Значение для поиска: ");
            l.Search(k);
            Console.ReadLine();
            Console.Clear();


            l.Show();
            k = ReadInt("Значение для удаления: ");
            l.Delete(k);
            Console.Clear();

            l.Show();

            Console.ReadLine();

        }
    }
}
