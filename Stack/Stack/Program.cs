using System;

    class Stack
    {
        public char[] letters = new char[8];
        int tail = 0;

        public char Get()
        {
            return letters[tail--];
        }

        public bool Add(char adding)
        {
            tail++;
            tail = tail % letters.Length;
            letters[tail] = adding;
            return true;
        }

        public void Print()
        {
            for (int i = tail; i > 0; i--)
            {
                 Console.Write(letters[i]);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack sta = new Stack();
            sta.Add('a');
            sta.Add('b');
            sta.Add('c');
            sta.Add('d');
            sta.Add('e');

            sta.Print();
            char c = sta.Get();
        Console.WriteLine(c);
            c = sta.Get();
        Console.WriteLine(c);
        c = sta.Get();
        Console.WriteLine(c);
        sta.Print();
            sta.Add('f');
            sta.Add('g');
            sta.Print();
        }
    }
