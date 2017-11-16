using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };

            string[] Phone = { "555-1334", "555-3882", "555-8211", "555-1617", "555-2803" };
            string strSearch;

            //prompt user
            Console.Write("Enter a name to search for in the phone book: ");
            strSearch = Console.ReadLine();

            //Loop thru array looking for the name
            for (int n = 0; n < Names.Length; n++)
            {
                if(Names[n].IndexOf(strSearch)> -1)
                {
                    Console.WriteLine(Names[n] + " -> " + Phone[n]);
                }
            }
            Console.ReadLine();

        




        }
    }
}
