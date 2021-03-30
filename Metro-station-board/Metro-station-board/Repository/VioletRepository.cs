using Metro_station_board.Context;
using Metro_station_board.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Repository
{
    class VioletRepository
    {
        private MetroStationBoardContext violationContext;
        public VioletRepository(MetroStationBoardContext scheduleContext)
        {
            if (scheduleContext != null)
                this.violationContext = scheduleContext;
        }
        public void addToDB(TimeSpan arriveTime, TimeSpan dispatchTime, string dispatchPoint, string endPoint)
        {
            ViolationModel violationModel = new ViolationModel
            {
                arrivedTime = arriveTime,
                dispatchTime = dispatchTime,
                dispatchPoint = dispatchPoint,
                endPoint = endPoint
            };
            violationContext.violationModels.Add(violationModel);
            violationContext.SaveChanges();
        }
        public void deleteFromDB(TimeSpan arriveTime, string endPoint)
        {
            if (!this.isEmpty())
            {
                violationContext.violationModels.Remove(violationContext.violationModels
                    .Where(o => o.arrivedTime == arriveTime)
                    .Where(o => o.endPoint == endPoint).FirstOrDefault());
                violationContext.SaveChanges();
            }
        }
        public bool isEmpty()
        {
            return violationContext.scheduleModels.Count() == 0;
        }
    }
}
