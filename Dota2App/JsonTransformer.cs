using DotaDomain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dota2App
{
    public class JsonTransformer
    {
        readonly string filepath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\DotaDomain\\staticFiles\\json\\";
        //public void CreateGibTypes()
        //{
        //    List<GibType> gibTypes = JsonConvert.DeserializeObject<List<GibType>>(JsonStrings._GIBTYPE);
        //    string filename = filepath + "GibTypes.json";
        //    if (File.Exists(filename))
        //    {
        //        File.Delete(filename);
        //    }

        //    string jsondata = JsonConvert.SerializeObject(gibTypes, Formatting.None);
        //    File.WriteAllText(filename, jsondata);
        //}
        //public void CreateRoles()
        //{
        //}
        //public void CreateVoiceActor()
        //{
        //}
        //public void CreatePrimaryAttribute()
        //{
        //}

        public void CreateJsonFiles()
        {
            CreateJsonFile<GibType>(JsonStrings._GIBTYPE,"GibType.json");
            CreateJsonFile<PrimaryAttribute>(JsonStrings._PRIMARYATTRIBUTES, "PrimaryAttribute.json");
            CreateJsonFile<Roles>(JsonStrings._ROLES, "Roles.json");
            //todo
            CreateJsonFile<VoiceActor>(JsonStrings._VOICEACTORS, "VoiceActors.json");

        }

        private void CreateJsonFile<T>(string json, string filename )
        {
            List<T> gibTypes = JsonConvert.DeserializeObject<List<T>>(json);
            string fullpath = filepath + filename;
            if (File.Exists(fullpath))
            {
                File.Delete(fullpath);
            }

            string jsondata = JsonConvert.SerializeObject(gibTypes, Formatting.None);
            File.WriteAllText(fullpath, jsondata);

        }

        public List<JsonHero> SetRolesIdInJsonFile()
        {
            List<JsonHero> jsonHeroes;
            using (StreamReader file = File.OpenText(filepath+"DotaHeroes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                jsonHeroes = (List<JsonHero>)serializer.Deserialize(file, typeof(List<JsonHero>));
            }
            List<GibType> gibTypes;
            using (StreamReader file = File.OpenText(filepath + "GibType.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                gibTypes = (List<GibType>)serializer.Deserialize(file, typeof(List<GibType>));
            }
            List<PrimaryAttribute> primaryAttribute;
            using (StreamReader file = File.OpenText(filepath + "PrimaryAttribute.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                primaryAttribute = (List<PrimaryAttribute>)serializer.Deserialize(file, typeof(List<PrimaryAttribute>));
            }
            List<Roles> roles;
            using (StreamReader file = File.OpenText(filepath + "Roles.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                roles = (List<Roles>)serializer.Deserialize(file, typeof(List<Roles>));
            }
            List<VoiceActor> voiceActors;
            using (StreamReader file = File.OpenText(filepath + "VoiceActors.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                voiceActors = (List<VoiceActor>)serializer.Deserialize(file, typeof(List<VoiceActor>));
            }
            foreach (JsonHero hero in jsonHeroes)
            {
                string pa = hero.PrimaryAttribute;
                //hero.PrimaryAttribute = null;
                hero.PrimaryAttributeId = primaryAttribute
                    .Where(x => x.Name == pa)
                    .Select(x => x.Id)
                    .Single();

                string gt = hero.GibType;
                //hero.GibType = null;
                hero.GibTypeId = gibTypes
                    .Where(x => x.Name == gt)
                    .Select(x => x.Id)
                    .Single();

                List<string> r = hero.Roles.ToList();
                //hero.Roles = null;
                var strings = roles.Select(x => x.Name)
                        .Select(y => y)
                        .Where(x=>r.Contains(x));

                hero.RolesId = roles
                    .Where(y => strings.Contains(y.Name))
                    .Select(x => x.Id);

                //todo voice actors
                string va = hero.VoiceActor;
                hero.VoiceActorId = voiceActors
                    .Where(x => x.Name == va)
                    .Select(x => x.Id)
                    .Single();
            }

            string json = JsonConvert.SerializeObject(jsonHeroes);
            CreateJsonFile<JsonHero>(json, "DotaHeroesWithIds.json");
            return jsonHeroes;
        }


    }
}
