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

            [JsonProperty("original_language")]
            public string OriginalLanguage { get; set; }

            [JsonProperty("original_title")]
            public string OriginalTitle { get; set; }

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("popularity")]
            public int Popularity { get; set; }

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
            public int VoteAverage { get; set; }

            [JsonProperty("vote_count")]
            public int VoteCount { get; set; }

            [JsonProperty("genres")]
            public Genres[] Genres{ get; set; }

            genres array[object]
            id integer
            name string


            production_companies    array[object]
            name    string
            id  integer

            production_countries    array[object]
            iso_3166_1  string
            name        string

            spoken_languages    array[object]
            iso_639_1   string
            name        string


        }

        public partial class Genres
        {
            [JsonProperty("icon")]
            public string Icon { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("main")]
            public string Main { get; set; }
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
                //MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                //DateParseHandling = DateParseHandling.None,
            };
        }
    }
}
