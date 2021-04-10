using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using Metro_station_board;
using Metro_station_board.Interfaces;
using Metro_station_board.Repository;
using System.Web.Mvc;

public class AutofacConfig
{
    public ContainerBuilder ConfigureContainer()
    {
        // получаем экземпляр контейнера
        var builder = new ContainerBuilder();

        // регистрируем контроллер в текущей сборке
        builder.RegisterControllers(typeof(MetroStationBoard).Assembly);

        // регистрируем споставление типов
        builder.RegisterType<AdRepository>().As<IAdRepository>();
        builder.RegisterType<ScheduleRepository>().As<IScheduleRepository>();
        builder.RegisterType<VioletRepository>().As<IVioletRepository>();

        // создаем новый контейнер с теми зависимостями, которые определены выше
        var container = builder.Build();

        // установка сопоставителя зависимостей
        DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        return builder;
    }
}