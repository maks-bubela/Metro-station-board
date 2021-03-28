using System;
using System.Collections.Generic;
using System.Text;

namespace Metro_station_board
{
    interface IObjectTrain
    {
        public string GetDispatchPoint();
        public string GetEndPoint();
        public bool isTransportInWay();
    }
}
