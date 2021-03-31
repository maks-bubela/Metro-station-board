using Metro_station_board.Context;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Metro_station_board
{
    public partial class Form1 : Form
    {
        private MetroStationBoardContext context = new MetroStationBoardContext();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void tableButton_Click(object sender, EventArgs e)
        {

        }

        private void sourseButton_Click(object sender, EventArgs e)
        {

        }

        private void adButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.adModels.Local.ToBindingList();
        }

        private void dataButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.violationModels.Local.ToBindingList();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.scheduleModels.Local.ToBindingList();
        }
    }
}
