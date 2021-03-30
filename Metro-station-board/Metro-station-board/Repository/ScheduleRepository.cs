using Metro_station_board.Context;
using Metro_station_board.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void deleteFromDB(TimeSpan arriveTime, string endPoint)
        {
            if (!this.isEmpty())
            {
                scheduleContext.scheduleModels.Remove(scheduleContext.scheduleModels
                    .Where(o => o.arriveTime == arriveTime)
                    .Where(o => o.endPoint == endPoint).FirstOrDefault());
                scheduleContext.SaveChanges();
            }
        }
        public bool isEmpty()
        {
            return scheduleContext.scheduleModels.Count() == 0;
        }
    }
}
