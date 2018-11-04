using System;

namespace ConnorFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write "POOP!" to the command line forever
            // So much poop
            while (true)
            {
                Console.WriteLine("POOP!");
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
