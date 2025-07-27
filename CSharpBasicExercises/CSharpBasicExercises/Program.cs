using System;

namespace CSharpBasicExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                MainMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ControlFlowExercises.ControlFlowMain();
                        break;
                    case 2:
                        ArraysAndListsExercises.ArraysAndListsMain();
                        break;
                    case 3:
                        StringExercises.StringMain();
                        break;
                    case -1:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void MainMenu()
        {
            Console.Write(@"***** MAIN MENU *****
Choose an option;
1) Control Flow Excercises
2) Arrays and Lists Excercises
3) String Excercises
-1) Close program
Note: This program does not contain input validation, so watch out ;)

Enter your choice: ");
        }
    }
}