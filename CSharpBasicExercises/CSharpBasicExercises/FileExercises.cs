using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSharpBasicExercises
{
    internal class FileExercises
    {
          public static void FileMain()
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
-1) Return to main menu

Enter your choice: ");
        }

        static void Exercise1()
        {
            Console.WriteLine();
            Console.WriteLine("This exercise reads a file and displays the numbebr of words in it.");
            var filePath = @"C:\Users\gkacp\Desktop\Programowanie\CSharpCourse\Kace98\CSharpCourses\CSharpBasicExercises\CSharpBasicExercises\test.txt";
            var content = System.IO.File.ReadAllText(filePath);
            var words = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Length);
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            return;
        }
        static void Exercise2()
        {
            Console.WriteLine();
            Console.WriteLine("This exercise reads a file and displays the longest word.");
            var filePath = @"C:\Users\gkacp\Desktop\Programowanie\CSharpCourse\Kace98\CSharpCourses\CSharpBasicExercises\CSharpBasicExercises\test.txt";
            var content = System.IO.File.ReadAllText(filePath);
            var words = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.OrderByDescending(w => w.Length).FirstOrDefault());
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            return;
        }
    }
}
