using System;

namespace LargestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write three numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int[] array = { num1, num2, num3 };
            int largest = array[0];
            int laix = 0;
            int temp;
            bool found;

            for(int i = 0; i < array.Length; i++)
            {
                found = false;
                largest = array[i];

                for(int p = i; p < array.Length; p++)
                {
                    if (largest < array[p])
                    {
                        found = true;
                        laix = p;
                        largest = array[p];
                    }
                }

                if (found)
                {
                    temp = array[i];
                    array[i] = array[laix];
                    array[laix] = temp;
                }
            }

            Console.WriteLine(array[0] + " " + array[1] + " " + array[2]);
        }
    }
}
