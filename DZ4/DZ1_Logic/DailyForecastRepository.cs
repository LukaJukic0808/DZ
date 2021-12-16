using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public class DailyForecastRepository : IEnumerable<DailyForecast>
    {
        private List<DailyForecast> dailyForecasts;

        public DailyForecastRepository()
        {
            dailyForecasts = new List<DailyForecast>();
        }

        public DailyForecastRepository(DailyForecastRepository repository)
        {
            dailyForecasts = new List<DailyForecast>();

            for(int i = 0; i < repository.dailyForecasts.Count; i++)
            {
                dailyForecasts.Add(new DailyForecast(repository.dailyForecasts[i].Date, repository.dailyForecasts[i].DayForecast));
            }
        }

        public void Add(DailyForecast forecast)
        {
            bool flag = false;

            for (int i = 0; i < dailyForecasts.Count; i++)
            {
                if (dailyForecasts[i].Date.Date == forecast.Date.Date)
                {
                    dailyForecasts[i]=forecast;
                    flag = true;
                }

            }
            if (!flag)
            {
                dailyForecasts.Add(forecast);
            }

            dailyForecasts.Sort();
        }

        public void Add(List<DailyForecast> dailyForecasts)
        {
            for (int i = 0; i < dailyForecasts.Count; i++)
            {
                bool flag = false;

                for (int j = 0; j < this.dailyForecasts.Count; j++)
                {
                    if (this.dailyForecasts[j].Date.Date == dailyForecasts[i].Date.Date)
                    {
                        this.dailyForecasts[j] = dailyForecasts[i];
                        flag = true;
                    }

                }

                if (!flag)
                {
                    this.dailyForecasts.Add(dailyForecasts[i]);
                }
                
            }

           this.dailyForecasts.Sort();
        }

        public void Remove(DateTime date)
        {
            bool flag = false;
            for(int i = 0; i < dailyForecasts.Count; i++)
            {
                if (dailyForecasts[i].Date.Date == date.Date)
                {
                    dailyForecasts.RemoveAt(i);
                    flag = true;
                }

            }
            if (!flag)
            {
                throw new NoSuchDailyWeatherException(date,$"No daily forecast for {date.ToString()}");
            }
        }

        public IEnumerator<DailyForecast> GetEnumerator()
        {
            return dailyForecasts.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for(int i = 0; i < dailyForecasts.Count; i++)
            {
                if (i != dailyForecasts.Count - 1)
                    builder.AppendLine(dailyForecasts[i].ToString());
                else
                    builder.Append(dailyForecasts[i].ToString());
            }

            return builder.ToString();
        }


    }
}
