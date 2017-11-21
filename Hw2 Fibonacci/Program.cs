using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2_Fibonacci
{
    class Program
    {
       

        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;
            Console.WriteLine("which Fibonacci number");
            int FibNumber = Convert.ToInt32(Console.ReadLine());
            // n represents fibonacci number
            for (int i = 1; i < FibNumber; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine(a);
            Console.ReadLine();

           
        
        }
    }
}
