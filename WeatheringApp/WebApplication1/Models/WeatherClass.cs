using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Weather
    {
        [JsonProperty("name")]
        public string cityName { get; set; }

        //[JsonProperty("clouds")]
        //public string clouds { get; set; }
        //[JsonProperty("results")]
        //public string temp { get; set; }

    }
}
