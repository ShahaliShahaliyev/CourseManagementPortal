using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement_Portal
{
    public class CommentClass
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int GroupId { get; set; }
        public int StudentId { get; set; }
        public string? Lesson { get; set; }
        public DateTime Date { get; set; }
        public string? Attendance { get; set; }
        public string? Comment { get; set; }
    }

    public class CommentClassDgw
    {
        public string? CourseName { get; set; }
        public string? GroupName { get; set; }
        public string? StudentName { get; set; }
        public string? StudentSurname { get; set; }
        public string? Lesson { get; set; }
        public DateTime Date { get; set; }
        public string? Attendance { get; set; }
        public string? Comment { get; set; }
    }
}
