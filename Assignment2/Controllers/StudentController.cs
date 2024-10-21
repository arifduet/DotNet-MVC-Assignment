using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult std()
        {
            var teacher1 = new Teacher {TeacherId = 1,Name = "Dr. Arman"};
            var teacher2 = new Teacher { TeacherId = 2, Name = "Abu Bakkor Siddique"};
            var teacher3 = new Teacher { TeacherId = 3, Name = "Dr.Rafiq" };
            var teacher4 = new Teacher { TeacherId = 4, Name = "Imran Masud" };

            var course1 = new Course { CourseId = 1, CourseName="Math",Teacher = teacher1};
            var course2 = new Course { CourseId = 2, CourseName = "English", Teacher = teacher2};
            var course3 = new Course { CourseId = 3, CourseName = "Bangla", Teacher = teacher3 };
            var course4 = new Course { CourseId = 4, CourseName = "Physics", Teacher = teacher4 };

            var students = new List<Student>
            {
                new Student { StudentId=1,Name = "Arif", Courses =new List<Course> {course2}},
                new Student { StudentId=2,Name = "Arman", Courses =new List<Course> {course1}},
                new Student { StudentId=3,Name = "Asif", Courses =new List<Course> {course4}},
                new Student { StudentId=4,Name = "Abir", Courses =new List<Course> {course1}},
                new Student { StudentId=5,Name = "Mariya", Courses =new List<Course> {course3}},
                new Student { StudentId=6,Name = "Mahila", Courses =new List<Course> {course2}},

            };
            return View(students);
        }
    }
}