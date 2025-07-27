using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasicExercises
{
    internal class ArraysAndListsExercises
    {
        public static void ArraysAndListsMain()
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
            Console.WriteLine(@"***** CONTROL FLOW EXERCISES *****
Options;
1) Exercise 1
2) Exercise 2
3) Exercise 3
4) Exercise 4
5) Exercise 5
-1) Return to main menu

Enter your choice: ");
        }
        static void Exercise1()
        {
            Console.WriteLine();
            Console.WriteLine(@"This exercise asks you to enter names
(consider it a simulation of people liking a post)
It will continue to take names as an input untill you press 'Enter' without inputting a name.
When that is done, a proper message will be displayed, dependand on how many people 'liked' the post.
(Nothing will be displayed if no names have been entered.");

            var names = new List<string>();
            var count = 0;
            while (true)
            {
                Console.Write("Enter a name (or press Enter to finish): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break; // Exit the loop if no input is given
                }
                names.Add(input);
                count++;
            }

            switch (count)
            {
                case 0:;
                    break;
                case 1:
                    Console.WriteLine($"{names[0]} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
                    break;
                case 3:
                    Console.WriteLine($"{names[0]}, {names[1]} and {count - 2} others liked this post.");
                    break;
                default:;
                    break;
            }

            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
            return;
        }
        static void Exercise2()
        {
            Console.WriteLine();
            Console.WriteLine(@"This exercise asks you to enter a name (or any string) to be reversed");
            Console.Write("Please enter the name: ");
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());
            //could also be done with a simple for loop:
            Console.WriteLine($"Reversed name: {reversed}");

            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
            return;
        }
        static void Exercise3()
        {
            Console.WriteLine();
            Console.WriteLine(@"This exercise asks you to enter 5 numbers, 
if there are any duplicates, you will be asked to reenter a number.");

            var numbers = new int[5];
            var count = 0;
            while (count < 5)
            {
                Console.Write($"Please enter number no.{count + 1}: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("This number has already been entered. Please enter a different number.");
                }
                else
                {
                    numbers[count] = input;
                    count++;
                }
            }
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
        }
        static void Exercise4()
        {
            Console.WriteLine();
            Console.WriteLine(@"This exercise asks you to enter numbers untill you enter 'Quit'.
You may enter duplicate numbers (or even should)
After entering the numbers only the unique ones will be displayed.");

            while (true)
            {
                var numbers = new List<int>();
                while (true)
                {
                    Console.Write("Please enter a number (or type 'Quit' to finish): ");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "quit")
                    {
                        break; // Exit the loop if 'Quit' is entered
                    }
                    if (int.TryParse(input, out int number))
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number or 'Quit' to finish.");
                    }
                }
                var uniqueNumbers = numbers.Distinct().ToList();
                Console.WriteLine("Unique numbers entered:");
                foreach (var number in uniqueNumbers)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("Press enter button to continue...");
                Console.ReadLine();
                return;
            }
        }
        static void Exercise5()
        {
            Console.WriteLine();
            Console.WriteLine(@"Here you are asked to enter a list of numbers devided by comma.
If the list is shorter the 5, it will be an invalid list.
If its valid, 3 smallest numbers will be displayed.");
            Console.Write("Please enter a list of numbers separated by commas: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',')
                               .Select(n => n.Trim())
                               .Where(n => int.TryParse(n, out _))
                               .Select(int.Parse)
                               .ToList();
            if (numbers.Count < 5)
            {
                Console.WriteLine("Invalid List");
            }
            else
            {
                var smallestNumbers = numbers.OrderBy(n => n).Take(3).ToList();
                Console.WriteLine("The three smallest numbers are:");
                foreach (var number in smallestNumbers)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
        }
    }
}
