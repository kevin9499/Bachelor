using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n What is your name !");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\n Hello, {name}, on  {date:d} at {date:t}!");

            Console.Write("\n Press any key to exit");
            Console.ReadKey(true);

        }
    }
}
