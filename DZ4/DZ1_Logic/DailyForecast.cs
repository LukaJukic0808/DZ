using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public class DailyForecast : IComparable<DailyForecast>, IEquatable<DailyForecast>
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
            return date.ToString() + ": " + dayForecast.ToString();
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

        public DateTime Date
        {
            get { return date; }
        }

        public Weather DayForecast
        {
            get { return dayForecast;}
        }

        public bool Equals(DailyForecast forecast)
        {
            if (forecast == null)
                return false;

            return this.date == forecast.date;
        }

        public int CompareTo(DailyForecast forecast)
        {
            if (forecast == null)
                return 1;
            if (this.date > forecast.date)
                return 1;
            else if (this.Equals(forecast))
                return 0;
            else
                return -1;
        }


    }
}
