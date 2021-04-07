using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Objects
{
    class ForecastObject
    {
        WeatherObject weather;

        public WeatherObject getForecast()
        {
            Random random = new Random();
            weather = new WeatherObject(random.Next(-20,40), random.Next(0,100), random.Next(0, 100), random.Next(0, 40));
            return weather;
        }
    }
}
