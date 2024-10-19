using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _004_Threads
{
    internal class Program
    {
        public static void WriteSecond(object argument)
        {
            Console.WriteLine(argument);
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(WriteSecond); 
            Thread thread = new Thread(parameterizedThreadStart);
            thread.Start("HELLO");
            Console.ReadKey();
        }
    }
}
