using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorSchedule
{
    public class DoctorRepository
    {
        private Dictionary<int,Doctor> _doctorDict;
        
        public DoctorRepository ()
        {
            _doctorDict = new Dictionary<int, Doctor>();
        }

        public void Add(Doctor doc) 
        {
            _doctorDict.Add(doc.Id, doc);
        }
        
        public void Delete(int doctorId)
        {
            _doctorDict.Remove(doctorId);
        } 

        public Doctor GetById(int doctorId)
        {
            if (!_doctorDict.ContainsKey(doctorId))
            {
                return null;
            }

            return _doctorDict[doctorId];
        }

        public Doctor GetBySurname(string surname)
        {
            foreach (var doctor in _doctorDict.Values)
            {
                if (doctor.LastName == surname )
                {
                    return doctor;
                }
            }

            return null;
        }

        public void Update(int id, Doctor doc)
        {
            if (_doctorDict.ContainsKey(id))
            {
                _doctorDict[id] = doc;
            }
                
            else
            {
                Console.WriteLine("There is no this ID in the Repository");
            }
        }
    }
}
