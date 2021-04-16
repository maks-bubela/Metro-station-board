using Autofac;
using Metro_station_board.Interfaces;
using Metro_station_board.Repository;
using MSB.Service;

namespace Metro_station_board.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataService>().As<IDataService>();
        }
    }
}
