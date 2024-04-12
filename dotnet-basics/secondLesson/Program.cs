using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intsToCompress = [10, 15, 20, 25, 30, 35, 5];

            // int totalValue = intsToCompress[0] + intsToCompress[1].....

            int totalValue = 0;
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < intsToCompress.Length; i++)
            {
                totalValue += intsToCompress[i];
            }
            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);


            startTime = DateTime.Now;
            totalValue = 0;
            foreach (int iter in intsToCompress)
            {
                totalValue += iter;
            }
            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);


            startTime = DateTime.Now;
            totalValue = 0;
            int index = 0;
            while (index < intsToCompress.Length)
            {
                totalValue += intsToCompress[index];
                index++;
            }
            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);



            startTime = DateTime.Now;
            totalValue = 0;
            index = 0;
            do
            {
                totalValue += intsToCompress[index];
                index++;
            }
            while (index < intsToCompress.Length);

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);



            startTime = DateTime.Now;
            totalValue = 0;
            totalValue = intsToCompress.Sum();
            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            Console.WriteLine(totalValue);




            totalValue = GetSum();

        }

        static private int GetSum()
        {
            int[] intsToCompress = [10, 15, 20, 25, 30, 35, 5];
            int totalValue = 0;
            foreach (int item in intsToCompress)
            {
                totalValue += item;
            }

            return totalValue;
        }
    }
}