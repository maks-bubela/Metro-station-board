using Metro_station_board.Model;
using System.Data.Entity;

namespace Metro_station_board.Context
{
    public class MetroStationBoardContext : DbContext
    {
        public MetroStationBoardContext(string connectionString) : base(connectionString)
        {
        }
        public MetroStationBoardContext()
        {
        }
        public DbSet<AdModel> adModels { get; set; }
        public DbSet<ScheduleModel> scheduleModels { get; set; }
        public DbSet<ViolationModel> violationModels { get; set; }
    }
}