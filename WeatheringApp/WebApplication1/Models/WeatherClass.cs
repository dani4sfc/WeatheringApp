using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class WeatherRoot
    {
        [JsonProperty("name")]
        public string cityName { get; set; }

        //Maybe the weather object needs to be serialized as array
        [JsonProperty("weather")]
        public Weather[] weather { get; set; }

        [JsonProperty("main")]
        public Main main { get; set; }

        [JsonProperty("wind")]
        public Wind wind { get; set; }

        [JsonProperty("clouds")]
        public Clouds clouds { get; set; }

        [JsonProperty("sys")]
        public Sys sys { get; set; }

        [JsonProperty("timezone")]
        public float timeZone { get; set; }
    }

    public partial class Weather
    {
        [JsonProperty("main")]
        public string main { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }
    }

    public partial class Main
    {
        [JsonProperty("temp")]
        public float temp { get; set; }

        [JsonProperty("feels_like")]
        public float feelsLike { get; set; }

        [JsonProperty("temp_min")]
        public float tempMin { get; set; }

        [JsonProperty("temp_max")]
        public float tempMax { get; set; }

        [JsonProperty("pressure")]
        public float pressure { get; set; }

        [JsonProperty("humidity")]
        public float humidity { get; set; }
    }

    public partial class Wind
    {
        [JsonProperty("speed")]
        public float speed { get; set; }

        [JsonProperty("deg")]
        public float deg { get; set; }

    }

    public partial class Clouds
    {
        [JsonProperty("clouds")]
        public float clouds { get; set; }

    }

    public partial class Sys
    {
        [JsonProperty("sunrise")]
        public double sunrise { get; set; }

        [JsonProperty("sunset")]
        public double sunset { get; set; }

    }


}
