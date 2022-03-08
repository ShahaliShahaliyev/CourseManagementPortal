using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement_Portal
{
    public class TeacherAndCoursesClass
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
    }
    public class TeacherAndCoursesClassDGW
    {
        public string? TeacherName { get; set; }
        public string? TeacherSurname { get; set; }
        public string? CourseName { get; set; }
    }
}
