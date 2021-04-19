using Metro_station_board.Model;
using System.Collections.Generic;

namespace Metro_station_board.Interfaces
{
    public interface IDataService
    {
        List<AdModel> getAdData();
        List<ScheduleModel> getScheduleData();
        List<ViolationModel> getVioletionData();
    }
}
