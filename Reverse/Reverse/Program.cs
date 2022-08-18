using System;

namespace Reverse
{
    class Program
    {
        static char[] Inverse(string word) 
        {
            char[] temp = new char[word.Length];

            for(int i = 0; i < word.Length; i++)
            {
                temp[i] = word[word.Length - i - 1];
            }

            return temp;
        }
        static void Main(string[] args)
        {
            char[] s = Inverse("rainbow");
            Console.WriteLine(s);
        }
    }
}
