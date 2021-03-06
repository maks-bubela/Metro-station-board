using Autofac;
using Metro_station_board.Interfaces;
using Metro_station_board.Modules;
using Metro_station_board.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MSB.Autofac;
using MSB.Service;

namespace Metro_station_board
{
    public partial class MetroStationBoard : Form
    {
        private static int adAmount = 0;
        private List<string> list;
        public MetroStationBoard()
        {
            InitializeComponent();
            CreateAdList();
            GenerateContent();
        }

        private void CreateAdList()
        {
            //list = (from e in context.adModels select e.ad).ToList();
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
            /*
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
            */
        }

        private void addonsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Forecast")
                guiUpdate(new ForecastObject());
            else if (e.ClickedItem.Text == "Train Simulator")
            {
                Train_Simulator train_Simulator = new Train_Simulator();
                train_Simulator.ShowDialog();
            }
        }

        private void guiUpdate(IAddons addons)
        {
            addons.getUI(this, addonsMenu);
        }

        private DataTable FillData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("dispatchPoint");
            dt.Columns.Add("endPoint");
            dt.Columns.Add("dispatchTime");
            dt.Columns.Add("arriveTime");
            /*
            /var data = context.scheduleModels.ToList();
            foreach (var oItem in data)
            {               
                dt.Rows.Add(new object[] { oItem.dispatchPoint, oItem.endPoint, oItem.dispatchTime, oItem.arriveTime });
            }       
            */
            return dt;
        }
        
    }
}
