using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace Dota2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to select a file and get the first 750 matches from your json dump.");
            Console.WriteLine("Check https://blog.opendota.com/2015/12/20/datadump/ to download it");
            string keyword = Console.ReadLine();
            if (keyword == "1")
            {
                Console.WriteLine("Enter your filename with path");
                string dir = Directory.GetCurrentDirectory();
                Process.Start("explorer.exe", dir);
                string updatedpath = Console.ReadLine();
                DotaJsonReader dotaJsonReader = new DotaJsonReader();
                string output = dotaJsonReader.GetFirstElementFromJson(updatedpath);
                Console.WriteLine(output);
            }
            else 
            {
                Console.WriteLine("Unknown command - exiting program");
            }
            Console.ReadLine();
        }

        
    }
}
