using System;
using System.Collections.Generic;
using System.Text;

namespace Metro_station_board
{
    class ObjectTrain : IObjectTrain
    {
        private string dispatchPoint;
        private string endPoint;
        private bool trainInTheWay;

        public ObjectTrain(string dispatchPoint, string endPoint, bool trainInTheWay)
        {
            this.dispatchPoint = dispatchPoint;
            this.endPoint = endPoint;
            this.trainInTheWay = trainInTheWay;
        }
        public string GetDispatchPoint() { return this.dispatchPoint; }
        public string GetEndPoint() { return this.endPoint; }
        public bool isTransportInWay() { return this.trainInTheWay; }
    }
}
