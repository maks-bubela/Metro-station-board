using Metro_station_board.Context;
using Metro_station_board.Interfaces;
using Metro_station_board.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metro_station_board.Repository
{
    public class ScheduleRepository : IScheduleRepository
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

        public void changeRecord(int id, string columnName , string changeData)
        {
            ScheduleModel scheduleModel = scheduleContext.scheduleModels.Find(id);
            if (scheduleModel != null)
            {
                if(columnName == "dispatchPoint")
                    scheduleModel.dispatchPoint = changeData;
                else if(columnName == "endPoint")
                    scheduleModel.endPoint = changeData;
                scheduleContext.SaveChanges();
            }
        }

        public void changeRecord(int id, string columnName, TimeSpan timeSpan)
        {
            ViolationModel violationModel = scheduleContext.violationModels.Find(id);
            if (violationModel != null)
            {
                if (columnName == "")
                    violationModel.arrivedTime = timeSpan;
                else if (columnName == " ")
                    violationModel.dispatchTime = timeSpan;
                scheduleContext.SaveChanges();
            }
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

        public List<ScheduleModel> getData()
        {
            return (scheduleContext.scheduleModels.ToList());
        }
    }
}
