using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public class DailyForecast
    {
        private DateTime date;
        private Weather dayForecast;

        public DailyForecast(DateTime date, Weather dayForecast)
        {
            this.date = date;
            this.dayForecast = dayForecast;
        }

        public override string ToString()
        {
            return date.ToString("G", new CultureInfo("fr-FR")) + ": " + dayForecast.ToString();
        }

        public double GetTemperature()
        {
            return dayForecast.GetTemperature();
        }

        public static bool operator >(DailyForecast forecast1,DailyForecast forecast2)
        {
            return forecast1.GetTemperature() > forecast2.GetTemperature();
        }

        public static bool operator <(DailyForecast forecast1, DailyForecast forecast2)
        {
            return forecast1.GetTemperature() < forecast2.GetTemperature();
        }


    }
}
