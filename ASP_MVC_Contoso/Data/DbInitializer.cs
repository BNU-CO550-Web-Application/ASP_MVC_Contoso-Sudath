using ASP_MVC_Contoso.Data;
using ASP_MVC_Contoso.Models;

namespace ASP_MVC_Contoso.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
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

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=10550,CourseCode="CO550",Title="Web Application",Credits=3},
                new Course{CourseID=10556,CourseCode="CO556",Title="Network System",Credits=3},
                new Course{CourseID=10558,CourseCode="CO558",Title="Database Design",Credits=3},
                new Course{CourseID=10567,CourseCode="CO567",Title="Object Oriented System",Credits=4},
                new Course{CourseID=10551,CourseCode="CO551",Title="Open Source System",Credits=4},
                new Course{CourseID=10565,CourseCode="CO565",Title="Web Services",Credits=3},
                new Course{CourseID=10566,CourseCode="CO566",Title="Mobile System",Credits=4},
                new Course{CourseID=10557,CourseCode="CO557",Title="Software Engineering",Credits=4}
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
                new Enrollment{StudentID=4,CourseID=10557},
                new Enrollment{StudentID=4,CourseID=10565,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=10567,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=10550},
                new Enrollment{StudentID=7,CourseID=10556,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
