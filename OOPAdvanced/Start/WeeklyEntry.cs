using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class WeeklyEntry:IComparable<WeeklyEntry>
    {
        private WeekDay weekDay;
        private string notes;

        public WeeklyEntry(string weekDay,string notes)
        {
            this.WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay), weekDay);
            this.Notes = notes;
        }
        public WeekDay WeekDay { get; private set; }
        public string Notes { get; private set; }

        public int CompareTo(WeeklyEntry entry)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.WeekDay} - {this.Notes}";
        }
    }
}
