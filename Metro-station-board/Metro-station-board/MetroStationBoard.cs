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

        public MetroStationBoard()
        {
            InitializeComponent();
            context.adModels.Load();
            context.scheduleModels.Load();
            context.violationModels.Load();
        }
    }
}
