using System;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("sem qualquer tipo de argumento!");
                return;
            }
            
            for (int i = 0; i < args.Length; i++)
            {
                args[i] = args[i].ToLower();
            }

            Array.Sort(args);

            string argMerge = string.Join("_", args);

            Console.WriteLine(argMerge);
        }
    }
}
