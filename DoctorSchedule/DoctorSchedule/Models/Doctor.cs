using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule
{
    public class Doctor
    {
        public static int count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Speciality { get; set; }
        public Company Company { get; set; }
        public List<WorkDay> WorkDays { get; set; }

        public Doctor (string name, string surname, string speciality)
        {
            Id = count;
            Name = name;
            Surname = surname;
            Speciality = speciality;
            count++;
            WorkDays = new List<WorkDay>();
        }
    }
}
