using System;

namespace Contacts
{
    class Program
    {
        static int Compare(string a, string b)
        {
            int shortest = a.Length;

            if (a.Length > b.Length)
            {
                shortest = b.Length;
            }
            for(int i = 0; i < shortest; i++)
            {
                if (a[i] < b[i])
                {
                    return -1;
                }
                else if (a[i] > b[i])
                {
                    return 1;
                }
            }

            return 0;

        }
        static void Main(string[] args)
        {
            string[] Names = { "abcd", "abc", "acbd", "abd", "acded", "Charlie", "Maria" };
            string[] sorted = { " ", " ", " ", " " };
            string smallest = Names[0];
            string temp = "?";
            int smix = 0;
            bool found = false;

           for(int i = 0; i < Names.Length; i++)
            {
                smallest = Names[i];
                for(int o = i + 1; o < Names.Length; o++)
                {
                    int result = Compare(Names[o], smallest);
                       if (result == -1)
                       {
                          smix = o;
                          smallest = Names[o];
                          found = true;
                       }
                   
                }
                if (found)
                {
                    temp = Names[i];
                    Names[i] = Names[smix];
                    Names[smix] = temp;
                    found = false;
                }
            }

           foreach(string l in Names)
            {
                Console.WriteLine(l);
            }



        }
    }
}
