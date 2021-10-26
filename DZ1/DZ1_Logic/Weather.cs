using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1_Logic
{
    public class Weather
    {
        private double currTemp;
        private double humidity;
        private double windSpeed;

        public Weather() { }

        public Weather(double currTemp, double humidity, double windSpeed)
        {
            this.currTemp = currTemp;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }

        public void SetTemperature(double currTemp)
        {
            this.currTemp = currTemp;
        }

        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }

        public void SetWindSpeed(double windSpeed)
        {
            this.windSpeed = windSpeed;
        }

        public double GetTemperature()
        {
            return currTemp;
        }

        public double GetHumidity()
        {
            return humidity;
        }

        public double GetWindSpeed()
        {
            return windSpeed;
        }

        public double CalculateFeelsLikeTemperature()
        {
            double feelsLike;

            feelsLike = -8.78469475556 + 1.61139411 * currTemp + 2.33854883889 * humidity - 0.14611605 * currTemp * humidity - 0.012308094 * currTemp * currTemp - 0.0164248277778 * humidity * humidity + 0.002211732 * currTemp * currTemp * humidity + 0.00072546 * currTemp * humidity * humidity - 0.000003582 * humidity * humidity * currTemp * currTemp;

            return feelsLike;

        }

        public double CalculateWindChill()
        {
            double windChill;

            windChill = 13.12 + 0.6215 * currTemp - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * currTemp * Math.Pow(windSpeed, 0.16);

            if (windChill < currTemp)
                return windChill;

            return 0;
        }

        


    }

}
