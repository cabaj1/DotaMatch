using System;
using DotaDomain;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using DotaDomain.jsonReader;

namespace Dota2App
{
    public class MatchUpReader
    {
        private List<HeroWinrate> heroWinrates = new List<HeroWinrate>();

        public List<int> CreateList()
        {
            string dir = Directory.GetCurrentDirectory();
            string HeroesJsonPath = dir + "\\..\\..\\..\\..\\DotaDomain\\staticFiles\\json\\Hero-ids.json";
            List<JsonHeroId> jsonHeroes;
            using (StreamReader sr = new StreamReader(HeroesJsonPath))
            {
                string json = sr.ReadToEnd();
                Newtonsoft.Json.Linq.JObject jsonObject = Newtonsoft.Json.Linq.JObject.Parse(json);
                json = jsonObject.GetValue("heroes").ToString();
                jsonHeroes = JsonConvert.DeserializeObject<List<JsonHeroId>>(json);
            }
            List<int> allHeroIds = jsonHeroes.Select(x => x.Id).ToList();

            return allHeroIds;
        }

        public List<HeroWinrate> SetUpHeroWinRates(List<int> heroIds)
        {
            List<HeroWinrate> heroWinRates = new List<HeroWinrate>();
            int max = heroIds.Max();
            Console.WriteLine(heroIds.Count());
            foreach (int id in heroIds)
            {
                foreach(int i in heroIds)
                {
                    if (id != i)
                    {
                        //Console.WriteLine($"heroid {id} - i {i} - heroIdCount {heroWinRates.Count()}");

                        heroWinrates.Add(new HeroWinrate()
                            {
                                HeroId = id,
                                HeroVersusId = i
                            }
                        );
                    }
                }
            }
            return heroWinrates;
        }

        public List<HeroWinrate> FillInHeroWinrate(List<HeroWinrate> heroWinRates, string filepath)
        {
            if (String.IsNullOrEmpty(filepath))
            {
                filepath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\DotaDomain\\staticFiles\\json\\workdata.json";
            }

            int counter=1;
            using (StreamReader sr = new StreamReader(filepath))
            {
                Console.WriteLine((sr.BaseStream as FileStream)?.Name);
                while (!sr.EndOfStream)
                {
                    string game = sr.ReadLine();
                    counter++;
                    if (counter % 2 == 1)
                    {
                        GameJson gameJson = JsonConvert.DeserializeObject<GameJson>(game);
                        AddGamesToHeroWinRate(gameJson, heroWinRates);
                    }

                }
            }
            return heroWinrates;
        }

        private void AddGamesToHeroWinRate(GameJson gameJson, List<HeroWinrate> heroWinrates)
        {
            bool hasRadiantWon = gameJson.radiant_win;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 5; i++)
                {
                    HeroWinrate herowinrate = new HeroWinrate();
                    herowinrate.HeroId = gameJson.players[i].hero_id;//gameJson.players.First(x => x.player_slot == i).player_slot;
                    herowinrate.HeroVersusId = gameJson.players[5+j].hero_id;//gameJson.players.First(x => x.player_slot == 5+j).player_slot;

                    int index = heroWinrates.FindIndex(a => a.Equals(herowinrate)); //11458
                    if (hasRadiantWon)
                    {
                        heroWinrates.ElementAt(index).AddWin();
                    }
                    else
                    {
                        heroWinrates.ElementAt(index).AddGame();
                    }
                }
            }
        }

        public void WriteToJsonFile(List<HeroWinrate> heroWinrates, string filepath,string filename)
        {
            if (String.IsNullOrEmpty(filename))
            {
                filename = "HeroWinrates.json";
            }

            if (String.IsNullOrEmpty(filepath))
            {
                filepath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\DotaDomain\\staticFiles\\json\\"+filename;
            }
            else
            {
                filepath = filepath + filename;
            }

            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }

            var json = JsonConvert.SerializeObject(heroWinrates); //JsonSerializer.Serialize(heroWinrates);

            File.WriteAllText(filepath,json);
        }
    }
}