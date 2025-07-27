using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpBasicExercises
{
    internal class StringExercises
    {
        public static void StringMain()
        {
            while (true)
            {
                Console.WriteLine();
                MainMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Exercise1();
                        break;
                    case 2:
                        Exercise2();
                        break;
                    case 3:
                        Exercise3();
                        break;
                    case 4:
                        Exercise4();
                        break;
                    case 5:
                        Exercise5();
                        break;
                    case -1:
                        Console.WriteLine("Returning to main menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void MainMenu()
        {
            Console.WriteLine(@"***** STRING EXERCISES *****
Options;
1) Exercise 1
2) Exercise 2
3) Exercise 3
4) Exercise 4
5) Exercise 5
-1) Return to main menu

Enter your choice: ");
        }

        static List<int> HyphenStringToList(string text)
        {
            var numbers = text.Split('-')
                .Select(n => n.Trim())
                .Where(n => !string.IsNullOrEmpty(n))
                .Select(int.Parse)
                .ToList();
            return numbers;
        }

        static List<int> ColonStringToList(string text)
        {
            var numbers = text.Split(':')
                .Select(n => n.Trim())
                .Where(n => !string.IsNullOrEmpty(n))
                .Select(int.Parse)
                .ToList();
            return numbers;
        }

        static void Exercise1()
        {
            Console.WriteLine();
            Console.WriteLine(@"This exercise checks if a sequence of numbers is consecutive.
It takes in a list of numbers devided by hyphen ( - ).");
            Console.Write("Please enter a list of numbers separated by hyphens (e.g., 1-2-3): ");
            var input = Console.ReadLine();
            var numbers = HyphenStringToList(input);
            var difference = numbers[1] - numbers[0];
            if (difference != 1 && difference != -1)
            {
                Console.WriteLine("Not consecutive.");
                return;
            }
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] - numbers[i - 1] != difference)
                {
                    Console.WriteLine("Not consecutive.");
                    return;
                }
            }
            Console.WriteLine("Consecutive.");
            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
            return;
        }

        static void Exercise2()
        {
            Console.WriteLine();
            Console.WriteLine(@"This exercise checks if a sequence of numbers contains duplicates.
It takes in a list of numbers devided by hyphen ( - ).");
            Console.WriteLine("Please enter a list of numbers separated by hyphens (e.g., 1-2-3): ");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }
            var numbers = HyphenStringToList(input);
            var duplicatesRemoved = numbers.Distinct().ToList();
            if (duplicatesRemoved.Count != numbers.Count)
            {
                Console.WriteLine("Duplicates.");
            }
            Console.WriteLine("Press enter button to continue");
            Console.ReadLine();
        }

        static void Exercise3()
        {
            Console.WriteLine();
            Console.WriteLine("This exercise checks if a given time is valid.");
            Console.Write("Please enter a time in the format HH:MM (e.g., 14:30): ");
            var input = Console.ReadLine();
            if (!input.Contains(':') || input.Length != 5)
                Console.WriteLine("Invalid time");
            else
            {
                var numbers = ColonStringToList(input);
                if (numbers.Count != 2 || numbers[0] < 0 || numbers[0] > 23 || numbers[1] < 0 || numbers[1] > 59)
                {
                    Console.WriteLine("Invalid time");
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
            return;
        }

        static void Exercise4()
        {
            Console.WriteLine();
            Console.WriteLine("This exercise converts a given text to PascalCase.");
            Console.Write("Please enter a text to convert to PascalCase (just a few words separated by space): ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                return;
            }
            var words = input.Split(' ');
            var pascalCaseText = string.Join("", words.Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
            Console.WriteLine(pascalCaseText);
            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
            return;
        }

        static void Exercise5()
        {
            Console.WriteLine();
            Console.WriteLine("This exercise counts the number of vowels in a given text.");
            Console.Write("Please enter a text to count the vowels: ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                return;
            }
            var vowels = "aeiouAEIOU";
            var count = input.Count(c => vowels.Contains(c));
            Console.WriteLine($"Number of vowels: {count}");
            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
        }
    }
}
