using System;

namespace Metro_station_board
{
    class ObjectSensor
    {

        private IObjectTransport transport;
        private long timer;

        // The time of needed arrival
        private int arrive_time;

        public IObjectTransport GetTransport() { return transport; }
        public int GetArriveTime() { return arrive_time; }

        public ObjectSensor(int endHours,int endMin,int endSec, IObjectTransport transport)
        {
            this.transport = transport;
            this.arrive_time = (60 * 60 * endHours) + (60 * endMin) + endSec;
        }

        public void startRide()
        {
            this.timer = DateTime.Now.Ticks;
        }
        public long finishRide()
        {
            return (DateTime.Now.Ticks - timer);
        }
    }
}
