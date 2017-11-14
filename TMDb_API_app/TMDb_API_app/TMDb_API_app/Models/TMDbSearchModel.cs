﻿using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TMDb_API_app.Models
{
    public static class TMDbSearchModel
    {
        public partial class SearhItem
        {
            //holds the movie id that will be used to get to the movie's page itself
            [JsonProperty("id")]
            public int MovieID { get; set; }
        }

        public partial class SearchItem
        {
            public static SearchItem FromJson(string json) => JsonConvert.DeserializeObject<SearchItem>(json, Converter.Settings);
        }

        public static string ToJson(this SearchItem self) => JsonConvert.SerializeObject(self, Converter.Settings);

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
