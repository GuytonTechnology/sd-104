/*
 * Project: Lab 2 batting average
 *    11-13-2017
 *    Author: J Guyton 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_battingav
{
    class Program
    {
        static void Main(string[] args)
        { //variable declaration
            string strPlayerName;
            int nHits, nAtBats;
            double dblBattingAverage;

            //prompt user

            Console.WriteLine("Calculate Batting Average");
                Console.WriteLine("Enter The Player's name: ");
            strPlayerName = Console.ReadLine();

            //prompt user for hits 
            Console.WriteLine("Enter the player's # of hits: ");
            nHits = Convert.ToInt32(Console.ReadLine());

            //prompt user for number of at bats
            Console.WriteLine("Enter the player's # of at bats:");
            nAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAverage = (double)nHits / nAtBats;

            //display results
            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();




 
        }
    }
}
