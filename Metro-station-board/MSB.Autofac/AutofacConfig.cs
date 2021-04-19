using Autofac;
using Autofac.Integration.Mvc;
using Metro_station_board.Context;
using Metro_station_board.Modules;
using MSB.Services.Modules;
using System.Web.Mvc;

namespace MSB.Autofac
{
    public class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.Register(ctx => new MetroStationBoardContext()).AsSelf();
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule<RepositoryModule>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }
    }
}
