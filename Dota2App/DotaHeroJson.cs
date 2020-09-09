using DotaDomain;
using HtmlAgilityPack;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Dota2App
{
    public class DotaHeroJson
    {
        const string DestinationPathHtml = @"\..\..\..\..\DotaDomain\staticFiles\html\";
        const string DestinationPathJson = @"\..\..\..\..\DotaDomain\staticFiles\json\";
        const string DestinationPathPng = @"\..\..\..\..\DotaDomain\staticFiles\png\";
        string path;
        const string Url = "https://dota2.gamepedia.com/";
        public DotaHeroJson()
        {

            path = Directory.GetCurrentDirectory();
        }
        public List<string> GetAllHeroes() 
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
            List<string> heroNames = jsonHeroes.Select(x => x.Localized_name).ToList();
            return heroNames;
        }

        public List<string> ConvertNames(List<string> names)
        {
            names.ForEach(x => x.Replace(" ", "_").Replace("-", "").Replace("'", "%27"));
            return names;
        }

        public List<string> ConvertNamesToLinks(List<string> names)
        {
            List<string> links = new List<string>();
            foreach (string name in names) 
            {
                links.Append(Url + name);
            }
            return links;
        }

        public List<FileStream> MakeHeroFiles(List<string> names) 
        {
            List<FileStream> myFiles = new List<FileStream>();
            foreach (string hero in names)
            {
                if (File.Exists(path + DestinationPathHtml + hero + ".html"))
                {
                    File.Delete(path + DestinationPathHtml + hero + ".html");
                }
                myFiles.Add(File.Create(path + DestinationPathHtml + hero + ".html"));
            }
            return myFiles;
        }

        public void DownloadHeroes(List<string> names)
        {
            using (WebClient client = new WebClient())
            {
                foreach (string name in names)
                {
                    client.DownloadFile(Url + name, path +  DestinationPathHtml + name+".html");
                }
            }
        }

        public void CloseFileStreams(List<FileStream> streams) 
        {
            foreach (var file in streams)
            {
                file.Close();
            }
        }
        public List<FileStream> CreateHeroImages(List<string> names)
        {
            //delete the png files if they exist and then create empty ones
            if (!Directory.Exists(path +  DestinationPathPng))
            {
                Directory.CreateDirectory(path +  DestinationPathHtml);
            }
            List<FileStream> myFiles = new List<FileStream>();
            foreach (string key in names)
            {
                myFiles.Add(File.Create(path +  DestinationPathPng +  key + ".png"));
                myFiles.Add(File.Create(path + DestinationPathPng + key + " minimap.png"));
            }
            return myFiles;
        }

        //public void DownloadHeroImage(List<string> heronames) 
        //{
            
        //        //download hero images files on the empty files (it works, but it's probably not the way how it should be done but it works so yeah)
        //        using (WebClient client = new WebClient())
        //        {
        //            foreach (var key in heronames)
        //            {
        //                client.DownloadFile(new Uri(key), path + DestinationPathPng + key + ".png");
        //            }

        //        }
        //}

        public void CreateJsonFile()
        {
            if (File.Exists(path +  DestinationPathJson + "DotaHeroes.json"))
            {
                File.Delete(path +  DestinationPathJson + "DotaHeroes.json");
            }
            File.Create(path +  DestinationPathJson + "DotaHeroes.json");
        }
        public void PopulateJsonFile(List<string> heronames)
        {
            //fill in json file 
            string html = "";
            List<JsonHero> heroes = new List<JsonHero>();

            foreach (var name in heronames)  //heronames.Count()
            {
                html = ReadHeroFile(name);
                JsonHero theHero = GetStats(html);

                theHero.SecondName = name;
                heroes.Add(theHero);
            }
            string json = new JavaScriptSerializer().Serialize(heroes);

            System.IO.File.WriteAllText(path +  DestinationPathJson + "DotaHeroes.json", json);
        }
        private string ReadHeroFile(string heroName)
        {
            //read hero file
            return File.ReadAllText(path + DestinationPathHtml + heroName + ".html");
        }
        private JsonHero GetStats(string html)
        {
            //create html object
            List<HtmlNode> tables = new List<HtmlNode>();
            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            //get table
            foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table")) //table
            {
                tables.Add(table);
            }
            //get data from table - the data we want is at pos 1 & 2

            var theFooter = doc.GetElementbyId("catlinks");

            //List<string> basicStats = new List<string>();
            List<string> basicStats = GetTableCellData(tables, 0);

            List<string> stats = GetTableCellData(tables, 1);
            foreach (HtmlNode tbody in tables.ElementAt(1).SelectNodes("tbody"))
            {
                foreach (HtmlNode row in tbody.SelectNodes("tr")) //cell
                {
                    foreach (HtmlNode cell in row.SelectNodes("th|td")) //cell
                    {
                        stats.Add(cell.InnerText);
                    }
                }
            }
            //table 2: hero stats
            List<string> info = GetTableCellData(tables, 2);

            //table 4: roles
            //because some heroes have summons and gamepedia makes an extra table for that
            List<string> roles = GetTableCellData(tables, tables.Count() - 1 - 2);


            //lore
            var lore = doc.GetElementbyId("heroBio");

            //get correct data from the lists
            DeleteNewLines(info);
            DeleteNewLines(stats);
            DeleteNewLines(roles);
            JsonHero hero = new JsonHero();
            GetHeroBasicInfo(basicStats.ElementAt(0), hero);
            GetHeroInfo(info, hero);
            GetHeroStats(stats, hero);
            GetHeroRoles(roles, hero);
            GetHeroTypeAndRange(theFooter, hero);
            GetHeroLore(lore, hero);
            GetHeroImage(doc,hero);

            return hero;
        }

        private void GetHeroImage(HtmlDocument doc, JsonHero hero)
        {
            var innerhtml = doc.DocumentNode.InnerHtml;
            string pattern = @"<(img)\b[^>]*>";

            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            List<string> images = new List<string>();
            MatchCollection matches = rgx.Matches(innerhtml);

            for (int i = 0, l = matches.Count; i < l; i++)
            {
                if (i == 0 || i == 4)  //0 is big icon, 4 is minimap
                {

                    images.Add(matches[i].Value);
                }
            }

            List<string> sources = new List<string>();
            foreach (string image in images)
            {
                string begin = image.Split("src=\"").Last();
                string fullsource = begin.Split("\" decoding=").First();
                sources.Add(fullsource);
            }
            using (WebClient client = new WebClient())
            {
                //myFiles.Add(File.Create(path + DestinationPathPng + key + " minimap.png"));
                client.DownloadFile(new Uri(sources[0]), path + DestinationPathPng + hero.Name + ".png");
                client.DownloadFile(new Uri(sources[1]), path + DestinationPathPng + hero.Name + " minimap.png");
            }
                var a = doc.DocumentNode.Descendants("img");
        }

        private List<string> GetTableCellData(List<HtmlNode> tables, int v)
        {
            //get the cell data
            List<string> stats = new List<string>();
            foreach (HtmlNode tbody in tables.ElementAt(v).SelectNodes("tbody"))
            {
                foreach (HtmlNode row in tbody.SelectNodes("tr"))
                {
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {
                        stats.Add(cell.InnerText);
                    }
                }
            }
            return stats;
        }

        private void GetHeroLore(HtmlNode lore, JsonHero hero)
        {
            //get hero lore
            var loreDiv = lore.SelectNodes("div");
            var heroLoreAndVoiceActor = loreDiv[2].InnerText.Remove(0, 8);
            var arrayLoreVoiceActor = heroLoreAndVoiceActor.Split(new string[] { "\n\n\nVoice:" }, StringSplitOptions.None);
            hero.Lore = arrayLoreVoiceActor[0];
            hero.VoiceActor = arrayLoreVoiceActor[1].Replace("(Responses)", "").Replace("\n", "").Trim();
        }

        private void GetHeroTypeAndRange(HtmlNode theFooter, JsonHero hero)
        {
            //get if the hero is a range or melee or is agility, intelligence or strength
            if (theFooter == null)
            { //for some reason ursa throws errors, so hardcoding a fix
                hero.PrimaryAttribute = "Agility";
                hero.AttackType = "Melee";
            }
            else
            {
                string footerString = theFooter.InnerHtml;

                if (footerString.Contains("Strength"))
                {
                    hero.PrimaryAttribute = "Strength";
                }
                else if (footerString.Contains("Agility"))
                {
                    hero.PrimaryAttribute = "Agility";
                }
                else
                {
                    hero.PrimaryAttribute = "Intelligence";
                }

                if (footerString.Contains("Melee"))
                {
                    hero.AttackType = "Melee";
                }
                else
                {
                    hero.AttackType = "Range";
                }
            }
        }

        private void GetHeroBasicInfo(string basicStats, JsonHero hero)
        {
            //get data from table from hero file
            do
            {
                basicStats = basicStats.Replace("\n", "+").Replace("++", "+");
            } while (basicStats.Contains("++"));
            var theBasicStats = basicStats.Split('+');
            hero.Name = theBasicStats[0];
            hero.Image = "images/" + theBasicStats[0] + ".png"; //todo, fix path
            hero.StartStrength = Int32.Parse(theBasicStats[1]);
            hero.StrengthPerLevel = Convert.ToDouble(theBasicStats[2].Replace(".", ","));
            hero.StartAgility = Int32.Parse(theBasicStats[3]);
            hero.AgilityPerLevel = Convert.ToDouble(theBasicStats[4].Replace(".", ","));
            hero.StartIntelligence = Int32.Parse(theBasicStats[5]);
            hero.IntelligencePerLevel = Convert.ToDouble(theBasicStats[6].Replace(".", ","));
        }

        private void GetHeroRoles(List<string> roles, JsonHero hero)
        {
            //get hero roels
            var heroRoles = roles.ElementAt(3).Replace("&#32;", ",").Replace("\n", "").Replace(" ", "").Split(',');
            //heroRoles.Reverse();
            List<string> values = heroRoles.Where(x => !string.IsNullOrWhiteSpace(x)).Distinct().ToList();
            hero.Roles = values;

        }

        private void GetHeroStats(List<string> stats, JsonHero hero)
        { //8 - 14 - 20 - ...
            //get hero stats on lvl 1
            hero.Health = Int32.Parse(stats.ElementAt(8));
            hero.HealthRegen = Convert.ToDouble(stats.ElementAt(14).Replace(".", ","));
            //hero.MagicalResistance = Convert.ToDouble(stats.ElementAt(20).Replace("%", "").Replace(".", ",")) / 100;
            hero.Mana = Int32.Parse(stats.ElementAt(20));
            hero.ManaRegen = Convert.ToDouble(stats.ElementAt(26).Replace(".", ","));
            //hero.SpellDamageAmplification = Convert.ToDouble(stats.ElementAt(38).Replace(".", ",").Replace("%", "")) / 100;
            hero.Armor = Convert.ToDouble(stats.ElementAt(32).Replace(".", ","));
            hero.AttacksPerSecond = Convert.ToDouble(stats.ElementAt(38).Replace(".", ","));
            //hero.MovementSpeedAmplification = Convert.ToDouble(stats.ElementAt(56).Replace(".", ",").Replace("%", "")) / 100;
            hero.Damage = Convert.ToDouble(stats.ElementAt(44).Replace(".", ",").Split('‒').ElementAt(1));
        }

        private void GetHeroInfo(List<string> info, JsonHero hero)
        {
            //get even more hero information
            hero.MagicalResistance = Convert.ToDouble(info.ElementAt(1).Replace("%", "").Replace(".", ",")) / 100;
            hero.MovementSpeed = Int32.Parse(info.ElementAt(3));
            hero.AttackSpeed = Int32.Parse(info.ElementAt(5));
            hero.TurnRate = Convert.ToDouble(info.ElementAt(7).Replace(".", ","));
            hero.DayVisionRange = Int32.Parse(info.ElementAt(9).Split('/').ElementAt(0));
            hero.NightVisionRange = Int32.Parse(info.ElementAt(9).Split('/').ElementAt(1));
            hero.AttackRange = Int32.Parse(info.ElementAt(11));
            if (info.ElementAt(13).Equals("Instant") || info.ElementAt(13).Equals("Instant\n"))
            {
                hero.ProjectileSpeed = 0;
            }
            else
            {
                hero.ProjectileSpeed = Int32.Parse(info.ElementAt(13));
            }
            hero.AttackAnimation = info.ElementAt(15).Replace("\n", "");
            hero.BaseAttackTIme = Convert.ToDouble(info.ElementAt(17).Replace(".", ","));
            hero.DamageBlock = Int32.Parse(info.ElementAt(19));
            hero.CollisionSize = Int32.Parse(info.ElementAt(21));
            if (info.ElementAt(23).Contains("&#160;"))
            {
                hero.Legs = Int32.Parse(info.ElementAt(23).Replace("&#160;", "").Replace(" ", ""));
            }
            else
            { //damnit ursa
                hero.Legs = Int32.Parse(info.ElementAt(23).Trim());
            }
            hero.GibType = info.ElementAt(25).Replace("\n", "");
        }

        private void DeleteNewLines(List<string> heroInformation)
        {
            //delete \n 
            heroInformation.ForEach(x => x.Replace(System.Environment.NewLine, ""));
        }
    }
}
