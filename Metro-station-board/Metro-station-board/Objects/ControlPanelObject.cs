﻿using Metro_station_board.Context;
using Metro_station_board.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_station_board.Objects
{
    class ControlPanelObject
    {
        private AdRepository adRepository;
        private ScheduleRepository scheduleRepository;
        private VioletRepository violationRepository;

        public ControlPanelObject(MetroStationBoardContext context)
        {
            adRepository = new AdRepository(context);
            scheduleRepository = new ScheduleRepository(context);
            violationRepository = new VioletRepository(context);
        }
        public void addAd()
        {
            adRepository.addToDB("");
        }
        public void addViolation()
        {
            TimeSpan nullTime = new TimeSpan(0, 0, 0);
            violationRepository.addToDB(nullTime, nullTime, "", "");
        }
        public void addSchedule()
        {
            TimeSpan nullTime = new TimeSpan(0, 0, 0);
            scheduleRepository.addToDB(nullTime, nullTime, "", "");
        }
        public void deleteAd(int id)
        {
            adRepository.deleteFromDB(id);
        }
        public void deleteViolation(int id)
        {
            violationRepository.deleteFromDB(id);
        }
        public void deleteSchedule(int id)
        {
            scheduleRepository.deleteFromDB(id);
        }


        public void changeAd(int id, string data)
        {
            adRepository.changeRecord(id, data);
        }

        public void changeViolation(int id,string name,string data)
        {
            violationRepository.changeRecord(id,name,data);
        }
        public void changeViolation(int id, string name, TimeSpan data)
        {
            violationRepository.changeRecord(id,name,data);
        }


        public void changeSchedule(int id, string name, string data)
        {
            scheduleRepository.changeRecord(id,name,data);
        }
        public void changeSchedule(int id, string name, TimeSpan data)
        {
            scheduleRepository.changeRecord(id,name,data);
        }

    }
}
