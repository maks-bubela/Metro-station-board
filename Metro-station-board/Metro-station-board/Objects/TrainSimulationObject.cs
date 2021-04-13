using Metro_station_board.Interfaces;
using Metro_station_board.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro_station_board.Objects
{
    class TrainSimulationObject : IAddons
    {
        ObjectSensor sensor;
        ObjectTrain train;
        public ObjectSensor GetSensor() { return sensor; }

        public TrainSimulationObject()
        {
            sensor = new ObjectSensor();
        }

        public void StartTrain(string dispatchPoint, string endPoint, TimeSpan dispatchTime, TimeSpan arriveTime)
        {
            train = new ObjectTrain(dispatchPoint, endPoint);
            train.trainInWay(true);
            Random random = new Random();
            TimeSpan violationDispatchTime = new TimeSpan(0,0,0);
            if (random.Next(100) % 100 < 5)
                violationDispatchTime = new TimeSpan(0, random.Next(5), 0);
            sensor.startRide(dispatchTime + violationDispatchTime);

            TimeSpan violationArriveTime = new TimeSpan(0,0,0);
            if (random.Next(100) % 100 < 5)
                violationArriveTime = new TimeSpan(0, random.Next(5), 0);
            sensor.finishRide(arriveTime + violationArriveTime);
            train.trainInWay(false);
            
            if(dispatchTime != sensor.GetDispatchTime() || arriveTime != sensor.GetArriveTime())
            {
                VioletRepository violetRepository = new VioletRepository(new Context.MetroStationBoardContext());
                violetRepository.addToDB(sensor.GetDispatchTime(), sensor.GetArriveTime(),dispatchPoint,endPoint);
            }

        }

        public void getUI(Form form, MenuStrip addonsMenu)
        {
        }

    }
}
