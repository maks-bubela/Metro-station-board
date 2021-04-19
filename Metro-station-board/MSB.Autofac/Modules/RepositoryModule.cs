using Autofac;
using Metro_station_board.Interfaces;
using Metro_station_board.Repository;

namespace MSB.Services.Modules
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdRepository>().As<IAdRepository>();
            builder.RegisterType<ScheduleRepository>().As<IScheduleRepository>();
            builder.RegisterType<VioletRepository>().As<IVioletRepository>();
        }
    }
}
