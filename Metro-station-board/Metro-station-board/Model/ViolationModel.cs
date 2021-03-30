using System;

namespace Metro_station_board.Model
{
    public class ViolationModel
    {
        public long Id { get; set; }
        public string dispatchPoint;
        public string endPoint;
        public TimeSpan dispatchTime { get; set; }
        public TimeSpan arrivedTime { get; set; }
    }
}
