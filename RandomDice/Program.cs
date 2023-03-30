using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int diceRoll = 0;
            int finalSum = 0;
            
            Console.WriteLine("How many dice to roll: ");
            int diceToRoll = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < diceToRoll; i++)
            {
                diceRoll = dice.Next(1, 7);
                finalSum += diceRoll;
            }

            Console.WriteLine($"The sum of the dice rolled is {finalSum}");
        }
    }
}
