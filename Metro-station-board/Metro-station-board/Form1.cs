using Metro_station_board.Context;
using Metro_station_board.Repository;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Metro_station_board
{
    public partial class Form1 : Form
    {
        private MetroStationBoardContext context = new MetroStationBoardContext();
        private string table;
        private AdRepository adRepository;
        private ScheduleRepository scheduleRepository;
        private VioletRepository violationRepository;
        public Form1()
        {
            InitializeComponent();
            adRepository = new AdRepository(context);
            context.adModels.Load();
            scheduleRepository = new ScheduleRepository(context);
            context.scheduleModels.Load();
            violationRepository = new VioletRepository(context);
            context.violationModels.Load();
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
            TimeSpan nullTime = new TimeSpan(0,0,0);
            switch (table)
            {
                case "Ad":
                    adRepository.addToDB("");
                    dataGridView1.Refresh();
                    break;
                case "Violation":
                    violationRepository.addToDB(nullTime, nullTime, "", "");
                    dataGridView1.Refresh();
                    break;
                case "Shedule":
                    scheduleRepository.addToDB(nullTime, nullTime, "","");
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
                    adRepository.deleteFromDB(index);
                    dataGridView1.Refresh();
                    break;
                case "Violation":
                    violationRepository.deleteFromDB(index);
                    dataGridView1.Refresh();
                    break;
                case "Shedule":
                    scheduleRepository.deleteFromDB(index);
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
                    adRepository.changeRecord(index, data);
                    dataGridView1.Refresh();
                    break;
                case "Violation":
                    if (dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 2)
                        violationRepository.changeRecord(index, name, data);
                    else if (dataGridView1.CurrentCell.ColumnIndex > 2)
                        violationRepository.changeRecord(index, name, TimeSpan.Parse(data));
                    dataGridView1.Refresh();
                    break;
                case "Shedule":
                    if (dataGridView1.CurrentCell.ColumnIndex == 1 || dataGridView1.CurrentCell.ColumnIndex == 2)
                        scheduleRepository.changeRecord(index, name, data);
                    else if (dataGridView1.CurrentCell.ColumnIndex > 2)
                        scheduleRepository.changeRecord(index, name, TimeSpan.Parse(data));
                    dataGridView1.Refresh();
                    break;
            }
        }
    }
}
