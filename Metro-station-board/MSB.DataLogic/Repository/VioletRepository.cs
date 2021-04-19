using Metro_station_board.Context;
using Metro_station_board.Interfaces;
using Metro_station_board.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metro_station_board.Repository
{
    public class VioletRepository : IVioletRepository
    {
        private MetroStationBoardContext violationContext;
        public VioletRepository(MetroStationBoardContext violationContext)
        {
            if (violationContext != null)
                this.violationContext = violationContext;
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

        public void changeRecord(int id, string columnName, string changeData)
        {
            ViolationModel violationModel = violationContext.violationModels.Find(id);
            if (violationModel != null)
            {
                if (columnName == "dispatchPoint")
                    violationModel.dispatchPoint = changeData;
                else if (columnName == "endPoint")
                    violationModel.endPoint = changeData;
                violationContext.SaveChanges();
            }
        }

        public void changeRecord(int id, string columnName,TimeSpan timeSpan)
        {
            ViolationModel violationModel = violationContext.violationModels.Find(id);
            if (violationModel != null)
            {
                if (columnName == "")
                    violationModel.arrivedTime = timeSpan;
                else if (columnName == " ")
                    violationModel.dispatchTime = timeSpan;
                violationContext.SaveChanges();
            }
        }

        public void deleteFromDB(int id)
        {
            if (!this.isEmpty())
            {
                violationContext.violationModels.Remove(violationContext.violationModels
                    .Where(o => o.Id == id)
                    .FirstOrDefault());
                violationContext.SaveChanges();
            }
        }
        public bool isEmpty()
        {
            return violationContext.violationModels.Count() == 0;
        }

        public List<ViolationModel> getData()
        {
            return (violationContext.violationModels.ToList());
        }
    }
}
