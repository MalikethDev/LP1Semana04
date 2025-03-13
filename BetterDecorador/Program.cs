using System;

namespace BetterDecorador
{
    public class Program
    {
        private static string Decor (string s , char dec, int i)
        {
            int count = 3;
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec} {count}";
        }
        public static void Main ( string [] args )
        {
            Console.WriteLine (Decor("Good Morning!" , '*', 3));
            Console.WriteLine ( Decor ("Good Evening" , '.', 3));
        }
    }
}

