using Metro_station_board.Context;
using Metro_station_board.Interfaces;
using Metro_station_board.Model;
using Metro_station_board.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Service
{
    class DataService : IDataService
    {
        AdRepository adRepository;
        ScheduleRepository scheduleRepository;
        VioletRepository violetRepository;
        public DataService()
        {
        }

        public List<AdModel> getAdData()
        {
            return (getAdData());
        }
    }
}
