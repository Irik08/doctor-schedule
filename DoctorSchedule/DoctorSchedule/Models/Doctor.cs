using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule
{
    public class Doctor
    {
        public static int count = 1;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Speciality { get; set; }
        public Company Company { get; set; }
        public Dictionary<int,WorkDay> WorkDays { get; set; }

        public Doctor (string name, string surname, string speciality)
        {
            Id = count;
            FirstName = name;
            LastName = surname;
            Speciality = speciality;
            count++;
            WorkDays = new Dictionary<int,WorkDay>();
        }
    }
}
