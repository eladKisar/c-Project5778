using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    [Serializable]
    public class WorkHours
    {
        public WorkHours(TimeSpan Start, TimeSpan End, bool Day)
        {
            StartHour = Start; EndHour = End; DayWork = Day;
        }
        public TimeSpan StartHour { get; set; }
        public TimeSpan EndHour { get; set; }
        public bool DayWork { get; set; }
     
    }
}