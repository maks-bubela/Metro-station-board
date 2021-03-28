using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Metro_station_board;

namespace Metro_station_board
{
    class ObjectSensor
    {
        private ObjectTrain train;
        private long timer;

        // The time of needed arrival
        private int arrive_time;

        public ObjectSensor(int endHours,int endMin,int endSec, ObjectTrain train)
        {
            this.train = train;
            this.arrive_time = (60 * 60 * endHours) + (60 * endMin) + endSec;
        }
    }
}
