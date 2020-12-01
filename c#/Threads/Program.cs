using System;
using System.Threading;

namespace Threads
{

    class Program
    {
        static int cpt = 10;
        public static void Main(String[] args)
        {
            MyThread myThread = new MyThread(10);
            myThread.callback += new MyThread.handler(threadCallBack);
            Thread thread = new Thread(new ThreadStart(myThread.ThreadLoop));
            thread.Start();
        }

        static void threadCallBack(int i)
        {
            if (cpt / 2 == i)
            {
                Console.WriteLine("Je suis à la moitier");
            }
        }
    }
}
