using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            Console.WriteLine();
            LetterCounter('n', "never gonna give you up, never gonna let you down");
            LetterCounter('i', "i love biscuits and gravy. its the best breakfast ever");
            LetterCounter('s', "sally sells sea shells down by the seashore. she is from sussex");
            Console.WriteLine();
            TextStats("coding is spectacular fun.");
            Console.ReadKey();
        }

        //Creating FizzBuzz function
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        //Creating letter counting function
        static void LetterCounter(char letter, string inString)
        {
            int totalLower = 0;
            int totalUpper = 0;
            int totalLetter = 0;
            var letterLower = letter.ToString().ToLower();
            var letterUpper = letter.ToString().ToUpper();
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i].ToString() == letterLower)
                {
                    totalLower++;
                    totalLetter++;
                }
                else if (inString[i].ToString() == letterUpper)
                {
                    totalUpper++;
                    totalLetter++;
                }
            }
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + totalLower);
            Console.WriteLine("Number of UPPERCASE " + letter + "'s found: " + totalUpper);
            Console.WriteLine("Total Number of " + letter + "'s found: " + totalLetter);
            Console.WriteLine();
        }

        //Creating TextStats function
        static void TextStats(string input)
        {
            var numChar = input.Length;
            var numCharSplit = input.Split(' ');
            var numWord = numCharSplit.Length;
            int numVow = 0;
            int numCon = 0;
            int numSpec = 0;

            var longestWord = "";
            var shortestWord = "------------------------------------";

            for (int i = 0; i < numCharSplit.Length; i++)
            {

                if (numCharSplit[i].Length > longestWord.Length)
                {
                    longestWord = numCharSplit[i];
                }
            }

            for (int i = 0; i < numCharSplit.Length; i++)
            {
                if (numCharSplit[i].Length < shortestWord.Length)
                {
                    shortestWord = numCharSplit[i];
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "i" || input[i].ToString() == "o" || input[i].ToString() == "u")
                {
                    numVow = numVow + 1;
                }
                else if (input[i].ToString() == "." || input[i].ToString() == "," || input[i].ToString() == "?" || input[i].ToString() == "!" || input[i].ToString() == "'")
                {
                    numSpec = numSpec + 1;
                }

                else if (input[i].ToString() != " ")
                {
                    numCon = numCon + 1;
                }
            }

            Console.WriteLine(input);
            Console.WriteLine("There are " + numChar + " characters.");
            Console.WriteLine("There are " + numWord + " words.");
            Console.WriteLine("There are " + numVow + " vowels.");
            Console.WriteLine("There are " + numCon + " consonants.");
            Console.WriteLine("There are " + numSpec + " special characters.");
            Console.WriteLine("the longest Word is: " + longestWord);
            Console.WriteLine("the shortest Word is: " + shortestWord);
            Console.WriteLine();
        }
    }
}
