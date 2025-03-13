using System;

namespace BetterDecorador
{
    /// <summary>
    /// This class contains the main function
    /// that decorates a string with a char
    /// repeated i times
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Decor function
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private static string Decor (string s , char dec, int i)
        {
            // Based on string, char and int
            // return a string with the string s surrounded by the char dec repeated i times
            // new string(dec, i) creates a string with i times the char dec
            return $"{new string(dec, i)} {s} {new string(dec, i)}";
        }

        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        public static void Main ( string [] args )
        {
            string s = args[0]; // first argument
            char dec = args[1][0]; // args[1][0] args[1] is a string and we need a char
            int i = int.Parse(args[2]); // parse to int the third argument
            
            Console.WriteLine(Decor(s, dec, i));
        }
    }
}

