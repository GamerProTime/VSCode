using System;

namespace Line
{
    class Queue
    {
        public char[] letters = new char[8];
        int tail = 0;
        int head = 0;

        public char Get()
        {
            return letters[head++];
        }
        
        public bool Add(char adding)
        {
            /*if(tail == letters.Length)
            {
                if(head > 0)
                {
                    tail = 0;
                }
                else
                {
                    return false;
                }
            }*/

            tail++;
            tail = tail % letters.Length;
            letters[tail] = adding;
            return true;
        }

        public void Print()
        {
            for(int i = head; i < tail; i++)
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
            Queue que = new Queue();
            que.Add('l');
            que.Add('a');
            que.Add('m');
            que.Add('b');
            que.Add('f');
            que.Add('m');
            que.Add('g');
            que.Add('x');
            que.Add('d');
            que.Add('o');

            que.Print();
            char c = que.Get();
            c = que.Get();
            c = que.Get();
            que.Print();
            que.Add('a');
            que.Add('b');
            que.Print();
        }
    }
}
