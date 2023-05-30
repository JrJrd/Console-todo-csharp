using System;
using System.Collections.Generic;

namespace ConsoleApp_todo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            List<string> taskList = new List<string>();
            string option = "";
            while (option != "x")
            {
                Console.WriteLine("What is next?");
                Console.WriteLine("+ for add");
                Console.WriteLine("- for remove");
                Console.WriteLine("= for view");
                Console.WriteLine("x to exit");

                option = Console.ReadLine();

                if (option == "+")
                {
                    Console.WriteLine("Enter task name:");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added.");
                }
                else if (option == "-")
                {
                    Console.WriteLine("Current tasks in the list:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + ": " + taskList[i]);
                    }

                    Console.WriteLine("Enter the number of the task to remove:");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    if (taskNumber >= 0 && taskNumber < taskList.Count)
                    {
                        taskList.RemoveAt(taskNumber);
                        Console.WriteLine("Task removed.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                }
                else if (option == "=")
                {
                    Console.WriteLine("Current tasks in the list:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + ": " + taskList[i]);
                    }
                }
                else if (option == "x")
                {
                    Console.WriteLine("Exit");
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
    }
}
