using System;

namespace DoctorSchedule
{
    class Program
    {
        private static DoctorRepository _doctorRepository;

        static void Main(string[] args)
        {
            InitRepository();
            //CreateDoctors();
            //CreateWorkDays();
            Display();
        }

        private static void InitRepository()
        {
            _doctorRepository = new DoctorRepository();
        }

        private static void CreateDoctors()
        {
            //var doc1 = new Doctor("Dmitrii", "Novikov", "Orthopedics");
            //_doctorRepository.Add(doc1);
            //var doc2 = new Doctor("Aleksandra", "Novikova", "General practice");
            //_doctorRepository.Add(doc2);
        }

        private static void CreateWorkDays()
        {
            AddWorkDayToDoctor(new DateTime(2021, 8, 14), new DateTime(2021, 8, 14, 8, 0, 0), new DateTime(2021, 8, 14, 10, 0, 0), 0);
            AddWorkDayToDoctor(new DateTime(2021, 11, 13), new DateTime(2021, 11, 13, 9, 0, 0), new DateTime(2021, 11, 13, 10, 30, 0), 1);
        }

        private static void AddWorkDayToDoctor(DateTime date, DateTime start, DateTime end, int doctorId)
        {
            var workday = new WorkDay();
            workday.StartTime = start;
            workday.EndTime = end;
            var doc = _doctorRepository.GetById(doctorId);
            _doctorRepository.Update(doctorId, doc);
        }

        private static void Display()
        {
            var doc1 = _doctorRepository.GetById(1);
            var doc2 = _doctorRepository.GetById(2);
            DisplayInfo(doc1);
            DisplayInfo(doc2);
        }

        private static void DisplayInfo(Doctor doc)
        {
            Console.WriteLine($"Doctor # {doc.Id} {doc.FirstName} {doc.LastName} works in {doc.Speciality}");
        }

        
    }
}
