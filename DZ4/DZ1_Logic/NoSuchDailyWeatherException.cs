using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
     public class NoSuchDailyWeatherException:Exception
    {
        private DateTime date;

        public NoSuchDailyWeatherException(DateTime date,string message):base(message)
        {
            this.date = date;
        }
    }
}
