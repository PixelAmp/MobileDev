using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TMDb_API_app.Models
{
    public static class TMDbMovieModel
    {
        public partial class MovieItem
        {
            [JsonProperty("budget")]
            public int Budget { get; set; }

            [JsonProperty("id")]
            public int MovieID { get; set; }
            
            [JsonProperty("original_language")]
            public string OriginalLanguage { get; set; }

            [JsonProperty("original_title")]
            public string OriginalTitle { get; set; }
            
            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("popularity")]
            public float Popularity { get; set; }

            [JsonProperty("revenue")]
            public int Revenue { get; set; }
            
            [JsonProperty("release_date")]
            public string ReleaseDate { get; set; }

            [JsonProperty("runtime")]
            public int Runtime { get; set; }
            
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("tagline")]
            public string Tagline { get; set; }

            [JsonProperty("vote_average")]
            public float VoteAverage { get; set; }
            
            [JsonProperty("vote_count")]
            public int VoteCount { get; set; }

            [JsonProperty("genres")]
            public Genres[] Genres{ get; set; }
            
            [JsonProperty("production_companies")]
            public ProductionCompanies[] ProductionCompanies { get; set; }

            [JsonProperty("production_countries")]
            public ProductionCountries[] ProductionCountries { get; set; }
            
            [JsonProperty("spoken_languages")]
            public SpokenLanguages[] SpokenLanguages { get; set; }
            
        }

        public partial class Genres
        {
            [JsonProperty("id")]
            public int ID { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public partial class ProductionCompanies
        {
            [JsonProperty("id")]
            public int ID { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public partial class ProductionCountries
        {
            [JsonProperty("iso_3166_1")]
            public string iso_3166_1 { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public partial class SpokenLanguages
        {
            [JsonProperty("iso_639_1")]
            public string iso_3166_1 { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }


        public partial class MovieItem
        {
            public static MovieItem FromJson(string json) => JsonConvert.DeserializeObject<MovieItem>(json, Converter.Settings);
        }

        public static string ToJson(this MovieItem self) => JsonConvert.SerializeObject(self, Converter.Settings);

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
