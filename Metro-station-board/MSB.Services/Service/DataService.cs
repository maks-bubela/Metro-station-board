using Metro_station_board.Interfaces;
using Metro_station_board.Model;
using System;
using System.Collections.Generic;

namespace MSB.Service
{
    public class DataService : IDataService
    {
        //AdRepository adRepository;
        IScheduleRepository scheduleRepository;
        IVioletRepository violetRepository;
        private readonly IAdRepository adRepository;
        public DataService(IAdRepository ad,IScheduleRepository schedule, IVioletRepository violet )
        {
            adRepository = ad ?? throw new ArgumentNullException(nameof(ad));
            scheduleRepository = schedule ?? throw new ArgumentNullException(nameof(ad));
            violetRepository = violet ?? throw new ArgumentNullException(nameof(ad));
        }

        public List<AdModel> getAdData()
        {
            return (adRepository.getData());
        }

        public List<ScheduleModel> getScheduleData()
        {
            return (scheduleRepository.getData());
        }

        public List<ViolationModel> getVioletionData ()
        {
            return (violetRepository.getData());
        }
    }
}
