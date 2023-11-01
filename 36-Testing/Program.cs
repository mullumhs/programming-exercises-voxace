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

            Console.Write("How old are you: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 75)
            {
                Console.WriteLine("Ineligible");                
            }
            else if(age >= 18)
            {
                Console.WriteLine("Eligible to vote!");
            }
            else
            {
                Console.WriteLine("Ineligible");
            }

            // Wait for input before ending
            Console.ReadLine();
        }
    }
}
