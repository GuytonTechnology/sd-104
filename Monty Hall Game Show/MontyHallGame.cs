using System;

namespace Monty_Hall_Game_Show
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] door;
            int playerSelection;
            int revealDoor = 0;
            int didSwitch = 0;
            int didntSwitch = 0;

            for (int n = 0; n < 10000; n++)
            {

                door = new string [] { "x", "x", "x" };
                Random rand = new Random();
                int randNum = rand.Next(0, 3);
                door[randNum] = "c";
                playerSelection = n % 3;


                for (int a = 0; a < door.Length; a++)
                {
                    if (door[a] != "c" && playerSelection != a)
                    {
                        revealDoor = a;
                    }
                }


                // when switching after the pick was made
                if (n % 2 == 0)

                {    

                    if (playerSelection != 0 && revealDoor != 0)
                    {
                        playerSelection = 0;
                    }

                     else if (playerSelection != 1 && revealDoor != 1)
                    {
                        playerSelection = 1;
                    }
                    else 
                    {
                        playerSelection = 2;
                    }

                    if (door[playerSelection] == "c")
                    {
                        didSwitch++;
                    }



                } else
                {
                    if (door[playerSelection] == "c")
                    {
                        didntSwitch++;
                    }
                }


            }

            Console.WriteLine("you have gotten it incorrect " + didntSwitch + " if you didn't switch and have gotten it correct " + didSwitch + " if you did switch");
            Console.ReadLine();
        }
    }
}
