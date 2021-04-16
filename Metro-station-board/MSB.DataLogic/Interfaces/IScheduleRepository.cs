using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Interfaces
{
    public interface IScheduleRepository
    {
        void addToDB(TimeSpan arriveTime, TimeSpan dispatchTime, string dispatchPoint, string endPoint);
        void changeRecord(int id, string columnName, string changeData);
        void changeRecord(int id, string columnName, TimeSpan timeSpan);
        void deleteFromDB(int id);
        bool isEmpty();
    }
}
