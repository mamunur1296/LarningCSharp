

namespace LarningCSharp.Class_003
{
    public class Looping
    {
        public void Main()
        {

            //int n = 10;
            //for (int i = 0; i <= n ; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = n; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //=====================================================
            //string[] obj = { "Apple","Banana","Cherry"};

            //for(int i= 0;i< obj.Length; i++)
            //{
            //    Console.WriteLine(obj[i]);  
            //}
            //=====================================================
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        Console.Write($"{i * j}\t");
            //    }
            //    Console.WriteLine();
            //}
            //=====================================================
            //for (int i = 1; i <= 5; i++)
            //{
            //    if (i == 2)
            //    {
            //        Console.WriteLine("Breaking the loop.");
            //        break;
            //    }
            //    Console.WriteLine($"Iteration: {i}");
            //}
            //=====================================================
            //for (int i = 1; i <= 5; i++)
            //{
            //    if (i == 2)
            //    {
            //        Console.WriteLine("Skipping iteration 2.");
            //        continue;
            //    }
            //    Console.WriteLine($"Iteration: {i}");
            //}
            //goto skip;
            //Console.WriteLine("Start of the program.");

            //=====================================================

            //Console.WriteLine("This line will be skipped.");


            //Console.WriteLine("Execution jumps here.");
            //skip:


            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        if (i == 2 && j == 2)
            //        {
            //            goto exit; 
            //        }
            //        Console.WriteLine($"i = {i}, j = {j}");
            //    }
            //}
            //=====================================================
            // exit: // Label
            //Console.WriteLine("Exited nested loops.");

            //menu: // Label for the menu
            //    Console.WriteLine("Choose an option:");
            //    Console.WriteLine("1. Say Hello");
            //    Console.WriteLine("2. Say Goodbye");
            //    Console.WriteLine("3. Exit");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("Hello!");
            //            goto menu; // Return to the menu
            //        case "2":
            //            Console.WriteLine("Goodbye!");
            //            goto menu; // Return to the menu
            //        case "3":
            //            Console.WriteLine("Exiting...");
            //            break; // Exit the program
            //        default:
            //            Console.WriteLine("Invalid choice. Try again.");
            //            goto menu; // Return to the menu
            //    }
            //=====================================================

            //Console.WriteLine("Start of the program.");

            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine($"Outer loop iteration {i}");
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine($"  Inner loop iteration {j}");
            //        if (i == 2 && j == 2)
            //        {
            //            Console.WriteLine("  Breaking out of both loops!");
            //            goto end; // Jump to the end of the program
            //        }
            //    }
            //}
            //=====================================================
            //end: // Label
            //Console.WriteLine("End of the program.");

            //int count = 1;

            //while (count <= 5)
            //{
            //    Console.WriteLine($"Count: {count}");
            //    count++; // Increment count
            //}
            //string input = "";
            //while (input != "exit")
            //{
            //    Console.WriteLine("Enter a command (type 'exit' to stop):");
            //    input = Console.ReadLine();
            //    Console.WriteLine($"You entered: {input}");
            //}


            //=====================================================

            //do
            //{
            //    Console.WriteLine($"Count: {count}");
            //    count++; // Increment count
            //} while (count <= 5);



            //=====================================================
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter a positive number:");
            //    number = Convert.ToInt32(Console.ReadLine());
            //} while (number <= 0);

            //Console.WriteLine($"You entered: {number}");


            Console.WriteLine("Looping");

        }
    }
}
