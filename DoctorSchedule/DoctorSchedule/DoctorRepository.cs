using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule
{
    public class DoctorRepository
    {
        private Dictionary<int,Doctor> _doctorDict;
        public void Add(Doctor doc) 
        {
            _doctorDict.Add(doc.ID, doc);
        }
        
        public void Delete(Doctor doc)
        {
            _doctorDict.Remove (doc.ID);
        } 

        public Doctor Get(string surname)
        {
            foreach (var doctor in _doctorDict.Values)
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
