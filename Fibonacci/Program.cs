using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            while (true)
            {
                int temp = a;
                a = b;
                b = temp + b;

                Console.WriteLine(a);

                if (a > 55)
                {
                    break;
                }
            }

        }
    }
}
