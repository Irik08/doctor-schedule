using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule
{
    public class Doctor
    {
        public static int count = 1;
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Secind_Name { get; set; }
        public string Speciality { get; set; }
        public Company Company { get; set; }
        public List<WorkDay> WorkDays { get; set; }

        public Doctor (string name, string surname, string speciality)
        {
            Id = count;
            First_Name = name;
            Secind_Name = surname;
            Speciality = speciality;
            count++;
            WorkDays = new List<WorkDay>();
        }
    }
}
