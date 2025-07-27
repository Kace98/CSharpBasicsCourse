using System;
using System.Linq;

namespace CSharpBasicExercises
{
    internal class ControlFlowExercises
    {
        public static void ControlFlowMain()
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
            Console.WriteLine("This exercise requiers to count how many numbers between 1 and 100 are devisable by 3...");
            var count = 0;
            for (int i = 1; i <= 100; i++)
            { 
                if (i % 3 ==0)
                    count++;
            }
            Console.WriteLine($"Between 1 and 100 there are {count} numbers devisable by 3.");
            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
            return;
        }

        static void Exercise2()
        {
            Console.WriteLine(@"This exercise will ask you to enter as many numbers as you want.
At any moment you can type 'ok' to end the loop.
After that the sum of the enter numbers will be displayed on the console.");
            var count = 0;
            var loop = 1;
            while ( true )
            {
                Console.Write($"Please enter number no.{loop}: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    Console.WriteLine($"The sum of the entered numbers is {count}.");
                    Console.WriteLine("Press enter button to continue...");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    if (int.TryParse(input, out int number))
                    {
                        count += number;
                        loop++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number or 'ok' to finish.");
                    }
                }
            }
        }

        static void Exercise3()
        {
            Console.WriteLine("This exercise will compute the factorial of any given number.");
            Console.Write("Please enter a number to compute its factorial: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            Console.WriteLine($"The factorial of {input} is: {number}");
            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
            return;
        }

        static void Exercise4()
        {
            Console.WriteLine(@"This exercise will generate a random number between 1 and 10
Then it will give you 4 chances to guess the number.
It will display the proper message depending on if you got it or not, good luck :)");
            
            var input = 0;
            var randomNumber = new Random().Next(1, 10);
            for (int i = 0; i <4; i++)
            {
                Console.Write($"Please enter your guess (attempt {i + 1}/4): ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.WriteLine("You guessed it!!!");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine($"Sorry, you are out of attempts. The correct number was {randomNumber}.");
                    Console.WriteLine("Press enter button to continue...");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Sorry, wrong guess, try again");

                }
            }
        }

        static void Exercise5()
        {
            Console.WriteLine("This exercise finds the highest number in a string of numbers, seperated by comma");
            Console.Write("Please enter a string of numbers, separated by commas: ");

            var input = Console.ReadLine();
            var numbers = input.Split(',').Select(n => Convert.ToInt32(n.Trim())).ToList();
            numbers.Sort();
            Console.WriteLine(numbers.Last());

            Console.WriteLine("Press enter button to continue...");
            Console.ReadLine();
        }
    }
}
