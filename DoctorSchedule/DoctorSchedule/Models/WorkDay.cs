using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule
{
    public class WorkDay
    {
        public readonly double timeForPerson = 20; 
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
