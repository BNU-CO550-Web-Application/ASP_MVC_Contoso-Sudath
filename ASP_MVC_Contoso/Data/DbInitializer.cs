using ASP_MVC_Contoso.Models;
using System;
using System.Linq;

namespace ASP_MVC_Contoso.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Sudath",LastName="Nawagamuwage",EnrollmentDate=DateTime.Parse("2022-09-1")},
                new Student{FirstMidName="Sam",LastName="Baker",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{FirstMidName="Jams",LastName="Paney",EnrollmentDate=DateTime.Parse("2022-09-1")},
                new Student{FirstMidName="Tania",LastName="Miles",EnrollmentDate=DateTime.Parse("2022-09-1")},
                new Student{FirstMidName="Toney",LastName="Smith",EnrollmentDate=DateTime.Parse("2022-09-1")},
                new Student{FirstMidName="Stuate",LastName="White",EnrollmentDate=DateTime.Parse("2022-09-1")},
                new Student{FirstMidName="Meson",LastName="Perera",EnrollmentDate=DateTime.Parse("2022-09-1")},
                new Student{FirstMidName="Tim",LastName="Harwad",EnrollmentDate=DateTime.Parse("2022-09-1")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
            var courses = new Course[]
            {
                new Course{CourseID=10550,CodeCode="CO550",Title="Web Application",Credits=3},
                new Course{CourseID=10556,CodeCode="CO556",Title="Network System",Credits=3},
                new Course{CourseID=10558,CodeCode="CO558",Title="Database Design",Credits=3},
                new Course{CourseID=10567,CodeCode="CO567",Title="Object Oriented System",Credits=4},
                new Course{CourseID=10551,CodeCode="CO551",Title="Open Source System",Credits=4},
                new Course{CourseID=10565,CodeCode="CO565",Title="Web Services",Credits=3},
                new Course{CourseID=10566,CodeCode="CO566",Title="Mobile System",Credits=4},
                new Course{CourseID=10557,CodeCode="CO557",Title="Software Engineering",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=10550,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=10556,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=10558,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=10567,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=10551,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=10565,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=10566,Grade=Grade.F},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=10557,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=14041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=10565,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
