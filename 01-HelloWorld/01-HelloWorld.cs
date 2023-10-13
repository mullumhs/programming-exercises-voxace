using System;

/*
===============================================================================
PROJECT 01: HELLO WORLD
===============================================================================
Objective:
- Familiarize with basic console output and input operations in C#.

Main Tasks:
1. Output 'Hello World!' to the console screen using 'Console.WriteLine();'.
2. Make the program wait for input using 'Console.ReadLine();'.

Questions:
1. What is the difference between input and output?
input is 
output is

Extension Tasks:
1. Output another message / pause after the ReadLine.
2. Research online how to change the colour and/or make the console beep.

Additional Resources:
- Microsoft Docs: Console.WriteLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline
- Microsoft Docs: Console.ReadLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_01_HelloWorld
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("Hello World");
            Console.ReadLine();
            Console.WriteLine("Goodbye");
            Console.Beep(10000,5000);
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================

Feedback on your C# Programming Task
Code

Your code is working as expected, well done. You have successfully written the Console.WriteLine("Hello World"); and Console.ReadLine(); statements under the Main method.
You've also successfully implemented the extension tasks by adding another Console.WriteLine("Goodbye"); statement and a Console.Beep(10000,5000); statement. Good job on researching and implementing these console methods!
Code Commenting

Your code comments are missing. It's a good practice to include comments in your code to explain what each part of your code does. This makes your code more readable for others and for yourself when you come back to it later. For example, you can add a comment above Console.WriteLine("Hello World"); like // Outputs "Hello World" to the console.
Answers to Questions

Your answers to the question "What is the difference between input and output?" are missing. Remember to fill in your answers in the comments section of your code.
Extension Tasks

You've successfully completed the extension tasks. You've added another message after the Console.ReadLine(); statement and made the console beep using Console.Beep(10000,5000);. Well done!
Keep up the good work! Remember to fill in your answers to the questions and include comments in your code.

===============================================================================
*/