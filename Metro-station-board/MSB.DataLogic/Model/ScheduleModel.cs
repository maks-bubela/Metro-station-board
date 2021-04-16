using System;

namespace Metro_station_board.Model
{
    public class ScheduleModel
    {
        public long Id { get; set; }
        public string dispatchPoint { get; set; }
        public string endPoint { get; set; }
        public TimeSpan dispatchTime { get; set; }
        public TimeSpan arriveTime { get; set; }
    }
}
