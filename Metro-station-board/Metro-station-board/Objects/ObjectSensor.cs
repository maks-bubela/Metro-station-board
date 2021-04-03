using System;

namespace Metro_station_board
{
    class ObjectSensor
    {
        private TimeSpan arrive_time;
        private TimeSpan dispatch_time;
        public TimeSpan GetArriveTime() { return arrive_time; }
        public TimeSpan GetDispatchTime() { return dispatch_time; }
        public ObjectSensor()
        {
        }
        public void startRide(TimeSpan dispatch_time)
        {
            this.dispatch_time = dispatch_time;
        }
        public void finishRide(TimeSpan arrive_time)
        {
            this.arrive_time = arrive_time;
        }
    }
}
