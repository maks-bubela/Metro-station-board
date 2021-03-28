using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Metro_station_board
{
    class ObjectSensor
    {
        private Timer timer;

        // The time of needed arrival
        private int endHours;
        private int endMin;
        private int endSec;

        // Departure time
        private int startHours;
        private int startMin;
        private int startSec;
        public ObjectSensor(int endHours,int endMin,int endSec)
        {
            this.timer = new Timer();
            this.startHours = 0;
            this.startMin = 0;
            this.startSec = 0;

            this.endHours = endHours;
            this.endMin = endMin;
            this.endSec = endSec;
        }
    }
}
