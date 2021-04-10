using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Metro_station_board;
using Metro_station_board.Context;
using Metro_station_board.Interfaces;
using Metro_station_board.Repository;
using System.Web.Mvc;

public class AutofacConfig
{
    public static IContainer ConfigureContainer()
    {
        var builder = new ContainerBuilder();

        builder.RegisterControllers(typeof(MetroStationBoard).Assembly);

        builder.Register(ctx => new MetroStationBoardContext()).AsSelf();
        builder.RegisterType<AdRepository>().As<IAdRepository>();
        builder.RegisterType<ScheduleRepository>().As<IScheduleRepository>();
        builder.RegisterType<VioletRepository>().As<IVioletRepository>();

        var container = builder.Build();

        DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        return container;
    }
}