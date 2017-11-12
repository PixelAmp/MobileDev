using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

//this file hos the model for the data recived from the Pokemon API
//data is recived, translated using JASON and then attached to their approptarete tags

namespace PokedexAPI.Models
{
    public static class PokedexModel
    {
        public partial class PokedexItem
        {
            //returns the Nat Dex #
            [JsonProperty("id")]
            public string DexNum { get; set; }

            //returns the name of the pokemon
            [JsonProperty("name")]
            public string Name { get; set; }

            //returns the chance of this Pokémon being female, in eighths; or -1 for genderless
            [JsonProperty("gender_rate")]
            public int GenderRate { get; set; }

            //returns the base capture rate; up to 255. The higher the number, the easier the catch.
            [JsonProperty("capture_rate")]
            public int CapRate { get; set; }

            //returns the base experience gained for defeating this Pokémon
            [JsonProperty("base_experience")]
            public int BaseEXP { get; set; }

            //returns the base height
            [JsonProperty("height")]
            public int Height { get; set; }

            //returns the weight
            [JsonProperty("weight")]
            public string Weight { get; set; }

          

            //returns amount of types and their values
            [JsonProperty("types")] 
            public PokemonType PokemonType { get; set; }


            //returns amount of types and their values
            [JsonProperty("stats")]
            public Stats Stats { get; set; }

            //returns amount of types and their values
            [JsonProperty("abilities")]
            public Abilities Abilities { get; set; }

        }

        public partial class PokemonType //holds the actual type of the pokemon
        {
            [JsonProperty("slot")]
            public int Slot { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public partial class Abilities //holds the stats of the pokemon
        {
            [JsonProperty("slot")]
            public int Slot { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }


        public partial class Stats //the top of stats, EV and Base Stat
        {
            //[JsonProperty("stat")]
            //public Stat Stat { get; set; }

                //if this works then I don't need code above that calls function below
            [JsonProperty("name")]
            public string StatType { get; set; }


            [JsonProperty("effort")]
            public int EV { get; set; }

            [JsonProperty("base_stat")]
            public int BaseStat { get; set; }
        }

        public partial class Stat //Name of the stat
        {
            [JsonProperty("name")]
            public string StatType { get; set; }

        }





        public partial class PokedexItem
        {
            public static PokedexItem FromJson(string json) => JsonConvert.DeserializeObject<PokedexItem>(json, Converter.Settings);
        }

        public static string ToJson(this PokedexItem self) => JsonConvert.SerializeObject(self, Converter.Settings);

        public class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
}
