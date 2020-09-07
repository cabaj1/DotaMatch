using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Dota2App
{
    public class DotaJsonReader
    { //https://stackoverflow.com/questions/43747477/how-to-parse-huge-json-file-as-stream-in-json-net?answertab=active#tab-top
        public void GetFirstElementFromJson(){
            string filepath = @"D:\dota-match\yasp-dump-2015-12-18.json";
            string newfile = @"D:\dota-match\workdata.json";
            int counter = 0;
            int AmountOfGames = 750; //around 100mb in file disk. Updated at 14:34
            var lines = File.ReadLines(filepath).Take(AmountOfGames*2);
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
            //DotaMatch match;
            //using (FileStream s = File.Open(@"D:\dota-match\yasp-dump-2015-12-18.json", FileMode.Open))
            //using (StreamReader sr = new StreamReader(s))
            //{
            //    Newtonsoft.Json.JsonReader reader = new Newtonsoft.Json.JsonTextReader(sr);//JsonTextReader(sr);
            //    while (reader.Read())
            //    {
            //        // deserialize only when there's "{" character in the stream
            //        if (reader.TokenType == JsonToken.StartObject && counter < maxAmountOfGames)
            //        {

            //            //match = JsonSerializer.Deserialize<DotaMatch>(reader);
            //            match = JsonConvert.DeserializeObject<DotaMatch>(reader.ToString());
            //            Debug.WriteLine("----------------------------------------------------------");
            //            Debug.WriteLine(match);
            //            Debug.WriteLine("----------------------------------------------------------");
            //            counter++;

            //        }
            //        else 
            //        {
            //            Debug.WriteLine(counter);
            //            Debug.WriteLine(maxAmountOfGames);
            //            Debug.WriteLine("Stopping process");
            //            break;
            //        }
            //   }
            //}
        }
    }
}
