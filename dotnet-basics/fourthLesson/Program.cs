using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MyApp.Data;
using MyApp.Models;




namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            // DataContextDapper dapper = new(configuration);
            DataContextEF ef = new(configuration);

            // string sqlCommand = "SELECT GETDATE()";

            // DateTime now = dapper.LoadDataSingle<DateTime>(sqlCommand);
            // Console.WriteLine(now);
            Computer myComputer = new()
            {
                Motherboard = "Test",
                HasWifi = true,
                HasLTE = true,
                ReleaseDate = DateTime.Now,
                Price = 15.66m,
                VideoCard = "RTX 2060"
            };

            ef.Add(myComputer);
            ef.SaveChanges();

            string sql = @"
                INSERT INTO TutorialAppSchema.Computer (
                    Motherboard,
                    HasWifi,
                    HasLTE,
                    ReleaseDate,
                    Price,
                    VideoCard 
                ) VALUES ('"
                + myComputer.Motherboard
                + "','" + myComputer.HasWifi
                + "','" + myComputer.HasLTE
                + "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd")
                + "','" + myComputer.Price
                + "','" + myComputer.VideoCard
                + "')";

            // Console.WriteLine(sql);



            // string sqlSelect = @"SELECT * FROM TutorialAppSchema.Computer";

            // int result = dapper.ExecuteSQLwithRoleCount(sql);
            // Console.WriteLine(result);

            // IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);
            IEnumerable<Computer>? comps = ef.Computer?.ToList<Computer>();


            if (comps != null)
            {
                foreach (Computer singleComputer in comps)
                {
                    Console.WriteLine(singleComputer.ComputerId);
                }
            }





        }
    }
}