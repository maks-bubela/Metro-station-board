using Metro_station_board.Context;
using Metro_station_board.Objects;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Metro_station_board
{
    public partial class MetroStationBoard : Form
    {
        private MetroStationBoardContext context = new MetroStationBoardContext();
        private string table;
        ControlPanelObject controlPanel;
        TimeSpan realTimeInWay;
        public MetroStationBoard()
        {
            InitializeComponent();
            context.adModels.Load();
            context.scheduleModels.Load();
            context.violationModels.Load();
            controlPanel = new ControlPanelObject(context);
        }

        private void tableButton_Click(object sender, EventArgs e)
        {

        }

        private void sourseButton_Click(object sender, EventArgs e)
        {

        }

        private void adButton_Click(object sender, EventArgs e)
        {
            table = "Ad";
            dataGridView1.DataSource = context.adModels.Local.ToBindingList();
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            table = "Violation";
            dataGridView1.DataSource = context.violationModels.Local.ToBindingList();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            table = "Shedule";
            dataGridView1.DataSource = context.scheduleModels.Local.ToBindingList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (table)
            {
                case "Ad":
                    controlPanel.addAd();
                    dataGridView1.Refresh();
                    break;
                case "Violation":
                    controlPanel.addViolation();
                    dataGridView1.Refresh();
                    break;
                case "Shedule":
                    controlPanel.addSchedule();
                    dataGridView1.Refresh();
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            switch (table)
            {
                case "Ad":
                    controlPanel.deleteAd(index);
                    dataGridView1.Refresh();
                    break;
                case "Violation":
                    controlPanel.deleteViolation(index);
                    dataGridView1.Refresh();
                    break;
                case "Shedule":
                    controlPanel.deleteSchedule(index);
                    dataGridView1.Refresh();
                    break;
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string data = dataGridView1.CurrentCell.Value.ToString();
            string name = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name;
            switch (table)
            {
                case "Ad":
                    controlPanel.changeAd(index, data);
                    dataGridView1.Refresh();
                    break;
                case "Violation":
                    if (dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 2)
                        controlPanel.changeViolation(index, name, data);
                    else if (dataGridView1.CurrentCell.ColumnIndex > 2)
                        controlPanel.changeViolation(index, name, TimeSpan.Parse(data));
                    dataGridView1.Refresh();
                    break;
                case "Shedule":
                    if (dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 2)
                        controlPanel.changeSchedule(index, name, data);
                    else if (dataGridView1.CurrentCell.ColumnIndex > 2)
                        controlPanel.changeSchedule(index, name, TimeSpan.Parse(data));
                    dataGridView1.Refresh();
                    break;
            }
        }

        private void goTrainButton_Click(object sender, EventArgs e)
        {
            if (table == "Shedule" && !timer1.Enabled)
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
