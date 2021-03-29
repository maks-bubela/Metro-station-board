using Metro_station_board.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metro_station_board.Model
{
    public class ViolationModel : IModel
    {
        public long Id { get; set; }
        public TimeSpan violationTime { get; set; }
    }
}
