﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class WeeklyCalendar
    {
        private IList<WeeklyEntry> data;
        public IEnumerable<WeeklyEntry> WeeklySchedule { get; }
        public WeeklyCalendar()
        {
            this.data = new List<WeeklyEntry>();
        }
        public void AddEntry(string weekday,string notes)
        {
            this.data.Add(new WeeklyEntry(weekday, notes));
        }
    }

}
