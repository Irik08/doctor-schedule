using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule.Models
{
    class Appointment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
