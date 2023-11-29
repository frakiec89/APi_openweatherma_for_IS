using Newtonsoft.Json;
using RestSharp;


namespace ConsoleApp10
{
    internal class ApiService
    {
        public WeatherRequst GetWeather( string lat , string lon , string tokent , string unit) // немного упростим  - пусть будет  все строка
        {
            string url = @$"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={tokent}&units={unit}";
            string res = Get(url);
            return JsonConvert.DeserializeObject<WeatherRequst>(res);
        }
         string Get (string url )
        {
            var options = new RestClientOptions();
            var client = new RestClient(options);
            var request = new RestRequest(url,  Method.Get);
            RestResponse response =  client.ExecuteAsync(request).Result;
            return response.Content;
        }
    }
}
