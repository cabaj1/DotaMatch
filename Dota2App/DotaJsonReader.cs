using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace Dota2App
{
    public class DotaJsonReader
    { //https://stackoverflow.com/questions/43747477/how-to-parse-huge-json-file-as-stream-in-json-net?answertab=active#tab-top
        public string GetFirstElementFromJson(string path){
            try {
                string filepath = @"D:\dota-match\yasp-dump-2015-12-18.json";
                if (path == "")
                {
                    path = filepath;
                }
                string dir = Directory.GetCurrentDirectory();

                string newfile = dir + "\\..\\..\\..\\..\\DotaDomain\\staticFiles\\workdata.json";
                //string newfile = @"D:\dota-match\workdata.json";
                int counter = 0;
                int AmountOfGames = 750; //around 100mb in file disk. Updated at 14:34
                var lines = File.ReadLines(path).Take(AmountOfGames * 2);
                //foreach (string line in lines) 
                //{
                //    Debug.WriteLine(line);
                //}
                if (File.Exists(newfile))
                {
                    File.Delete(newfile);
                }
                lines = lines.ToList().Append(@"]").ToArray();
                File.WriteAllLines(newfile, lines);
                return "Success!";
            }
            catch (Exception) 
            {
                return "Error";
            }
        }
    }
}
