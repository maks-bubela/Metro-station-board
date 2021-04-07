using Metro_station_board.Context;
using Metro_station_board.Objects;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;

namespace Metro_station_board
{
    public partial class MetroStationBoard : Form
    {
        private MetroStationBoardContext context = new MetroStationBoardContext();

        public MetroStationBoard()
        {
            InitializeComponent();
            context.adModels.Load();
            context.scheduleModels.Load();
            context.violationModels.Load();
        }

        private void ForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label temperature = new Label();
            Label precipitation = new Label();
            Label airHumidity = new Label();
            Label wind = new Label();
            int x = addonsMenu.Location.X;
            int y = addonsMenu.Location.Y + addonsMenu.Size.Height;
            ForecastObject forecast = new ForecastObject();
            this.Controls.Add(temperature);
            this.Controls.Add(precipitation);
            this.Controls.Add(airHumidity);
            this.Controls.Add(wind);
            temperature.Location = new Point(x,y);
            precipitation.Location = new Point(x + temperature.Size.Width, y);
            y += temperature.Size.Height;
            airHumidity.Location = new Point(x, y);
            wind.Location = new Point(x + temperature.Size.Width, y);
            temperature.Text = "Temperature : " + forecast.getForecast().GetTemp() + "°С";
            precipitation.Text = "Precipitation : " + forecast.getForecast().GetPrecipitation() + "%";
            airHumidity.Text = "Air Humidity : " + forecast.getForecast().GetAirHumidity() + "%";
            wind.Text = "Wind : " + forecast.getForecast().GetWind() + " km/h";

        }
    }
}
