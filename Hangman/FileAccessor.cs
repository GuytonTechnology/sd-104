using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console
{
    class FileAccessor
    {
        /// <summary>
        /// Get or sets the path of the file that is being accessed.
        /// </summary>
        public string FilePath { get; set; }


        /// <summary>
        /// Creates and instance of a FileAccessor, setting the 
        /// FilePath property to the passed value.
        /// </summary>
        /// <param name="filePath"></param>
        public FileAccessor(string filePath)
        {
            FilePath = filePath;
        }



        /// <summary>
        /// Returns a random line of the file.
        /// </summary>
        /// <returns>Random line from a file as a string.</returns>
        public string GetGenericLine()
        {
            StreamReader textIn = new StreamReader("FilePath");


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
    }
}
