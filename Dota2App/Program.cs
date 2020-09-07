using System;
using System.Text.Json;

namespace Dota2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get first element from json file!");
            DotaJsonReader dotaJsonReader = new DotaJsonReader();
            dotaJsonReader.GetFirstElementFromJson();
        }

        
    }
}
