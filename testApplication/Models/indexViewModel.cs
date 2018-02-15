using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testApplication.Models
{
    [Serializable]
    public class Rootobject
    {
        public Restresponse RestResponse { get; set; }
    }

    [Serializable]
    public class Restresponse
    {
        public string[] messages { get; set; }
        public Result[] result { get; set; }
        
    }

    [Serializable]
    public class Result
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("abbr")]
        public string abbr { get; set; }
        [JsonProperty("area")]
        public string area { get; set; }
        [JsonProperty("largest_city")]
        public string largest_City { get; set; }
        [JsonProperty("capital")]
        public string capital { get; set; }
    }

}