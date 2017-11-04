using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Start
    {
        static void Main(string[] args)
        {
            WeeklyCalendar calendar = new WeeklyCalendar();
            calendar.AddEntry("Monday", "Internal meeting");
            calendar.AddEntry("Tuesday", "Create Presentation");
            calendar.AddEntry("Tuesday", "Create lab and exercises");
            calendar.AddEntry("Thursday", "Enum lectures");
            var ordered = calendar.WeeklySchedule.OrderBy(n => n).ToList();
            foreach (var weeklyentry in ordered)
            {
                Console.WriteLine(weeklyentry);
            }
            
        }
    }
}
