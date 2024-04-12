using System;
using MyApp.Models;

namespace MyApp
{


    internal class Program
    {
        static void Main(string[] args)
        {

            Computer myComputer = new()
            {
                Motherboard = "Test",
                HasWifi = true,
                ReleaseDate = DateTime.Now,
                Price = 943.57m,
                VideoCard = "RTX2060"
            };

            Console.WriteLine(myComputer.HasWifi);
            myComputer.HasWifi = false;

        }
    }
}