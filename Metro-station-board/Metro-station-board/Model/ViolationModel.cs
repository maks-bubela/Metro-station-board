using System;
using System.Collections.Generic;
using System.Text;

namespace Metro_station_board.Model
{
    public class ViolationModel
    {
        public long Id { get; set; }
        public TimeSpan violationTime { get; set; }
    }
}
