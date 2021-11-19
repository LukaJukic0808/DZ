using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public class WeeklyForecast
    {
        private DailyForecast[] forecasts;


        public WeeklyForecast(DailyForecast[] forecasts)
        {
            this.forecasts = forecasts;
        }

        public DailyForecast this[int forecastIndex]
        {
            get { return forecasts[forecastIndex]; }
        }

        public string GetAsString()
        {
            string all = "";
            for(int i = 0; i < forecasts.Length; i++)
            {
                 all += forecasts[i].GetAsString()+'\n';
            }

            return all;
        }

        public double GetMaxTemperature()
        {
            DailyForecast max = forecasts[0];
            for(int i = 0; i < forecasts.Length; i++)
            {
                if (forecasts[i] > max)
                    max = forecasts[i];
            }

            return max.GetTemperature();
        }
    }
}
