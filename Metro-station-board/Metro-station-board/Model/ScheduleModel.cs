using System;

namespace Metro_station_board.Model
{
    public class ScheduleModel
    {
        public long Id { get; set; }
        public string dispatchPoint;
        public string endPoint;
        public TimeSpan dispatchTime { get; set; }
        public TimeSpan arriveTime { get; set; }
    }
}
