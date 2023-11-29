using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp10
{
    public class WeatherRequst
    {
      public   coord coord { get ; set; }

        [JsonProperty("base")]
        public string _base { get ; set; }


    }

    public class coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }
}