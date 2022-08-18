using System;
using System.Threading;

namespace Proccesser
{
    class Program
    {
        static long total = 0l;
        private Object thisLock = new Object();
        public void DoWork()
        {
            long i = 0;
           // lock (thisLock)
            {
                Console.WriteLine("Thread Starting... " + Thread.CurrentThread.ManagedThreadId);
                while (i < 200000000)
                {
                    i++;
                    //lock (thisLock)
                    {
                        total++;
                    }
                }
            }
               // Console.WriteLine("i is " + i + " and thread is " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("total is " + total + " and thread is " + Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            for(int i = 0; i < 6; i++)
            {
                Thread thread1 = new Thread(p.DoWork);
                thread1.Start();
            }
            
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(total);
        }
    }  }
 
