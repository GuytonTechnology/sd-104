using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            double dbltwointegers;

            //prompt user to add integers
            Console.WriteLine("pick a number to add");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("pick a number");

            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1+" + "+ n2 + " = " + (n1 + n2));

            //prompt user to subtract integers

            Console.WriteLine("Pick a number to subtract");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a number");

            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1+" - "+ n2+ " = " + (n1 - n2));

            Console.WriteLine("Pick a number to multiply ");

      
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 + " * " + n2 + " = " + (n1 * n2));

            Console.WriteLine("Pick a number to divide");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number");
            n2 = Convert.ToInt32(Console.ReadLine());
            dbltwointegers = (double)n1 / n2;
            Console.Write(n1 + " / " + n2 + " = " + (dbltwointegers));
            Console.ReadLine();








        }
    }
}
