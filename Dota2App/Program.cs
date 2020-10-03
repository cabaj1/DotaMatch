using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Dota2App
{
    internal class Program
    {
        private static void Main(string[] args)
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
                DotaMatchJsonReader dotaJsonReader = new DotaMatchJsonReader();
                string output = dotaJsonReader.GetFirstElementFromJson(updatedpath);
                Console.WriteLine(output);
            }
            else if (keyword == "2")
            {
                DotaHeroJson dotaHero = new DotaHeroJson();
                List<string> names = dotaHero.GetAllHeroes();
                names.ForEach(x => Console.WriteLine(x));

                List<string> convertedNames = dotaHero.ConvertNames(names);
                List<string> links = dotaHero.ConvertNamesToLinks(convertedNames);

                links = dotaHero.ConvertNamesToLinks(names);

                Console.WriteLine("Making hero files");
                var streams = dotaHero.MakeHeroFiles(names);
                Console.WriteLine("Closing streams");
                dotaHero.CloseFileStreams(streams);
                Console.WriteLine("Download heroes files");
                dotaHero.DownloadHeroes(convertedNames);

                Console.WriteLine("Making png files");
                var streams2 = dotaHero.CreateHeroImages(names);
                Console.WriteLine("Closing streams");
                dotaHero.CloseFileStreams(streams2);

                Console.WriteLine("Downloading png files");
                //dotaHero.DownloadHeroImage(convertedNames); //todo
                Console.WriteLine("Making json file");
                dotaHero.CreateJsonFile();

                Console.WriteLine("populate json file");
                dotaHero.PopulateJsonFile(convertedNames);
                Console.WriteLine("Finished!");
            }
            else if (keyword == "3")
            {
                //read matchups
                MatchUpReader matchUpReader = new MatchUpReader();
                Console.WriteLine("Creating list");
                var list = matchUpReader.CreateList();
                Console.WriteLine("Set up blanco win rates");
                var heroWinRates =  matchUpReader.SetUpHeroWinRates(list);
                Console.WriteLine("Read json file and count games & losses");
                heroWinRates = matchUpReader.FillInHeroWinrate(heroWinRates, null);
                Console.WriteLine("Write to json");
                matchUpReader.WriteToJsonFile(heroWinRates,null,null);
                Console.WriteLine("Finished!!");
            }
            else
            {
                Console.WriteLine("Unknown command - exiting program");
            }
            Console.ReadLine();
        }

        //todo fix bug
    }
}