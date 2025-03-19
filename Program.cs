using System;

namespace Csharp_Writeline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  //Reads from top to bottom, Console.Writeline new line
            Console.WriteLine("This is my crash course for C#!");

            Console.Write("Same Line"); //Console.Write does not go to the next line
            Console.Write("Same Line");

            Console.WriteLine("Hello World"); //Combination
            Console.Write("Hello Programmers");
            Console.WriteLine("Welcome to C#");

            Console.Write("Hello \nWorld"); //special characters \n = new line
        }
    }
}
