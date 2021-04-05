using Metro_station_board.Context;
using Metro_station_board.Model;
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
        private MetroStationBoardContext context;

        public ControlPanelObject()
        {
            context = new MetroStationBoardContext();
            adRepository = new AdRepository(context);
            scheduleRepository = new ScheduleRepository(context);
            violationRepository = new VioletRepository(context);
        }
        //----- Add methods
        public void addAd(string ad)
        {
            adRepository.addToDB(ad);
        }
        public void addViolation(TimeSpan arriveTime, TimeSpan dispatchTime, string dispatchPoint, string endPoint)
        {
            violationRepository.addToDB(arriveTime, dispatchTime, dispatchPoint, endPoint);
        }
        public void addSchedule(TimeSpan arriveTime, TimeSpan dispatchTime, string dispatchPoint, string endPoint)
        {
            scheduleRepository.addToDB(arriveTime, dispatchTime, dispatchPoint, endPoint);
        }

        //----- Delete methods
        public void deleteAd(int id)
        {
            adRepository.deleteFromDB(id);
        }
        public void deleteViolation(int id)
        {
            violationRepository.deleteFromDB(id);
        }
        public void deleteSchedule(int id)
        {
            scheduleRepository.deleteFromDB(id);
        }

        //----- Change methods
        public void changeAd(int id, string data)
        {
            adRepository.changeRecord(id, data);
        }

        //----- Schedule change methods
        public void changeSchedule(int id, string name, string data)
        {
            scheduleRepository.changeRecord(id,name,data);
        }
        public void changeSchedule(int id, string name, TimeSpan data)
        {
            scheduleRepository.changeRecord(id,name,data);
        }

        //----- get data methods
        public AdModel getAd(int id) { return context.adModels.FirstOrDefault(u => u.Id == id); }
        public ScheduleModel getSchedule(int id) { return context.scheduleModels.FirstOrDefault(u => u.Id == id); }
        public ViolationModel getViolation(int id) { return context.violationModels.FirstOrDefault(u => u.Id == id); }
    }
}
