using System;

namespace Special
{
    public class Program
    {
        private static int GetSpecial(int n)
        {
        if (n == 0) return 0; // Base case 1
        if (n == 1) return 1; // Base case 2

        // Recursive case
        return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }

    public static void Main(string[] args)
        {
        Console.Write("Insert n-th number of the special sequence: ");
        
        // Read user input
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            Console.WriteLine(GetSpecial(n));
        else
            Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        }
    }
}
