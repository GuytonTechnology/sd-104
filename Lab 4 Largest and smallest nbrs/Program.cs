using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Largest_and_smallest_nbrs
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            int nSmallest;
            int nLargest;
            int nCurrent;
            string strEntry;

            //first integer
            Console.WriteLine("Enter an integer: ");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another integer or Q to Quit");
            strEntry = Console.ReadLine();

            //Loop
            while(strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                //check to see if input will replace largest or smallest
                if(nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if(nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }
                //prompt user
                Console.WriteLine("Enter another integer or Q to Quit");
                strEntry = Console.ReadLine();
            }

            //print results
            Console.WriteLine("The Largest value you entered was " + nLargest);
            Console.WriteLine("The smallest value you entered was " + nSmallest);

            Console.ReadLine();

        }
    }
}
