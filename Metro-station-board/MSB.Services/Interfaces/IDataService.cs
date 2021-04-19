using Metro_station_board.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Interfaces
{
    public interface IDataService
    {
        List<AdModel> getAdData();
        List<ScheduleModel> getScheduleData();
        List<ViolationModel> getVioletionData();
    }
}
