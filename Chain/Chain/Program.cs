using System;

namespace Chain
{
    class Link
    {
        public char value = ' ';
        public Link next;
    }
    class Program
    {
        static void Print(Link chain)
        {
            while(chain != null)
            {
                Console.WriteLine(chain.value);
                chain = chain.next;
            }
        }

        static void Find(Link chain, char letter)
        {
            Link origin = chain;
            while (chain != null)
            {
                if (chain.value == letter)
                {
                    Console.WriteLine(letter + " is in " + origin.value);
                    return;
                }
                else
                {
                    chain = chain.next;
                }
            }
            Console.WriteLine(letter + " is not in " + origin.value);

        }

        static void Append(Link chain, char letter)
        {
            Link newlett = new Link();
            newlett.value = letter;
            while (true)
            {
                if(chain.next == null)
                {
                    break;
                }
                else
                {
                    chain = chain.next;
                }
            }
            chain.next = newlett;
        }

        static Link Prepend(Link chain, char letter)
        {
            Link head = new Link();
            head.value = letter;
            head.next = chain;
            return head;
        }

        static Link Remove(Link chain, char victim)
        {
            Link head = chain;
            while (chain != null)
            {
                if(chain.next == null)
                {
                    return head;
                }

                if(head.value == victim)
                {
                    head = chain.next;
                    return head;
                }
                else if (chain.next.value == victim)
                {
                    chain.next = chain.next.next;
                    return head;
                }
                    chain = chain.next;
            }
            return head;
        }

        static void Main(string[] args)
        {
            Link z = new Link();
            Link e = new Link();
            Link b = new Link();
            Link r = new Link();
            Link a = new Link();

            z.value = 'z';
            e.value = 'e';
            b.value = 'b';
            r.value = 'r';
            a.value = 'a';

            z.next = e;
            e.next = b;
            b.next = r;
            r.next = a;

            Print(z);
            Find(z, 'k');
            Append(z, 's');
            Print(z);
            Link head = Prepend(z, 'i');
            Print(head);
            Console.WriteLine("Removing Letter...");
            head = Remove(head, 'b');
            Print(head);
        }
    }
}
