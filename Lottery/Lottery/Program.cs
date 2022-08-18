using System;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            int winner = 0;
            string[] Names = new string[5];
            int[] Numbers = new int[5];
            int[] AllNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("What's player " + i + "'s name?");
                Names[i] = Console.ReadLine();
                Console.WriteLine("What's player " + Names[i] + "'s secret number?");
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            int lucky = new Random().Next(0, 5);
            for (int i = 0; i < 5; i++)
            {
                int selection = Numbers[i];
                AllNumbers[selection] = 0;
            }
            for (int i = 0; i < 10; i++)
                if (AllNumbers[i] != 0)
                    winner = AllNumbers[i];
                    
            //string luckyguy = Names[lucky];
            Console.WriteLine("Rolling the Dice...");
            for (int i = 0; i < 10; i++)
                Console.Write(AllNumbers[i] + " ");
            // Console.WriteLine(luckyguy + " is the winner with the winner number of " + winner);
            Console.WriteLine("Nobody Won! The number is " + winner);
        }
    }
}
