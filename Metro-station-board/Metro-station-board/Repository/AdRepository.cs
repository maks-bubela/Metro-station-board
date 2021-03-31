using Metro_station_board.Context;
using Metro_station_board.Model;
using System.Linq;

namespace Metro_station_board.Repository
{
    class AdRepository
    {
        private MetroStationBoardContext adContext;
        public AdRepository(MetroStationBoardContext adContext)
        {
            if (adContext != null)
                this.adContext = adContext;
        }
        public void addToDB(string ad)
        {
            if (!(adContext.adModels.Count() > 10))
            {
                AdModel adModel = new AdModel();
                adModel.ad = ad;
                adContext.adModels.Add(adModel);
                adContext.SaveChanges();
            }
        }
        public void deleteFromDB(string ad)
        {
            if (!this.isEmpty())
            {
                adContext.adModels.Remove(adContext.adModels.Where(o => o.ad == ad).FirstOrDefault());
                adContext.SaveChanges();
            }
        }
        public bool isEmpty()
        {
            return adContext.adModels.Count() == 0;
        }
    }
}
