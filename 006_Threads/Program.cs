using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _006_Threads
{
    internal class Program
    {
        public static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 10) + "Secondary");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(WriteSecond);
            Thread thread = new Thread(threadStart);
            thread.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Primary");
                Thread.Sleep(1500);
            }

            thread.IsBackground = true;  //default holatda false
        }
    }
}
