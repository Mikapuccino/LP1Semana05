using System;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            // If there are no arguments, prints message and ends program
            if (args.Length == 0)
            {
                Console.WriteLine("sem qualquer tipo de argumento!");
                return;
            }
            
            // Puts every string in args into lower case
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].ToLower();
            }

            // Sorts every argument in alphabetical order
            Array.Sort(args);

            // Merges every argument into one string and writes it on console
            string argMerge = string.Join("_", args);

            Console.WriteLine(argMerge);
        }
    }
}
