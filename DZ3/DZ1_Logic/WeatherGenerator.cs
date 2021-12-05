using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Logic
{
    public class WeatherGenerator
    {
        private double minTemperature;
        private double maxTemperature;
        private double minHumidity;
        private double maxHumidity;
        private double minWindSpeed;
        private double maxWindSpeed;
        private IRandomGenerator randomGenerator;

        public WeatherGenerator(double minTemperature, double maxTemperature, double minHumidity, double maxHumidity, double minWindSpeed, double maxWindSpeed, IRandomGenerator randomGenerator)
        {
            this.minTemperature = minTemperature;
            this.maxTemperature = maxTemperature;
            this.minHumidity = minHumidity;
            this.maxHumidity = maxHumidity;
            this.minWindSpeed = minWindSpeed;
            this.maxWindSpeed = maxWindSpeed;
            this.randomGenerator = randomGenerator;
        }

        public Weather Generate()
        {
            return new Weather(randomGenerator.GenerateDouble(minTemperature, maxTemperature), randomGenerator.GenerateDouble(minHumidity, maxHumidity), randomGenerator.GenerateDouble(minWindSpeed, maxWindSpeed));
        }

        public void SetGenerator(IRandomGenerator randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }
    }
}
