using Metro_station_board.Context;
using Metro_station_board.Interfaces;
using Metro_station_board.Model;
using System.Linq;

namespace Metro_station_board.Repository
{
    public class AdRepository : IAdRepository
    {
        private const int MAX_AD_RECORD = 10;
        private MetroStationBoardContext adContext;
        public AdRepository(MetroStationBoardContext adContext)
        {
            if (adContext != null)
                this.adContext = adContext;
        }
        public void addToDB(string ad)
        {
            if (!(adContext.adModels.Count() > MAX_AD_RECORD))
            {
                AdModel adModel = new AdModel();
                adModel.ad = ad;
                adContext.adModels.Add(adModel);
                adContext.SaveChanges();
            }
        }

        public void changeRecord(int id, string changeData)
        {
            AdModel adModel = adContext.adModels.Find(id);
            if (adModel != null)
            {
                adModel.ad = changeData;
                adContext.SaveChanges();
            }
        }

        public void deleteFromDB(int id)
        {
            if (!this.isEmpty())
            {
                adContext.adModels.Remove(adContext.adModels.Where(o => o.Id == id).FirstOrDefault());
                adContext.SaveChanges();
            }
        }
        public bool isEmpty()
        {
            return adContext.adModels.Count() == 0;
        }
    }
}
