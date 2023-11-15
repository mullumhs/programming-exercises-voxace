using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Testing
{
    internal class Program
    {
        // USE THIS FILE FOR TESTING AND EXPERIMENTATION

        static void Main(string[] args)
        {
            // Write your code here

            // I want a program that gets the user's name, asks for two numbers, then multiplies the two numbers
            // Let's write some functions! What functions do we need?
            // First: What are functions and how are they different to methods?           

            string name = GetName();
            SayHello(name);

            Console.Write("Please Enter a number: ");
            int x = GetNumber();

            Console.Write("Please Enter a number: ");
            int y = GetNumber();

            Console.WriteLine($"Your answer is {MultiplyNumbers(x, y)}");

            // Wait for input before ending
            Console.ReadLine();
        }

        static int MultiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        static int GetNumber()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static string GetName()
        {
            string name = Console.ReadLine();
            return name;
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
