using Metro_station_board.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_station_board.Objects
{
    class ForecastObject : IAddons
    {
        WeatherObject weather;

        public ForecastObject()
        {
            Random random = new Random();
            weather = new WeatherObject(random.Next(-20, 40), random.Next(0, 100), random.Next(0, 100), random.Next(0, 40));
        }
        public WeatherObject getForecast(){ return weather;}

        public void getUI(Form form, MenuStrip addonsMenu)
        {
            Label temperature = new Label();
            Label precipitation = new Label();
            Label airHumidity = new Label();
            Label wind = new Label();
            int x = addonsMenu.Location.X;
            int y = addonsMenu.Location.Y + addonsMenu.Size.Height;
            ForecastObject forecast = new ForecastObject();
            temperature.Location = new Point(x, y);
            precipitation.Location = new Point(x + temperature.Size.Width, y);
            y += temperature.Size.Height;
            airHumidity.Location = new Point(x, y);
            wind.Location = new Point(x + temperature.Size.Width, y);
            temperature.Text = "Temperature : " + forecast.getForecast().GetTemp() + "°С";
            precipitation.Text = "Precipitation : " + forecast.getForecast().GetPrecipitation() + "%";
            airHumidity.Text = "Air Humidity : " + forecast.getForecast().GetAirHumidity() + "%";
            wind.Text = "Wind : " + forecast.getForecast().GetWind() + " km/h";
            form.Controls.Add(temperature);
            form.Controls.Add(precipitation);
            form.Controls.Add(airHumidity);
            form.Controls.Add(wind);
        }
    }
}
