
namespace Metro_station_board
{
    class ObjectTrain : IObjectTransport
    {
        private string dispatchPoint;
        private string endPoint;
        private bool trainInTheWay;

        public ObjectTrain(string dispatchPoint, string endPoint)
        {
            this.dispatchPoint = dispatchPoint;
            this.endPoint = endPoint;
        }
        public void trainInWay(bool inWay) { this.trainInTheWay = inWay; }
        public string GetDispatchPoint() { return this.dispatchPoint; }
        public string GetEndPoint() { return this.endPoint; }
        public bool isTransportInWay() { return this.trainInTheWay; }
    }
}
