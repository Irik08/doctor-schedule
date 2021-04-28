using System;

namespace DoctorSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            var DocRep = new DoctorRepository();
            var doc1 = new Doctor("Dmitrii", "Novikov", "Orthopedics");
            DocRep.Add(doc1);
            var doc2 = new Doctor("Aleksandra", "Novikova", "General practice");
            DocRep.Add(doc2);
            var workday1 = new WorkDay();
            workday1.Date = new DateTime(2021, 8, 14);
            workday1.StartTime = new DateTime(2021, 8, 14, 8, 0, 0);
            workday1.EndTime = new DateTime(2021, 8, 14, 10, 0, 0);
            doc1.WorkDays.Add(workday1);
            var workday2 = new WorkDay();
            workday2.Date = new DateTime(2021, 11, 13);
            workday2.StartTime = new DateTime(2021, 11, 13, 9, 30, 0);
            workday2.EndTime = new DateTime(2021, 11, 13, 10, 30, 0);
            doc2.WorkDays.Add(workday2);

            Console.WriteLine($"Doctor {doc1.Name} {doc1.Surname} will work on {doc1.WorkDays[0].Date.ToShortDateString()} from {doc1.WorkDays[0].StartTime.ToLongTimeString()} to {doc1.WorkDays[0].EndTime.ToLongTimeString()}");
            Console.WriteLine($"Doctor {doc2.Name} {doc2.Surname} will work on {doc2.WorkDays[0].Date.ToShortDateString()} from {doc2.WorkDays[0].StartTime.ToLongTimeString()} to {doc2.WorkDays[0].EndTime.ToLongTimeString()}");


        }
    }
}
