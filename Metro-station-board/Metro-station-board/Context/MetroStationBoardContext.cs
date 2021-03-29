using Metro_station_board.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Metro_station_board.Context
{
    public class MetroStationBoardContext : DbContext
    {
        public MetroStationBoardContext(string connectionString) : base(connectionString)
        {
        }
        public DbSet<AdModel> adModels { get; set; }
        public DbSet<ScheduleModel> scheduleModels { get; set; }
        public DbSet<ViolationModel> violationModels { get; set; }
    }
}