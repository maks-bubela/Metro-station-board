using Metro_station_board.Context;
using Metro_station_board.Interfaces;
using Metro_station_board.Model;
using Metro_station_board.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSB.Service
{
    public class DataService : IDataService
    {
        //AdRepository adRepository;
        ScheduleRepository scheduleRepository;
        VioletRepository violetRepository;
        private readonly IAdRepository adRepository;
        public DataService(IAdRepository ad)
        {
            adRepository = ad ?? throw new ArgumentNullException(nameof(ad));
        }

        public DataService(IVioletRepository violet)
        {
            violetRepository = (VioletRepository)violet;
        }

        public DataService(IScheduleRepository schedule)
        {
            scheduleRepository = (ScheduleRepository)schedule;
        }

        public List<AdModel> getData()
        {
            return (adRepository.getAdData());
        }
    }
}
