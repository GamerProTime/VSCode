using System;

namespace LargestLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] order = "cate".ToCharArray();
            char smallest = order[0];
            int smix = 0;
            for(int o = 0; o < order.Length; o++)
            {
                bool found = false;
                smallest = order[o];

                for (int i = o; i < order.Length; i++)
                {

                    if (smallest > order[i])
                    {
                        found = true;
                        smix = i;
                        smallest = order[i];
                    }
                }
                Console.WriteLine(smallest + " " + smix);

                if (found)
                {
                    char temp = order[o];
                    order[o] = order[smix];
                    order[smix] = temp;
                }
                
            }
            Console.WriteLine(smallest);
            Console.WriteLine(smix);
            Console.WriteLine(order);
            
        }
    }
}
