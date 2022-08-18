using System;
using System.Collections.Generic;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> phoneBook = new Dictionary <string, int>();
            phoneBook["Maddie"] = 1122;
            phoneBook["Chris"] = 2233;
            phoneBook["Alex"] = 123456;
            //string[] names = { "Maddie", "Chris", "Alex" };
            //int[] numbers = { 1122, 2233, 123456 };
            Console.WriteLine("Who do you want to call?");
            string user = Console.ReadLine();

            int phone = phoneBook[user];
            Console.WriteLine(phone);
            

        }
    }
}
