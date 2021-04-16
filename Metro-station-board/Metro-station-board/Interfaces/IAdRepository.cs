using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Interfaces
{
    public interface IAdRepository
    {
        void addToDB(string ad);
        void changeRecord(int id, string changeData);
        void deleteFromDB(int id);
        bool isEmpty();
    }
}
