
namespace Metro_station_board
{
    interface IObjectTransport
    {
        public string GetDispatchPoint();
        public string GetEndPoint();
        public bool isTransportInWay();
    }
}
