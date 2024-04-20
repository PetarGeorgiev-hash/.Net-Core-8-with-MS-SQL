using System;

namespace MyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task firstTask = new(() =>
            {
                Thread.Sleep(100);
                Console.WriteLine("Task 1");
            });


            Task secondTask = ConsoleAfterDelayAsync("Task 2", 150);
            Task thirdTask = ConsoleAfterDelayAsync("Task 3", 50);

            firstTask.Start();
            ConsoleAfterDelay("Delay", 101);

            await secondTask;
            await firstTask;

            Console.WriteLine("After the task was created");

            await thirdTask;
        }

        static void ConsoleAfterDelay(string txt, int delay)
        {
            Thread.Sleep(delay);
            Console.WriteLine(txt);
        }
        static async Task ConsoleAfterDelayAsync(string txt, int delay)
        {
            await Task.Delay(delay);
            Console.WriteLine(txt);
        }
    }
}