namespace Metro_station_board
{
    public interface IObjectTransport
    {
        string GetDispatchPoint();
        string GetEndPoint();
        bool isTransportInWay();
    }
}
