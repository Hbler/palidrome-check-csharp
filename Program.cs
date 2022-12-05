using System;
using System.Text;
using System.Text.RegularExpressions;

namespace IsPalidromeChallange
{

    class Program
    {

        static (bool isPal, int length) IsPalidrome(string input)
        {
            string noSpace = Regex.Replace(input.ToLower(), "\\s+", "");
            string normalized = Regex.Replace(noSpace, "\\p{P}", "");
            string reverse = new String(normalized.Reverse().ToArray());

            bool isPal = reverse == normalized;
            int length = isPal ? input.Length : 0;

            return (isPal, length);


        }
        static void Main()
        {
            bool done = false;
            string input;

            Console.WriteLine("Check if a word or phrase is a palidrome!\nWrite it below:");

            while (!done)
            {
                input = Console.ReadLine();

                if (!(input == ""))
                {
                    if (input == "exit")
                    {
                        done = true;
                        break;
                    };

                    (bool isPal, int length) = IsPalidrome(input);

                    Console.WriteLine($"Palidrome: {isPal}, Lenght: {length}\n");
                    Console.WriteLine("Check another or type: exit");
                }
                else
                {
                    Console.WriteLine("Null input, try again:\n");

                }


            }

        }
    }


}
