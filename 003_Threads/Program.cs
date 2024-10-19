using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _003_Threads
{
    public class Program
    {
        public static void WriteSecond()
        {
            Thread current = Thread.CurrentThread;
            current.Name = "Secondary";

            Console.WriteLine("ID потока {0}: {1}", current.Name, current.GetHashCode());
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new String(' ', 10) + current.Name + " " + i);
                Thread.Sleep(1000);
            }
        }
        public static void Main(string[] args)
        {
            Thread current = Thread.CurrentThread;
            current.Name = "Primary";
            Console.WriteLine("ID потока {0}: {1}", current.Name, current.GetHashCode());

            ThreadStart secondStart = new ThreadStart(WriteSecond);
            Thread second = new Thread(WriteSecond);
            second.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine( current.Name + " " + i);
                Thread.Sleep(1500);
            }

            Console.ReadKey();
        }
    }
}
