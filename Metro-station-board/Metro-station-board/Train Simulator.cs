using Autofac;
using Metro_station_board.Context;
using Metro_station_board.Model;
using Metro_station_board.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_station_board
{
    public partial class Train_Simulator : Form
    {
        TimeSpan realTimeInWay;
        public Train_Simulator()
        {
            InitializeComponent();
            var container = AutofacConfig.ConfigureContainer();
            var service = container.Resolve<MetroStationBoardContext>();
            dataGridView1.DataSource = service.scheduleModels.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                string dispatchPoint = (dataGridView1.CurrentRow.Cells[1].Value.ToString());
                string arrivePoint = (dataGridView1.CurrentRow.Cells[2].Value.ToString());
                TimeSpan dispatchTime = TimeSpan.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                TimeSpan arriveTime = TimeSpan.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                TrainSimulationObject simulationObject = new TrainSimulationObject();
                simulationObject.StartTrain(dispatchPoint, arrivePoint, dispatchTime, arriveTime);

                realTimeInWay = simulationObject.GetSensor().GetArriveTime() - simulationObject.GetSensor().GetDispatchTime();
                dispatchLabel.Text = dispatchPoint;
                arriveLabel.Text = arrivePoint;

                timer1.Enabled = true;
                timer1.Interval = 1000;
                timer1.Tick += timerTick;
                timer1.Start();
            }
        }
        public void timerTick(object sender, EventArgs e)
        {
            if (realTimeInWay.TotalSeconds > 0)
            {
                realTimeInWay -= new TimeSpan(0, 0, 1);
                timerLabel.Text = realTimeInWay.ToString();
            }
            else
            {
                timer1.Tick -= timerTick;
                timer1.Stop();
            }
        }
    }
}
