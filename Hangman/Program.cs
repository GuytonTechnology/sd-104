using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console

{
    class Program
    {

        static string strLettersGuessed;
        
        static string strSecretWord = GetWord();
        static int nWrongGuesses = 0;
        static string[] WordDisplay = InitializeWordDisplay(strSecretWord);
        static bool guessedIt = false;

        static void Main(string[] args)
        {
            





            //display all gallows
            while (!guessedIt && nWrongGuesses < 10)
            {

            
           
                HangmanGallows.DrawGallow(nWrongGuesses);
                Console.WriteLine();

                //Print the word underscore

                PrintSecretWord(WordDisplay);
                Console.WriteLine("Letters guessed: " + strLettersGuessed);

                nWrongGuesses += PlayerGuess(WordDisplay, strSecretWord);
                guessedIt = GuessedWord(WordDisplay);
                
                
            }//end While

            if (guessedIt)
            {
                Console.WriteLine("You are a True Champion " + strSecretWord);
            }
            else
            {
                Console.WriteLine("Womp Womp Womp:: The word was " + strSecretWord);
            }
            Console.ReadLine();
        }//end Main

        private static string GetWord()
        {
            StreamReader textIn = new StreamReader(path: "wordbank-1.txt");
            

            //get random word
            Random random = new Random();
            int randNum = random.Next(1, 479781);

            //read through file to get that word
            for (int n = 0; n < randNum; n++)
            {
                textIn.ReadLine();
            }

            return textIn.ReadLine();
        
        }

        private static bool GuessedWord(string[] WordDisplay)
        {
            //loop through WordDisplay and see if the word is guessed
            for (int n = 0; n < WordDisplay.Length; n++)
            {
                if (WordDisplay[n] == " _ ")
                {
                    return false;
                }//end if
            }//end for loop

            return true;
        }//end GuessedWord 

        

        private static int PlayerGuess(string[] WordDisplay, string strSecretWord)
        {
            string strUserGuess;
            int nWrongGuess = 1;

            //prompt user
            Console.Write("\nGuess a letter:");
            strUserGuess = Console.ReadLine();
            strLettersGuessed += strUserGuess;

            //process guess
            for (int n = 0; n < strSecretWord.Length; n++)
            {
                if (strSecretWord[n].ToString() == strUserGuess)
                {
                    WordDisplay[n] = strUserGuess;
                    nWrongGuess = 0;
                }
            }
            return nWrongGuess;
            
        }

        private static void PrintSecretWord(string[] wordDisplay)
        {
            for (int i = 0; i <wordDisplay .Length; i++)
            {
                Console.Write(wordDisplay[i]);

            }
            Console.WriteLine();
        }

        private static string[] InitializeWordDisplay(string strSecretWord)
        {
            string[] wordDisplay = new string[strSecretWord.Length];

            //Fill wordDisplay array with _
            for (int i = 0; i < wordDisplay.Length; i++)
            {
                wordDisplay[i] = " _ ";
            }

            return wordDisplay;
        }

        
    }
}
