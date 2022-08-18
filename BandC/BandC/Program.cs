using System;

namespace BandC
{
    class Program
    {
        static void Generator()
        {
            Random r = new Random();
            int randomnum = 0;
            int prev = 0;
            char[] botnum = {'0', '0', '0', '0'};
            for (int i = 0; i < 4; i++)
            {
                randomnum = r.Next(0, 10);
                randomnum = randomnum + 48;
                botnum[i] = (char)randomnum;
            }
            Console.WriteLine(botnum);
        }
            static void Main(string[] args)
        {
            int guesses = 8;
            int bulls = 0;
            int cows = 0;
            Generator();
            //Console.WriteLine("What is you secret 4-Digit Number?");
            char[] number = Console.ReadLine().ToCharArray();

            while (guesses > 0)
            {
                cows = 0;
                bulls = 0;
                Console.WriteLine("What is your guess?");
                char[] guess = Console.ReadLine().ToCharArray();
                guesses--;
                for (int t = 0; t < 4; t++)
                {
                    if (guess[t] == number[t])
                    {
                        bulls++;
                    }
                    else
                    {

                        for (int i = 0; i < 4; i++)
                        {
                            if (guess[t] == number[i])
                            {
                                cows++;
                            }

                        }
                    }

                }

                if (bulls == 4)
                {
                    Console.WriteLine("Congrats. You Won!");
                    break;
                }
                else
                {
                    Console.WriteLine("You have " + bulls + " bulls and " + cows + " cows. Keep going.");
                }
                
            }
            if (guesses == 0)
            {
                Console.WriteLine("Bad Luck! The number was " + number);
            }
        }

    }
}
