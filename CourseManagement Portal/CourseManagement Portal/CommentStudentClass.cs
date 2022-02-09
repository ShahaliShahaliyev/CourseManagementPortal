using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement_Portal
{
    public class CommentStudentClass
    {
        public string? Student { get; set; }
        public string? Course { get; set; }
        public string? Lesson { get; set; }
        public DateTime Date { get; set; }
        public string Attendance { get; set; }
        public string? Comment { get; set; }
    }

}
