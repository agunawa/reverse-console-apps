using System;
using static System.Console;

namespace Macquarie.Console.Apps
{
    class Program
    {
        static void Main()
        {
            WriteLine("Please type in your firstname");
            var userInput = ReadLine();
            while (string.IsNullOrWhiteSpace(userInput))
            {
                WriteLine("Please type in your firstname");
                userInput = ReadLine();
            }


            char[] array = userInput.ToCharArray();
            Array.Reverse(array);
            string reverse = new string(array);
            string result = $"Hello {userInput}, your name is {userInput.Length} characters in length and backward it is {reverse}";
            WriteLine(result);
            ReadKey();
        }
    }
}
