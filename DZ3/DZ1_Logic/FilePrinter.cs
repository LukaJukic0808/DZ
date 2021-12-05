using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ2_Logic
{
    public class FilePrinter:IPrinter
    {
        private string filePath;

        public FilePrinter(string filePath)
        {
            this.filePath = filePath;
        }

        public void printWeather(Weather[] weathers)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < weathers.Length; i++)
                    writer.WriteLine(weathers[i].ToString());
            }
        }
    }
}
