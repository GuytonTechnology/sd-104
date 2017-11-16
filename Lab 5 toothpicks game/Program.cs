using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_toothpicks_game
{
    class Program
    {
        

        static void Main(string[] args)
        {

            int nToothPicks = 23;
            int nUserPick, nCpuPick =0;


            //Game Title
            Console.WriteLine("$$$$$$Game of 23$$$$$$$$");
            Console.WriteLine("Pick either 1, 2, or 3 toothpicks form the pile.");
            Console.WriteLine("I will pick after you.  Last unintelligent entity to draw a toothpick looses.");

            do
            {



                //display toothpicks
                for (int i = 0; i < nToothPicks; i++)
                {
                    if (i % 4 == 0)
                    {
                        Console.Write("/");
                    }
                    else if (i % 4 == 1)
                    {
                        Console.Write("|");
                    }
                    else if (i % 4 == 2)
                    {
                        Console.Write("_");

                    }
                    else
                    {
                        Console.Write("\\");
                    }
                }
                Console.WriteLine("Pick 1, 2, or 3 Toothpicks");
                while (!int.TryParse(Console.ReadLine(), out nUserPick) || (nUserPick < 1 || nUserPick > 3))
                {
                    Console.WriteLine("Not a valid entry. Must be a number.");
                    Console.WriteLine("Pick 1, 2 or 3 toothpicks");
                }

                nToothPicks -= nUserPick;

                //computer's choice
                if (nToothPicks > 4 )
                {
                    nCpuPick = 4 - nUserPick;
                    Console.WriteLine("I pick " + nCpuPick);
                }
                else if(nToothPicks > 1 && nToothPicks < 4)
                {
                    nCpuPick = nToothPicks - 1;
                    Console.WriteLine("I pick " + nCpuPick+" you loose");
                
                }
                else if(nToothPicks ==1)
                {
                    nCpuPick = 1;
                    Console.WriteLine("I pick " + nCpuPick + " you win!!");
                }
                nToothPicks -= nCpuPick;
            } while (nToothPicks > 1);
            Console.ReadLine();
        }
    }
}
