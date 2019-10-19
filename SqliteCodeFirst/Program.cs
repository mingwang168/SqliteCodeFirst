using System;
using static SqliteCodeFirst.Model;

namespace SqliteCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ClassContext())
            {
                db.Add(new Instructor { InstructorId = "A01968215", Name = "Phil Weier" });

                //db.Add(new Class { ClassId = 1, Instructor = new Instructor { InstructorId = "A01968415", Name = "Phil Weier" }, InstructorId = "3", Title = "teacher" });
                db.SaveChanges();
                foreach (Instructor instructor in db.Instructors)
                {
                    Console.WriteLine(instructor.InstructorId + ": " + instructor.Name);
                }


            }

        }
    }
}
