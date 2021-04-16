using System;

namespace Metro_station_board.Model
{
    public class ViolationModel
    {
        public long Id { get; set; }
        public string dispatchPoint { get; set; }
        public string endPoint { get; set; }
        public TimeSpan dispatchTime { get; set; }
        public TimeSpan arrivedTime { get; set; }
    }
}
