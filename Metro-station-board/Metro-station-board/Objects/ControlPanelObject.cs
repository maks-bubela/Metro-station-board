using Metro_station_board.Context;
using Metro_station_board.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Objects
{
    class ControlPanelObject
    {
        private AdRepository adRepository;
        private ScheduleRepository scheduleRepository;
        private VioletRepository violationRepository;

        public ControlPanelObject(MetroStationBoardContext context)
        {
            adRepository = new AdRepository(context);
            scheduleRepository = new ScheduleRepository(context);
            violationRepository = new VioletRepository(context);
        }
        public void addAd()
        {
            adRepository.addToDB("");
        }
        public void addViolation()
        {
            TimeSpan nullTime = new TimeSpan(0, 0, 0);
            violationRepository.addToDB(nullTime, nullTime, "", "");
        }
        public void addSchedule()
        {
            TimeSpan nullTime = new TimeSpan(0, 0, 0);
            scheduleRepository.addToDB(nullTime, nullTime, "", "");
        }
    }
}
