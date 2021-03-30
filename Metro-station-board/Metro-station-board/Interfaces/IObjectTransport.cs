
namespace Metro_station_board
{
    interface IObjectTransport
    {
        string GetDispatchPoint();
        string GetEndPoint();
        bool isTransportInWay();
    }
}
