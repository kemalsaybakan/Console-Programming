using System;

namespace console_programming // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Ask name 
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            // Ask surname 
            Console.WriteLine("Enter your surname : ");
            string surname = Console.ReadLine();

            // Print name and surname on console 
            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}