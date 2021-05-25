using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

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
            try
            {
                using (var connection = new SqlConnection("Server=DESKTOP-ELI56PS;Initial Catalog=ID_db;Integrated Security=True"))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", doctorId);
                    var reader = connection.ExecuteReader("p_Doctors_GetById", parameters, commandType: System.Data.CommandType.StoredProcedure);
                    reader.Read();

                    return new Doctor()
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Speciality = reader.GetString(3)
                    };
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
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
