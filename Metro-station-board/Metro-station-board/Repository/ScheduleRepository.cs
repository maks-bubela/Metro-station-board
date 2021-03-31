using Metro_station_board.Context;
using Metro_station_board.Model;
using System;
using System.Linq;

namespace Metro_station_board.Repository
{
    class ScheduleRepository
    {
        private MetroStationBoardContext scheduleContext;
        public ScheduleRepository(MetroStationBoardContext scheduleContext)
        {
            if (scheduleContext != null)
                this.scheduleContext = scheduleContext;
        }
        public void addToDB(TimeSpan arriveTime, TimeSpan dispatchTime,string dispatchPoint, string endPoint)
        {
            ScheduleModel scheduleModel = new ScheduleModel 
            {
                arriveTime = arriveTime,
                dispatchTime = dispatchTime,
                dispatchPoint = dispatchPoint,
                endPoint = endPoint
            };
            scheduleContext.scheduleModels.Add(scheduleModel);
            scheduleContext.SaveChanges();
        }
        public void deleteFromDB(int id)
        {
            if (!this.isEmpty())
            {
                scheduleContext.scheduleModels.Remove(scheduleContext.scheduleModels
                    .Where(o => o.Id == id)
                    .FirstOrDefault());
                scheduleContext.SaveChanges();
            }
        }
        public bool isEmpty()
        {
            return scheduleContext.scheduleModels.Count() == 0;
        }
    }
}
