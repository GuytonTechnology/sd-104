using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console
{
    class HangmanGallows
    { 

        /// <summary>
        /// Clears the console window and draws the hangman gallows in the stage passed in
        /// there are 10 stages
        /// </summary>
        /// <param name="wrongGuesses">Indicats which stage of the hangman gallow to draw</param>
        public static void DrawGallow(int wrongGuesses)
        {
            //clear screen for new gallow.
            Console.Clear();

            switch (wrongGuesses)
            {
                case 0: Stage0(); break;
                case 1: Stage1(); break;
                case 2: Stage2(); break;
                case 3: Stage3(); break;
                case 4: Stage4(); break;
                case 5: Stage5(); break;
                case 6: Stage6(); break;
                case 7: Stage7(); break;
                case 8: Stage8(); break;
                case 9: Stage9(); break;
                case 10: StageFinal(); break;
            }
        }

        private static void Stage0()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage1()
        {

            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage2()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |              ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage3()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage4()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |    |     |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage5()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @      |   ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage6()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @       @  ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage7()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \'   @ ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void Stage8()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\_____/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }
        private static void Stage9()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    /     \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\__~__/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

        private static void StageFinal()
        {
            Console.WriteLine("               _______       ");
            Console.WriteLine("              |     __|__    ");
            Console.WriteLine("              |    / x x \\  ");
            Console.WriteLine("              |   @   \"   @ ");
            Console.WriteLine("              |    \\__~__/  ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      /|\\    ");
            Console.WriteLine("              |       |      ");
            Console.WriteLine("              |      / \\    ");
            Console.WriteLine("        ______|______        ");
        }

    }
}
