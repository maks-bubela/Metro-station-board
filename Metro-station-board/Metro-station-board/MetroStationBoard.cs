using Metro_station_board.Context;
using Metro_station_board.Interfaces;
using Metro_station_board.Objects;
using System;
using System.Collections;
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
            CreateAdList();
            GenerateContent();
        }

        private void CreateAdList()
        {
            list = (from e in context.adModels select e.ad).ToList();
        }
        private void AddAd_Click(object sender, EventArgs e)
        {
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

        private void addonsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Forecast")
                guiUpdate(new ForecastObject());
        }

        private void guiUpdate(IAddons addons)
        {
            addons.getUI(this, addonsMenu);
        }
    }
}
