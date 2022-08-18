using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your pick, player 1?");
            string pick1 = Console.ReadLine();
            Console.WriteLine("What is your pick, player 2?");
            string pick2 = Console.ReadLine();

            if (pick1 == pick2)
            {
                Console.WriteLine("It's a draw");
                return;
            }
            if (pick1 == "rock" && pick2 == "paper")
            {
                Console.WriteLine("Player 2 wins!");
                return;
            }
               
            if (pick1 == "paper" && pick2 == "rock")
                Console.WriteLine("Player 1 wins!");
            if (pick1 == "scissors" && pick2 == "paper")
                Console.WriteLine("Player 1 wins!");
            if (pick1 == "paper" && pick2 == "scissors")
                Console.WriteLine("Player 2 wins!");
            if (pick1 == "scissors" && pick2 == "paper")
                Console.WriteLine("Player 1 wins!");
            if (pick1 == "rock" && pick2 == "scissors")
                Console.WriteLine("Player 1 wins!");
            if (pick1 == "scissors" && pick2 == "rock")
                Console.WriteLine("Player 2 wins!");
        }
    }
}
