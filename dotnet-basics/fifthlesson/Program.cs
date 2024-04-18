using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sql = @"
                INSERT INTO TutorialAppSchema.Computer (
                    Motherboard,
                    HasWifi,
                    HasLTE,
                    ReleaseDate,
                    Price,
                    VideoCard 
                ) VALUES ('""')";



            File.WriteAllText("log.txt", sql);
            // File.AppendAllText(Path.GetFullPath("log.txt"), sql);

            using StreamWriter openFile = new("log.txt", append: true);

            openFile.WriteLine(sql);
        }
    }
}