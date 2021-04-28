﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule
{
    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Speciality { get; set; }
        public Company Company { get; set; }
    }
}
