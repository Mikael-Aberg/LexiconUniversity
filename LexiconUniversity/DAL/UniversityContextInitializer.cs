using LexiconUniversity.Models;
using System;
using System.Data.Entity;

namespace LexiconUniversity.DAL
{
    internal class UniversityContextInitializer : DropCreateDatabaseAlways<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var courses = new[]
            {
                new Course { CourseId = 1050, Name = ".NET", Credit = 30},
                new Course { CourseId = 1060, Name = "Java", Credit = 28},
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var students = new[]
            {
                new Student { FirstName = "Adam", LastName = "Andresson" },
                new Student { FirstName = "Bertil", LastName = "Bosson" },
                new Student { FirstName = "Cecilia", LastName = "Carlsson" },
                new Student { FirstName = "David", LastName = "Duke" },
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var enrollments = new[]
            {
                new Enrollment { StudentId = students[0].Id, CourseId = 1050, Grade = Grade.A, EnrollmentDate = DateTime.Parse("2017-01-12") },
                new Enrollment { StudentId = students[1].Id, CourseId = 1050, Grade = Grade.F, EnrollmentDate = DateTime.Parse("2017-01-02") },
                new Enrollment { StudentId = students[2].Id, CourseId = 1050, EnrollmentDate = DateTime.Today },
                new Enrollment { StudentId = students[3].Id, CourseId = 1060, EnrollmentDate = DateTime.Today },
                new Enrollment { StudentId = students[0].Id, CourseId = 1060, Grade = Grade.B, EnrollmentDate = DateTime.Parse("2016-12-26") },
                new Enrollment { StudentId = students[1].Id, CourseId = 1060, Grade = Grade.C, EnrollmentDate = DateTime.Parse("2017-01-24") },
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}