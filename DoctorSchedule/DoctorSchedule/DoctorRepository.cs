using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule
{
    public class DoctorRepository
    {
        private List<Doctor> _doctorList;
        public void Add(Doctor doc) 
        {
            _doctorList.Add(doc);
        }
    }
}
