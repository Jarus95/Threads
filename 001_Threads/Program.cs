using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_Threads
{
    public class Program
    {
        static void Main(string[] args)
        {
            ThreadStart writeSecondDelegate = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecondDelegate);
            thread.Start();
            while (true)
            {
                Console.WriteLine("Primary");
            }

           
        }

        public  static void WriteSecond()
        {
            while (true)
            {
                Console.WriteLine(new string(' ', 10) + "Secondary");
            }
        }
    }
}
