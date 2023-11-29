using ConsoleApp10;

ApiService apiService = new ApiService();
WeatherRequst result = 
    apiService.GetWeather("53.198627", "50.113987", 
    "0a263fb06730c2c682dc7c82e0c58501", "metric");


Console.WriteLine(result.coord.lon);

Console.WriteLine(result.coord.lat);