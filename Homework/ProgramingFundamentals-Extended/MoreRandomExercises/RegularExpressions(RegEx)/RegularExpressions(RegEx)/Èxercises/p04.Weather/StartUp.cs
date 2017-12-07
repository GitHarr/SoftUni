namespace p04.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static void Main()
        {
            var regex = new Regex(@"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[a-zA-Z]+)[|]");

            var cities = new Dictionary<string, WeatherInfo>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var weatherMatch = regex.Match(line);

                if (!weatherMatch.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var city = weatherMatch.Groups["city"].Value;
                var averageTemp = double.Parse(weatherMatch.Groups["temp"].Value);
                var weather = weatherMatch.Groups["weather"].Value;

                var weatherInfo = new WeatherInfo
                {
                    AverageTemp = averageTemp,
                    Weather = weather
                };

                cities[city] = weatherInfo;

                line = Console.ReadLine();
            }

            var sortedCities = cities.OrderBy(a => a.Value.AverageTemp)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var cityInfo in sortedCities)
            {
                var city = cityInfo.Key;
                var weatherInfo = cityInfo.Value;

                Console.WriteLine($"{city} => {weatherInfo.AverageTemp:F2} => {weatherInfo.Weather}");
            }
        }
    }

    class WeatherInfo
    {
        public double AverageTemp { get; set; }

        public string Weather { get; set; }
    }

}
