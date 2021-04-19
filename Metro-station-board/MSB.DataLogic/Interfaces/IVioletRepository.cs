using Metro_station_board.Model;
using System;
using System.Collections.Generic;

namespace Metro_station_board.Interfaces
{
    public interface IVioletRepository
    {
        void addToDB(TimeSpan arriveTime, TimeSpan dispatchTime, string dispatchPoint, string endPoint);
        void changeRecord(int id, string columnName, string changeData);
        void changeRecord(int id, string columnName, TimeSpan timeSpan);
        void deleteFromDB(int id);
        bool isEmpty();
        List<ViolationModel> getData();
    }
}
