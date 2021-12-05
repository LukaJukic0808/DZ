using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DZ2_Logic
{
    public static class ForecastUtilities
    {
        
        public static DailyForecast Parse(string dailyWeatherInput)
        {
            DateTime date = DateTime.Parse(dailyWeatherInput.Substring(0, 20));
            double temp = double.Parse(dailyWeatherInput.Substring(20, 4), CultureInfo.InvariantCulture);
            double windSpeed = double.Parse(dailyWeatherInput.Substring(25, 5), CultureInfo.InvariantCulture);
            double humidity = double.Parse(dailyWeatherInput.Substring(31, 3), CultureInfo.InvariantCulture);
            Weather dayForecast = new Weather(temp, humidity, windSpeed);

            return new DailyForecast(date, dayForecast);
        }

        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            Weather max = weathers[0];
            int i;

            for (i = 0; i < weathers.Length; i++)
            {
                if (weathers[i].CalculateWindChill() > max.CalculateWindChill())
                    max = weathers[i];
            }

            return max;

        }

        public static void PrintWeathers(IPrinter[] printer,Weather[] weathers)
        {
            for (int i = 0; i < printer.Length; i++)
                printer[i].printWeather(weathers);
        }
    }
}
