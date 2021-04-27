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
        
        public void Delete(Doctor doc)
        {
            _doctorList.Remove(doc);
        } 

        public Doctor Get(string surname)
        {
            foreach (var doctor in _doctorList)
            {
                if (doctor.Surname == surname )
                {
                    return doctor;
                }
            }

            return null;
        }
    }
}
