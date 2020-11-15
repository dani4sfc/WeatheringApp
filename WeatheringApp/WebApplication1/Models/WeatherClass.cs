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
        public double temp { get; set; }

        [JsonProperty("feels_like")]
        public double feelsLike { get; set; }

        [JsonProperty("temp_min")]
        public double tempMin { get; set; }

        [JsonProperty("temp_max")]
        public double tempMax { get; set; }

        [JsonProperty("pressure")]
        public int pressure { get; set; }

        [JsonProperty("humidity")]
        public int humidity { get; set; }
    }

    public partial class Wind
    {
        [JsonProperty("speed")]
        public double speed { get; set; }

        [JsonProperty("deg")]
        public double deg { get; set; }

    }

    public partial class Clouds
    {
        [JsonProperty("clouds")]
        public int clouds { get; set; }

    }

    public partial class Sys
    {
        [JsonProperty("sunrise")]
        public string sunrise { get; set; }

        [JsonProperty("sunset")]
        public string sunset { get; set; }

    }


}
