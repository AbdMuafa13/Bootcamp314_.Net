using System;

namespace logic314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World Muafa!\n");
            Console.Write("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your Password : ");
            string password = Console.ReadLine();

            bool isAdult = age > 18;
            bool isPasswordValid = password == "admin";

            if(isAdult && isPasswordValid)
            {
                Console.WriteLine("Welcome To the Club");
            }
            else
            {
                Console.WriteLine("Sorry, try again!");
            }

            Console.ReadKey();
        }

    }
}
