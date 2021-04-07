using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Objects
{
    class WeatherObject
    {
        private int temperature;
        private int precipitation;
        private int airHumidity;
        private int wind;

        public int GetTemp() { return temperature; }
        public int GetPrecipitation() { return precipitation; }
        public int GetAirHumidity() { return airHumidity; }
        public int GetWind() { return wind; }


        public WeatherObject(int temperature, int precipitation, int airHumidity, int wind)
        {
            this.temperature = temperature;
            this.precipitation = precipitation;
            this.airHumidity = airHumidity;
            this.wind = wind;
        }
    }
}
