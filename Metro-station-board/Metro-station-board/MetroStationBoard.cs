using Metro_station_board.Context;
using Metro_station_board.Objects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Metro_station_board
{
    public partial class MetroStationBoard : Form
    {
        private static int adAmount = 0;
        private MetroStationBoardContext context = new MetroStationBoardContext();
        private List<string> list;

        public MetroStationBoard()
        {
            InitializeComponent();
            context.adModels.Load();
            context.scheduleModels.Load();
            context.violationModels.Load();
            CreateAdList();
            GenerateContent();
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
        private void CreateAdList()
        {
            list = (from e in context.adModels select e.ad).ToList();
        }
        private void AddAd_Click(object sender, EventArgs e)
        {
            AddAdWindow addAdWindow = new AddAdWindow();
            addAdWindow.ShowDialog();
            CreateAdList();
        }

        private void EditAd_Click(object sender, EventArgs e)
        {
            EditAd editAd = new EditAd();
            editAd.ShowDialog();
            CreateAdList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveAd();
        }
        private void MoveAd()
        {
            adLabel.Left += -5;
            if (adLabel.Left <= panel1.Left)
            {
                GenerateContent();
            }
        }
        private void GenerateContent()
        {
            if (adAmount <= context.adModels.Count() - 1)
            {
                adLabel.Left = panel1.Right;
                adLabel.Text = list[adAmount];
                adAmount++;
            }
            else
            {
                adAmount = 0;
            }
        }
    }
}
