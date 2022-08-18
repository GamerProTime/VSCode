using System;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for(int i = 0; i < 4; i++)
            {
                for(int o = 0; o < 7; o ++)
                Console.WriteLine(days[o]);
            }

            for (int i = 1; i < 11; i ++)
            {
                for (int o = 1; o < 11; o++)
                {
                    Console.WriteLine(o * i);
                }

            }
                
                    
        }
    }
}
